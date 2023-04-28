using System;
using System.Collections.Generic;
using Winch.Core;
using Winch.Config;
using System.Reflection;
using Newtonsoft.Json.Linq;
using HarmonyLib;
using System.IO;
using System.Diagnostics;
using FluffyUnderware.DevTools.Extensions;

namespace ConfigChanger
{
    public class Loader
    {
        public static Dictionary<Type, string> setType = new Dictionary<Type, string>()
        {
            { typeof(System.Single), "Single"},
            { typeof(System.Int32), "Int32"},
            { typeof(System.Decimal), "Decimal"},
            { typeof(System.String), "String"}
        };
        public static GameConfigData baseConfig;
        public static void Initialize()
        {
            GenerateConfig();

            string _path = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\Mods\\ConfigChanger\\" + "Config.json";
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

        public static void GenerateConfig()
        {
            WinchCore.Log.Info("Getting config...");
            baseConfig = GameManager.Instance.GameConfigData;
            foreach (PropertyInfo prop in baseConfig.GetType().GetRuntimeProperties())
            {
                try
                {
                    string[] propValues = new string[2] {
                        setType[prop.PropertyType],
                        prop.GetValue(baseConfig).ToString()
                    };
                    if (setType.ContainsKey(prop.PropertyType))
                    {
                        ModConfig.GetProperty<JArray>("ConfigChanger", prop.Name.ToString(), JArray.FromObject(propValues)).ToObject<string[]>();
                    }
                }
                catch (KeyNotFoundException) {}
                catch (Exception ex)
                {
                    WinchCore.Log.Debug(ex);
                }
            }
            ModConfig.GetProperty("ConfigChanger", "doLoadCustomConfig", true);
            CustomPatches.InitializeCustomPatches();
        }
    }
}
