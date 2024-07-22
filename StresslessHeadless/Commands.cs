using FrooxEngine.Headless;
using HarmonyLib;
using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    internal static void DelayedPatch(Harmony harmony)
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
                if (stressMode == false)
                {  
                    stressMode = true;
                    Msg("Stress enabled");
                }
                else Msg("Stress already enabled");
            }
            else if (args[0].Contains("disable"))
            {
                if (stressMode == true)
                {
                    stressMode = false;
                    Msg("Stress disabled");
                }
                else Msg("Stress already disabled");
            }
            else 
            {
                Warn("Argument must be enable or disable");
            }
        }));
    }
}