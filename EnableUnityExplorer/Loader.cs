using Winch.Core.API;
using UnityExplorer;
using System;

namespace EnableUnityExplorer
{
    public class Loader
    {
        public static void Initialize ()
        {
            DredgeEvent.ManagersLoaded += startUnityExplorer;
        }

        public static void startUnityExplorer(object sender, EventArgs e)
        {
            ExplorerStandalone.CreateInstance();
        }
    }
}