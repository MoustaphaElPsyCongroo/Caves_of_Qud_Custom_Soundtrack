using Custom_Soundtrack.ManageTracks;
using HarmonyLib;
using XRL.UI;
using XRL.World;
using XRL.World.Parts;
using System;

namespace Custom_Soundtrack.OptionSwitchHandler
{
    [HarmonyPatch]
    class HandleOptionSwitch
    {
        [HarmonyPatch(typeof(Options), nameof(Options.SetOption))]
        [HarmonyPatch(new Type[] { typeof(string), typeof(string) })]
        static void Postfix(string ID, string Value)
        {
            if (ID == "Custom_Soundtrack_Enable")
            {
                // Resets any timer so that music can be overriden at any time
                TrackManager.previousZone = null;

                if (Value == "Yes")
                {
                    TrackManager TrackManager = new TrackManager();
                    Zone Z = XRL.The.ActiveZone;

                    if (Z != null)
                    {
                        bool shouldPatchTrack = TrackManager.ShouldPatchTrackIn(Z);
                        GameObject firstObject = Z.GetCell(0, 0).GetFirstObject("ZoneMusic");
                        string[] trackData = TrackManager.GetTrackIn(Z);

                        if (trackData == null || trackData[0] == "default")
                        {
                            if (firstObject != null && firstObject.TryGetPart<Music>(out var Part))
                            {
                                SoundManager.PlayMusic(
                                    firstObject.GetStringProperty("Track"),
                                    "music"
                                );
                            }
                        }
                        else
                        {
                            SoundManager.PlayMusic(trackData[0], "music");
                        }
                    }
                }

                if (Value == "No")
                {
                    TrackManager TrackManager = new TrackManager();
                    Zone Z = XRL.The.ActiveZone;
                    if (Z != null)
                    {
                        bool shouldPatchTrack = TrackManager.ShouldPatchTrackIn(Z);
                        GameObject firstObject = Z.GetCell(0, 0).GetFirstObject("ZoneMusic");

                        if (firstObject != null && firstObject.TryGetPart<Music>(out var Part))
                        {
                            SoundManager.PlayMusic(firstObject.GetStringProperty("Track"), "music");
                        }
                    }
                }
            }
        }
    }
}
