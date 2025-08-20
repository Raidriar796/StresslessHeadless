using FrooxEngine.Headless;
using HarmonyLib;
using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    internal static void DelayedPatch()
    {
        var target = typeof(HeadlessCommands).GetMethod(nameof(HeadlessCommands.SetupCommonCommands));
        var postfix = typeof(StresslessHeadless).GetMethod(nameof(StressCommand));
        harmony.Patch(target, postfix: new HarmonyMethod(postfix));
    }

    public static void StressCommand(CommandHandler handler)
    {
        handler.RegisterCommand(new GenericCommand("stress", "disables all patches", "<enable/disable>", async (h, world, args) =>
        {
            if (args.Count != 1)
            {
                Warn("Must contain 1 argument");
            }
            else if (args[0].Contains("enable"))
            {
                harmony.UnpatchAll();
            }
            else if (args[0].Contains("disable"))
            {
                SelectivePatches();
            }
            else
            {
                Warn("Argument must be enable or disable");
            }
        }));
    }
}
