using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    public static ModConfiguration Config;

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> Enable =
        new ModConfigurationKey<bool>("Enable", null, () => true);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunArrowMesh =
        new ModConfigurationKey<bool>("RunArrowMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunAssetVariantGeneration =
        new ModConfigurationKey<bool>("RunAssetVariantGeneration", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunAudioWaveformTexture =
        new ModConfigurationKey<bool>("RunAutoLookAtUser", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunAutoLookAtUser =
        new ModConfigurationKey<bool>("RunAutoLookAtUser", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunAxisAligner =
        new ModConfigurationKey<bool>("RunAxisAligner", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBallisticPathMesh =
        new ModConfigurationKey<bool>("RunBallisticPathMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBentTubeMesh =
        new ModConfigurationKey<bool>("RunBentTubeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelBoxMesh =
        new ModConfigurationKey<bool>("RunBevelBoxMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelPlaneMesh =
        new ModConfigurationKey<bool>("RunBevelPlaneMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelRingMesh =
        new ModConfigurationKey<bool>("RunBevelRingMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBevelStripeMesh =
        new ModConfigurationKey<bool>("RunBevelStripeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBezierTubeMesh =
        new ModConfigurationKey<bool>("RunBezierTubeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBoxArrayMesh =
        new ModConfigurationKey<bool>("RunBoxArrayMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunBoxMesh =
        new ModConfigurationKey<bool>("RunBoxMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCameraFrustumMesh =
        new ModConfigurationKey<bool>("RunCameraFrustumMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCapsuleMesh =
        new ModConfigurationKey<bool>("RunCapsuleMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCircleMesh =
        new ModConfigurationKey<bool>("RunCircleMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCircleSegmentShaderMesh =
        new ModConfigurationKey<bool>("RunCircleSegmentShaderMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunColorWheelTriangleMesh =
        new ModConfigurationKey<bool>("RunColorWheelTriangleMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunConeMesh =
        new ModConfigurationKey<bool>("RunConeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCrossMesh =
        new ModConfigurationKey<bool>("RunCrossMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunConvexHullMesh =
        new ModConfigurationKey<bool>("RunConvexHullMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCurvedPlaneMesh =
        new ModConfigurationKey<bool>("RunCurvedPlaneMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunCylinderMesh =
        new ModConfigurationKey<bool>("RunCylinderMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunDiscordIntegration =
        new ModConfigurationKey<bool>("RunDiscordIntegration", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunDocumentPageTexture =
        new ModConfigurationKey<bool>("RunDocumentPageTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunDynamicBoneChain =
        new ModConfigurationKey<bool>("RunDynamicBoneChain", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunEyeManager =
        new ModConfigurationKey<bool>("RunEyeManager", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunFrameMesh =
        new ModConfigurationKey<bool>("RunFrameMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunGradientStripTexture =
        new ModConfigurationKey<bool>("RunGradientStripTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunGridTexture =
        new ModConfigurationKey<bool>("RunGridTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunHollowConeMesh =
        new ModConfigurationKey<bool>("RunHollowConeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunIcoSphereMesh =
        new ModConfigurationKey<bool>("RunIcoSphereMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLabelPointerMesh =
        new ModConfigurationKey<bool>("RunLabelPointerMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLegacyCircleSegmentMesh =
        new ModConfigurationKey<bool>("RunLegacyCircleSegmentMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLightningMesh =
        new ModConfigurationKey<bool>("RunLightningMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLogging =
        new ModConfigurationKey<bool>("RunLogging", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLoggingErrors =
        new ModConfigurationKey<bool>("RunLoggingErrors", null, () => true);
    
    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLoggingWarnings =
        new ModConfigurationKey<bool>("RunLoggingWarnings", null, () => true);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLookAt =
        new ModConfigurationKey<bool>("RunLookAt", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunLookAtUser =
        new ModConfigurationKey<bool>("RunLookAtUser", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunMultiBevelStripeMesh =
        new ModConfigurationKey<bool>("RunMultiBevelStripeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunMultiLineMesh =
        new ModConfigurationKey<bool>("RunMultiLineMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunMultiSegmentMesh =
        new ModConfigurationKey<bool>("RunMultiSegmentMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunNoiseTexture =
        new ModConfigurationKey<bool>("RunNoiseTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner1D =
        new ModConfigurationKey<bool>("RunPanner1D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner2D =
        new ModConfigurationKey<bool>("RunPanner2D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner3D =
        new ModConfigurationKey<bool>("RunPanner3D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPanner4D =
        new ModConfigurationKey<bool>("RunPanner4D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunPointMesh =
        new ModConfigurationKey<bool>("RunPointMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunProtofluxVisuals =
        new ModConfigurationKey<bool>("RunProtofluxVisuals", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunQuadArrayMesh =
        new ModConfigurationKey<bool>("RunQuadArrayMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunQuadMesh =
        new ModConfigurationKey<bool>("RunQuadMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunRampMesh =
        new ModConfigurationKey<bool>("RunRampMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunRingMesh =
        new ModConfigurationKey<bool>("RunRingMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSegmentMesh =
        new ModConfigurationKey<bool>("RunSegmentMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSimplexTexture =
        new ModConfigurationKey<bool>("RunSimplexTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSlotSegmentMesh =
        new ModConfigurationKey<bool>("RunSlotSegmentMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSolidColorTexture =
        new ModConfigurationKey<bool>("RunSolidColorTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSphereMesh =
        new ModConfigurationKey<bool>("RunSphereMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSpinner =
        new ModConfigurationKey<bool>("RunSpinner", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunSteamIntegration =
        new ModConfigurationKey<bool>("RunSteamIntegration", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunStringQRCodeTexture =
        new ModConfigurationKey<bool>("RunDocumentPageTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunStripeMesh =
        new ModConfigurationKey<bool>("RunStripeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTorusMesh =
        new ModConfigurationKey<bool>("RunTorusMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTriangleMesh =
        new ModConfigurationKey<bool>("RunTriangleMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTubeBoxMesh =
        new ModConfigurationKey<bool>("RunTubeBoxMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTubeMesh =
        new ModConfigurationKey<bool>("RunTubeMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunTubeSpiralMesh =
        new ModConfigurationKey<bool>("RunTubeSpiralMesh", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunUVTexture =
        new ModConfigurationKey<bool>("RunUVTexture", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunVRIK =
        new ModConfigurationKey<bool>("RunVRIK", null, () => false);
    
    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunVRIKAvatar =
        new ModConfigurationKey<bool>("RunVRIKAvatar", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWiggler =
        new ModConfigurationKey<bool>("RunWiggler", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWireMeshBase =
        new ModConfigurationKey<bool>("RunWireMeshBase", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler1D =
        new ModConfigurationKey<bool>("RunWobbler1D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler2D =
        new ModConfigurationKey<bool>("RunWobbler2D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler3D =
        new ModConfigurationKey<bool>("RunWobbler3D", null, () => false);

    [AutoRegisterConfigKey] public static readonly ModConfigurationKey<bool> RunWobbler4D =
        new ModConfigurationKey<bool>("RunWobbler4D", null, () => false);
}