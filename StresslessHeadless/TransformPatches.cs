using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(AutoLookAtUser), "OnCommonUpdate")]
    private class AutoLookAtUserPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunAutoLookAtUser)) return false;

            return false;
        }
    }

    [HarmonyPatch(typeof(AxisAligner), "OnCommonUpdate")]
    private class AxisAlignerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunAxisAligner)) return false;

            return false;
        }
    }

    [HarmonyPatch(typeof(LookAt), "OnCommonUpdate")]
    private class LookAtPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLookAt)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LookAtUser), "OnCommonUpdate")]
    private class LookAtUserPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLookAtUser)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner1D), "OnCommonUpdate")]
    private class Panner1DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner1D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner2D), "OnCommonUpdate")]
    private class Panner2DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner2D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner3D), "OnCommonUpdate")]
    private class Panner3DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner3D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Panner4D), "OnCommonUpdate")]
    private class Panner4DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPanner4D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Spinner), "OnCommonUpdate")]
    private class SpinnerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSpinner)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wiggler), "OnCommonUpdate")]
    private class WigglerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWiggler)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler1D), "OnCommonUpdate")]
    private class Wobbler1DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler1D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler2D), "OnCommonUpdate")]
    private class Wobbler2DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler2D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler3D), "OnCommonUpdate")]
    private class Wobbler3DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler3D)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(Wobbler4D), "OnCommonUpdate")]
    private class Wobbler4DPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWobbler4D)) return false;

            return true;
        }
    }
}