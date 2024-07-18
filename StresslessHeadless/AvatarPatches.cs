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
            if (!Config.GetValue(RunDynamicBoneChain)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(EyeManager), "OnCommonUpdate")]
    private class EyeManagerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunEyeManager)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(VRIK), "OnCommonUpdate")]
    private class VRIKPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunVRIK)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(VRIKAvatar), "OnCommonUpdate")]
    private class VRIKAvatarPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunVRIKAvatar)) return false;

            return true;
        }
    }
}