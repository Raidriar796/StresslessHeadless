using HarmonyLib;
using ResoniteModLoader;

namespace StresslessHeadless;

public partial class StresslessHeadless : ResoniteMod
{
    public override string Name => "StresslessHeadless";
    public override string Author => "Raidriar796";
    public override string Version => "1.2.0";
    public override string Link => "https://github.com/Raidriar796/StresslessHeadless";

    public override void OnEngineInit()
    {
        Harmony harmony = new("net.raidriar796.StresslessHeadless");
        Config = GetConfiguration();
        Config?.Save(true);

        if (ModLoader.VERSION == "2.4.0") Msg(warningText);
        else if (ModLoader.VERSION == "2.5.0") Msg(warningText);
        else if (ModLoader.VERSION == "2.5.1") Msg(warningText);
        else if (!ModLoader.IsHeadless) Msg("Mod intended for Headless clients, please uninstall");
        else if (Config.GetValue(Enable)) harmony.PatchAll();
    }
    private string warningText = "Mod Loader out of date, please update to 2.6.0 or later";
}
