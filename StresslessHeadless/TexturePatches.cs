using FrooxEngine;
using HarmonyLib;
using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(AudioWaveformTexture), "UpdateTextureData")]
    private class AudioWaveformTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunAudioWaveformTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(DocumentPageTexture), "UpdateTextureData")]
    private class DocumentPageTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunDocumentPageTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(GradientStripTexture), "UpdateTextureData")]
    private class GradientStripTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunGradientStripTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(GridTexture), "UpdateTextureData")]
    private class GridTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunGridTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(NoiseTexture), "UpdateTextureData")]
    private class NoiseTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunNoiseTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SimplexTexture), "UpdateTextureData")]
    private class SimplexTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSimplexTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SolidColorTexture), "UpdateTextureData")]
    private class SolidColorTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSolidColorTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(StringQRCodeTexture), "UpdateAssetData")]
    private class StringQRCodeTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunStringQRCodeTexture) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(UVTexture), "UpdateTextureData")]
    private class UVTexturePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunUVTexture) || stressMode) return true;

            return false;
        }
    }
}