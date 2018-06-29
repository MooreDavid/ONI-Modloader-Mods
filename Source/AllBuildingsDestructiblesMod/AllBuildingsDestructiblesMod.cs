using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;

namespace AllBuildingsDestructiblesMod
{
	[HarmonyPatch(typeof(POIBunkerExteriorDoor), "CreateBuildingDef")]
	internal class Patches_POIBunkerExteriorDoor_CreateBuildingDef
	{		
		private static void Postfix(ref BuildingDef __result)
		{
			Debug.Log(" === POIBunkerExteriorDoor_CreateBuildingDef Postfix === ");
			__result.Invincible = false;
		}
	}

	[HarmonyPatch(typeof(POIDoorInternalConfig), "CreateBuildingDef")]
	internal class Patches_POIDoorInternalConfig_CreateBuildingDef
	{
		private static void Postfix(ref BuildingDef __result)
		{
			Debug.Log(" === POIDoorInternalConfig_CreateBuildingDef Postfix === ");
			__result.Invincible = false;
		}
	}

	[HarmonyPatch(typeof(POIFacilityDoorConfig), "CreateBuildingDef")]
	internal class Patches_POIFacilityDoorConfig_CreateBuildingDef
	{
		private static void Postfix(ref BuildingDef __result)
		{
			Debug.Log(" === POIFacilityDoorConfig_CreateBuildingDef Postfix === ");
			__result.Invincible = false;
		}
	}

	[HarmonyPatch(typeof(TilePOIConfig), "CreateBuildingDef")]
	internal class Patches_TilePOIConfig_CreateBuildingDef
	{
		private static void Postfix(ref BuildingDef __result)
		{
			Debug.Log(" === TilePOIConfig_CreateBuildingDef Postfix === ");
			__result.Invincible = false;
		}
	}
}
