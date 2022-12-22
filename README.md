# Do Not Steal
A quality of life addition to prevent Macaques from stealing fire creating items.

Speeds up lighting fires since the drills no longer have to be in a container to prevent theft.

# Settings
|Name|Default|Description|
|--|--|--|
|CardNames|BowDrill, HandDrill, StoneSharpened|The cards to ignore from rummaging events.|

# Changing the Configuration
All options are contained in the config file which is located at ```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx\config\DoNotSteal.cfg```.

The .cfg file will not exist until the mod is installed and then the game is run.

To reset the config, delete the config file.  A new config will be created the next time the game is run.

# Installation 
This mod requires the BepInEx mod loader.

## BepInEx Setup
If BepInEx has already been installed, skip this section.

Download BepInEx from https://github.com/BepInEx/BepInEx/releases/download/v5.4.21/BepInEx_x64_5.4.21.0.zip

* Extract the contents of the BepInEx zip file into the game's directory:
```<Steam Directory>\steamapps\common\Card Survival Tropical Island```

    __Important__:  The .zip file *must* be extracted to the root folder of the game.  If BepInEx was extracted correctly, the following directory will exist: ```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx```.  This is a common install issue.

* Run the game.  Once the main menu is shown, exit the game.
    
* In the BepInEx folder, there will now be a "plugins" directory.

## Mod Setup
* Download the DoNotSteal.zip.  
    * If on Nexumods.com, download from the Files tab.
    * Otherwise, download from https://github.com/NBKRedSpy/CardSurvival-DoNotSteal/releases/

* Extract the contents of the zip file into the ```BepInEx/plugins``` folder.

* Run the Game.  The mod will now be enabled.

# Uninstalling

## Uninstall
This resets the game to an unmodded state.

Delete the BepInEx folder from the game's directory
```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx```

## Uninstalling This Mod Only

This method removes this mod, but keeps the BepInEx mod loader and any other mods.

Delete the ```DoNotSteal.dll``` from the ```<Steam Directory>\steamapps\common\Card Survival Tropical Island\BepInEx\plugins``` directory.

# Compatibility
Safe to add and remove from existing saves.

# Credits
<a href="https://www.flaticon.com/free-icons/monkey" title="monkey icons">Monkey icons created by Freepik - Flaticon</a>
<a href="https://www.flaticon.com/free-icons/fire" title="fire icons">Fire icons created by Freepik - Flaticon</a>

# Change Log
## 1.1.0
* Added Sharpened Stones to the list.
* Removed debug log output.
