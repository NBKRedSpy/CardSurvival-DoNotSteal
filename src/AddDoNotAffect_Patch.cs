using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace DoNotSteal
{
    [HarmonyPatch(typeof(GameManager), "InitializeStatsAndActions")]
    public static class AddDoNotAffect_Patch
    {
        private static bool WasRun = false;

        public static void Postfix(GameManager __instance)
        {

            if (WasRun) return;

            WasRun = true;

            List<UniqueIDScriptable> cards = GameLoad.Instance.DataBase.AllData;

            Plugin.LogInfo("Cards: " + String.Join(",",cards.Where(x => x.name.Contains("Drill")).Select(x => x.name)));


            //Get the cards to ignore
            CardOrTagRef[] ignoreCards = cards
                .Where(x =>
                {
                    return Plugin.CardNames.Any(ignoreCardNames => ignoreCardNames == x.name);
                })
                .Select(itemCard =>
                {
                    var cardRef = new CardOrTagRef();
                    cardRef.Target = itemCard;
                    return cardRef;
                })
                .ToArray();


            List<CardData> eventCards = cards
                .Where(x => x.name.Contains("Rummaging"))
                .Cast<CardData>()
                .ToList();

            eventCards
                .Do(x => x.DismantleActions
                    .Do(action => action.ExtraDurabilityModifications
                        .Do(durabilityMod =>
                        {
                            durabilityMod.NOTAffectedThings = durabilityMod.NOTAffectedThings.AddRangeToArray(ignoreCards);
                        })));

        }
    }
}
