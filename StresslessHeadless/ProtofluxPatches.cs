using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine.ProtoFlux;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(ProtoFluxNodeVisual), "GenerateVisual")]
    public class GenerateVisualPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunProtofluxVisuals) || stressMode) return true;

            return false;
        }
    }
}