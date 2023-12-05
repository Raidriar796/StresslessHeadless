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
    public override string Version => "1.1.0";
    public override string Link => "https://github.com/Raidriar796/StresslessHeadless";

    public static ModConfiguration Config;

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunAutoLookAtUser =
        new ModConfigurationKey<bool>(
            "RunAutoLookAtUser",
            "Run AutoLookAtUser",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunDynamicBoneChain =
        new ModConfigurationKey<bool>(
            "RunDynamicBoneChain",
            "Run DynamicBoneChain",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunEyeManager =
        new ModConfigurationKey<bool>(
            "RunEyeManager",
            "Run EyeManager",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLookAt =
        new ModConfigurationKey<bool>(
            "RunLookAt",
            "Run LookAt",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLookAtUser =
        new ModConfigurationKey<bool>(
            "RunLookAtUser",
            "Run LookAtUser",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner1D =
        new ModConfigurationKey<bool>(
            "RunPanner1D",
            "Run Panner1D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner2D =
        new ModConfigurationKey<bool>(
            "RunPanner2D",
            "Run Panner2D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner3D =
        new ModConfigurationKey<bool>(
            "RunPanner3D",
            "Run Panner3D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner4D =
        new ModConfigurationKey<bool>(
            "RunPanner4D",
            "Run Panner4D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSpinner =
        new ModConfigurationKey<bool>(
            "RunSpinner",
            "Run Spinner",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunVRIK =
        new ModConfigurationKey<bool>(
            "RunVRIK",
            "Run VRIK",
            () => false);
    
    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunVRIKAvatar =
        new ModConfigurationKey<bool>(
            "RunVRIKAvatar",
            "Run VRIKAvatar",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWiggler =
        new ModConfigurationKey<bool>(
            "RunWiggler",
            "Run Wiggler",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler1D =
        new ModConfigurationKey<bool>(
            "RunWobbler1D",
            "Run Wobbler1D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler2D =
        new ModConfigurationKey<bool>(
            "RunWobbler2D",
            "Run Wobbler2D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler3D =
        new ModConfigurationKey<bool>(
            "RunWobbler3D",
            "Run Wobbler3D",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler4D =
        new ModConfigurationKey<bool>(
            "RunWobbler4D",
            "Run Wobbler4D",
            () => false);

    public override void OnEngineInit()
    {
        Harmony harmony = new("net.raidriar796.StresslessHeadless");
        Config = GetConfiguration();
        Config?.Save(true);
        if (Type.GetType("FrooxEngine.Headless.HeadlessCommands, Resonite") != null) harmony.PatchAll();
    }

    [HarmonyPatch(typeof(AutoLookAtUser), "OnCommonUpdate")]
    public class AutoLookAtUserPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunAutoLookAtUser)) return false;

            return false;
        }
    }

    [HarmonyPatch(typeof(DynamicBoneChainManager), "Update")]
    public class DynamicBoneChainPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDynamicBoneChain)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(EyeManager), "OnCommonUpdate")]
    public class EyeManagerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunEyeManager)) return false;

            return true;
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
