![GitHub all releases](https://img.shields.io/github/downloads/bdlm-dev/dredge-mods/total?style=for-the-badge)
# dredge-mods
A collection of mods I've written for DREDGE in C#, using [Winch](https://github.com/Hacktix/Winch).

## Installation
### Winch **must** be installed first.
Mods are installed by extracting the downloaded .zip file, and then placing that file directly into your **Mods** folder.

# Mods
## AdjustHoodedFigures **[DEPRECATED]**
- **Deprecated as of DREDGE 1.1**
- **The fix that this mod performs was integrated into the base game !!**
- ~~Checks for failed Hooded Figure quests, and restarts them.~~
- ~~Only restarts **failed** quests.~~
- ~~Applies check once save is entered.~~
- ~~Books **can** be obtained from restarted quests.~~

## ConfigChanger
- Allows game config values to be changed from a Config.json file located within the `Mods/ConfigChanger/` folder.
- More than **60** modifiable attributes, detailed [here](https://github.com/bdlm-dev/dredge-mods/tree/main/ConfigChanger).
- Includes attributes such as `BaseAberrationSpawnChance`, `BasePlayerSpeed`, `ResearchItemDredgeSpotSpawnChance` and many more.
#### Instructions
- Launch the game to generate your config file, then change any values you wish to change and relaunch the game to use them.<br>
- Use of custom or default config can be controlled via the boolean `doLoadCustomConfig` entry at the bottom of the config.<br>
- Config can be reset and regenerated by deleting the `Config.json` and launching the game.

## EnableUnityExplorer
- Enables the [UnityExplorer](https://github.com/sinai-dev/UnityExplorer) for DREDGE.
- `An in-game UI for exploring, debugging and modifying Unity games.`
- UnityExplorer used has been rebuilt with HarmonyLib replacing HarmonyX, fork available [here](https://github.com/bdlm-dev/DREDGE-UnityExplorer/releases)
