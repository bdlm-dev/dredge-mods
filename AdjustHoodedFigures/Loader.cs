using System.Collections.Generic;
using Winch.Core;
using static Winch.Core.API.DredgeEvent;

namespace AdjustHoodedFigures
{
    public class Loader
    {
        public static string Template = "HoodedFigure";
        public static void Initialize()
        {
            QuestsLoaded += FetchQuests;
        }

        public static void FetchQuests(object sender, AddressablesLoadedEventArgs<QuestData> e)
        {
            List<string> toRemoveEntry = new List<string>();
            // Fetch and remove failed quest entries.
            foreach (SerializedQuestEntry entry in GameManager.Instance.SaveData.questEntries.Values) 
            {
                if( entry.id.Contains(Template) && entry.resolutionIndex == 1)
                {
                    toRemoveEntry.Add(entry.id);
                }
            }
            foreach (string key in toRemoveEntry)
            {
                GameManager.Instance.SaveData.questEntries.Remove(key);
            }

            List<string> toRemoveNode = new List<string>();
            // Fetch and remove visited dialogue nodes of failed quest entries.
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
            foreach(string key in toRemoveNode)
            {
                GameManager.Instance.SaveData.visitedNodes.Remove(key);
            }
            WinchCore.Log.Info(toRemoveNode.Count == 0 ? "No failed Hooded Figures" : "Re-established failed Hooded Figures");
        }
    }
}