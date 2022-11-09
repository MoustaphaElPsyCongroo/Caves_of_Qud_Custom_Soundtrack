using Custom_Soundtrack.ManageTracks;
using HarmonyLib;
using XRL.World;
using XRL.World.Biomes;

namespace Custom_Soundtrack.BiomeModifierSupport
{
    [HarmonyPatch]
    class BiomeSupport
    {
        public static string originalZoneName = "";

        [HarmonyPatch(typeof (IBiome), nameof(IBiome.MutateZoneName))]
        static bool Prefix(string Name, string ZoneID, int NameOrder)
        {
            originalZoneName = Name;
            return true;
        }
    }
}
