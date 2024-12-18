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

        if (!Config.GetValue(RunArrowMesh))
        {
            harmony.Patch(typeof(ArrowMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }   

        if (!!Config.GetValue(RunAssetVariantGeneration))
        {
            harmony.Patch(typeof(AssetVariantGenerator.ComputeTask).GetMethod("ComputeVariant", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);

            harmony.Patch(typeof(AssetVariantGenerator.ComputeTask).GetMethod("ComputeVariant", BindingFlags.Instance | BindingFlags.Public), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunAudioWaveformTexture))
        {
            harmony.Patch(typeof(AudioWaveformTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunAutoLookAtUser))
        {
            harmony.Patch(typeof(AutoLookAtUser).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunAxisAligner))
        {
            harmony.Patch(typeof(AxisAligner).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBallisticPathMesh))
        {
            harmony.Patch(typeof(BallisticPathMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBentTubeMesh))
        {
            harmony.Patch(typeof(BentTubeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBevelBoxMesh))
        {
            harmony.Patch(typeof(BevelBoxMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBevelPlaneMesh))
        {
            harmony.Patch(typeof(BevelPlaneMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBevelStripeMesh))
        {
            harmony.Patch(typeof(BevelStripeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBezierTubeMesh))
        {
            harmony.Patch(typeof(BezierTubeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBoxArrayMesh))
        {
            harmony.Patch(typeof(BoxArrayMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunBoxMesh))
        {
            harmony.Patch(typeof(BoxMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCameraFrustumMesh))
        {
            harmony.Patch(typeof(CameraFrustumMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCapsuleMesh))
        {
            harmony.Patch(typeof(CapsuleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCircleMesh))
        {
            harmony.Patch(typeof(CircleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCircleSegmentShaderMesh))
        {
            harmony.Patch(typeof(CircleSegmentShaderMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunColorWheelTriangleMesh))
        {
            harmony.Patch(typeof(ColorWheelTriangleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunConeMesh))
        {
            harmony.Patch(typeof(ConeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCrossMesh))
        {
            harmony.Patch(typeof(CrossMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunConvexHullMesh))
        {
            harmony.Patch(typeof(ConvexHullMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCurvedPlaneMesh))
        {
            harmony.Patch(typeof(CurvedPlaneMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunCylinderMesh))
        {
            harmony.Patch(typeof(CylinderMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunDocumentPageTexture))
        {
            harmony.Patch(typeof(DocumentPageTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunDynamicBoneChain))
        {
            harmony.Patch(typeof(DynamicBoneChainManager).GetMethod("Update", BindingFlags.Instance | BindingFlags.Public), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunEyeManager))
        {
            harmony.Patch(typeof(EyeManager).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunFrameMesh))
        {
            harmony.Patch(typeof(FrameMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunGradientStripTexture))
        {
            harmony.Patch(typeof(GradientStripTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunGridTexture))
        {
            harmony.Patch(typeof(GridTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunHollowConeMesh))
        {
            harmony.Patch(typeof(HollowConeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunIcoSphereMesh))
        {
            harmony.Patch(typeof(IcoSphereMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLabelPointerMesh))
        {
            harmony.Patch(typeof(LabelPointerMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLegacyCircleSegmentMesh))
        {
            harmony.Patch(typeof(LegacyCircleSegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLightningMesh))
        {
            harmony.Patch(typeof(LightningMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLogging))
        {
            harmony.Patch(typeof(UniLog).GetMethod("Log", [typeof(string), typeof(bool)]), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLoggingErrors))
        {
            harmony.Patch(typeof(UniLog).GetMethod("Error"), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLoggingWarnings))
        {
            harmony.Patch(typeof(UniLog).GetMethod("Warning"), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLookAt))
        {
            harmony.Patch(typeof(LookAt).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunLookAtUser))
        {
            harmony.Patch(typeof(LookAtUser).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunMultiBevelStripeMesh))
        {
            harmony.Patch(typeof(MultiBevelStripeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunMultiLineMesh))
        {
            harmony.Patch(typeof(MultiLineMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunMultiSegmentMesh))
        {
            harmony.Patch(typeof(MultiSegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunNoiseTexture))
        {
            harmony.Patch(typeof(NoiseTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunPanner1D))
        {
            harmony.Patch(typeof(Panner1D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunPanner2D))
        {
            harmony.Patch(typeof(Panner2D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunPanner3D))
        {
            harmony.Patch(typeof(Panner3D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunPanner4D))
        {
            harmony.Patch(typeof(Panner4D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunPointMesh))
        {
            harmony.Patch(typeof(PointMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunProtofluxVisuals))
        {
            harmony.Patch(typeof(ProtoFluxNodeVisual).GetMethod("GenerateVisual", BindingFlags.Instance | BindingFlags.Public), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunQuadArrayMesh))
        {
            harmony.Patch(typeof(QuadArrayMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunQuadMesh))
        {
            harmony.Patch(typeof(QuadMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunRampMesh))
        {
            harmony.Patch(typeof(RingMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunSegmentMesh))
        {
            harmony.Patch(typeof(SegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunSimplexTexture))
        {
            harmony.Patch(typeof(SimplexTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunSlotSegmentMesh))
        {
            harmony.Patch(typeof(SegmentMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunSolidColorTexture))
        {
            harmony.Patch(typeof(SolidColorTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunSphereMesh))
        {
            harmony.Patch(typeof(SphereMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunSpinner))
        {
            harmony.Patch(typeof(Spinner).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunStringQRCodeTexture))
        {
            harmony.Patch(typeof(StringQRCodeTexture).GetMethod("UpdateAssetData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunStripeMesh))
        {
            harmony.Patch(typeof(StripeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunTorusMesh))
        {
            harmony.Patch(typeof(TorusMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunTriangleMesh))
        {
            harmony.Patch(typeof(TriangleMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunTubeBoxMesh))
        {
            harmony.Patch(typeof(TubeBoxMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunTubeMesh))
        {
            harmony.Patch(typeof(TubeMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunTubeSpiralMesh))
        {
            harmony.Patch(typeof(TubeSpiralMesh).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunUVTexture))
        {
            harmony.Patch(typeof(UVTexture).GetMethod("UpdateTextureData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunVRIK))
        {
            harmony.Patch(typeof(VRIK).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunVRIKAvatar))
        {
            harmony.Patch(typeof(VRIKAvatar).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunWiggler))
        {
            harmony.Patch(typeof(Wiggler).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunWireMeshBase))
        {
            harmony.Patch(typeof(WireMeshBase).GetMethod("UpdateMeshData", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunWobbler1D))
        {
            harmony.Patch(typeof(Wobbler1D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunWobbler2D))
        {
            harmony.Patch(typeof(Wobbler2D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunWobbler3D))
        {
            harmony.Patch(typeof(Wobbler3D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }

        if (!Config.GetValue(RunWobbler4D))
        {
            harmony.Patch(typeof(Wobbler4D).GetMethod("OnCommonUpdate", BindingFlags.Instance | BindingFlags.NonPublic), prefix: SkipMethod);
        }
    }
}
