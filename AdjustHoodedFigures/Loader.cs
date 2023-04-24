using System.Collections.Generic;
using Winch.Core;
using Winch.Core.API;
using Winch.Core.API.Events.Addressables;

namespace AdjustHoodedFigures
{
    public class Loader
    {
        public static string Template = "HoodedFigure";
        public static void Initialize()
        {
            DredgeEvent.AddressableEvents.QuestsLoaded.On += FetchQuests;
        }

        public static void FetchQuests(object sender, AddressablesLoadedEventArgs<QuestData> e)
        {
            List<string> toRemoveEntry = new List<string>();
            foreach (SerializedQuestEntry entry in GameManager.Instance.SaveData.questEntries.Values) 
            {
                if( entry.id.Contains(Template) && entry.resolutionIndex == 1)
                {
                    toRemoveEntry.Add(entry.id);
                }
            }
            toRemoveEntry.ForEach(entry => GameManager.Instance.SaveData.questEntries.Remove(entry));

            List<string> toRemoveNode = new List<string>();
            foreach (string node in GameManager.Instance.SaveData.visitedNodes)
            {
                if (node.Contains(Template))
                {
                    foreach (string key in toRemoveEntry)
                    {
                        string sub = key.Substring(6);
                        if (node.Contains(sub))
                        {
                            toRemoveNode.Add(node);
                        }
                    }
                }
            }
            toRemoveNode.ForEach(entry => GameManager.Instance.SaveData.visitedNodes.Remove(entry));
            WinchCore.Log.Info(toRemoveNode.Count == 0 ? "No failed Hooded Figures" : "Re-established failed Hooded Figures");
        }
    }
}
