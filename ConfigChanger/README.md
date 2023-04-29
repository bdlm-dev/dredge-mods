**This file contains information on each of the modifiable attributes this mod provides.**
## Custom Attributes
| Variable Name | Type | Default Value | Purpose |
| --- | --- | --- | --- |
| doLoadCustomConfig | boolean | true | Boolean `true` or `false` determining whether custom config should be used.
| removeBoundary | boolean | false | Boolean `true` or `false` determining whether the "Entering Uncharted Waters" text and forced world events take effect.

# Default Attributes
| Variable Name | Type | Default Value | Purpose |
| --- | --- | --- | --- |
| WorldSize  | float | 1500 | Determines the scale of some game objects related to the game environment. Change this if you know what  you're doing.
| DepthModifier  | float | 100 | Modifier applied to the depth displayed in the crab pot UI. Does not influence what is caught.
| BasePlayerHealth  | integer | 2 | Starting health of the player with no hull upgrades.
| PlayerHealthPerHullTier  | integer | 1 | Increase in player health per hull tier.
| BaseMovementSpeedModifier  | float | 10 | Multiplicative modifier applied to player movement speed
| BaseReverseSpeedModifier  | float | 0.5 | Speed of player moving backwards in relation to moving forward: reversing is 50% the regular player speed.
| BaseTurnSpeed  | float | 120 | Speed at which the player can turn, roughly equivalent to n/2 degrees/second
| NumAttachedMonstersToNullifyEngines  | float | 6 | The number of Devil's Spine Piranhas required to attach to the player to disable the player engines entirely.
| GlobalSanityModifier  | float | 0.015 | Factor applied during sanity calculation affecting the scale of changes to player sanity- double the default will mean you gain/lose sanity twice as fast.
| NightSanityModifier  | float | -0.55 | Base modifier for how much the player sanity should change during the night.
| DaySanityModifier  | float | 0.4 | Base modifier for how much the player sanity should change during the day.
| SleepingSanityModifier  | float | 2 | Base modifier for how much the player sanity should change during sleep.
| MaxLightSanityModifier  | float | 0.5 | Modifier determining the maximum effect light can have on player sanity.
| LumensForMaxLightSanityModifier  | float | 4000 | Lumens necessary before reaching the MaxLightSanityModifier.
| AberrationStartDay  | integer | 5 | First day that Aberrations can be caught.
| BaseAberrationSpawnChance  | float | 0.01 | Base chance of catching an aberration during the day.
| NightAberrationSpawnChance  | float | 0.03 | Base chance of catching an aberration during the night.
| SpecialSpotAberrationSpawnBonus  | float | 0.35 | Additive bonus chance of catching an aberration at a special fishing spot as marked by glowing particles.
| SpawnChanceIncreasePerNonAberrationCaught  | decimal | 0.005 | Additive increase in chance of catching an aberration per non-aberration caught.
| MaxAberrationSpawnChance  | float | 0.35 | Maximum aberration catch chance.
| ResearchItemDredgeSpotSpawnChance  | float | 0.07 | Chance of receiving a research item from a dredge spot for a non-research-item dredge spot.
| ResearchItemCrabPotSpawnChance  | float | 0.02 | Chance to replace caught item in crab pot with a research item, **Does not apply in the current game version- Relies on an item property that none of the 'pot-able' items have enabled.**
| TrophyMaxSize  | float | 0.85 | Minimum size necessary for a fish to be considered a trophy.
| MaxCrabPotCount  | integer | 25 | Maximum number of crab pots allowed to be deployed at once. **Only applies on the switch version of the game.**
| SpecialSpotChanceDay  | float | 0.025 | Chance of a fishing spot becoming a special spot during the day.
| SpecialSpotChanceNight  | float | 0.1 | Chance of a fishing spot becoming a special spot during the night.
| MinSizeSaleModifier  | decimal | 0.75 | Modifier for minimum price a fish can be sold for depending on its size in relation to its species average.
| MaxSizeSaleModifier  | decimal | 1.25 | Modifier for maximum price a fish can be sold for depending on its size in relation to its species average.
| FreshnessLossPerDay  | float | 2 | Reduction in freshness per day.
| MaxFreshness  | float | 3 | Maximum freshness, fresh fish start at this value and become rot once they reach 0.
| NumCellsPerFishBait  | integer | 4 | Can't find usages in code, but would assume is the number of 'cells of fish' per bait given.
| NumFishInBaitBallMin  | integer | 2 | Minimum number of fish that can be found in a bait fishing spot.
| NumFishInBaitBallMax  | integer | 4 | Maximum number of fish that can be found in a bait fishing spot.
| NumFishSpeciesInBaitBall  | integer | 4 | Maximum number of different species that can be found in a bait fishing spot.
| HourDurationInSeconds  | float | 12 | Duration of an in-game hour in seconds of player movement
| BasePlayerSpeed  | float | 10 | Base speed of the player, 10kn.
| BaseFishingSpeedModifier  | float | 0.5 | Base fishing speed modifier: 50%
| ForcedTimePassageSpeedModifier  | float | 20 | Rate at which time passes under a forced time passing event, such as sleeping.
| FishingTimePassageSpeedModifier  | float | 2.5 | Rate at which time passes while fishing.
| EquipmentInstallTimePerSquare  | float | 1 | Number of hours necessary to install equipment per cell of equipment.
| HullRepairCostPerSquare  | decimal | 30 | Cost to repair each damaged health slot at the top of the Cargo tab.
| PotRepairCostPerDay  | decimal | 5 | Cost to repair for each lost day of durability on a crab pot.
| NetRepairCostPerDay  | decimal | 50 | Cost to repair for each lost day of durability on a trawl net.
| DeployableDamagePerHitProportional  | float | 0.25 | Damage to durability taken per damaged cell for items with durability affected after taking damageas a proportion of their maximum durability.
| AtrophyStockPenalty  | float | -10 | Value that atrophy sets the stock of a fishing spot to. A spot can only be fished from at or above 1.
| AtrophyGuaranteedAberrationCount  | integer | 1 | Number of aberrations that atrophy will attempt to guarantee.
| AtrophyTotalParasiteChance  | float | 0.5 | Chance for atrophy to have a fish afflicted by parasite. Maximum one per atrophy.
| AtrophyConditionMin  | float | 0.75 | Lowest possible freshness for an atrophy catch.
| AtrophyConditionMax  | float | 1.5 | Greatest possible freshness for an atrophy catch.
| GreaterMarrowDebt  | decimal | 50 | Starting player debt at greater marrow.
| GreaterMarrowDebtRepaymentProportion  | decimal | 0.15 | Portion of earnings repaid into debt.
| WorldEventRollFrequency  | float | 0.1 | Minimum time between rolls for world events in terms of in-game days.
| WorldEventChance  | float | 1 | Chance for a roll for a world event to succeed. 0-1
| TrophyNotchSpawnChance  | float | 0.075 | Chance for a trophy notch to spawn.
| BaitedTrophyNotchSpawnChance  | float | 0.4 | Chance for a trophy notch to spawn for bait fishing spots
| FishToCatchBetweenTrophyNotches  | integer | 5 | Necessary fish to catch between being able to spawn trophy notches.
| StockReplenishCoefficient  | float | 0.3 | Multiplier affecting the rate at which stock of a fishing spot will replenish.
| MinStockReplenish  | float | 0.2 | Minimum base stock for a fishing spot to replenish per day.
| InsaneTooltipThreshold  | float | 0.3 | Threshold for game to display insanity tooltip.
| BanishMachineDurationDays  | float | 0.5 | Duration of the stellar basin repulsion machine.
| ItemInfectionSpreadIntervalDays  | float | 0.2 | Interval in days at which infection will attempt to spread.
| ItemInfectionSpreadChance  | float | 0.15 | Chance for infection to successfully spread.
| InfectionAberrationSwapChance  | float | 0.15 | Chance for infection to convert a fish to (one of) its aberrant counterpart(s).
| CameraShakeScaleFactor  | float | 2 | Factor affecting scale of camera shake effects.
| HasteHeatCap  | float | 8 | Maximum haste heat.
| HasteHeatGain  | float | 1 | Multiplicative factor affecting haste heat gain.
| HasteHeatLoss  | float | 0.8 | Multiplicative factor affecting haste heat loss.
| HasteHeatCooldown  | float | 0.5 | Number of seconds before haste can be reactivated after reaching maximum haste heat.
| name  | string | GameConfigDataProd | Ignore.
