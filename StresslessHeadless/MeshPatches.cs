using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using FrooxEngine.CommonAvatar;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(ArrowMesh), "UpdateMeshData")]
    private class ArrowMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunArrowMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BallisticPathMesh), "UpdateMeshData")]
    private class BallisticPathMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBallisticPathMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BentTubeMesh), "UpdateMeshData")]
    private class BentTubeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBentTubeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelBoxMesh), "UpdateMeshData")]
    private class BevelBoxMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelBoxMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelPlaneMesh), "UpdateMeshData")]
    private class BevelPlaneMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelPlaneMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelRingMesh), "UpdateMeshData")]
    private class BevelRingMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelRingMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BevelStripeMesh), "UpdateMeshData")]
    private class BevelStripeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBevelStripeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BezierTubeMesh), "UpdateMeshData")]
    private class BezierTubeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBezierTubeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BoxArrayMesh), "UpdateMeshData")]
    private class BoxArrayMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBoxArrayMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(BoxMesh), "UpdateMeshData")]
    private class BoxMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunBoxMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CameraFrustumMesh), "UpdateMeshData")]
    private class CameraFrustumMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCameraFrustumMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CapsuleMesh), "UpdateMeshData")]
    private class CapsuleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCapsuleMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CircleMesh), "UpdateMeshData")]
    private class CircleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCircleMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CircleSegmentShaderMesh), "UpdateMeshData")]
    private class CircleSegmentShaderMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCircleSegmentShaderMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(ColorWheelTriangleMesh), "UpdateMeshData")]
    private class ColorWheelTriangleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunColorWheelTriangleMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(ConeMesh), "UpdateMeshData")]
    private class ConeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunConeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CrossMesh), "UpdateMeshData")]
    private class CrossMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCrossMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(ConvexHullMesh), "UpdateMeshData")]
    private class ConvexHullMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunConvexHullMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CurvedPlaneMesh), "UpdateMeshData")]
    private class CurvedPlaneMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCurvedPlaneMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(CylinderMesh), "UpdateMeshData")]
    private class CylinderMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunCylinderMesh)) return false;

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

    [HarmonyPatch(typeof(FrameMesh), "UpdateMeshData")]
    private class FrameMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunFrameMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(HollowConeMesh), "UpdateMeshData")]
    private class HollowConeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunHollowConeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(IcoSphereMesh), "UpdateMeshData")]
    private class IcoSphereMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunIcoSphereMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LabelPointerMesh), "UpdateMeshData")]
    private class LabelPointerMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLabelPointerMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LegacyCircleSegmentMesh), "UpdateMeshData")]
    private class LegacyCircleSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLegacyCircleSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(LightningMesh), "UpdateMeshData")]
    private class LightningMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunLightningMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(MultiBevelStripeMesh), "UpdateMeshData")]
    private class MultiBevelStripeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunMultiBevelStripeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(MultiLineMesh), "UpdateMeshData")]
    private class MultiLineMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunMultiLineMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(MultiSegmentMesh), "UpdateMeshData")]
    private class MultiSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunMultiSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(PointMesh), "UpdateMeshData")]
    private class PointMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunPointMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(QuadArrayMesh), "UpdateMeshData")]
    private class QuadArrayMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunQuadArrayMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(QuadMesh), "UpdateMeshData")]
    private class QuadMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunQuadMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(RampMesh), "UpdateMeshData")]
    private class RampMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunRampMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(RingMesh), "UpdateMeshData")]
    private class RingMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunRingMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SegmentMesh), "UpdateMeshData")]
    private class SegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SlotSegmentMesh), "UpdateMeshData")]
    private class SlotSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSlotSegmentMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SphereMesh), "UpdateMeshData")]
    private class SphereMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSphereMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(StripeMesh), "UpdateMeshData")]
    private class StripeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunStripeMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TorusMesh), "UpdateMeshData")]
    private class TorusMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTorusMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TriangleMesh), "UpdateMeshData")]
    private class TriangleMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTriangleMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TubeBoxMesh), "UpdateMeshData")]
    private class TubeBoxMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTubeBoxMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(TubeMesh), "UpdateMeshData")]
    private class TubeMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTubeMesh)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(TubeSpiralMesh), "UpdateMeshData")]
    private class TubeSpiralMeshPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunTubeSpiralMesh)) return false;

            return true;
        }
    }
    
    [HarmonyPatch(typeof(WireMeshBase), "UpdateMeshData")]
    private class WireMeshBasePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunWireMeshBase)) return false;

            return true;
        }
    }
}