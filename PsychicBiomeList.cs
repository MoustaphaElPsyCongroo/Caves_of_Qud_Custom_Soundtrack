using System;
using System.Collections.Generic;
using System.Linq;
using XRL;

namespace Custom_Soundtrack.PsychicBiomeSupport
{
    [HasCallAfterGameLoaded]
    public class PsychicBiomeMods
    {
        public static List<string> psychicBiomeModifiers = new List<string>();

        // Called whenever loading a save game
        [CallAfterGameLoaded]
        public static void GetPsychicBiomeModifiers()
        {
            List<MutationEntry> mentalMutations;

            mentalMutations = MutationFactory
                .GetMutationsOfCategory("Mental")
                .FindAll(
                    (MutationEntry x) =>
                        !x.BiomeAdjective.IsNullOrEmpty() || !x.BiomeEpithet.IsNullOrEmpty()
                );

            foreach (MutationEntry mentalMutation in mentalMutations)
            {
                string adjective = mentalMutation.BiomeAdjective;

                if (adjective != "")
                {
                    psychicBiomeModifiers.Add(adjective);
                }
            }
        }
    }
}
