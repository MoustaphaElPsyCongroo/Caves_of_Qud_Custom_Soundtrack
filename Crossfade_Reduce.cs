using HarmonyLib;

namespace Custom_Soundtrack.HarmonyPatches
{
    [HarmonyPatch]
    class Crossfade_Reduce
    {
        [HarmonyPatch(typeof (SoundManager), nameof(SoundManager.PlayMusic))]
        static void Prefix(
            string Track,
            bool Crossfade,
            ref float CrossfadeDuration
        )
        {
            CrossfadeDuration = 2f; //Default value: 12f
        }
    }
}
