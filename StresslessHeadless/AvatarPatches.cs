using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using FrooxEngine.CommonAvatar;
using FrooxEngine.FinalIK;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(DynamicBoneChainManager), "Update")]
    private class DynamicBoneChainPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunDynamicBoneChain) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(EyeManager), "OnCommonUpdate")]
    private class EyeManagerPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunEyeManager) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(VRIK), "OnCommonUpdate")]
    private class VRIKPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunVRIK) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(VRIKAvatar), "OnCommonUpdate")]
    private class VRIKAvatarPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunVRIKAvatar) || stressMode) return true;

            return false;
        }
    }
}