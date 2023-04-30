using Custom_Soundtrack.ManageTracks;
using HarmonyLib;

namespace Custom_Soundtrack.HarmonyPatches
{
    [HarmonyPatch]
    class RemoveCampfireSounds
    {
        [HarmonyPatch(typeof (CampfireSounds), nameof(CampfireSounds.Open))]
        static bool Prefix()
        {
            return false;
        }
    }
}
