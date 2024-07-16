using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine.Interfacing;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(DiscordConnector), "ClearCurrentStatus")]
    private class DiscordClearCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "Dispose")]
    private class DiscordDisposePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "Initialize")]
    private class DiscordInitializePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "LogHook")]
    private class LogHookPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "OnRichPresenceSettingsChanged")]
    private class OnRichPresenceSettingsChangedPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "SetBlankActivity")]
    private class SetBlankActivityPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "SetCurrentStatus")]
    private class DiscordSetCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "Update")]
    private class DiscordUpdatePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "UserCallback")]
    private class UserCallbackPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }
}