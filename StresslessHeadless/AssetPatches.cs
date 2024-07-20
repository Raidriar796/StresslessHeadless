using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using Elements.Assets;

namespace StresslessHeadless;
public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(AssetVariantGenerator), "ComputeVariant", [typeof(AssetVariantGenerator.ComputeTask)])]
    private class ComputeVariantPatch1
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunAssetVariantGeneration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(AssetVariantGenerator), "ComputeVariant", [typeof(Uri), typeof(string), typeof(string), typeof(IAssetVariantDescriptor)])]
    private class ComputeVariantPatch2
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunAssetVariantGeneration)) return false;

            return true;
        }
    }
}