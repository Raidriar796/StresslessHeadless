using FrooxEngine;
using HarmonyLib;
using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    public override string Name => "StresslessHeadless";
    public override string Author => "Raidriar796";
    public override string Version => "1.3.1";
    public override string Link => "https://github.com/Raidriar796/StresslessHeadless";

    public override void OnEngineInit()
    {
        Harmony harmony = new("net.raidriar796.StresslessHeadless");
        Config = GetConfiguration();
        Config?.Save(true);

        Engine.Current.RunPostInit(() => 
        {
            if (Config.GetValue(Enable))
            {
                SelectivePatches(harmony);
                DelayedPatch(harmony);
            }
        });
    }
    private static bool stressMode = false;
}
