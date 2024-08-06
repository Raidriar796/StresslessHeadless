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
            if (Config.GetValue(RunAutoLookAtUser) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(AxisAligner), "OnCommonUpdate")]
    private class AxisAlignerPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunAxisAligner) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(LookAt), "OnCommonUpdate")]
    private class LookAtPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLookAt) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(LookAtUser), "OnCommonUpdate")]
    private class LookAtUserPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLookAtUser) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Panner1D), "OnCommonUpdate")]
    private class Panner1DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunPanner1D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Panner2D), "OnCommonUpdate")]
    private class Panner2DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunPanner2D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Panner3D), "OnCommonUpdate")]
    private class Panner3DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunPanner3D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Panner4D), "OnCommonUpdate")]
    private class Panner4DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunPanner4D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Spinner), "OnCommonUpdate")]
    private class SpinnerPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSpinner) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Wiggler), "OnCommonUpdate")]
    private class WigglerPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunWiggler) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler1D), "OnCommonUpdate")]
    private class Wobbler1DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunWobbler1D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler2D), "OnCommonUpdate")]
    private class Wobbler2DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunWobbler2D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler3D), "OnCommonUpdate")]
    private class Wobbler3DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunWobbler3D) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(Wobbler4D), "OnCommonUpdate")]
    private class Wobbler4DPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunWobbler4D) || stressMode) return true;

            return false;
        }
    }
}