using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(ArrowMesh), "UpdateMeshData")]
    private class ArrowMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunArrowMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BallisticPathMesh), "UpdateMeshData")]
    private class BallisticPathMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBallisticPathMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BentTubeMesh), "UpdateMeshData")]
    private class BentTubeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBentTubeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BevelBoxMesh), "UpdateMeshData")]
    private class BevelBoxMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBevelBoxMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BevelPlaneMesh), "UpdateMeshData")]
    private class BevelPlaneMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBevelPlaneMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BevelRingMesh), "UpdateMeshData")]
    private class BevelRingMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBevelRingMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BevelStripeMesh), "UpdateMeshData")]
    private class BevelStripeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBevelStripeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BezierTubeMesh), "UpdateMeshData")]
    private class BezierTubeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBezierTubeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BoxArrayMesh), "UpdateMeshData")]
    private class BoxArrayMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBoxArrayMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(BoxMesh), "UpdateMeshData")]
    private class BoxMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunBoxMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CameraFrustumMesh), "UpdateMeshData")]
    private class CameraFrustumMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCameraFrustumMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CapsuleMesh), "UpdateMeshData")]
    private class CapsuleMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCapsuleMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CircleMesh), "UpdateMeshData")]
    private class CircleMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCircleMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CircleSegmentShaderMesh), "UpdateMeshData")]
    private class CircleSegmentShaderMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCircleSegmentShaderMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(ColorWheelTriangleMesh), "UpdateMeshData")]
    private class ColorWheelTriangleMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunColorWheelTriangleMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(ConeMesh), "UpdateMeshData")]
    private class ConeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunConeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CrossMesh), "UpdateMeshData")]
    private class CrossMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCrossMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(ConvexHullMesh), "UpdateMeshData")]
    private class ConvexHullMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunConvexHullMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CurvedPlaneMesh), "UpdateMeshData")]
    private class CurvedPlaneMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCurvedPlaneMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(CylinderMesh), "UpdateMeshData")]
    private class CylinderMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunCylinderMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(FrameMesh), "UpdateMeshData")]
    private class FrameMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunFrameMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(HollowConeMesh), "UpdateMeshData")]
    private class HollowConeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunHollowConeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(IcoSphereMesh), "UpdateMeshData")]
    private class IcoSphereMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunIcoSphereMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(LabelPointerMesh), "UpdateMeshData")]
    private class LabelPointerMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLabelPointerMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(LegacyCircleSegmentMesh), "UpdateMeshData")]
    private class LegacyCircleSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLegacyCircleSegmentMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(LightningMesh), "UpdateMeshData")]
    private class LightningMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLightningMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(MultiBevelStripeMesh), "UpdateMeshData")]
    private class MultiBevelStripeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunMultiBevelStripeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(MultiLineMesh), "UpdateMeshData")]
    private class MultiLineMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunMultiLineMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(MultiSegmentMesh), "UpdateMeshData")]
    private class MultiSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunMultiSegmentMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(PointMesh), "UpdateMeshData")]
    private class PointMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunPointMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(QuadArrayMesh), "UpdateMeshData")]
    private class QuadArrayMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunQuadArrayMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(QuadMesh), "UpdateMeshData")]
    private class QuadMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunQuadMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(RampMesh), "UpdateMeshData")]
    private class RampMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunRampMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(RingMesh), "UpdateMeshData")]
    private class RingMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunRingMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SegmentMesh), "UpdateMeshData")]
    private class SegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSegmentMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SlotSegmentMesh), "UpdateMeshData")]
    private class SlotSegmentMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSlotSegmentMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SphereMesh), "UpdateMeshData")]
    private class SphereMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSphereMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(StripeMesh), "UpdateMeshData")]
    private class StripeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunStripeMesh) || stressMode) return true;

            return false;
        }
    }
    
    [HarmonyPatch(typeof(TorusMesh), "UpdateMeshData")]
    private class TorusMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunTorusMesh) || stressMode) return true;

            return false;
        }
    }
    
    [HarmonyPatch(typeof(TriangleMesh), "UpdateMeshData")]
    private class TriangleMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunTriangleMesh) || stressMode) return true;

            return false;
        }
    }
    
    [HarmonyPatch(typeof(TubeBoxMesh), "UpdateMeshData")]
    private class TubeBoxMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunTubeBoxMesh) || stressMode) return true;

            return false;
        }
    }
    
    [HarmonyPatch(typeof(TubeMesh), "UpdateMeshData")]
    private class TubeMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunTubeMesh) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(TubeSpiralMesh), "UpdateMeshData")]
    private class TubeSpiralMeshPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunTubeSpiralMesh) || stressMode) return true;

            return false;
        }
    }
    
    [HarmonyPatch(typeof(WireMeshBase), "UpdateMeshData")]
    private class WireMeshBasePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunWireMeshBase) || stressMode) return true;

            return false;
        }
    }
}