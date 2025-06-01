# EmpyreanYouExampleMod

An example mod for the game EMPYREAN//YOU.

## setup steps

1. Use this GitHub template to create your own new repository
2. Rename all occurrences of `EmpyreanYouExampleMod` (including folders and files) to your mod's name
3. Edit `YourModName/YourModName.csproj.user` as needed to point to your game installation and the Unity Editor v2022.3.53f1 executable

## folders explanation

- `YourModName` contains the C# code making up a BepInEx plugin
- `Assets` contains a Unity project where asset bundles be automatically built for loading
- `Resources` contains files that will be copied to the `dev` directory

## usage

Add the `dev` directory as a development path in the Mods menu

## important notes

- The Unity editor can freeze when building the asset bundle: in this case, kill it from Task Manager, delete _all_ Unity-generated files (files you didn't make) except for `.meta` files corresponding to the files you want in any asset bundles, and retry the build
- Ignore the error about Harmony being a broken Unity plugin
- A dummy scene and a URP pipeline are required for meshes to render (but should not be part of the asset bundle)
- Do not name any of your asset bundles `assetbundles`
- When building the project with the Unity editor open, you will need to first build the Asset Bundle from the `Assets` menu, and then build the C# plugin
- The Unity project depends on EMPYREAN//YOU's built `Assembly-CSharp`, as well as all the Unity plugins it references

### this example specifically

This example mod demonstrates a few things:
- a custom component in `Components/SizeOscillator`
- a Harmony patch to a game class in `Patches/NulcanPatch`
- a custom game object which uses the custom component in `Assets/Assets/Prefabs/FishBall`
