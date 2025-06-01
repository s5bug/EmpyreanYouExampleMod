# EmpyreanYouExampleMod

An example mod for the game EMPYREAN//YOU.

## setup steps

1. Use this GitHub template to create your own new repository
2. Rename all occurrences of `EmpyreanYouExampleMod` (including folders and files) to your mod's name
3. Edit `YourModName/YourModName.csproj.user` as needed to point to your game installation and the Unity Editor v2022.3.53f1 executable
4. **Build the `csproj`.** Opening the Unity editor in `Assets` before building the C# project can lead to some things not working properly
5. In the EMPYREAN//YOU Mods menu, add the newly-generated `dev` folder as a development mod folder

## folders explanation

- `YourModName` contains the C# code making up a BepInEx plugin
- `Assets` contains a Unity project where asset bundles be automatically built for loading
- `Resources` contains files that will be copied to the `dev` directory

## important notes

- The Unity editor can freeze when building the asset bundle: in this case, your `.meta` files are broken, and you will want to delete as many Unity-generated files as you can while keeping the `.meta`s for DLLs containing scripts you reference and assets going into your asset bundles intact
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
