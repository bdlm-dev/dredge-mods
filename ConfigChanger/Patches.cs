using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Newtonsoft.Json.Linq;
using Winch.Config;
using Winch.Core;

namespace ConfigChanger
{
    [HarmonyPatch(typeof(GameConfigData), "get_WorldSize")]
    class WorldSizePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "WorldSize", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_DepthModifier")]
    class DepthModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "DepthModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BasePlayerHealth")]
    class BasePlayerHealthPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BasePlayerHealth", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_PlayerHealthPerHullTier")]
    class PlayerHealthPerHullTierPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "PlayerHealthPerHullTier", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BaseMovementSpeedModifier")]
    class BaseMovementSpeedModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BaseMovementSpeedModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BaseReverseSpeedModifier")]
    class BaseReverseSpeedModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BaseReverseSpeedModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BaseTurnSpeed")]
    class BaseTurnSpeedPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BaseTurnSpeed", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NumAttachedMonstersToNullifyEngines")]
    class NumAttachedMonstersToNullifyEnginesPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NumAttachedMonstersToNullifyEngines", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_GlobalSanityModifier")]
    class GlobalSanityModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "GlobalSanityModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NightSanityModifier")]
    class NightSanityModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NightSanityModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_DaySanityModifier")]
    class DaySanityModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "DaySanityModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_SleepingSanityModifier")]
    class SleepingSanityModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "SleepingSanityModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MaxLightSanityModifier")]
    class MaxLightSanityModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MaxLightSanityModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_LumensForMaxLightSanityModifier")]
    class LumensForMaxLightSanityModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "LumensForMaxLightSanityModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_AberrationStartDay")]
    class AberrationStartDayPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "AberrationStartDay", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BaseAberrationSpawnChance")]
    class BaseAberrationSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BaseAberrationSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NightAberrationSpawnChance")]
    class NightAberrationSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NightAberrationSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_SpecialSpotAberrationSpawnBonus")]
    class SpecialSpotAberrationSpawnBonusPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "SpecialSpotAberrationSpawnBonus", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_SpawnChanceIncreasePerNonAberrationCaught")]
    class SpawnChanceIncreasePerNonAberrationCaughtPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "SpawnChanceIncreasePerNonAberrationCaught", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MaxAberrationSpawnChance")]
    class MaxAberrationSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MaxAberrationSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_ResearchItemDredgeSpotSpawnChance")]
    class ResearchItemDredgeSpotSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "ResearchItemDredgeSpotSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_ResearchItemCrabPotSpawnChance")]
    class ResearchItemCrabPotSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "ResearchItemCrabPotSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_TrophyMaxSize")]
    class TrophyMaxSizePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "TrophyMaxSize", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MaxCrabPotCount")]
    class MaxCrabPotCountPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MaxCrabPotCount", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_SpecialSpotChanceDay")]
    class SpecialSpotChanceDayPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "SpecialSpotChanceDay", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_SpecialSpotChanceNight")]
    class SpecialSpotChanceNightPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "SpecialSpotChanceNight", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MinSizeSaleModifier")]
    class MinSizeSaleModifierPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MinSizeSaleModifier", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MaxSizeSaleModifier")]
    class MaxSizeSaleModifierPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MaxSizeSaleModifier", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_FreshnessLossPerDay")]
    class FreshnessLossPerDayPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "FreshnessLossPerDay", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MaxFreshness")]
    class MaxFreshnessPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MaxFreshness", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NumCellsPerFishBait")]
    class NumCellsPerFishBaitPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NumCellsPerFishBait", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NumFishInBaitBallMin")]
    class NumFishInBaitBallMinPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NumFishInBaitBallMin", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NumFishInBaitBallMax")]
    class NumFishInBaitBallMaxPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NumFishInBaitBallMax", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NumFishSpeciesInBaitBall")]
    class NumFishSpeciesInBaitBallPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NumFishSpeciesInBaitBall", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_HourDurationInSeconds")]
    class HourDurationInSecondsPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "HourDurationInSeconds", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BasePlayerSpeed")]
    class BasePlayerSpeedPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BasePlayerSpeed", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BaseFishingSpeedModifier")]
    class BaseFishingSpeedModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BaseFishingSpeedModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_ForcedTimePassageSpeedModifier")]
    class ForcedTimePassageSpeedModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "ForcedTimePassageSpeedModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_FishingTimePassageSpeedModifier")]
    class FishingTimePassageSpeedModifierPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "FishingTimePassageSpeedModifier", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_EquipmentInstallTimePerSquare")]
    class EquipmentInstallTimePerSquarePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "EquipmentInstallTimePerSquare", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_HullRepairCostPerSquare")]
    class HullRepairCostPerSquarePatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "HullRepairCostPerSquare", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_PotRepairCostPerDay")]
    class PotRepairCostPerDayPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "PotRepairCostPerDay", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_NetRepairCostPerDay")]
    class NetRepairCostPerDayPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "NetRepairCostPerDay", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_DeployableDamagePerHitProportional")]
    class DeployableDamagePerHitProportionalPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "DeployableDamagePerHitProportional", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_AtrophyStockPenalty")]
    class AtrophyStockPenaltyPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "AtrophyStockPenalty", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_AtrophyGuaranteedAberrationCount")]
    class AtrophyGuaranteedAberrationCountPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "AtrophyGuaranteedAberrationCount", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_AtrophyTotalParasiteChance")]
    class AtrophyTotalParasiteChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "AtrophyTotalParasiteChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_AtrophyConditionMin")]
    class AtrophyConditionMinPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "AtrophyConditionMin", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_AtrophyConditionMax")]
    class AtrophyConditionMaxPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "AtrophyConditionMax", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_GreaterMarrowDebt")]
    class GreaterMarrowDebtPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "GreaterMarrowDebt", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_GreaterMarrowDebtRepaymentProportion")]
    class GreaterMarrowDebtRepaymentProportionPatch
    {
        static Decimal Postfix(Decimal value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "GreaterMarrowDebtRepaymentProportion", null).ToObject<string[]>();
            return Convert.ToDecimal(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_WorldEventRollFrequency")]
    class WorldEventRollFrequencyPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "WorldEventRollFrequency", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_WorldEventChance")]
    class WorldEventChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "WorldEventChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_TrophyNotchSpawnChance")]
    class TrophyNotchSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "TrophyNotchSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BaitedTrophyNotchSpawnChance")]
    class BaitedTrophyNotchSpawnChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BaitedTrophyNotchSpawnChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_FishToCatchBetweenTrophyNotches")]
    class FishToCatchBetweenTrophyNotchesPatch
    {
        static Int32 Postfix(Int32 value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "FishToCatchBetweenTrophyNotches", null).ToObject<string[]>();
            return Convert.ToInt32(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_StockReplenishCoefficient")]
    class StockReplenishCoefficientPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "StockReplenishCoefficient", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_MinStockReplenish")]
    class MinStockReplenishPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "MinStockReplenish", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_InsaneTooltipThreshold")]
    class InsaneTooltipThresholdPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "InsaneTooltipThreshold", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_BanishMachineDurationDays")]
    class BanishMachineDurationDaysPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "BanishMachineDurationDays", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_ItemInfectionSpreadIntervalDays")]
    class ItemInfectionSpreadIntervalDaysPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "ItemInfectionSpreadIntervalDays", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_ItemInfectionSpreadChance")]
    class ItemInfectionSpreadChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "ItemInfectionSpreadChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_InfectionAberrationSwapChance")]
    class InfectionAberrationSwapChancePatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "InfectionAberrationSwapChance", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_CameraShakeScaleFactor")]
    class CameraShakeScaleFactorPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "CameraShakeScaleFactor", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_HasteHeatCap")]
    class HasteHeatCapPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "HasteHeatCap", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_HasteHeatGain")]
    class HasteHeatGainPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "HasteHeatGain", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_HasteHeatLoss")]
    class HasteHeatLossPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "HasteHeatLoss", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }

    [HarmonyPatch(typeof(GameConfigData), "get_HasteHeatCooldown")]
    class HasteHeatCooldownPatch
    {
        static float Postfix(float value)
        {
            string[] values = ModConfig.GetProperty<JArray>("ConfigChanger", "HasteHeatCooldown", null).ToObject<string[]>();
            return Convert.ToSingle(values[1]);
        }
    }
}
