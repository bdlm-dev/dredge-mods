using System;
using System.Collections.Generic;
using Winch.Core;
using Winch.Config;
using static Winch.Core.API.DredgeEvent;
using System.Reflection;
using Newtonsoft.Json.Linq;
using HarmonyLib;
using System.IO;
using System.Diagnostics;

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
        public static List<Type> validTypes = new List<Type>() { typeof(System.Int32), typeof(System.Single), typeof(System.String), typeof(System.Decimal) };
        public static GameConfigData baseConfig;
        public static void Initialize()
        {
            ManagersLoaded += LoadConfig;
            string _path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\Mods\\ConfigChanger\\" + "Config.json";
            WinchCore.Log.Debug(_path);
            if (File.Exists(_path))
            {
                if (ModConfig.GetProperty("ConfigChanger", "doLoadCustomConfig", false) == true)
                {
                    WinchCore.Log.Info("Applying Harmony Patches...");
                    WinchCore.Log.Info("Custom config applied.");
                    var harmony = new Harmony("com.dredge.configchanger");
                    harmony.PatchAll();
                }
            }
        }

        public static void LoadConfig(object sender, EventArgs e)
        {
            GenerateConfig();
        }

        public static void GenerateConfig()
        {
            WinchCore.Log.Info("Building config...");
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
                        ModConfig.GetProperty<JArray>("ConfigChanger", prop.Name.ToString(), JArray.FromObject(propValues)).ToObject<string[]>();
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
            ModConfig.GetProperty("ConfigChanger", "doLoadCustomConfig", true);
        }
    }
}
