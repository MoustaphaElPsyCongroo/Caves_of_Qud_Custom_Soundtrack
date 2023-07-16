using Custom_Soundtrack.ManageTracks;
using HarmonyLib;
using XRL.World;
using XRL.World.Parts;

namespace Custom_Soundtrack.HarmonyPatches
{
    [HarmonyPatch]
    class Play
    {
        [HarmonyPatch(typeof (Music), nameof(Music.TryMusic))]
        static bool Prefix(Music __instance)
        {
            TrackList Tracks = new TrackList();
            GameObject ParentObject = __instance.ParentObject;
            Zone Z = ParentObject.CurrentZone;
            string[] trackData; // In the form [ trackname, isSameTrack=null ]
            bool shouldPatchTrack = Tracks.ShouldPatchTrackIn(Z);

            if (shouldPatchTrack == false)
            {
                trackData = Tracks.GetTrackIn(Z);

                if (trackData != null && trackData[0] != "default")
                {
                    if (trackData[1] == null)
                    {
                        SoundManager
                            .PlayMusic(trackData[0],
                            !ParentObject.HasTag("NoCrossfade"));
                    }

                    /* When custom music should be played, don't continue the
                    original method */
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
