using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winch.Config;
using HarmonyLib;
using Winch.Core;

namespace ConfigChanger
{
    internal class CustomPatches
    {
        public static List<string> customVariables = new List<string>() 
        { 
            "removeBoundary"
        };
        public static void InitializeCustomPatches()
        {
            // Generate all custom variables in config file.
            customVariables.ForEach(x => ModConfig.GetProperty("ConfigChanger", x, false));
        }
    }


    [HarmonyPatch(typeof(BoundaryEnforcer))]
    [HarmonyPatch("DoBoundaryCheck")]
    class RemovedBoundaryPatch
    {
        static bool Prefix()
        {
            if (ModConfig.GetProperty("ConfigChanger", "removeBoundary", false))
            {
                return false;
            }
            return true;
        }
    }
}
