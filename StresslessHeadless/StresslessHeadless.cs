﻿using FrooxEngine;
using HarmonyLib;
using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    public override string Name => "StresslessHeadless";
    public override string Author => "Raidriar796";
    public override string Version => "2.0.0";
    public override string Link => "https://github.com/Raidriar796/StresslessHeadless";
    private static Harmony harmony = new("net.raidriar796.StresslessHeadless");

    public override void OnEngineInit()
    {
        Config = GetConfiguration();
        Config?.Save(true);

        Engine.Current.RunPostInit(() => 
        {
            if (Config.GetValue(Enable) && ModLoader.IsHeadless)
            {
                SelectivePatches();
                DelayedPatch();
            }
            else if (!ModLoader.IsHeadless)
            {
                Warn("StresslessHeadless is intended for headless clients only, please uninstall");
            }
        });
    }
}
