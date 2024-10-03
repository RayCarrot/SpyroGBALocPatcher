# Spyro GBA Localization Patcher
A simple CMD tool for patching the localization text in the Digital Eclipse Spyro GBA games.

# Usage
The tool supports three launch arguments:

### Generate config files
`-g`

This generates default config files in the current directory.

### Import
`-i configFilePath`

This imports the text from the text file to the ROM file.

### Export
`-e configFilePath`

This exports the text from the ROM file to the text file.

# Config file
In order for text to be imported or exported a valid config file needs to be used. This is a simple JSON file with the following fields:

* **ROMFilePath**: The file path to the ROM file.
* **TextFilePath**: The file path to the text file. This is a JSON file.
* **LocAddress**: The address to the localization table in the ROM. This is an absolute address where the ROM uses base address 0x08000000.
* **LocLength**: The max length of the localization data to avoid overwriting existing data, or -1 to allow any length.
* **Font**: The font character table, defining which character each font index represents.

# Games
* **Spyro: Season of Ice**: All versions are supported, however there is currently no default config for the JP version.
* **Spyro: Season of Flame**: All versions are supported.
* **Spyro: Attack of the Rhynocs**: Currently not supported due to text data being compressed (see [Ray1Map](https://github.com/BinarySerializer/Ray1Map/blob/master/Assets/Scripts/Games/GBAIsometric/Serializable/IceDragon/Localization/GBAIsometric_IceDragon_LocBlock.cs#L44)).
