using System;
using Custom_Soundtrack.ManageTracks;
using Custom_Soundtrack.Utilities;
using HarmonyLib;
using XRL.World;

namespace Custom_Soundtrack.PatchNoMusicLoad
{
    [HarmonyPatch]
    class PatchNoMusicLoad
    {
        [HarmonyPatch(typeof (Zone), nameof(Zone.Activated))]
        static void Postfix(Zone __instance)
        {
            Zone Z = __instance;
            TrackList Tracks = new TrackList();
            string[] trackData; // In the form [ trackname, isSameTrack=null ]
            bool shouldPatchTrack = Tracks.ShouldPatchTrackIn(Z);

            if (shouldPatchTrack == true)
            {
                trackData = Tracks.GetTrackIn(Z);

                if (trackData != null)
                {
                    string trackToPlay = trackData[0];

                    if (trackToPlay != "default" && trackData[1] == null)
                    {
                        SoundManager.PlayMusic (trackToPlay);
                    }
                }
            }
        }
    }
}
