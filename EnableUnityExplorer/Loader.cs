using Winch.Core.API;
using UnityExplorer;
using System;

namespace EnableUnityExplorer
{
    public class Loader
    {
        public static void Initialize ()
        {
            ExplorerStandalone.CreateInstance();
        }
    }
}
