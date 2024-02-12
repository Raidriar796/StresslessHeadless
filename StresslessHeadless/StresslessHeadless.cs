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
    public override string Version => "1.2.0";
    public override string Link => "https://github.com/Raidriar796/StresslessHeadless";

    public static ModConfiguration Config;

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunArrowMesh =
        new ModConfigurationKey<bool>(
            "RunArrowMesh",
            "Run ArrowMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunAutoLookAtUser =
        new ModConfigurationKey<bool>(
            "RunAutoLookAtUser",
            "Run AutoLookAtUser",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBallisticPathMesh =
        new ModConfigurationKey<bool>(
            "RunBallisticPathMesh",
            "Run BallisticPathMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBentTubeMesh =
        new ModConfigurationKey<bool>(
            "RunBentTubeMesh",
            "Run BentTubeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelBoxMesh =
        new ModConfigurationKey<bool>(
            "RunBevelBoxMesh",
            "Run BevelBoxMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelPlaneMesh =
        new ModConfigurationKey<bool>(
            "RunBevelPlaneMesh",
            "Run BevelPlaneMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelRingMesh =
        new ModConfigurationKey<bool>(
            "RunBevelRingMesh",
            "Run BevelRingMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelStripeMesh =
        new ModConfigurationKey<bool>(
            "RunBevelStripeMesh",
            "Run BevelStripeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBezierTubeMesh =
        new ModConfigurationKey<bool>(
            "RunBezierTubeMesh",
            "Run BezierTubeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBoxArrayMesh =
        new ModConfigurationKey<bool>(
            "RunBoxArrayMesh",
            "Run BoxArrayMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBoxMesh =
        new ModConfigurationKey<bool>(
            "RunBoxMesh",
            "Run BoxMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCameraFrustumMesh =
        new ModConfigurationKey<bool>(
            "RunCameraFrustumMesh",
            "Run CameraFrustumMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCapsuleMesh =
        new ModConfigurationKey<bool>(
            "RunCapsuleMesh",
            "Run CapsuleMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCircleMesh =
        new ModConfigurationKey<bool>(
            "RunCircleMesh",
            "Run CircleMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCircleSegmentShaderMesh =
        new ModConfigurationKey<bool>(
            "RunCircleSegmentShaderMesh",
            "Run CircleSegmentShaderMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunColorWheelTriangleMesh =
        new ModConfigurationKey<bool>(
            "RunColorWheelTriangleMesh",
            "Run ColorWheelTriangleMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunConeMesh =
        new ModConfigurationKey<bool>(
            "RunConeMesh",
            "Run ConeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCrossMesh =
        new ModConfigurationKey<bool>(
            "RunCrossMesh",
            "Run CrossMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunConvexHullMesh =
        new ModConfigurationKey<bool>(
            "RunConvexHullMesh",
            "Run ConvexHullMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCurvedPlaneMesh =
        new ModConfigurationKey<bool>(
            "RunCurvedPlaneMesh",
            "Run CurvedPlaneMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCylinderMesh =
        new ModConfigurationKey<bool>(
            "RunCylinderMesh",
            "Run CylinderMesh",
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

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunFrameMesh =
        new ModConfigurationKey<bool>(
            "RunFrameMesh",
            "Run FrameMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunHollowConeMesh =
        new ModConfigurationKey<bool>(
            "RunHollowConeMesh",
            "Run HollowConeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunIcoSphereMesh =
        new ModConfigurationKey<bool>(
            "RunIcoSphereMesh",
            "Run IcoSphereMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLabelPointerMesh =
        new ModConfigurationKey<bool>(
            "RunLabelPointerMesh",
            "Run LabelPointerMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLegacyCircleSegmentMesh =
        new ModConfigurationKey<bool>(
            "RunLegacyCircleSegmentMesh",
            "Run LegacyCircleSegmentMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLightningMesh =
        new ModConfigurationKey<bool>(
            "RunLightningMesh",
            "Run LightningMesh",
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

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunMultiBevelStripeMesh =
        new ModConfigurationKey<bool>(
            "RunMultiBevelStripeMesh",
            "Run MultiBevelStripeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunMultiLineMesh =
        new ModConfigurationKey<bool>(
            "RunMultiLineMesh",
            "Run MultiLineMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunMultiSegmentMesh =
        new ModConfigurationKey<bool>(
            "RunMultiSegmentMesh",
            "Run MultiSegmentMesh",
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

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPointMesh =
        new ModConfigurationKey<bool>(
            "RunPointMesh",
            "Run PointMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunQuadArrayMesh =
        new ModConfigurationKey<bool>(
            "RunQuadArrayMesh",
            "Run QuadArrayMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunQuadMesh =
        new ModConfigurationKey<bool>(
            "RunQuadMesh",
            "Run QuadMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunRampMesh =
        new ModConfigurationKey<bool>(
            "RunRampMesh",
            "Run RampMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunRingMesh =
        new ModConfigurationKey<bool>(
            "RunRingMesh",
            "Run RingMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSegmentMesh =
        new ModConfigurationKey<bool>(
            "RunSegmentMesh",
            "Run SegmentMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSlotSegmentMesh =
        new ModConfigurationKey<bool>(
            "RunSlotSegmentMesh",
            "Run SlotSegmentMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSphereMesh =
        new ModConfigurationKey<bool>(
            "RunSphereMesh",
            "Run SphereMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSpinner =
        new ModConfigurationKey<bool>(
            "RunSpinner",
            "Run Spinner",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunStripeMesh =
        new ModConfigurationKey<bool>(
            "RunStripeMesh",
            "Run StripeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTorusMesh =
        new ModConfigurationKey<bool>(
            "RunTorusMesh",
            "Run TorusMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTriangleMesh =
        new ModConfigurationKey<bool>(
            "RunTriangleMesh",
            "Run TriangleMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTubeBoxMesh =
        new ModConfigurationKey<bool>(
            "RunTubeBoxMesh",
            "Run TubeBoxMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTubeMesh =
        new ModConfigurationKey<bool>(
            "RunTubeMesh",
            "Run TubeMesh",
            () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTubeSpiralMesh =
        new ModConfigurationKey<bool>(
            "RunTubeSpiralMesh",
            "Run TubeSpiralMesh",
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

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWireMeshBase =
        new ModConfigurationKey<bool>(
            "RunWireMeshBase",
            "Run WireMeshBase",
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

        if (ModLoader.VERSION == "2.4.0") OutOfDateWarning();
        else if (ModLoader.VERSION == "2.5.0") OutOfDateWarning();
        else if (ModLoader.VERSION == "2.5.1") OutOfDateWarning();
        else if (!ModLoader.IsHeadless) Msg("Mod intended for Headless clients, please uninstall");
        else harmony.PatchAll();
    }

    public static void OutOfDateWarning()
    {
        Msg("Mod Loader out of date, please update to 2.6.0 or later");
    }

    [HarmonyPatch(typeof(ArrowMesh), "UpdateMeshData")]
    public class ArrowMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunArrowMesh)) return false;

            return true;
        }
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

    [HarmonyPatch(typeof(BallisticPathMesh), "UpdateMeshData")]
    public class BallisticPathMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBallisticPathMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BentTubeMesh), "UpdateMeshData")]
    public class BentTubeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBentTubeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelBoxMesh), "UpdateMeshData")]
    public class BevelBoxMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelBoxMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelPlaneMesh), "UpdateMeshData")]
    public class BevelPlaneMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelPlaneMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelRingMesh), "UpdateMeshData")]
    public class BevelRingMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelRingMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelStripeMesh), "UpdateMeshData")]
    public class BevelStripeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelStripeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BezierTubeMesh), "UpdateMeshData")]
    public class BezierTubeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBezierTubeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BoxArrayMesh), "UpdateMeshData")]
    public class BoxArrayMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBoxArrayMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BoxMesh), "UpdateMeshData")]
    public class BoxMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBoxMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CameraFrustumMesh), "UpdateMeshData")]
    public class CameraFrustumMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCameraFrustumMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CapsuleMesh), "UpdateMeshData")]
    public class CapsuleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCapsuleMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CircleMesh), "UpdateMeshData")]
    public class CircleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCircleMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CircleSegmentShaderMesh), "UpdateMeshData")]
    public class CircleSegmentShaderMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCircleSegmentShaderMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(ColorWheelTriangleMesh), "UpdateMeshData")]
    public class ColorWheelTriangleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunColorWheelTriangleMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(ConeMesh), "UpdateMeshData")]
    public class ConeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunConeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CrossMesh), "UpdateMeshData")]
    public class CrossMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCrossMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(ConvexHullMesh), "UpdateMeshData")]
    public class ConvexHullMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunConvexHullMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CurvedPlaneMesh), "UpdateMeshData")]
    public class CurvedPlaneMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCurvedPlaneMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CylinderMesh), "UpdateMeshData")]
    public class CylinderMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCylinderMesh)) return false;

            return true;
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

    [HarmonyPatch(typeof(FrameMesh), "UpdateMeshData")]
    public class FrameMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunFrameMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(HollowConeMesh), "UpdateMeshData")]
    public class HollowConeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunHollowConeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(IcoSphereMesh), "UpdateMeshData")]
    public class IcoSphereMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunIcoSphereMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LabelPointerMesh), "UpdateMeshData")]
    public class LabelPointerMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLabelPointerMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LegacyCircleSegmentMesh), "UpdateMeshData")]
    public class LegacyCircleSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLegacyCircleSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LightningMesh), "UpdateMeshData")]
    public class LightningMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLightningMesh)) return false;

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

    [HarmonyPatch(typeof(MultiBevelStripeMesh), "UpdateMeshData")]
    public class MultiBevelStripeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunMultiBevelStripeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(MultiLineMesh), "UpdateMeshData")]
    public class MultiLineMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunMultiLineMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(MultiSegmentMesh), "UpdateMeshData")]
    public class MultiSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunMultiSegmentMesh)) return false;

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

    [HarmonyPatch(typeof(PointMesh), "UpdateMeshData")]
    public class PointMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPointMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(QuadArrayMesh), "UpdateMeshData")]
    public class QuadArrayMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunQuadArrayMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(QuadMesh), "UpdateMeshData")]
    public class QuadMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunQuadMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(RampMesh), "UpdateMeshData")]
    public class RampMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunRampMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(RingMesh), "UpdateMeshData")]
    public class RingMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunRingMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SegmentMesh), "UpdateMeshData")]
    public class SegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SlotSegmentMesh), "UpdateMeshData")]
    public class SlotSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSlotSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SphereMesh), "UpdateMeshData")]
    public class SphereMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSphereMesh)) return false;

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

    [HarmonyPatch(typeof(StripeMesh), "UpdateMeshData")]
    public class StripeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunStripeMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TorusMesh), "UpdateMeshData")]
    public class TorusMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTorusMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TriangleMesh), "UpdateMeshData")]
    public class TriangleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTriangleMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TubeBoxMesh), "UpdateMeshData")]
    public class TubeBoxMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTubeBoxMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TubeMesh), "UpdateMeshData")]
    public class TubeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTubeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(TubeSpiralMesh), "UpdateMeshData")]
    public class TubeSpiralMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTubeSpiralMesh)) return false;

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

    [HarmonyPatch(typeof(Wiggler), "OnCommonUpdate")]
    public class WigglerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWiggler)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(WireMeshBase), "UpdateMeshData")]
    public class WireMeshBasePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWireMeshBase)) return false;

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
