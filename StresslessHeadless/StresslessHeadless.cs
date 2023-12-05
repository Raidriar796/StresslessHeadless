using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using FrooxEngine.CommonAvatar;
using FrooxEngine.FinalIK;

namespace StresslessHeadless;

public class StresslessHeadless : ResoniteMod
{
    public override string Name => "StresslessHeadless";
    public override string Author => "Raidriar796";
    public override string Version => "1.0.0";
    public override string Link => "https://github.com/Raidriar796/StresslessHeadless";

    public override void OnEngineInit()
    {
        Harmony harmony = new("net.raidriar796.StresslessHeadless");

        if (Type.GetType("FrooxEngine.Headless.HeadlessCommands, Resonite") != null) harmony.PatchAll();
    }

    [HarmonyPatch(typeof(VRIK), "OnCommonUpdate")]
    public class VRIKPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(VRIKAvatar), "OnCommonUpdate")]
    public class VRIKAvatarPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(DynamicBoneChainManager), "Update")]
    public class DynamicBoneChainPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(EyeManager), "OnCommonUpdate")]
    public class EyeManagerPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Panner1D), "OnCommonUpdate")]
    public class Panner1DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Panner2D), "OnCommonUpdate")]
    public class Panner2DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Panner3D), "OnCommonUpdate")]
    public class Panner3DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Panner4D), "OnCommonUpdate")]
    public class Panner4DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Spinner), "OnCommonUpdate")]
    public class SpinnerPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Wiggler), "OnCommonUpdate")]
    public class WigglerPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler1D), "OnCommonUpdate")]
    public class Wobbler1DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler2D), "OnCommonUpdate")]
    public class Wobbler2DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler3D), "OnCommonUpdate")]
    public class Wobbler3DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler4D), "OnCommonUpdate")]
    public class Wobbler4DPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(LookAt), "OnCommonUpdate")]
    public class LookAtPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(LookAtUser), "OnCommonUpdate")]
    public class LookAtUserPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(AutoLookAtUser), "OnCommonUpdate")]
    public class AutoLookAtUserPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Bounds), "ComputeExactBounds")]
    public class ComputeExactBoundsPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(Bounds), "ForEachExactBoundedPoint")]
    public class ForEachExactBoundedPointPatch
    {
        private static bool Prefix()
        {
            return false;
        }
    }
}
