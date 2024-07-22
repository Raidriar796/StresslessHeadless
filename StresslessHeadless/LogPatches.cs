using HarmonyLib;
using ResoniteModLoader;
using Elements.Core;

namespace StresslessHeadless;
public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(UniLog), "Error")]
    private class ErrorPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLoggingErrors) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(UniLog), "Log", [typeof(string), typeof(bool)])]
    private class LogPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLogging) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(UniLog), "Warning")]
    private class WarningPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunLoggingWarnings) || stressMode) return true;

            return false;
        }
    }
}   