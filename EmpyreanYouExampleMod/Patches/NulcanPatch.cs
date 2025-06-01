using System.IO;
using Guns;
using HarmonyLib;
using Player;
using UnityEngine;

namespace EmpyreanYouExampleMod.Patches;

[HarmonyPatch(typeof(Nulcan))]
public class NulcanPatch {
    [HarmonyPatch(nameof(Nulcan.Shoot))]
    [HarmonyPrefix]
    static bool SpawnFishSphere(Nulcan __instance) {
        Plugin.Logger.LogDebug("Spawning fish sphere!");
        
        AssetBundle withFishBall = null;
        foreach (var bundle in AssetBundle.GetAllLoadedAssetBundles()) {
            if (bundle.Contains("Assets/Prefabs/FishBall.prefab")) {
                withFishBall = bundle;
                break;
            }
        }

        if (withFishBall is null) {
            string assetBundlesDir =
                Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Plugin.self.Location)), "assetbundles");
            
            Plugin.Logger.LogInfo($"Loading asset bundle from {assetBundlesDir}");
            
            withFishBall = AssetBundle.LoadFromFile(Path.Combine(assetBundlesDir, "fishy_sphere"));
            withFishBall.LoadAllAssets();
        }

        GameObject fishBall = withFishBall.LoadAsset<GameObject>("Assets/Prefabs/FishBall.prefab");
        
        GameObject next = GameObject.Instantiate(fishBall, PlayerTransitionHelper.Player.transform);

        return true;
    }
}
