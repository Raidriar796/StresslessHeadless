using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;
using FrooxEngine.CommonAvatar;
using FrooxEngine.FinalIK;
using Elements.Core;
using FrooxEngine.ProtoFlux;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    private static bool Skip()
    {
        return false;
    }
    private static void SelectivePatches(Harmony harmony)
    {
        var skipMethod = typeof(StresslessHeadless).GetMethod("Skip");

        // Asset Patches
        if (Config.GetValue(RunAssetVariantGeneration))
        {
            harmony.Patch(typeof(AssetVariantGenerator.ComputeTask).GetMethod("ComputeVariant"), prefix: skipMethod);

            harmony.Patch(typeof(AssetVariantGenerator.ComputeTask).GetMethod("ComputeVariant"), prefix: skipMethod);
        }

        // Avatar Patches
        if (Config.GetValue(RunDynamicBoneChain))
        {
            harmony.Patch(typeof(DynamicBoneChainManager).GetMethod("Update"), prefix: skipMethod);
        }

        if (Config.GetValue(RunEyeManager))
        {
            harmony.Patch(typeof(EyeManager).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunVRIK))
        {
            harmony.Patch(typeof(VRIK).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunVRIKAvatar))
        {
            harmony.Patch(typeof(VRIKAvatar).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        // Log Patches
        if (Config.GetValue(RunLoggingErrors))
        {
            harmony.Patch(typeof(UniLog).GetMethod("Error"), prefix: skipMethod);
        }

        if (Config.GetValue(RunLogging))
        {
            harmony.Patch(typeof(UniLog).GetMethod("Log", [typeof(string), typeof(bool)]), prefix: skipMethod);
        }

        if (Config.GetValue(RunLoggingWarnings))
        {
            harmony.Patch(typeof(UniLog).GetMethod("Warning"), prefix: skipMethod);
        }

        // Mesh Patches
        if (Config.GetValue(RunArrowMesh))
        {
            harmony.Patch(typeof(ArrowMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBallisticPathMesh))
        {
            harmony.Patch(typeof(BallisticPathMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBentTubeMesh))
        {
            harmony.Patch(typeof(BentTubeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBevelBoxMesh))
        {
            harmony.Patch(typeof(BevelBoxMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBevelPlaneMesh))
        {
            harmony.Patch(typeof(BevelPlaneMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBevelStripeMesh))
        {
            harmony.Patch(typeof(BevelStripeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBezierTubeMesh))
        {
            harmony.Patch(typeof(BezierTubeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBoxArrayMesh))
        {
            harmony.Patch(typeof(BoxArrayMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunBoxMesh))
        {
            harmony.Patch(typeof(BoxMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCameraFrustumMesh))
        {
            harmony.Patch(typeof(CameraFrustumMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCapsuleMesh))
        {
            harmony.Patch(typeof(CapsuleMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCircleMesh))
        {
            harmony.Patch(typeof(CircleMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCircleSegmentShaderMesh))
        {
            harmony.Patch(typeof(CircleSegmentShaderMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunColorWheelTriangleMesh))
        {
            harmony.Patch(typeof(ColorWheelTriangleMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunConeMesh))
        {
            harmony.Patch(typeof(ConeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCrossMesh))
        {
            harmony.Patch(typeof(CrossMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunConvexHullMesh))
        {
            harmony.Patch(typeof(ConvexHullMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCurvedPlaneMesh))
        {
            harmony.Patch(typeof(CurvedPlaneMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunCylinderMesh))
        {
            harmony.Patch(typeof(CylinderMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunFrameMesh))
        {
            harmony.Patch(typeof(FrameMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunHollowConeMesh))
        {
            harmony.Patch(typeof(HollowConeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunIcoSphereMesh))
        {
            harmony.Patch(typeof(IcoSphereMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunLabelPointerMesh))
        {
            harmony.Patch(typeof(LabelPointerMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunLegacyCircleSegmentMesh))
        {
            harmony.Patch(typeof(LegacyCircleSegmentMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunLightningMesh))
        {
            harmony.Patch(typeof(LightningMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunMultiBevelStripeMesh))
        {
            harmony.Patch(typeof(MultiBevelStripeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunMultiLineMesh))
        {
            harmony.Patch(typeof(MultiLineMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunMultiSegmentMesh))
        {
            harmony.Patch(typeof(MultiSegmentMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunPointMesh))
        {
            harmony.Patch(typeof(PointMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunQuadArrayMesh))
        {
            harmony.Patch(typeof(QuadArrayMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunQuadMesh))
        {
            harmony.Patch(typeof(QuadMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunRampMesh))
        {
            harmony.Patch(typeof(RingMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunSegmentMesh))
        {
            harmony.Patch(typeof(SegmentMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunSlotSegmentMesh))
        {
            harmony.Patch(typeof(SegmentMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunSphereMesh))
        {
            harmony.Patch(typeof(SphereMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunStripeMesh))
        {
            harmony.Patch(typeof(StripeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunTorusMesh))
        {
            harmony.Patch(typeof(TorusMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunTriangleMesh))
        {
            harmony.Patch(typeof(TriangleMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunTubeBoxMesh))
        {
            harmony.Patch(typeof(TubeBoxMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunTubeMesh))
        {
            harmony.Patch(typeof(TubeMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunTubeSpiralMesh))
        {
            harmony.Patch(typeof(TubeSpiralMesh).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunWireMeshBase))
        {
            harmony.Patch(typeof(WireMeshBase).GetMethod("UpdateMeshData"), prefix: skipMethod);
        }

        // Protoflux patches
        if (Config.GetValue(RunProtofluxVisuals))
        {
            harmony.Patch(typeof(ProtoFluxNodeVisual).GetMethod("GenerateVisual"), prefix: skipMethod);
        }

        // Texture Patches
        if (Config.GetValue(RunAudioWaveformTexture))
        {
            harmony.Patch(typeof(AudioWaveformTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunDocumentPageTexture))
        {
            harmony.Patch(typeof(DocumentPageTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunGradientStripTexture))
        {
            harmony.Patch(typeof(GradientStripTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunGridTexture))
        {
            harmony.Patch(typeof(GridTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunNoiseTexture))
        {
            harmony.Patch(typeof(NoiseTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunSimplexTexture))
        {
            harmony.Patch(typeof(SimplexTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunSolidColorTexture))
        {
            harmony.Patch(typeof(SolidColorTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunStringQRCodeTexture))
        {
            harmony.Patch(typeof(StringQRCodeTexture).GetMethod("UpdateAssetData"), prefix: skipMethod);
        }

        if (Config.GetValue(RunUVTexture))
        {
            harmony.Patch(typeof(UVTexture).GetMethod("UpdateTextureData"), prefix: skipMethod);
        }

        // Transform Patches
        if (Config.GetValue(RunAutoLookAtUser))
        {
            harmony.Patch(typeof(AutoLookAtUser).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunAxisAligner))
        {
            harmony.Patch(typeof(AxisAligner).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunLookAt))
        {
            harmony.Patch(typeof(LookAt).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunLookAtUser))
        {
            harmony.Patch(typeof(LookAtUser).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunPanner1D))
        {
            harmony.Patch(typeof(Panner1D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunPanner2D))
        {
            harmony.Patch(typeof(Panner2D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunPanner3D))
        {
            harmony.Patch(typeof(Panner3D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunSpinner))
        {
            harmony.Patch(typeof(Spinner).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunWiggler))
        {
            harmony.Patch(typeof(Wiggler).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunWobbler1D))
        {
            harmony.Patch(typeof(Wobbler1D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunWobbler2D))
        {
            harmony.Patch(typeof(Wobbler2D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunWobbler3D))
        {
            harmony.Patch(typeof(Wobbler3D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }

        if (Config.GetValue(RunWobbler4D))
        {
            harmony.Patch(typeof(Wobbler4D).GetMethod("OnCommonUpdate"), prefix: skipMethod);
        }
    }
}
