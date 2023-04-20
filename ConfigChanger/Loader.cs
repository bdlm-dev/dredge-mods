using System;
using System.Collections.Generic;
using Winch.Core;
using Winch.Config;
using static Winch.Core.API.DredgeEvent;
using System.Reflection;
using Newtonsoft.Json.Linq;
using HarmonyLib;

namespace ConfigChanger
{
    public class Loader
    {

        public static Dictionary<Type, string> SetType = new Dictionary<Type, string>()
        {
            { typeof(System.Single), "Single"},
            { typeof(System.Int32), "Int32"},
            { typeof(System.Decimal), "Decimal"},
            { typeof(System.String), "String"}
        };
        public static bool doLoadCustomConfig = true;
        public static Dictionary<string, string[]> customConfig = new Dictionary<string, string[]>();
        public static List<Type> validTypes = new List<Type>() { typeof(System.Int32), typeof(System.Single), typeof(System.String), typeof(System.Decimal) };
        public static GameConfigData baseConfig;
        public static void Initialize()
        {
            ManagersLoaded += LoadConfig;
            if (ModConfig.GetProperty("ConfigChanger", "doLoadCustomConfig", true))
            {
                WinchCore.Log.Info("Applying Harmony Patches...");
                var harmony = new Harmony("com.dredge.configchanger");
                harmony.PatchAll();
            }
        }

        public static void LoadConfig(object sender, EventArgs e)
        {
            if (ModConfig.GetProperty("ConfigChanger", "doLoadCustomConfig", true))
            {
                GenerateConfig();
            }
        }

        public static void GenerateConfig()
        {
            WinchCore.Log.Debug("Fetching config...");
            baseConfig = GameManager.Instance.GameConfigData;
            foreach (PropertyInfo prop in baseConfig.GetType().GetRuntimeProperties())
            {
                try
                {
                    string[] propValues = new string[2] {
                        SetType[prop.PropertyType],
                        prop.GetValue(baseConfig).ToString()
                    };
                    if (validTypes.Contains(prop.PropertyType))
                    {
                        customConfig.Add(prop.Name, propValues);
                        customConfig[prop.Name] = ModConfig.GetProperty<JArray>("ConfigChanger", prop.Name.ToString(), null).ToObject<string[]>();
                    }
                }
                catch (Exception ex)
                {
                    if (!(ex is KeyNotFoundException))
                    {
                        WinchCore.Log.Error(ex.ToString());
                        WinchCore.Log.Debug($"{prop} | {prop.PropertyType} | {prop.Name}");
                    }
                }
            }
            foreach (KeyValuePair<string, string[]> entry in customConfig)
            {
                var values = entry.Value;
                WinchCore.Log.Debug($"{entry.Key} : [{values[0]}:{values[1]}]");
                if (values[0] == "Single")
                {
                    setGameConfigDataProperty<Single>(entry.Key, Convert.ToSingle(values[1]));
                }
                else if (values[0] == "Int32")
                {
                    setGameConfigDataProperty<Int32>(entry.Key, Convert.ToInt32(values[1]));
                }
                else if (values[0] == "Decimal")
                {
                    setGameConfigDataProperty<Decimal>(entry.Key, Convert.ToDecimal(values[1]));
                }
                else
                {
                    setGameConfigDataProperty<string>(entry.Key, values[1]);
                }
            }
        }

        public static void setGameConfigDataProperty<T>(string key, T data)
        {
            try
            {
                WinchCore.Log.Debug($"Set property {key} to {data}");
                // will need to patch in set methods for these attributes
                //GameManager.Instance.GameConfigData.GetType().GetRuntimeProperty(key).SetValue(GameManager.Instance.GameConfigData, data, null);
            }
            catch (Exception ex)
            {
                WinchCore.Log.Error(ex);
                WinchCore.Log.Debug($"{key}:{data}");
            }
        }
    }
}