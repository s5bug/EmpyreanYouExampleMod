using System.IO;
using UnityEditor;

public class BuildAssetBundles
{
    [MenuItem ("Assets/Build AssetBundles")]
    public static void Run() {
        Directory.CreateDirectory("build/assetbundles");
        BuildPipeline.BuildAssetBundles("build/assetbundles", BuildAssetBundleOptions.StrictMode, BuildTarget.StandaloneWindows);
    }
}
