using ResoniteModLoader;
using HarmonyLib;
using FrooxEngine;
using FrooxEngine.CommonAvatar;
using FrooxEngine.FinalIK;
using Elements.Core;
using FrooxEngine.ProtoFlux;
using System.Reflection;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    public static bool Skip()
    {
        return false;
    }
    private static void SelectivePatches()
    {
        var Prefix = typeof(StresslessHeadless).GetMethod("Skip", BindingFlags.Static | BindingFlags.Public);
        HarmonyMethod SkipMethod = new HarmonyMethod(Prefix);

        if (!RunArrowMesh.Value)
        {
            harmony.Patch(typeof(ArrowMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunAudioWaveformTexture.Value)
        {
            harmony.Patch(typeof(AudioWaveformTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunAutoLookAtUser.Value)
        {
            harmony.Patch(typeof(AutoLookAtUser).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunAxisAligner.Value)
        {
            harmony.Patch(typeof(AxisAligner).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBallisticPathMesh.Value)
        {
            harmony.Patch(typeof(BallisticPathMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBentTubeMesh.Value)
        {
            harmony.Patch(typeof(BentTubeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBevelBoxMesh.Value)
        {
            harmony.Patch(typeof(BevelBoxMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBevelPlaneMesh.Value)
        {
            harmony.Patch(typeof(BevelPlaneMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBevelStripeMesh.Value)
        {
            harmony.Patch(typeof(BevelStripeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBezierTubeMesh.Value)
        {
            harmony.Patch(typeof(BezierTubeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBoxArrayMesh.Value)
        {
            harmony.Patch(typeof(BoxArrayMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunBoxMesh.Value)
        {
            harmony.Patch(typeof(BoxMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCameraFrustumMesh.Value)
        {
            harmony.Patch(typeof(CameraFrustumMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCapsuleMesh.Value)
        {
            harmony.Patch(typeof(CapsuleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCircleMesh.Value)
        {
            harmony.Patch(typeof(CircleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCircleSegmentShaderMesh.Value)
        {
            harmony.Patch(typeof(CircleSegmentShaderMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunColorWheelTriangleMesh.Value)
        {
            harmony.Patch(typeof(ColorWheelTriangleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunConeMesh.Value)
        {
            harmony.Patch(typeof(ConeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCrossMesh.Value)
        {
            harmony.Patch(typeof(CrossMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunConvexHullMesh.Value)
        {
            harmony.Patch(typeof(ConvexHullMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCurvedPlaneMesh.Value)
        {
            harmony.Patch(typeof(CurvedPlaneMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunCylinderMesh.Value)
        {
            harmony.Patch(typeof(CylinderMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunDocumentPageTexture.Value)
        {
            harmony.Patch(typeof(DocumentPageTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunDynamicBoneChain.Value)
        {
            harmony.Patch(typeof(DynamicBoneChainManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public), prefix: SkipMethod);
        }

        if (!RunEyeManager.Value)
        {
            harmony.Patch(typeof(EyeManager).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunFrameMesh.Value)
        {
            harmony.Patch(typeof(FrameMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunGradientStripTexture.Value)
        {
            harmony.Patch(typeof(GradientStripTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunGridTexture.Value)
        {
            harmony.Patch(typeof(GridTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunHollowConeMesh.Value)
        {
            harmony.Patch(typeof(HollowConeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunIcoSphereMesh.Value)
        {
            harmony.Patch(typeof(IcoSphereMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunLabelPointerMesh.Value)
        {
            harmony.Patch(typeof(LabelPointerMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunLegacyCircleSegmentMesh.Value)
        {
            harmony.Patch(typeof(LegacyCircleSegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunLightningMesh.Value)
        {
            harmony.Patch(typeof(LightningMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunLogging.Value)
        {
            harmony.Patch(typeof(UniLog).GetMethod("Log", [typeof(string), typeof(bool)]), prefix: SkipMethod);
        }

        if (!RunLoggingErrors.Value)
        {
            harmony.Patch(typeof(UniLog).GetMethod("Error"), prefix: SkipMethod);
        }

        if (!RunLoggingWarnings.Value)
        {
            harmony.Patch(typeof(UniLog).GetMethod("Warning"), prefix: SkipMethod);
        }

        if (!RunLookAt.Value)
        {
            harmony.Patch(typeof(LookAt).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunLookAtUser.Value)
        {
            harmony.Patch(typeof(LookAtUser).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunMultiBevelStripeMesh.Value)
        {
            harmony.Patch(typeof(MultiBevelStripeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunMultiLineMesh.Value)
        {
            harmony.Patch(typeof(MultiLineMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunMultiSegmentMesh.Value)
        {
            harmony.Patch(typeof(MultiSegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunNoiseTexture.Value)
        {
            harmony.Patch(typeof(NoiseTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunPanner1D.Value)
        {
            harmony.Patch(typeof(Panner1D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunPanner2D.Value)
        {
            harmony.Patch(typeof(Panner2D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunPanner3D.Value)
        {
            harmony.Patch(typeof(Panner3D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunPanner4D.Value)
        {
            harmony.Patch(typeof(Panner4D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunPointMesh.Value)
        {
            harmony.Patch(typeof(PointMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunProtofluxVisuals.Value)
        {
            harmony.Patch(typeof(ProtoFluxNodeVisual).GetMethod("GenerateVisual", BindingFlags.Instance | BindingFlags.Public), prefix: SkipMethod);
        }

        if (!RunQuadArrayMesh.Value)
        {
            harmony.Patch(typeof(QuadArrayMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunQuadMesh.Value)
        {
            harmony.Patch(typeof(QuadMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunRampMesh.Value)
        {
            harmony.Patch(typeof(RingMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunSegmentMesh.Value)
        {
            harmony.Patch(typeof(SegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunSimplexTexture.Value)
        {
            harmony.Patch(typeof(SimplexTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunSlotSegmentMesh.Value)
        {
            harmony.Patch(typeof(SegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunSolidColorTexture.Value)
        {
            harmony.Patch(typeof(SolidColorTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunSphereMesh.Value)
        {
            harmony.Patch(typeof(SphereMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunSpinner.Value)
        {
            harmony.Patch(typeof(Spinner).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunStringQRCodeTexture.Value)
        {
            harmony.Patch(typeof(StringQRCodeTexture).GetMethod("UpdateAssetData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunStripeMesh.Value)
        {
            harmony.Patch(typeof(StripeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunTorusMesh.Value)
        {
            harmony.Patch(typeof(TorusMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunTriangleMesh.Value)
        {
            harmony.Patch(typeof(TriangleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunTubeBoxMesh.Value)
        {
            harmony.Patch(typeof(TubeBoxMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunTubeMesh.Value)
        {
            harmony.Patch(typeof(TubeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunTubeSpiralMesh.Value)
        {
            harmony.Patch(typeof(TubeSpiralMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunUVTexture.Value)
        {
            harmony.Patch(typeof(UVTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunVRIK.Value)
        {
            harmony.Patch(typeof(VRIK).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunVRIKAvatar.Value)
        {
            harmony.Patch(typeof(VRIKAvatar).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunWiggler.Value)
        {
            harmony.Patch(typeof(Wiggler).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunWireMeshBase.Value)
        {
            harmony.Patch(typeof(WireMeshBase).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunWobbler1D.Value)
        {
            harmony.Patch(typeof(Wobbler1D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunWobbler2D.Value)
        {
            harmony.Patch(typeof(Wobbler2D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunWobbler3D.Value)
        {
            harmony.Patch(typeof(Wobbler3D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!RunWobbler4D.Value)
        {
            harmony.Patch(typeof(Wobbler4D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }
    }
}
