using HarmonyLib;
using ResoniteModLoader;
using FrooxEngine;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    [HarmonyPatch(typeof(SteamConnector), "ClearCurrentStatus")]
    private class SteamClearCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "DeleteFile")]
    private class DeleteFilePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "Dispose")]
    private class SteamDisposePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "GameRichPresenceJoinRequested")]
    private class GameRichPresenceJoinRequestedPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "Initialize")]
    private class SteamInitializePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "InitializeSteamAPI")]
    private class InitializeSteamAPIPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "IsRemotePlayActive")]
    private class IsRemotePlayActivePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "NotifyOfLocalUser")]
    private class NotifyOfLocalUserPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "OnSteamSettingsChanged")]
    private class OnSteamSettingsChangedPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "SetCurrentStatus")]
    private class SteamSetCurrentStatusPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "ThreadWorker")]
    private class ThreadWorkerPatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }

    [HarmonyPatch(typeof(SteamConnector), "Update")]
    private class SteamUpdatePatch
    {
        private static bool Prefix()
        {
            if (Config.GetValue(RunSteamIntegration) || stressMode) return true;

            return false;
        }
    }
}