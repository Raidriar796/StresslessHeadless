using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(SteamConnector), "ClearCurrentStatus")]
    public class SteamClearCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "DeleteFile")]
    public class DeleteFilePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "Dispose")]
    public class SteamDisposePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "GameRichPresenceJoinRequested")]
    public class GameRichPresenceJoinRequestedPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "Initialize")]
    public class SteamInitializePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "InitializeSteamAPI")]
    public class InitializeSteamAPIPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "IsRemotePlayActive")]
    public class IsRemotePlayActivePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "NotifyOfLocalUser")]
    public class NotifyOfLocalUserPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "OnSteamSettingsChanged")]
    public class OnSteamSettingsChangedPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "SetCurrentStatus")]
    public class SteamSetCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "ThreadWorker")]
    public class ThreadWorkerPatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "Update")]
    public class SteamUpdatePatch
    {
        private static bool Prefix()
        {
            if (!Config.GetValue(RunSteamIntegration)) return false;

            return true;
        }
    }
}