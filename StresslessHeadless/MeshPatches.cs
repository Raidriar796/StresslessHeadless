using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using FrooxEngine.CommonAvatar;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(ArrowMesh), "UpdateMeshData")]
    public class ArrowMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunArrowMesh)) return false;

            return true;
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
    
    [HarmonyPatch(typeof(WireMeshBase), "UpdateMeshData")]
    public class WireMeshBasePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWireMeshBase)) return false;

            return true;
        }
    }
}