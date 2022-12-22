using System.Collections.Generic;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using System.Linq;

namespace DoNotSteal
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource Log { get; set; }

        public static List<string> CardNames { get; set; }

        private void Awake()
        {

            Log = Logger;

            string csvCardNames = Config.Bind("General", nameof(CardNames),
                "BowDrill, HandDrill, StoneSharpened", "The cards to ignore from rummaging events.")
                .Value;

            CardNames = csvCardNames.Split(',').ToList().Select(x => x.Trim()).ToList();



            Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
            harmony.PatchAll();

        }

        public static void LogInfo(string text)
        {
            Plugin.Log.LogInfo(text);
        }

        public static string GetGameObjectPath(GameObject obj)
        {
            GameObject searchObject = obj;

            string path = "/" + searchObject.name;
            while (searchObject.transform.parent != null)
            {
                searchObject = searchObject.transform.parent.gameObject;
                path = "/" + searchObject.name + path;
            }
            return path;
        }

    }
}