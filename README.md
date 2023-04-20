![GitHub all releases](https://img.shields.io/github/downloads/bdlm-dev/dredge-mods/total?style=for-the-badge)
# dredge-mods
A collection of mods I've written for DREDGE in C#, using [Winch](https://github.com/Hacktix/Winch).

## Installation
### Winch **must** be installed first.
Mods are installed by extracting the downloaded .zip file, and then placing that file directly into your **Mods** folder.

# Mod List
### AdjustHoodedFigures
- Checks for failed Hooded Figure quests, and restarts them.
- Only restarts **failed** quests.
- Applies check once save is entered.
- Books **can** be obtained from restarted quests.

### ConfigChanger
- Allows game config values to be changed from a Config.json file located within the `Mods/ConfigChanger/` folder.
- More than **60** modifiable attributes
- Includes attributes such as `BaseAberrationSpawnChance`, `BasePlayerSpeed`, `ResearchItemDredgeSpotSpawnChance` and many more detailed [here](https://github.com/bdlm-dev/dredge-mods/tree/main/ConfigChanger).
- Place into mods folder, run the game, and then close the game. This will generate your config file.
- Then change the value for any entries you wish to change in the config, save the file, and launch the game to use your custom config.
- Use of custom values can be controlled via the boolean `doLoadCustomConfig` entry at the bottom of the config.
