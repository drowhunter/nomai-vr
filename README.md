![NomaiVR](logo.png)

# NomaiVR - Outer Wilds VR Mod

The aim of this mod is to enable VR mode in Outer Wilds, and eventually fix the problems that come with forcing VR in a game that's obviously not prepared for it.

## YOU WILL HAVE A BAD TIME

While the game is playable at a surprisingly decent level, a lot of things range from mildly glitchy to completely broken. Expect low performance, crashes, blue screen, house fires, big explosions visibe from space. Have a look at the [currently open issues](https://github.com/Raicuparta/NomaiVR/issues) to have an idea of some of the stuff that needs fixing.
 
## Installation

[Download the latest release](https://github.com/Raicuparta/NomaiVR/releases/latest). There should be two directories and one `exe` file inside. Extract it somewhere (doesn't matter where, you'll move them later).

Before moving on to the next sections, find out where your game directory is. If you bought through Epic, it should be `C:\Program Files\Epic Games\OuterWilds`.

Now to install everything:

### Adding the OpenVR and Oculus libraries

Move the contents of the `Plugins` directory from the mod to `[Outer Wilds]\OuterWilds_Data\Plugins` where `[Outer Wilds]` is the directory mentioned before.

### Enabling VR mode

Run `UnityXREnable.exe` and follow the instalation. On the third step, make sure to select the base game's directory, as mentioned before. One file will be patched, and a backup of it will be made in the same directory. You can delete the `.exe` file if you want now.

### Installing the VR fixes mod with OWML

(If you're already familiar with OWML just install the mod normally and skip to 4.)

1. Download [Outer Worlds Mod Loader](https://github.com/amazingalek/owml/releases/latest);
2. Extract it anywhere;
3. From the NomaiVR mod files, move `Mods/NomaiVR` to the Mods directory of `OWML`;
4. Make sure your VR headset is enabled and ready (not on standby);
5. Have either SteamVR or Oculus app running;
6. Get the puke bucket ready;
7. Launch the game through `OWML.Launcher.exe`.
8. If you can't see / do anything in VR, look at your computer screen, there might be some button prompt or something that needs attention but doesn't work in VR yet.

## Contributing

Look at through [currently open issues](https://github.com/Raicuparta/NomaiVR/issues) and see if there's something you'd like to help with. For investigation issues, you can help just by running the mod normally and testing stuff! For other issues, you'll need to follow the instructions in the Development section. Just fork the project and open a PR when you want to submit a change.

If your desired contribution doesn't fit one of the existing issues, create an issue first so we can discuss it.

## Development

- [Get OWML](https://github.com/amazingalek/owml) (follow instructions there);
- Download and install the latest release of NomaiVR as per the installation instructions;
- Clone NomaiVR's source;
- Open the project solution file `NomaiVR.sln` in Visual Studio;
- Fix the missing references (`Assembly-CSharp` and all the `UnityEngine` dlls) adding new references pointing to the same dlls in your game's directory, specifically in `Outer Wilds\OuterWilds_Data\Managed`;
- (Optional) Fix the post-build step under build settings, so you don't have to move the built dll to the mods folder every time. Make sure it points to the same place where you installed NomaiVR;
- Build the project;
- Run the game through OWML;
- Confirm that NomaiVR is running.

## Help / Discuss development / Tell me about your day

[Join the Outer Wilds Discord](https://discord.gg/dg8A7m), we have a nice `#modding` channel where you can discuss all types of things.
