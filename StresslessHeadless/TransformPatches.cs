using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(AutoLookAtUser), "OnCommonUpdate")]
    public class AutoLookAtUserPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunAutoLookAtUser)) return false;

            return false;
        }
    }

    [HarmonyPatch(typeof(LookAt), "OnCommonUpdate")]
    public class LookAtPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLookAt)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LookAtUser), "OnCommonUpdate")]
    public class LookAtUserPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLookAtUser)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner1D), "OnCommonUpdate")]
    public class Panner1DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner1D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner2D), "OnCommonUpdate")]
    public class Panner2DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner2D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner3D), "OnCommonUpdate")]
    public class Panner3DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner3D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner4D), "OnCommonUpdate")]
    public class Panner4DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner4D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Spinner), "OnCommonUpdate")]
    public class SpinnerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSpinner)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wiggler), "OnCommonUpdate")]
    public class WigglerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWiggler)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler1D), "OnCommonUpdate")]
    public class Wobbler1DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler1D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler2D), "OnCommonUpdate")]
    public class Wobbler2DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler2D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler3D), "OnCommonUpdate")]
    public class Wobbler3DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler3D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler4D), "OnCommonUpdate")]
    public class Wobbler4DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler4D)) return false;

            return true;
        }
    }
}