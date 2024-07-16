using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine.Interfacing;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(DiscordConnector), "ClearCurrentStatus")]
    public class DiscordClearCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "Dispose")]
    public class DiscordDisposePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "Initialize")]
    public class DiscordInitializePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "LogHook")]
    public class LogHookPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "OnRichPresenceSettingsChanged")]
    public class OnRichPresenceSettingsChangedPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "SetBlankActivity")]
    public class SetBlankActivityPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "SetCurrentStatus")]
    public class DiscordSetCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "Update")]
    public class DiscordUpdatePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(DiscordConnector), "UserCallback")]
    public class UserCallbackPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunDiscordIntegration)) return false;

            return true;
        }
    }
}