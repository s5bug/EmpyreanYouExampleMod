using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using EmpyreanYouExampleMod.Patches;
using HarmonyLib;

namespace EmpyreanYouExampleMod;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin {
    internal static new ManualLogSource Logger;

    public static Assembly self;

    private void Awake() {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        
        self = Assembly.GetExecutingAssembly();

        Harmony.CreateAndPatchAll(typeof(NulcanPatch), MyPluginInfo.PLUGIN_GUID);
    }
}
