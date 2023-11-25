using HarmonyLib;

namespace Custom_Soundtrack.HarmonyPatches
{
    [HarmonyPatch]
    class Crossfade_Reduce
    {
        [HarmonyPatch(typeof(SoundManager), nameof(SoundManager.PlayMusic))]
        static void Prefix(ref float CrossfadeDuration)
        {
            CrossfadeDuration = 2.2f; //Default value: 12f
        }
    }
}
