using HarmonyLib;

namespace Custom_Soundtrack.HarmonyPatches
{
    [HarmonyPatch]
    class Crossfade_Reduce
    {
        [HarmonyPatch(typeof (SoundManager), nameof(SoundManager.PlayMusic))]
        static void Prefix(
            string Track,
            string Channel,
            bool Crossfade,
            ref float CrossfadeDuration
        )
        {
            CrossfadeDuration = 2.2f; //Default value: 12f
        }
    }
}
