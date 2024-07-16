using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using FrooxEngine.FinalIK;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(DynamicBoneChainManager), "Update")]
    public class DynamicBoneChainPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDynamicBoneChain)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(VRIK), "OnCommonUpdate")]
    public class VRIKPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunVRIK)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(VRIKAvatar), "OnCommonUpdate")]
    public class VRIKAvatarPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunVRIKAvatar)) return false;

            return true;
        }
    }
}