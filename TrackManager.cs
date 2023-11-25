using System;
using System.Collections.Generic;
using Custom_Soundtrack.PsychicBiomeSupport;
using Custom_Soundtrack.Utilities;
using HistoryKit;
using XRL;
using XRL.World;
using HarmonyLib;

namespace Custom_Soundtrack.ManageTracks
{
    [HarmonyPatch]
    public class TrackManager
    {
        public List<string> Tracks = null;
        public static IDictionary<string, List<string>> Tracklist = new UserTrackList().Tracks;

        private string toPatch = "";

        private static string previousTrack = null;

        public static string previousZone = null;

        private static int previousZ;

        private static DateTime previousTime;

        private static TimeSpan timeSincePrevious;

        private static DateTime maxTime;

        public static double tracksMinSeconds = 120;

        private string isSameTrack = null;

        private void SetTrackListFor(Zone Z)
        {
            /*
            --<------------- START EDITING AFTER THIS LINE --------<-----
            */
            // else
            /*
            *******************************************************
            ******************** NAMED LOCATIONS ******************
            *******************************************************
            */
            //---------- //ASPHALT MINES //-----------
            if (Z.DisplayName.Contains("Asphalt Mines") && Z.Z <= 40)
            {
                //Surface & Upper shafts
                if (Z.Z <= 14)
                {
                    Tracks = Tracklist["Asphalt Mines_0-4_Upper shafts"];
                } //Ancient Bones
                else if (Z.Z == 15)
                {
                    Tracks = Tracklist["Asphalt Mines_5_Ancient Bones"];
                } //Middle Shafts
                else if (Z.Z <= 18)
                {
                    Tracks = Tracklist["Asphalt Mines_6-8_Middle Shafts"];
                } //Deep Shafts
                else if (Z.Z <= 22)
                {
                    Tracks = Tracklist["Asphalt Mines_9-12_Deep Shafts"];
                } //Darkunder
                else if (Z.Z <= 28)
                {
                    Tracks = Tracklist["Asphalt Mines_13-18_Darkunder"];
                } //Great Sea
                else if (Z.Z == 29)
                {
                    Tracks = Tracklist["Asphalt Mines_19_Great Sea"];
                } //Tunnels of Ur & Swilling Vast
                else if (Z.Z <= 40)
                {
                    Tracks = Tracklist["Asphalt Mines_20-30_Tunnels of Ur & Swilling Vast"];
                }
            } //---------- //BARATHRUM'S STUDY & GRIT GATE //-----------
            else if (Z.DisplayName.Contains("Grit Gate") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = Tracklist["Grit Gate_0"];
                } //Lower Tunnels
                else if (Z.Z <= 12)
                {
                    Tracks = Tracklist["Grit Gate_1-2_Lower Tunnels"];
                } //Grit Gate Entrance
                else if (Z.Z == 13)
                {
                    Tracks = Tracklist["Grit Gate_3_Gate Entrance"];
                } //Barathrum's Study
                else if (Z.Z == 14)
                {
                    Tracks = Tracklist["Grit Gate_4_Barathrum's Study"];
                }
            } //---------- //BETHESDA SUSA //-----------
            else if (Z.DisplayName.Contains("Bethesda Susa") && Z.Z <= 26)
            {
                //Surface & Ruined Wharf
                if (Z.Z <= 11)
                {
                    Tracks = Tracklist["Bethesda Susa_0-1_Ruined Wharf"];
                } //Healing Pools 1: Jotun, Who Parts Limbs
                else if (Z.Z == 12)
                {
                    Tracks = Tracklist["Bethesda Susa_2_Healing Pools 1: Jotun, Who Parts Limbs"];
                } //Healing Pools 2: Fjorn-Josef, Who Knits The Icy Lattice
                else if (Z.Z == 13)
                {
                    Tracks = Tracklist[
                        "Bethesda Susa_3_Healing Pools 2: Fjorn-Josef, Who Knits The Icy Lattice"
                    ];
                } //Healing Pools 3: Haggabah, Who Plies The Umbral Path
                else if (Z.Z == 14)
                {
                    Tracks = Tracklist[
                        "Bethesda Susa_4_Healing Pools 3: Haggabah, Who Plies The Umbral Path"
                    ];
                } //Abandoned Ward 1
                else if (Z.Z == 15)
                {
                    Tracks = Tracklist["Bethesda Susa_5_Abandoned Ward 1"];
                } //Ruined Ward
                else if (Z.Z <= 20)
                {
                    if (Z.Z == 16)
                    {
                        Tracks = Tracklist["Bethesda Susa_6-10_Ruined Ward_6"];
                    }
                    else
                    {
                        Tracks = Tracklist["Bethesda Susa_6-10_Ruined Ward_7-10"];
                    }
                } //Abandoned Ward 2
                else if (Z.Z <= 22)
                {
                    Tracks = Tracklist["Bethesda Susa_11-12_Abandoned Ward 2"];
                } //Cybernetics Ward
                else if (Z.Z == 23)
                {
                    Tracks = Tracklist["Bethesda Susa_13_Cybernetics Ward"];
                } //Cryobarrios
                else if (Z.Z <= 25)
                {
                    Tracks = Tracklist["Bethesda Susa_14-15_Cryobarrios"];
                } //Temple of the Rock
                else if (Z.Z == 26)
                {
                    Tracks = Tracklist["Bethesda Susa_16_Temple of the Rock"];
                }
            } //---------- //BEY LAH //-----------
            else if (Z.DisplayName.Contains("Bey Lah"))
            {
                Tracks = Tracklist["Bey Lah"];
            } //---------- //CHARRED TREE //-----------
            else if (
                Z.DisplayName.Contains("charred tree")
                || Z.HasBuilder("ClearAll") && (Z.NewTier <= 4)
            )
            {
                Tracks = Tracklist["Charred Tree"];
            } //---------- //EYN ROJ and CRYSTALLINE ROOTS //-----------
            else if (
                Z.Z <= 50
                && (Z.DisplayName == "Eyn Roj" || Z.DisplayName.Contains("crystalline roots"))
            )
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_0"];
                } //Strata 1-4, before intermediate stairs
                else if (Z.Z <= 14)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_1-4"];
                } //Intermediate stairs 1: strata 5, 10, 15, 20
                else if (Z.Z <= 30 && Z.Z % 5 == 0)
                {
                    Tracks = Tracklist[
                        "Eyn Roj and Crystalline Roots_5, 10, 15, 20_Intermediate stairs 1"
                    ];
                } //Strata 6-9
                else if (Z.Z <= 19)
                {
                    //6-7
                    if (Z.Z <= 17)
                    {
                        Tracks = Tracklist["Eyn Roj and Crystalline Roots_6-7"];
                    } //8-9
                    else
                    {
                        Tracks = Tracklist["Eyn Roj and Crystalline Roots_8-9"];
                    }
                } //Strata 11-14
                else if (Z.Z <= 24)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_11-14"];
                } //Strata 16-19
                else if (Z.Z <= 29)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_16-19"];
                } //Strata 21-24
                else if (Z.Z <= 34)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_21-24"];
                } //Intermediate stairs 2: strata 25, 30, 35, 40
                else if (Z.Z <= 50 && Z.Z % 5 == 0)
                {
                    //Stratum 25
                    if (Z.Z == 35)
                    {
                        Tracks = Tracklist[
                            "Eyn Roj and Crystalline Roots_25_Intermediate stairs 2"
                        ];
                    } //Stratum 30
                    else if (Z.Z == 40)
                    {
                        Tracks = Tracklist[
                            "Eyn Roj and Crystalline Roots_30_Intermediate stairs 2"
                        ];
                    } //Stratum 35
                    else if (Z.Z == 45)
                    {
                        Tracks = Tracklist[
                            "Eyn Roj and Crystalline Roots_35_Intermediate stairs 2"
                        ];
                    } //Stratum 40 - last floor
                    else if (Z.Z == 50)
                    {
                        Tracks = Tracklist["Eyn Roj and Crystalline Roots_40_Last Floor"];
                    }
                } //Strata 26-29
                else if (Z.Z <= 39)
                {
                    //26-27
                    if (Z.Z <= 37)
                    {
                        Tracks = Tracklist["Eyn Roj and Crystalline Roots_26-27"];
                    } //28-29
                    else
                    {
                        Tracks = Tracklist["Eyn Roj and Crystalline Roots_28-29"];
                    }
                } //Strata 31-34
                else if (Z.Z <= 44)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_31-34"];
                } //Strata 36-39
                else if (Z.Z <= 49)
                {
                    Tracks = Tracklist["Eyn Roj and Crystalline Roots_36-39"];
                }
            } //---------- //EZRA //-----------
            else if (Z.DisplayName == "Ezra")
            {
                Tracks = Tracklist["Ezra"];
            } //---------- //GOLGOTHA //-----------
            else if (Z.DisplayName.Contains("Golgotha") && Z.Z <= 15)
            {
                //Surface & Trash Chutes 1
                if (Z.Z <= 11)
                {
                    Tracks = Tracklist["Golgotha_0-1_Trash Chutes 1"];
                } //Trash Chutes 2 - 4
                else if (Z.Z <= 14)
                {
                    Tracks = Tracklist["Golgotha_2-4_Trash Chutes 2-4"];
                } //Cloaca
                else if (Z.Z == 15)
                {
                    Tracks = Tracklist["Golgotha_5_Cloaca"];
                }
            } //---------- //GYL //-----------
            else if (Z.DisplayName.Contains("Gyl"))
            {
                Tracks = Tracklist["Gyl"];
            } //---------- //JOPPA //-----------
            else if (Z.DisplayName.Contains("Joppa"))
            {
                Tracks = Tracklist["Joppa"];
            } //---------- //RUINS OF JOPPA / ABANDONED JOPPA //-----------
            else if (
                Z.DisplayName.Contains("ruins of Joppa")
                || Z.DisplayName.Contains("abandoned village")
            )
            {
                Tracks = Tracklist["Ruins of Joppa"];
            } //---------- //KYAKUKYA //-----------
            else if (Z.DisplayName.Contains("Kyakukya"))
            {
                Tracks = Tracklist["Kyakukya"];
            } //---------- //OMONPORCH //-----------
            else if (Z.DisplayName.Contains("Omonporch"))
            {
                //Court of the Sultans
                if (Z.DisplayName.Contains("Court"))
                {
                    Tracks = Tracklist["Omonporch_Court of the Sultans"];
                } //Twin Gates
                else if (Z.DisplayName.Contains("Twin Gates"))
                {
                    Tracks = Tracklist["Omonporch_Twin Gates"];
                } //"Outskirts"
            } //---------- //RED ROCK //-----------
            else if (Z.DisplayName.Contains("Red Rock") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = Tracklist["Red Rock_0"];
                } //Stratum 1
                else if (Z.Z == 11)
                {
                    Tracks = Tracklist["Red Rock_1"];
                } //Stratum 2
                else if (Z.Z == 12)
                {
                    Tracks = Tracklist["Red Rock_2"];
                } //Stratum 3
                else if (Z.Z == 13)
                {
                    Tracks = Tracklist["Red Rock_3"];
                } //Stratum 4
                else if (Z.Z == 14)
                {
                    Tracks = Tracklist["Red Rock_4"];
                }
            } //---------- //RUST WELLS //-----------
            else if (Z.DisplayName.Contains("Rustwell") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = Tracklist["Rust Wells"];
                }
                else
                //Stratum 1 - 4
                {
                    Tracks = Tracklist["Rust Wells_1-4"];
                }
            } //---------- //RUSTED ARCHWAY //-----------
            else if (Z.DisplayName.Contains("rusted archway") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = Tracklist["Rusted Archway_0"];
                } //Stratum 1-2
                else if (Z.Z <= 12)
                {
                    Tracks = Tracklist["Rusted Archway_1-2"];
                } //Stratum 3
                else if (Z.Z == 13)
                {
                    Tracks = Tracklist["Rusted Archway_3"];
                } //Stratum 4
                else if (Z.Z == 14)
                {
                    Tracks = Tracklist["Rusted Archway_4"];
                }
            } //---------- //STILTGROUNDS //-----------
            else if (Z.DisplayName.Contains("Stiltgrounds"))
            {
                toPatch = "yes";
                Tracks = Tracklist["Stillgrounds"];
            } //---------- //SIX DAY STILT //-----------
            else if (Z.DisplayName.Contains("Six Day Stilt"))
            {
                Tracks = Tracklist["Six Day Stilt"];
            } //---------- //THE HYDROPON //-----------
            else if (
                Z.DisplayName.Contains("Hydropon") || Z.HasBuilder("ClearAll") && (Z.NewTier >= 6)
            )
            {
                toPatch = "yes";

                Tracks = Tracklist["The Hydropon"];
            } //---------- //TOMB OF THE EATERS / SPINDLE CHANNEL //-----------
            else if (
                Z.DisplayName.Contains("Tomb of the Eaters")
                || (Z.DisplayName.Contains("banana grove") && Z.Z == 11)
                || (Z.DisplayName.Contains("Spindle Channel"))
            )
            {
                // Liminal Ways
                if (Z.DisplayName.Contains("Liminal Way"))
                {
                    Tracks = Tracklist["Tomb_of_the_Eaters_Liminal Way"];
                }
                else if (Z.DisplayName.Contains("Spindle Channel"))
                {
                    toPatch = "yes";
                    Tracks = Tracklist["Tomb_of_the_Eaters_Spindle Channel"];
                } //Surface - Grand Vestibule and access corridors
                else if (Z.Z == 10)
                {
                    //Grand Vestibule
                    if (Z.DisplayName.Contains("Grand Vestibule"))
                    {
                        Tracks = Tracklist["Tomb_of_the_Eaters_0_Grand Vestibule"];
                    } //Access corridors, structural ribs
                    else if (Z.DisplayName.Contains("access corridor"))
                    {
                        Tracks = Tracklist[
                            "Tomb_of_the_Eaters_0_Access corridors and structural ribs"
                        ];
                    }
                } //Stratum 1 - Folk Catacombs, Banana grove passage to the tomb
                else if (Z.Z == 11)
                {
                    if (Z.DisplayName.Contains("banana grove"))
                    {
                        Tracks = Tracklist["Tomb_of_the_Eaters_1_Banana grove passage to the tomb"];
                    }
                    else if (Z.DisplayName.Contains("Folk Catacombs"))
                    {
                        Tracks = Tracklist["Tomb_of_the_Eaters_1_Folk Catacombs"];
                    }
                } //Above level 1 - Crematory and Columbarium
                else if (Z.Z == 9)
                {
                    if (Z.DisplayName.Contains("Crematory"))
                    {
                        Tracks = Tracklist["Tomb_of_the_Eaters_+1_Crematory"];
                    }
                    else if (Z.DisplayName.Contains("Columbarium"))
                    {
                        Tracks = Tracklist["Tomb_of_the_Eaters_+1_Columbarium"];
                    }
                } //Above level 2 - Lower Crypts: Warriors and Tutors
                else if (Z.Z == 8)
                {
                    if (Z.DisplayName.Contains("Lower Crypts"))
                    {
                        Tracks = Tracklist[
                            "Tomb_of_the_Eaters_+2_Lower Crypts: Warriors and Tutors"
                        ];
                    }
                } //Above level 3 - Upper Crypts: Priests and Royal families
                else if (Z.Z == 7)
                {
                    if (Z.DisplayName.Contains("Upper Crypts"))
                    {
                        Tracks = Tracklist[
                            "Tomb_of_the_Eaters_+3_Upper Crypts: Priests and Royal families"
                        ];
                    }
                } //Sultan Tombs: Above levels 4-9
                else if (Z.Z >= 5)
                {
                    Tracks = Tracklist["Tomb_of_the_Eaters_+4-+5_Sultan Tomb"];
                }
                else if (Z.Z >= 3)
                {
                    Tracks = Tracklist["Tomb_of_the_Eaters_+6-+7_Sultan Tomb"];
                }
                else if (Z.Z >= 1)
                {
                    Tracks = Tracklist["Tomb_of_the_Eaters_+8-+9_Sultan Tomb"];
                } //The Unfinished Tomb: Above level 10
                else if (Z.Z == 0)
                {
                    Tracks = Tracklist["Tomb_of_the_Eaters_The Unfinished Tomb"];
                }
            } //---------- //THIN WORLD / GATE TO BRIGHTSHEOL //-----------
            else if (Z.DisplayName.Contains("thin world") || Z.DisplayName.Contains("Brightsheol"))
            {
                toPatch = "yes";
                Tracks = Tracklist["Thin World"];
            } //---------- //TREMBLING DUNES //-----------
            else if (Z.DisplayName.Contains("Trembling Dunes") && Z.Z <= 12)
            {
                Tracks = Tracklist["Trembling Dunes"];
            } //---------- //TZIMTZLUM //-----------
            else if (Z.DisplayName.Contains("Tzimtzlum"))
            {
                toPatch = "yes";
                Tracks = Tracklist["Tzimtzlum"];
            } //---------- //WATERLOGGED TUNNEL //-----------
            else if (Z.DisplayName.Contains("waterlogged tunnel"))
            {
                Tracks = Tracklist["Waterlogged Tunnel"];
            } //---------- //YD FREEHOLD //-----------
            else if (Z.DisplayName.Contains("Yd Freehold"))
            {
                Tracks = Tracklist["Yd Freehold"];
            } /*
            *****************************************************
            ********** RANDOM VILLAGES (EXCEPT GOATFOLK) ********
            *****************************************************/
            else if (Z.HasBuilder("Village") || Z.HasBuilder("VillageOutskirts"))
            {
                string villageFaction = Z.GetZoneProperty("faction");
                string region = Z.GetRegion();
                bool isAbandoned = IsAbandonedVillage(villageFaction);
                bool isStarting = IsStartingVillage(villageFaction);

                // ABANDONED STARTING VILLAGE (VERY RARE) //
                if (isStarting && isAbandoned)
                {
                    Tracks = Tracklist["Random Village_Abandoned starting village (very rare)"];
                } // ABANDONED VILLAGE //
                else if (isAbandoned)
                {
                    Tracks = Tracklist["Random Villages_Abandoned village"];
                } // STARTING VILLAGE //
                else if (isStarting)
                {
                    Tracks = Tracklist["Random Villages_Starting village"];
                } // DESERT CANYON VILLAGE //
                else if (region == "DesertCanyon")
                {
                    Tracks = Tracklist["Random Villages_Desert Canyon village"];
                } // SALT DUNES VILLAGE //
                else if (region == "Saltdunes")
                {
                    Tracks = Tracklist["Random Villages_Salt Desert village"];
                } // SALT MARSH VILLAGE //
                else if (region == "Saltmarsh")
                {
                    Tracks = Tracklist["Random Villages_Salt Marshes village"];
                } // HILLS VILLAGE //
                else if (region == "Hills")
                {
                    Tracks = Tracklist["Random Villages_Hills village"];
                } // RIVERS VILLAGE //
                else if (region == "Water")
                {
                    Tracks = Tracklist["Random Villages_Rivers village"];
                } // BANANA GROVE VILLAGE //
                else if (region == "BananaGrove")
                {
                    Tracks = Tracklist["Random Villages_Banana Grove village"];
                } // RAINBOW WOOD VILLAGE //
                else if (region == "Fungal")
                {
                    Tracks = Tracklist["Random Villages_Rainbow Woods village"];
                } // LAKE HINNOM VILLAGE
                else if (region == "LakeHinnom")
                {
                    Tracks = Tracklist["Random Villages_Lake Hinnom village"];
                } // PALLADIUM REEF VILLAGE //
                else if (region == "PalladiumReef")
                {
                    Tracks = Tracklist["Random Villages_Palladium Reef village"];
                } // MOUNTAINS VILLAGE //
                else if (region == "Mountains")
                {
                    Tracks = Tracklist["Random Villages_Mountains village"];
                } // FLOWER FIELDS VILLAGE //
                else if (region == "Flowerfields")
                {
                    Tracks = Tracklist["Random Villages_Flower Fields village"];
                } // JUNGLE VILLAGE //
                else if (region == "Jungle")
                {
                    Tracks = Tracklist["Random Villages_Jungle village"];
                } // DEEP JUNGLE VILLAGE //
                else if (region == "DeepJungle")
                {
                    Tracks = Tracklist["Random Villages_Deep Jungle village"];
                } // RUINS VILLAGE //
                else if (region == "Ruins")
                {
                    Tracks = Tracklist["Random Villages_Ruins village"];
                } // BAROQUE RUINS VILLAGE //
                else if (region == "BaroqueRuins")
                {
                    Tracks = Tracklist["Random Villages_Baroque Ruins village"];
                } // MOON STAIR VILLAGE //
                else if (region == "MoonStair")
                {
                    Tracks = Tracklist["Random Villages_Moon Stairs village"];
                }
            } /*
            *****************************************************
            ************** GOATFOLK VILLAGES & HAUNTS ***********
            *****************************************************

               // GOATFOLK VILLAGES //
            */
            else if (Z.HasBuilder("GoatfolkYurts"))
            {
                Tracks = Tracklist["Goatfolk Villages"];
            } // GOATFOLK HAUNTS //
            else if (Z.HasBuilder("GoatfolkQlippothYurts"))
            {
                Tracks = Tracklist["Goatfolk Haunts"];
            } // RAZED GOATFOLK VILLAGE //
            else if (
                Z.HasBuilder("RazedGoatfolkVillage") || Z.HasBuilder("MinorRazedGoatfolkVillage")
            )
            {
                Tracks = Tracklist["Razed Goatfolk Village"];
            } /*
            *****************************************************
            *********************** LAIRS ***********************
            *****************************************************
            */
            else if (Z.HasBuilder("BasicLair"))
            {
                string region = Z.GetRegion();

                if (Z.Z > 10)
                {
                    toPatch = "yes";
                }

                // LAIR MERCHANTS (Kitchen, workshop, etc) //
                if (!Z.DisplayName.Contains("lair"))
                {
                    Tracks = Tracklist["Lairs_Lair Merchants (workshops, kitchens, etc)"];
                } // TIER (0-)1: SALT MARSHES, DESERT CANYONS //
                else if (Z.NewTier <= 1)
                {
                    Tracks = Tracklist["Lairs_Tier (0-)1_Salt Marshes lairs"];
                } // TIER 2: SALT DESERTS, HILLS, FLOWER FIELDS //
                else if (Z.NewTier == 2)
                {
                    if (region == "Flowerfields")
                    {
                        Tracks = Tracklist["Lairs_Tier 2_Flower Fields lairs"];
                    }
                    else
                    {
                        Tracks = Tracklist["Lairs_Tier 2_Salt Deserts & Hills lairs"];
                    }
                } // TIERS 3-4: JUNGLES, RUINS, RIVERS, MOUNTAINS //
                else if (Z.NewTier <= 4)
                {
                    // RUINS
                    if (region == "Ruins")
                    {
                        Tracks = Tracklist["Lairs_Tier 3-4_Ruins lairs"];
                    } // JUNGLE
                    else if (region == "Jungle")
                    {
                        Tracks = Tracklist["Lairs_Tier 3-4_Jungle lairs"];
                    } // RIVERS
                    else if (region == "Water")
                    {
                        Tracks = Tracklist["Lairs_Tier 3-4_Rivers lairs"];
                    } // MOUNTAINS
                    else if (region == "Mountains")
                    {
                        Tracks = Tracklist["Lairs_Tier 3-4_Mountains lairs"];
                    }
                } // TIERS 5-6: RAINBOW WOODS, LAKE HINNOM, BANANA GROVE, DEEP JUNGLE //
                else if (Z.NewTier <= 6)
                {
                    // RAINBOW WOODS
                    if (region == "Fungal")
                    {
                        Tracks = Tracklist["Lairs_Tier 5-6_Rainbow Woods lairs"];
                    } // LAKE HINNOM
                    else if (region == "LakeHinnom")
                    {
                        Tracks = Tracklist["Lairs_Tier 5-6_Lake Hinnom lairs"];
                    } // BANANA GROVE & DEEP JUNGLE
                    else if (region == "BananaGrove" || region == "DeepJungle")
                    {
                        Tracks = Tracklist["Lairs_Tier 5-6_Banana Grove lairs"];
                    }
                } // TIER 7: PALLADIUM REEF, BAROQUE RUINS (BOTH ARE RARE)
                else if (Z.NewTier == 7)
                {
                    // PALLADIUM REEF
                    if (region == "PalladiumReef")
                    {
                        Tracks = Tracklist["Lairs_Tier 7_Paladium Reef lairs"];
                    }
                    else if (region == "BaroqueRuins")
                    {
                        Tracks = Tracklist["Lairs_Tier 7_Baroque Ruins lairs"];
                    }
                } // TIER 8: MOON STAIR
                else if (Z.NewTier == 8)
                {
                    Tracks = Tracklist["Lairs_Tier 8_Moon Stair lairs"];
                }
            } // THE LAIR OF OBOROQORU, LEGENDARY APE GOD
            else if (Z.HasBuilder("ApegodCave"))
            {
                toPatch = "yes";

                // Strata 1-5
                if (Z.Z <= 15)
                {
                    Tracks = Tracklist["Lairs_The Lair of Oboroqoru, Legendary Ape God_1-5"];
                } // Strata 6-8
                else if (Z.Z <= 18)
                {
                    Tracks = Tracklist["Lairs_The Lair of Oboroqoru, Legendary Ape God_6-8"];
                } // Strata 9: Oboroqoru's floor
                else if (Z.Z == 19)
                {
                    Tracks = Tracklist[
                        "Lairs_The Lair of Oboroqoru, Legendary Ape God_9_Oboroqoru's Floor"
                    ];
                }
            } /*
            *****************************************************
            ******************* OVERLAND RUINS ******************
            *****************************************************
            */
            else if (Z.HasBuilder("OverlandRuins"))
            {
                string region = Z.GetRegion();

                // TIER (0-)1: SALT MARSHES, DESERT CANYONS //
                if (Z.NewTier <= 1)
                {
                    if (region == "Saltmarsh")
                    {
                        Tracks = Tracklist["Overland Ruins_Tier (0-)1_Salt Marshes ruins"];
                    }
                    else if (region == "DesertCanyon")
                    {
                        Tracks = Tracklist["Overland Ruins_Tier (0-)1_Desert Canyon ruins"];
                    }
                    else
                    {
                        Tracks = Tracklist[
                            "Overland Ruins_Tier (0-)1_Fallback (most likely never used)"
                        ];
                    }
                } // TIER 2: SALT DESERTS, HILLS, FLOWER FIELDS //
                else if (Z.NewTier == 2)
                {
                    if (region == "Flowerfields")
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 2_Flower Fields ruins"];
                    }
                    else
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 2_Hills & Salt Desert ruins"];
                    }
                } // TIERS 3-4: JUNGLES, RUINS, RIVERS, MOUNTAINS //
                else if (Z.NewTier <= 4)
                {
                    if (region == "Jungle" || region == "Ruins")
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 3-4_Jungle ruins"];
                    } // Rivers
                    else if (region == "Water")
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 3-4_Rivers ruins"];
                    }
                    else
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 3-4_Mountains ruins"];
                    }
                } // TIERS 5-6: RAINBOW WOODS, LAKE HINNOM, DEEP JUNGLE, BANANA GROVE //
                else if (Z.NewTier <= 6)
                {
                    if (region == "LakeHinnom" || region == "Fungal")
                    {
                        Tracks = Tracklist[
                            "Overland Ruins_Tier 5-6_Rainbow Woods & Lake Hinnom ruins"
                        ];
                    }
                    else
                    {
                        Tracks = Tracklist[
                            "Overland Ruins_Tier 5-6_Deep Jungle & Banana Grove ruins"
                        ];
                    }
                } // TIER 7: PALLADIUM REEF, BAROQUE RUINS
                else if (Z.NewTier == 7)
                {
                    if (region == "PalladiumReef")
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 7_Palladium Reef ruins"];
                    }
                    else
                    {
                        Tracks = Tracklist["Overland Ruins_Tier 7_Baroque Ruins ruins"];
                    }
                } // TIER 8: MOON STAIR
                else if (Z.NewTier == 8)
                {
                    Tracks = Tracklist["Overland Ruins_Tier 7_Moon Stair ruins"];
                }
            } /*
            *****************************************************
            ******************* HISTORIC SITES ******************
            *****************************************************
            */
            else if (Z.HasBuilder("SultanDungeon"))
            {
                string region = Z.GetRegion();

                // FIFTH PERIOD, TIERS 0-1: SALT MARSHES, DESERT CANYONS //
                if (Z.NewTier <= 1)
                {
                    Tracks = Tracklist[
                        "Historic Sites_5th Period, Tier 1_Salt Marshes & Desert Canyon historic sites"
                    ];
                } // FIFTH PERIOD, TIER 2: SALT DESERTS, HILLS, FLOWER FIELDS //
                else if (Z.NewTier == 2)
                {
                    // FLOWER FIELDS
                    if (region == "Flowerfields")
                    {
                        Tracks = Tracklist[
                            "Historic Sites_5th Period, Tier 2_Flower Fields historic sites"
                        ];
                    }
                    // SALT DESERTS, HILLS
                    else
                    {
                        Tracks = Tracklist[
                            "Historic Sites_5th Period, Tier 2_Salt Desert & Hills historic sites"
                        ];
                    }
                } // FOURTH PERIOD, TIERS 3-4: JUNGLES, RUINS, RIVERS, MOUNTAINS //
                else if (Z.NewTier <= 4)
                {
                    // JUNGLE - Guaranteed (tier 3)
                    if (Z.NewTier == 3)
                    {
                        Tracks = Tracklist[
                            "Historic Sites_4th Period, Tiers 3-4_Jungle historic sites (guaranteed)"
                        ];
                    }
                    // MOUNTAINS
                    else if (region == "Mountains")
                    {
                        Tracks = Tracklist[
                            "Historic Sites_4th Period, Tiers 3-4_Mountains historic sites"
                        ];
                    }
                    // RUINS
                    else if (region == "Ruins")
                    {
                        Tracks = Tracklist[
                            "Historic Sites_4th Period, Tiers 3-4_Ruins historic sites"
                        ];
                    }
                    // RIVERS
                    else
                    {
                        Tracks = Tracklist[
                            "Historic Sites_4th Period, Tiers 3-4_Rivers historic sites"
                        ];
                    }
                } // THIRD PERIOD, TIERS 5-6: RAINBOW WOOD
                else if (Z.NewTier <= 6 && (region == "Fungal"))
                {
                    Tracks = Tracklist[
                        "Historic Sites_3rd Period, Tiers 5-6_Rainbow Woods historic sites"
                    ];
                } // THIRD PERIOD, TIERS 5-6: LAKE HINNOM
                else if (Z.NewTier <= 6 && (region == "LakeHinnom"))
                {
                    Tracks = Tracklist[
                        "Historic Sites_3rd Period, Tiers 5-6_Lake Hinnom historic sites"
                    ];
                } // THIRD PERIOD, TIERS 5-6: BANANA GROVE, DEEP JUNGLE
                else if (Z.NewTier <= 6)
                {
                    // BANANA GROVE
                    if (region == "BananaGrove")
                    {
                        Tracks = Tracklist[
                            "Historic Sites_3rd Period, Tiers 5-6_Banana Grove historic sites"
                        ];
                    } // DEEP JUNGLE
                    else if (region == "DeepJungle")
                    {
                        Tracks = Tracklist[
                            "Historic Sites_3rd Period, Tiers 5-6_Deep Jungle historic sites"
                        ];
                    }
                } // SECOND PERIOD, TIER 7: BAROQUE RUINS
                else if (Z.NewTier == 7 && region == "BaroqueRuins")
                {
                    Tracks = Tracklist[
                        "Historic Sites_2nd Period, Tier 7_Baroque Ruins historic sites"
                    ];
                } // SECOND PERIOD, TIER 7: PALLADIUM REEF
                else if (Z.NewTier == 7)
                {
                    Tracks = Tracklist[
                        "Historic Sites_2nd Period, Tier 7_Palladium Reef historic sites"
                    ];
                } // FIRST PERIOD, TIER 8: MOON STAIR
                else if (Z.NewTier == 8)
                {
                    Tracks = Tracklist[
                        "Historic Sites_1st Period, Tier 8_Moon Stair historic sites"
                    ];
                }
            } /*
            *****************************************************
            ******************* WORLD MAP TERRAIN ***************
            *****************************************************
            */

            if (Tracks == null && Z.Z <= 15)
            {
                string region = Z.GetRegion();

                // BANANA GROVE
                if (region == "BananaGrove" || Z.DisplayName.Contains("banana grove"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Banana Grove terrain_0"];
                    } // Subterranean Banana Grove
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Banana Grove terrain_Subterranean"];
                    }
                } // BAROQUE RUINS
                else if (region == "BaroqueRuins" || Z.DisplayName.Contains("baroque ruins"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Baroque Ruins terrain_0"];
                    } // Subterranean Baroque Ruins
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Baroque Ruins terrain_Subterranean"];
                    }
                } // DEEP JUNGLE
                else if (region == "DeepJungle" || Z.DisplayName.Contains("deep jungle"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Deep Jungle terrain_0"];
                    } // Subterranean Deep Jungle
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Deep Jungle terrain_Subterranean"];
                    }
                } // DESERT CANYON
                else if (region == "DesertCanyon" || Z.DisplayName.Contains("desert canyon"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Desert Canyon terrain_0"];
                    } // Subterranean Desert Canyon
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Desert Canyon terrain_Subterranean"];
                    }
                } // FLOWER FIELDS
                else if (region == "Flowerfields" || Z.DisplayName.Contains("flower fields"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Flower Fields terrain_0"];
                    } // Subterranean Flower Fields
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Flower Fields terrain_Subterranean"];
                    }
                } // HILLS
                else if (region == "Hills" || Z.DisplayName.Contains("hills"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Hills terrain_0"];
                    } // Subterranean Hills
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Hills terrain_Subterranean"];
                    }
                } // JUNGLE
                else if (region == "Jungle" || Z.DisplayName.Contains("jungle"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Jungle terrain_0"];
                    } // Subterranean Jungle
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Jungle terrain_Subterranean"];
                    }
                } // LAKE HINNOM
                else if (region == "LakeHinnom" || Z.DisplayName.Contains("Hinnom"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Lake Hinnom terrain_0"];
                    } // Subterranean Lake Hinnom
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Lake Hinnom terrain_Subterranean"];
                    }
                } // MOON STAIR
                else if (region == "MoonStair" || Z.DisplayName.Contains("Stair"))
                {
                    // Roaming Keter of Chavah, the Tree of Life
                    if (Z.Z < 10)
                    {
                        toPatch = "yes";

                        Tracks = Tracklist[
                            "World Map terrain_Moon Stair terrain_Roaming Keter of Chavah, the Tree of Life"
                        ];
                    } // Surface
                    else if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Moon Stair terrain_0"];
                    } // Subterranean stair
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Moon Stair terrain_Subterranean"];
                    }
                } // MOUNTAINS
                else if (region == "Mountains" || Z.DisplayName.Contains("mountains"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Mountains terrain_0"];
                    } // Subterranean Mountains
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Mountains terrain_Subterranean"];
                    }
                } // PALLADIUM REEF
                else if (region == "PalladiumReef" || Z.DisplayName.Contains("Reef"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Palladium Reef terrain_0"];
                    } // Subterranean reef
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Palladium Reef terrain_Subterranean"];
                    }
                } // RAINBOW WOOD
                else if (region == "Fungal" || Z.DisplayName.Contains("Rainbow Wood"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Rainbow Woods terrain_0"];
                    } // Subterranean Rainbow Wood
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Rainbow Woods terrain_Subterranean"];
                    }
                } // RIVERS
                else if (region == "Water" || Z.DisplayName.Contains("river"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Rivers terrain_0"];
                    } // Subterranean rivers
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Rivers terrain_Subterranean"];
                    }
                } // RUINS
                else if (region == "Ruins" || Z.DisplayName.Contains("ruins"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Ruins terrain_0"];
                    } // Subterranean Ruins
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Ruins terrain_Subterranean"];
                    }
                } // SALT DESERTS
                else if (region == "Saltdunes" || Z.DisplayName.Contains("salt desert"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Salt Desert terrain_0"];
                    } // Subterranean desert
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Salt Desert terrain_Subterranean"];
                    }
                } // SALT MARSH
                else if (region == "Saltmarsh" || Z.DisplayName.Contains("salt marsh"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks = Tracklist["World Map terrain_Salt Marshes terrain_0"];
                    } // Subterranean marsh
                    else
                    {
                        Tracks = Tracklist["World Map terrain_Salt Marshes terrain_Subterranean"];
                    }
                }
            } /*
            *****************************************************
            ********************* UNDERGROUND *******************
            *****************************************************
            */
            else if (Tracks == null && Z.Z >= 16)
            {
                // Tier 2 (Formula starts at 2)
                if (Z.NewTier == 2)
                {
                    Tracks = Tracklist["Underground_Tier 2 (formula starts at 2)"];
                } // Tier 3
                else if (Z.NewTier == 3)
                {
                    Tracks = Tracklist["Underground_Tier 3"];
                } // Tier 4
                else if (Z.NewTier == 4)
                {
                    Tracks = Tracklist["Underground_Tier 4"];
                } // Tier 5
                else if (Z.NewTier == 5)
                {
                    Tracks = Tracklist["Underground_Tier 5"];
                } // Tier 6
                else if (Z.NewTier == 6)
                {
                    Tracks = Tracklist["Underground_Tier 6"];
                } // Tier 7
                else if (Z.NewTier == 7)
                {
                    Tracks = Tracklist["Underground_Tier 7"];
                } // Tier 8
                else if (Z.NewTier == 8)
                {
                    Tracks = Tracklist["Underground_Tier 8"];
                }
            }
        }

        /*
        --<------------- END OF WHERE YOU EDIT --------<----- */
        // public static void Reset()
        // {
        //     previousZone = null;
        //     previousTime = DateTime.Now.AddSeconds(tracksMinSeconds);
        // }

        public static bool IsStartingVillage(string villageFaction)
        {
            HistoricEntitySnapshot villageSnapshot;
            bool IsStartingVillage;

            villageSnapshot = Qud.API.HistoryAPI.GetVillageSnapshot(villageFaction);

            if (villageSnapshot == null)
            {
                return false;
            }

            IsStartingVillage = villageSnapshot
                .GetProperty("isVillageZero", "false")
                .EqualsNoCase("true");

            return IsStartingVillage;
        }

        public static bool IsAbandonedVillage(string villageFaction)
        {
            HistoricEntitySnapshot villageSnapshot;

            villageSnapshot = Qud.API.HistoryAPI.GetVillageSnapshot(villageFaction);

            if (villageSnapshot == null)
            {
                return false;
            }

            if (villageSnapshot.GetProperty("abandoned") == "true")
            {
                return true;
            }
            return false;
        }

        public bool ShouldPatchTrackIn(Zone Z)
        {
            SetTrackListFor(Z);

            if (toPatch != "")
            {
                return true;
            }

            return false;
        }

        public string[] GetTrackIn(Zone Z)
        {
            int index;
            string[] trackData;
            string trackToPlay;
            string currentZone = Z.ReferenceDisplayName;

            if (Tracks == null)
            {
                previousTrack = "default";
                previousZone = currentZone;
                previousZ = Z.Z;
                previousTime = DateTime.Now;
                isSameTrack = null;
                return null;
            }

            index = Custom_Soundtrack_Random.Next(0, Tracks.Count - 1);
            trackToPlay = Tracks[index];

            /* Remove zone modifiers from the string for an accurate
            compare of ReferenceDisplayName */
            string[] zoneModifiers =
            {
                "slimy",
                "slime-drenched",
                "tarry",
                "rusty",
                "rust-shrouded",
                "subterranean",
                "outskirts"
            };
            foreach (string modifier in zoneModifiers)
            {
                currentZone = currentZone.Replace(modifier, String.Empty);
            }

            /* Support for Psychic Biomes, that add modifiers tied
            to mental mutations (check XRL.World.Biomes.PsychicBiome) */
            if (
                Z.GetRegion() == "MoonStair"
                || Z.DisplayName.Contains("Stair")
                || Z.DisplayName == "Eyn Roj"
                || Z.DisplayName.Contains("crystalline roots")
            )
            {
                List<string> psychicBiomeModifiers = PsychicBiomeMods.psychicBiomeModifiers;

                foreach (string modifier in psychicBiomeModifiers)
                {
                    currentZone = currentZone.Replace(modifier, String.Empty);
                }
            }

            currentZone = currentZone.Trim(' ');

            /*
            If a track have been playing for less than tracksMinSeconds
            seconds, save it and continue playing it. Also we only want to
            save it when the character stays on the same location. If
            character goes to another location, clear the previous Track.
            */
            if (previousZone != null)
            {
                DateTime currentTime = DateTime.Now;
                TimeSpan timeInterval = currentTime - previousTime;

                if (timeSincePrevious == TimeSpan.Zero)
                {
                    maxTime = previousTime.AddSeconds(tracksMinSeconds);
                }
                timeSincePrevious += timeInterval;

                int zSubstrLen = currentZone.Length > 5 ? 5 : currentZone.Length;
                int prevSubstrLen = previousZone.Length > 5 ? 5 : previousZone.Length;

                string formattedPrevZone = previousZone.Substring(0, prevSubstrLen);
                string formattedCurZone = currentZone.Substring(0, zSubstrLen);

                // Switched zones : change track
                if (formattedPrevZone != formattedCurZone)
                {
                    previousTrack = "";
                    timeSincePrevious = TimeSpan.Zero;
                    isSameTrack = null;
                }
                // Times up, or in village outskirts: keep playing track
                else if (
                    (currentTime < maxTime || Z.HasBuilder("VillageOutskirts"))
                    && Tracks.Contains(previousTrack)
                )
                {
                    trackToPlay = previousTrack;
                    isSameTrack = "yes";
                }
                else
                {
                    if (trackToPlay != previousTrack)
                    {
                        timeSincePrevious = TimeSpan.Zero;
                        isSameTrack = null;
                    }
                    else
                    {
                        isSameTrack = "yes";
                    }
                }
            }

            // XRL.Messages.MessageQueue.AddPlayerMessage (currentZone);
            /*
            ** UNCOMMENT FOUR LINES BELOW IF YOU WANT TO DISPLAY TRACK
            *  NAMES
                (remove the slashes, start at the if, not the line before)
            */
            // if (trackToPlay != previousTrack)
            // {
            // XRL.Messages.MessageQueue.AddPlayerMessage (trackToPlay);
            // }
            trackData = new string[] { trackToPlay, isSameTrack };
            previousTrack = trackToPlay;
            previousZone = currentZone;
            previousZ = Z.Z;
            previousTime = DateTime.Now;
            return trackData;
        }
    }

    [HarmonyPatch]
    public class SaveMenuReset
    {
        /*
          Prevents Continue from keeping main menu music playing by removing
          cached previous Zone on save
        */
        [HarmonyPatch(typeof(XRLGame), nameof(XRLGame.SaveGame))]
        static bool Prefix()
        {
            TrackManager.previousZone = null;
            return true;
        }
    }
}
