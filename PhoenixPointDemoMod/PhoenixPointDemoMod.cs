using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using PhoenixPoint;
using Harmony;
using PhoenixPoint.Common.Entities.Items;
using PhoenixPoint.Geoscape.Levels.Factions;
using PhoenixPoint.Common.View.ViewControllers.Inventory;
using PhoenixPoint.Common.View.ViewModules;
using PhoenixPoint.Common.Core;
using UnityEngine.EventSystems;
using PhoenixPoint.Common.Entities.GameTags;
using Base.Core;
using UnityEngine;

namespace PhoenixPointDemoMod
{
    public class PhoenixPointDemoMod
    {

        public static void Init()
        {
            var harmony = HarmonyInstance.Create("io.github.realitymachina.DemonstrationMod");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

        }

        [HarmonyPatch(typeof(ItemManufacturing), "AddProductionToItem")]
        public static class PhoenixPoint_ItemManufacuating_AddProductionToItem_Patch
        {
            static bool Prefix(ItemManufacturing __instance, ref int __result, ref ItemManufacturing.ManufactureQueueItem element, ref int production)
            {
                production *= 100;
                return true; // returning false here lets us skip the original method used here
            }
        }

        

    }
}