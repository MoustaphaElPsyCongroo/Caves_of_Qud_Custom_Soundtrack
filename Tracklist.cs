using System;
using System.Collections.Generic;
using System.Linq;
using Custom_Soundtrack.Utilities;
using HistoryKit;
using XRL;
using XRL.World;

namespace Custom_Soundtrack.ManageTracks
{
    public class TrackList
    {
        public string[] Tracks = null;

        private string toPatch = "";

        private static string previousTrack = null;

        private static string previousZone = null;

        private static int previousZ;

        private static DateTime previousTime;

        private static TimeSpan timeSincePrevious;

        private static DateTime maxTime;

        public double tracksMinSeconds = 150;

        private string isSameTrack = null;

        private void setTrackListFor(Zone Z)
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
                    Tracks =
                        new string[] {
                            "AsphaltMines_BindingOfIsaacRepentance_Fissure"
                        };
                } //Ancient Bones
                else if (Z.Z == 15)
                {
                    Tracks =
                        new string[] {
                            "AsphaltMines_PMDBRT_MtBlazePeakRemastered"
                        };
                } //Middle Shafts
                else if (Z.Z <= 18)
                {
                    Tracks =
                        new string[] { "AsphaltMines_PMDBRT_MtBlazeRemix" };
                } //Deep Shafts
                else if (Z.Z <= 22)
                {
                    Tracks =
                        new string[] { "AsphaltMines_PMDRRT_MagmaCavern" };
                } //Darkunder
                else if (Z.Z <= 28)
                {
                    Tracks =
                        new string[] {
                            "AsphaltMines_PMDSky_SpringCaveDepths"
                        };
                } //Great Sea
                else if (Z.Z == 29)
                {
                    Tracks =
                        new string[] {
                            "AsphaltMines_PMDRRT_MtBlazePeakRemastered"
                        };
                } //Tunnels of Ur & Swilling Vast
                else if (Z.Z <= 40)
                {
                    Tracks =
                        new string[] {
                            "AsphaltMines_BindingOfIsaacAntibirth_Flashpoint_BBasement",
                            "AsphaltMines_ChocoboEB_GuardianDarkness",
                            "AsphaltMines_BindingOfIsaacAntibirth_Flashpoint_BBasement",
                            "AsphaltMines_ChocoboEB_GuardianDarkness",
                            "AsphaltMines_PMDBRT_MagmaCavernPitRemix"
                        };
                }
            } //---------- //BARATHRUM'S STUDY & GRIT GATE //-----------
            else if (Z.DisplayName.Contains("Grit Gate") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks =
                        new string[] {
                            "GritGate_PSMD_RevelationMountainPart1"
                        };
                } //Lower Tunnels
                else if (Z.Z <= 12)
                {
                    Tracks =
                        new string[] {
                            "GritGate_CastlevaniaCOD_EneomaosMachineTower"
                        };
                } //Grit Gate Entrance
                else if (Z.Z == 13)
                {
                    Tracks =
                        new string[] {
                            "GritGate_PMDSky_TemporalSpire",
                            "GritGate_PMDSky_TemporalSpire",
                            "default"
                        };
                } //Barathrum's Study
                else if (Z.Z == 14)
                {
                    Tracks =
                        new string[] {
                            "GritGate_PokemonDPP_ProfRowanLaboratory"
                        };
                }
            } //---------- //BETHESDA SUSA //-----------
            else if (Z.DisplayName.Contains("Bethesda Susa") && Z.Z <= 26)
            {
                //Surface & Ruined Wharf
                if (Z.Z <= 11)
                {
                    Tracks =
                        new string[] {
                            "BethesdaSusa_PMDGTI_GreatGlacierWesternSpire"
                        };
                } //Healing Pools 1: Jotun, Who Parts Limbs
                else if (Z.Z == 12)
                {
                    Tracks =
                        new string[] { "BethesdaSusa_PokemonRSE_EliteFour" };
                } //Healing Pools 2: Fjorn-Josef, Who Knits The Icy Lattice
                else if (Z.Z == 13)
                {
                    Tracks =
                        new string[] {
                            "BethesdaSusa_Tangledeep_BanditBattle"
                        };
                } //Healing Pools 3: Haggabah, Who Plies The Umbral Path
                else if (Z.Z == 14)
                {
                    Tracks =
                        new string[] {
                            "BethesdaSusa_DivinityOS2_TheBattleForDivinity"
                        };
                } //Abandoned Ward 1
                else if (Z.Z == 15)
                {
                    Tracks = new string[] { "default" };
                } //Ruined Ward
                else if (Z.Z <= 20)
                {
                    Tracks =
                        new string[] {
                            "BethesdaSusa_PMDSky_BlizzardIsland",
                            "BethesdaSusa_PMDSky_VastIceMountainPeak",
                            "BethesdaSusa_PMDGTI_GreatGlacierCrystalTower",
                            "default"
                        };
                } //Abandoned Ward 2
                else if (Z.Z <= 22)
                {
                    Tracks =
                        new string[] { "BethesdaSusa_PSMD_TreeofLifeTrunk" };
                } //Cybernetics Ward
                else if (Z.Z == 23)
                {
                    Tracks =
                        new string[] {
                            "BethesdaSusa_PMDSky_SkyPeakSnowfield"
                        };
                } //Cryobarrios
                else if (Z.Z <= 25)
                {
                    Tracks =
                        new string[] { "BethesdaSusa_PMDBRT_FrostyGrotto" };
                } //Temple of the Rock
                else if (Z.Z == 26)
                {
                    Tracks =
                        new string[] {
                            "BethesdaSusa_PMDGTI_GreatGlacierWesternSpire",
                            "default"
                        };
                }
            } //---------- //BEY LAH //-----------
            else if (Z.DisplayName.Contains("Bey Lah"))
            {
                Tracks =
                    new string[] {
                        "BeyLah_WildARMs_APersonsWarmth",
                        "BeyLah_ShirenMD2_BambooVillage",
                        "BeyLah_WildARMsAF_VillageoftheElw"
                    };
            } //---------- //CHARRED TREE //-----------
            else if (
                Z.DisplayName.Contains("charred tree") ||
                Z.HasBuilder("ClearAll") && (Z.NewTier <= 4)
            )
            {
                Tracks =
                    new string[] {
                        "CharredTree_PMDRRT_RunAwayFugitives",
                        "CharredTree_PMDBRT_PartingFarewell",
                        "CharredTree_PMDSky_Réminiscences"
                    };
            } //---------- //EYN ROJ and CRYSTALLINE ROOTS //-----------
            else if (
                Z.Z <= 50 &&
                (
                Z.DisplayName == "Eyn Roj" ||
                Z.DisplayName.Contains("crystalline roots")
                )
            )
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = new string[] { "EynRoj_PSMD_WitheredTreeOfLife" };
                } //Strata 1-4, before intermediate stairs
                else if (Z.Z <= 14)
                {
                    Tracks = new string[] { "EynRoj_PSMD_TreeOfLifeRoots" };
                } //Intermediate stairs 1: strata 5, 10, 15, 20
                else if (Z.Z <= 30 && Z.Z % 5 == 0)
                {
                    Tracks = new string[] { "default" };
                } //Strata 6-9
                else if (Z.Z <= 19)
                {
                    //6-7
                    if (Z.Z <= 17)
                    {
                        Tracks = new string[] { "EynRoj_PMDBRT_SkyTower" };
                    } //8-9
                    else
                    {
                        Tracks =
                            new string[] {
                                "EynRoj_PMDBRT_SkyTower",
                                "EynRoj_PMDRRT_SkyTower"
                            };
                    }
                } //Strata 11-14
                else if (Z.Z <= 24)
                {
                    Tracks = new string[] { "EynRoj_PMDSky_TemporalTower" };
                } //Strata 16-19
                else if (Z.Z <= 29)
                {
                    Tracks =
                        new string[] { "EynRoj_PMDBRT_SkyTowerRemastered" };
                } //Strata 21-24
                else if (Z.Z <= 34)
                {
                    Tracks =
                        new string[] {
                            "EynRoj_PMDSky_TemporalTowerRemastered"
                        };
                } //Intermediate stairs 2: strata 25, 30, 35, 40
                else if (Z.Z <= 50 && Z.Z % 5 == 0)
                {
                    //Stratum 25
                    if (Z.Z == 35)
                    {
                        Tracks =
                            new string[] {
                                "EynRoj_PokemonBDSP_PokémonLeagueNight"
                            };
                    } //Stratum 30
                    else if (Z.Z == 40)
                    {
                        Tracks =
                            new string[] { "EynRoj_PMDSky_HaveToGetHome" };
                    } //Stratum 35
                    else if (Z.Z == 45)
                    {
                        Tracks =
                            new string[] { "EynRoj_PMDSky_DontEverForget" };
                    } //Stratum 40 - last floor
                    else if (Z.Z == 50)
                    {
                        Tracks =
                            new string[] {
                                "EynRoj_PMDSky_DialgasFightToTheFinish"
                            };
                    }
                } //Strata 26-29
                else if (Z.Z <= 39)
                {
                    //36-37
                    if (Z.Z <= 37)
                    {
                        Tracks =
                            new string[] { "EynRoj_PMDBRT_SkyTowerSummit" };
                    } //38-39
                    else
                    {
                        Tracks =
                            new string[] {
                                "EynRoj_PMDBRT_SkyTowerSummit",
                                "EynRoj_PMDBRT_SkyTowerSummitRemastered"
                            };
                    }
                } //Strata 31-34
                else if (Z.Z <= 44)
                {
                    Tracks =
                        new string[] {
                            "EynRoj_PMDSky_TemporalSpireRemastered"
                        };
                } //Strata 36-39
                else if (Z.Z <= 49)
                {
                    Tracks =
                        new string[] {
                            "EynRoj_NieRAutomata_TheWeightOfTheWorld_End"
                        };
                }
            } //---------- //EZRA //-----------
            else if (Z.DisplayName == "Ezra")
            {
                Tracks =
                    new string[] { "Ezra_ShirenMD5_KeidaiNight", "default" };
            } //---------- //GOLGOTHA //-----------
            else if (Z.DisplayName.Contains("Golgotha") && Z.Z <= 15)
            {
                //Surface & Trash Chutes 1
                if (Z.Z <= 11)
                {
                    Tracks =
                        new string[] {
                            "Golgotha_BindingOfIsaacRepentance_NightSoil_Dross"
                        };
                } //Trash Chutes 2 - 4
                else if (Z.Z <= 14)
                {
                    Tracks =
                        new string[] {
                            "Golgotha_BindingOfIsaacRepentance_NightSoil_Dross",
                            "Golgotha_BindingOfIsaacAntibirth_HallowedGround_Downpour"
                        };
                } //Cloaca
                else if (Z.Z == 15)
                {
                    Tracks =
                        new string[] {
                            "Golgotha_DivinityOS2_QuirkyBones_Slow"
                        };
                }
            } //---------- //GYL //-----------
            else if (Z.DisplayName.Contains("Gyl"))
            {
                Tracks = new string[] { "Gyl_DivinityOS2_Rivellon" };
            } //---------- //JOPPA //-----------
            else if (Z.DisplayName.Contains("Joppa"))
            {
                Tracks =
                    new string[] {
                        "Joppa_Haffner_Dom",
                        "default",
                        "Joppa_Haffner_Dom"
                    };
            } //---------- //RUINS OF JOPPA / ABANDONED JOPPA //-----------
            else if (
                Z.DisplayName.Contains("ruins of Joppa") ||
                Z.DisplayName.Contains("abandoned village")
            )
            {
                Tracks =
                    new string[] { "Joppa_Ruins_WildARMs_AloneInTheWorld" };
            } //---------- //KYAKUKYA //-----------
            else if (Z.DisplayName.Contains("Kyakukya"))
            {
                Tracks =
                    new string[] {
                        "Kyakukya_WildARMs_Town",
                        "Kyakukya_WildARMs_ToTheEndWilderness"
                    };
            } //---------- //OMONPORCH //-----------
            else if (Z.DisplayName.Contains("Omonporch"))
            {
                //Court of the Sultans
                if (Z.DisplayName.Contains("Court"))
                {
                    Tracks =
                        new string[] {
                            "Omonporch_DivinityOS2_SanctuaryOfAmadia"
                        };
                } //Twin Gates
                else if (Z.DisplayName.Contains("Twin Gates"))
                {
                    Tracks =
                        new string[] { "Omonporch_DivinityOS2_ArxSquareAlt2" };
                } //"Outskirts"
            } //---------- //RED ROCK //-----------
            else if (Z.DisplayName.Contains("Red Rock") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks = new string[] { "RedRock_ShirenMD2_OldMine" };
                } //Stratum 1
                else if (Z.Z == 11)
                {
                    Tracks =
                        new string[] {
                            "RedRock_ShirenMD1SNES_CavernInTheCliff"
                        };
                } //Stratum 2
                else if (Z.Z == 12)
                {
                    Tracks =
                        new string[] { "RedRock_ShirenMD2_TableMountain1" };
                } //Stratum 3
                else if (Z.Z == 13)
                {
                    Tracks =
                        new string[] {
                            "RedRock_ShirenMD1SNES_TableMountain3"
                        };
                } //Stratum 4
                else if (Z.Z == 14)
                {
                    Tracks =
                        new string[] {
                            "RedRock_ShirenMD1SNES_WaterfallCavern"
                        };
                }
            } //---------- //RUST WELLS //-----------
            else if (Z.DisplayName.Contains("Rustwell") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks =
                        new string[] { "RustWells_ShirenMD1DS_TaintedPath" };
                }
                else
                //Stratum 1 - 4
                {
                    Tracks =
                        new string[] {
                            "RustWells_ShirenMD1DS_TaintedPath",
                            "RustWells_PMDGTI_IllusoryHazyPass",
                            "RustWells_PMDGTI_WithinTheCragsOfLament"
                        };
                }
            } //---------- //RUSTED ARCHWAY //-----------
            else if (Z.DisplayName.Contains("rusted archway") && Z.Z <= 14)
            {
                //Surface
                if (Z.Z == 10)
                {
                    Tracks =
                        new string[] {
                            "RustedArchway_FinalFantasy10HD_Sprouting"
                        };
                } //Stratum 1-2
                else if (Z.Z <= 12)
                {
                    Tracks =
                        new string[] {
                            "RustedArchway_FinalFantasy10HD_Sprouting",
                            "RustedArchway_PokemonBW_Route10"
                        };
                } //Stratum 3
                else if (Z.Z == 13)
                {
                    Tracks =
                        new string[] {
                            "RustedArchway_PokemonHgSs_Route26-27"
                        };
                } //Stratum 4
                else if (Z.Z == 14)
                {
                    Tracks =
                        new string[] { "RustedArchway_Reborn_Succession" };
                }
            } //---------- //STILTGROUNDS //-----------
            else if (Z.DisplayName.Contains("Stiltgrounds"))
            {
                toPatch = "yes";
                Tracks =
                    new string[] {
                        "Stiltgrounds_BindingOfIsaacRebirth_EverlastingHymn",
                        "Stiltgrounds_BindingOfIsaacWrathOfTheLamb_LamentOfTheAngel",
                        "Stiltgrounds_BindingOfIsaacRebirth_EverlastingHymn",
                        "Stiltgrounds_BindingOfIsaacAntibirth_TheThief"
                    };
            } //---------- //SIX DAY STILT //-----------
            else if (Z.DisplayName.Contains("Six Day Stilt"))
            {
                Tracks =
                    new string[] {
                        "SixDayStilt_DivinityOS2_Temple",
                        "SixDayStilt_Elona_ShrineOfGuardian"
                    };
            } //---------- //THE HYDROPON //-----------
            else if (Z.DisplayName.Contains("The Hydropon")) ||
                Z.HasBuilder("ClearAll") && (Z.NewTier >= 6)
            {
                Tracks =
                    new string[] {
                        "TheHydropon_DivinityOS2_FinalDepartureEnding"
                    };
            } //---------- //TOMB OF THE EATERS / SPINDLE CHANNEL //-----------
            else if (
                Z.DisplayName.Contains("Tomb of the Eaters") ||
                (Z.DisplayName.Contains("banana grove") && Z.Z == 11) ||
                (Z.DisplayName.Contains("Spindle Channel"))
            )
            {
                // Liminal Ways
                if (Z.DisplayName.Contains("Liminal Way"))
                {
                    Tracks =
                        new string[] {
                            "TombOfTheEaters_WildARMs_KishumFlame"
                        };
                }
                else if (Z.DisplayName.Contains("Spindle Channel"))
                {
                    Tracks =
                        new string[] { "TombOfTheEaters_ZeldaNes_Opening" };
                } //Surface - Grand Vestibule and access corridors
                else if (Z.Z == 10)
                {
                    //Grand Vestibule
                    if (Z.DisplayName.Contains("Grand Vestibule"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_ShirenMD5_TowerMiracleKiseki2",
                                "TombOfTheEaters_PSMD_RevelationMountainOrchestral"
                            };
                    } //Access corridors, structural ribs
                    else if (Z.DisplayName.Contains("access corridor"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_DivinityOS2_QuirkyBones"
                            };
                    }
                } //Stratum 1 - Folk Catacombs, Banana grove passage to the tomb
                else if (Z.Z == 11)
                {
                    if (Z.DisplayName.Contains("banana grove"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_WildARMs_KishumFlame"
                            };
                    }
                    else if (Z.DisplayName.Contains("Folk Catacombs"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_PMDSky_SteamCave",
                                "default"
                            };
                    }
                } //Above level 1 - Crematory and Columbarium
                else if (Z.Z == 9)
                {
                    if (Z.DisplayName.Contains("Crematory"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_BindingOfIsaacAntibirth_MachineInTheWalls",
                                "TombOfTheEaters_CastlevaniaDawnofSorrow_LePinacle"
                            };
                    }
                    else if (Z.DisplayName.Contains("Columbarium"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_PMDSky_SealedRuin"
                            };
                    }
                } //Above level 2 - Lower Crypts: Warriors and Tutors
                else if (Z.Z == 8)
                {
                    if (Z.DisplayName.Contains("Lower Crypts"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_CastlevaniaDawnOfSorrow_CondemnedTower"
                            };
                    }
                } //Above level 3 - Upper Crypts: Priests and Royal families
                else if (Z.Z == 7)
                {
                    if (Z.DisplayName.Contains("Upper Crypts"))
                    {
                        Tracks =
                            new string[] {
                                "TombOfTheEaters_Albinioni_AdagioInGMinor",
                                "TombOfTheEaters_Albinioni_AdagioInGMinor",
                                "TombOfTheEaters_TouhouGW_WindGodGirl"
                            };
                    }
                } //Sultan Tombs: Above levels 4-9
                else if (Z.Z >= 5)
                {
                    Tracks =
                        new string[] { "TombOfTheEaters_Bach_Concerto5Largo" };
                }
                else if (Z.Z >= 3)
                {
                    Tracks =
                        new string[] { "TombOfTheEaters_GaryMoore_TheLoner" };
                }
                else if (Z.Z >= 1)
                {
                    Tracks =
                        new string[] {
                            "TombOfTheEaters_ThePanpipers_LonelyShepherd"
                        };
                } //The Unfinished Tomb: Above level 10
                else if (Z.Z == 0)
                {
                    Tracks =
                        new string[] {
                            "TombOfTheEaters_RichardClayderman_LoveStory"
                        };
                }
            } //---------- //THIN WORLD / GATE TO BRIGHTSHEOL //-----------
            else if (
                Z.DisplayName.Contains("thin world") ||
                Z.DisplayName.Contains("Brightsheol")
            )
            {
                toPatch = "yes";
                Tracks =
                    new string[] {
                        "ThinWorld_BindingOfIsaacRepented_GuardiansGift",
                        "ThinWorld_BindingOfIsaacRepented_GuardiansGift",
                        "default"
                    };
            } //---------- //TREMBLING DUNES //-----------
            else if (Z.DisplayName.Contains("Trembling Dunes") && Z.Z <= 12)
            {
                Tracks =
                    new string[] { "TremblingDunes_PMDSky_UpperSteamCave" };
            } //---------- //TZIMTZLUM //-----------
            else if (Z.DisplayName.Contains("Tzimtzlum"))
            {
                toPatch = "yes";
                Tracks =
                    new string[] {
                        "Tzimtzlum_PMDRTDX_DeepSeaCurrent",
                        "Tzimtzlum_PMDRTDX_DeepSeaCurrent",
                        "default"
                    };
            } //---------- //WATERLOGGED TUNNEL //-----------
            else if (Z.DisplayName.Contains("waterlogged tunnel"))
            {
                Tracks =
                    new string[] {
                        "WaterloggedTunnel_PMDSky_WaterfallCave",
                        "RuinsRegion_TalesOfMajEyal_Mystery"
                    };
            } //---------- //YD FREEHOLD //-----------
            else if (Z.DisplayName.Contains("Yd Freehold"))
            {
                Tracks =
                    new string[] {
                        "YdFreehold_PokemonRSE_DewfordTown",
                        "YdFreehold_FinalFantasy7_AheadOnOurWay"
                    };
            } /*
            *****************************************************
            ********** RANDOM VILLAGES (EXCEPT GOATFOLK) ********
            *****************************************************/
            else if (
                Z.HasBuilder("Village") || Z.HasBuilder("VillageOutskirts")
            )
            {
                string villageFaction = Z.GetZoneProperty("faction");
                string region = Z.GetRegion();
                bool isAbandoned = IsAbandonedVillage(villageFaction);
                bool isStarting = IsStartingVillage(villageFaction);

                // ABANDONED STARTING VILLAGE (VERY RARE) //
                if (isStarting && isAbandoned)
                {
                    Tracks =
                        new string[] {
                            "VillageStartingAbandoned_JoaquinRodrigo_ConciertoDeAranjuez"
                        };
                } // ABANDONED VILLAGE //
                else if (isAbandoned)
                {
                    Tracks =
                        new string[] {
                            "VillageAbandoned_DragonQuestVIII_Remembrances",
                            "VillageAbandoned_NarutoShippuden_Loneliness",
                            "VillageAbandoned_FinalFantasy4DS_ThemeOfSorrow",
                            "VillageAbandoned_SteinsGate_Farewell",
                            "VillageAbandoned_PSMD_WithinTheSadness",
                            "VillageAbandoned_TheLegendOfHeroes_InMyHeart"
                        };
                } // STARTING VILLAGE //
                else if (isStarting)
                {
                    Tracks =
                        new string[] {
                            "VillageStarting_WildARMs_IntoTheWilderness",
                            "VillageStarting_WildARMs_IntoTheWilderness",
                            "VillageStarting_TouhouGW_TheBulletReporter",
                            "VillageStarting_WildARMs_IntoTheWilderness",
                            "VillageStarting_TheLegendsOfHeroes_OpeningSize",
                            "VillageStarting_WildARMs_IntoTheWilderness",
                            "VillageStarting_BindingOfIsaacWrathOfTheLamb_Opening",
                            "VillageStarting_BindingOfIsaacAntibirth_Descent"
                        };
                } // DESERT CANYON VILLAGE //
                else if (region == "DesertCanyon")
                {
                    Tracks =
                        new string[] {
                            "VillageDesertCanyon_ZeldaOcarinaOfTime_KakarikoVillage",
                            "VillageDesertCanyon_PokemonSunMoon_RanchOhana"
                        };
                } // SALT DUNES VILLAGE //
                else if (region == "Saltdunes")
                {
                    Tracks =
                        new string[] {
                            "VillageSaltDunes_DivinityOS2_FortJoyBattleTambura",
                            "VillageSaltDunes_DivinityOS2_FortJoyBattleTambura",
                            "VillageSaltDunes_TheLegendOfHeroes_AmberAmourLute"
                        };
                } // SALT MARSH VILLAGE //
                else if (region == "Saltmarsh")
                {
                    Tracks =
                        new string[] {
                            "VillageSaltMarsh_PSMD_SchoolForestLofiRemix",
                            "VillageSaltMarsh_PSMD_SchoolForestLofiRemix",
                            "VillageSaltMarsh_TheLegendOfHeroes_ACatRelaxingInTheSunRemastered"
                        };
                } // HILLS VILLAGE //
                else if (region == "Hills")
                {
                    Tracks =
                        new string[] {
                            "VillageHills_FinalFantasy6PR_KidsRunThroughTheCityCorner",
                            "VillageHills_PokemonBW2_VillageBridge",
                            "VillageHills_FinalFantasy6PR_KidsRunThroughTheCityCorner"
                        };
                } // RIVERS VILLAGE //
                else if (region == "Water")
                {
                    Tracks =
                        new string[] {
                            "VillageRivers_Bach_AirOnTheGString",
                            "VillageRivers_PokemonORAS_OceanicMuseum",
                            "VillageRivers_Bach_AirOnTheGString"
                        };
                } // BANANA GROVE VILLAGE //
                else if (region == "BananaGrove")
                {
                    Tracks =
                        new string[] {
                            "VillageBananaGrove_TheLegendOfHeroes_GoInGoodCheer",
                            "VillageBananaGrove_PMDGTI_PokemonParadiseFinal",
                            "VillageBananaGrove_WildARMsAF_Town"
                        };
                } // RAINBOW WOOD VILLAGE //
                else if (region == "Fungal")
                {
                    Tracks =
                        new string[] {
                            "VillageRainbowWood_BradWhitePierreGill_Lullaby",
                            "VillageRainbowWood_BindingOfIsaacAntibirth_JourneyFromAJarToTheSky"
                        };
                } // LAKE HINNOM VILLAGE
                else if (region == "LakeHinnom")
                {
                    Tracks =
                        new string[] {
                            "VillageLakeHinnom_PokemonBW_UndellaTown"
                        };
                } // PALLADIUM REEF VILLAGE //
                else if (region == "PalladiumReef")
                {
                    Tracks =
                        new string[] {
                            "VillagePalladiumReef_PMDBRT_MtFreezePeakRemastered",
                            "VillagePalladiumReef_PMDBRT_MtFreezePeakRemastered",
                            "VillagePalladiumReef_Elona_Ruins"
                        };
                } // MOUNTAINS VILLAGE //
                else if (region == "Mountains")
                {
                    Tracks =
                        new string[] {
                            "VillageMountains_ShirenMD5_IoriVillage",
                            "VillageMountains_PokemonDPP_EternaCityNight"
                        };
                } // FLOWER FIELDS VILLAGE //
                else if (region == "Flowerfields")
                {
                    Tracks =
                        new string[] {
                            "VillageFlowerFields_PokemonHgSs_NationalPark",
                            "VillageFlowerFields_PokemonDPP_FloaromaTownDay"
                        };
                } // JUNGLE VILLAGE //
                else if (region == "Jungle")
                {
                    Tracks =
                        new string[] {
                            "VillageJungle_PSMD_PartnersThemeLofiRemix",
                            "VillageJungle_PokemonDPP_EternaForest"
                        };
                } // DEEP JUNGLE VILLAGE //
                else if (region == "DeepJungle")
                {
                    Tracks =
                        new string[] {
                            "VillageDeepJungle_PMDSky_HiddenLand",
                            "VillageDeepJungle_ShirenMD3_OtsutsukiVillageAncient"
                        };
                } // RUINS VILLAGE //
                else if (region == "Ruins")
                {
                    Tracks =
                        new string[] {
                            "VillageRuins_DivinityOS2_TheBlackPits",
                            "VillageRuins_FinalFantasy7_InfiltratingShinra"
                        };
                } // BAROQUE RUINS VILLAGE //
                else if (region == "BaroqueRuins")
                {
                    Tracks =
                        new string[] {
                            "VillageBaroqueRuins_DivinityOS2_MysteriousTrails",
                            "VillageBaroqueRuins_JimmyThackery_TheBarbersGuitar",
                            "VillageBaroqueRuins_DivinityOS2_MysteriousTrails"
                        };
                } // MOON STAIR VILLAGE //
                else if (region == "MoonStair")
                {
                    Tracks =
                        new string[] {
                            "VillageMoonStair_FinalFantasy7_YouCanHearTheCryOfThePlanet",
                            "VillageMoonStair_FinalFantasy7_TheGreatNorthernCaveRemastered"
                        };
                }
            } /*
            *****************************************************
            ************** GOATFOLK VILLAGES & HAUNTS ***********
            *****************************************************

               // GOATFOLK VILLAGES //
            */
            else if (Z.HasBuilder("GoatfolkYurts"))
            {
                Tracks =
                    new string[] {
                        "GoatfolkVillage_DivinityOS2_FortJoyBattleBansuri",
                        "GoatfolkVillage_FinalFantasy4_Boss",
                        "GoatfolkVillage_PokemonOrigins_WildBattle",
                        "GoatfolkVillage_DivinityOS2_FortJoyBattleBansuri",
                        "GoatfolkVillage_PokemonBW_GymLeaderBattle",
                        "GoatfolkVillage_PokemonDPP_TeamGalaxyAdminBattle",
                        "GoatfolkVillage_DivinityOS2_FortJoyBattleBansuri"
                    };
            } // GOATFOLK HAUNTS //
            else if (Z.HasBuilder("GoatfolkQlippothYurts"))
            {
                Tracks =
                    new string[] {
                        "GoatfolkHaunts_FinalFantasy4DS_TheDreadfulFight",
                        "GoatfolkHaunts_FinalFantasy4SNES_BossBattle",
                        "GoatfolkHaunts_FinalFantasy5GBA_BattleTheme",
                        "GoatfolkHaunts_PokemonSunMoon_EliteFourBattle",
                        "GoatfolkHaunts_PokemonBW2_GymLeaderBattle"
                    };
            } // RAZED GOATFOLK VILLAGE //
            else if (
                Z.HasBuilder("RazedGoatfolkVillage") ||
                Z.HasBuilder("MinorRazedGoatfolkVillage")
            )
            {
                Tracks =
                    new string[] { "GoatfolkRazed_Terminator2_MainTheme" };
            } /*
            *****************************************************
            *********************** LAIRS ***********************
            *****************************************************
            */
            else if (Z.HasBuilder("BasicLair"))
            {
                if (Z.Z > 10)
                {
                    toPatch = "yes";
                }

                // LAIR MERCHANTS (Kitchen, workshop, etc) //
                if (!Z.DisplayName.Contains("lair"))
                {
                    Tracks =
                        new string[] {
                            "LairMerchant_ShirenMD2_Track8",
                            "LairMerchant_DivinityOS2_RedPrinceTheme",
                            "LairMerchant_PSMD_DrilburCoalMine"
                        };
                } // TIER (0-)1: SALT MARSHES, DESERT CANYONS //
                else if (Z.NewTier <= 1)
                {
                    Tracks =
                        new string[] {
                            "Lair0-1_FinalFantasy7_J-E-N-O-V-A",
                            "Lair0-1_TouhouGW_KobitoOfTheShiningNeedle",
                            "Lair0-1_PokemonSunMoon_VictoryRoad",
                            "Lair0-1_ChocoboMD-EB_FestivalOfTheHunt"
                        };
                } // TIER 2: SALT DESERTS, HILLS, FLOWER FIELDS //
                else if (Z.NewTier == 2)
                {
                    Tracks =
                        new string[] {
                            "Lair2_TouhouGW_BloomNobly~BorderOfLife",
                            "Lair2_DivinityOS2_TavernFight",
                            "Lair2_DivinityOS2_TheShadowPrince",
                            "Lair2_CastlevaniaDawnOfSorrow_ClocherMaudit"
                        };
                } // TIERS 3-4: JUNGLES, RUINS, RIVERS, MOUNTAINS //
                else if (Z.NewTier <= 4)
                {
                    Tracks =
                        new string[] {
                            "Lair3-4_FinalFantasy15_StandYourGround",
                            "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                            "Lair3-4_Bleach_FadeToBlackB13a",
                            "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                            "Lair3-4_BindingOfIsaacAntibirth_Allnoise"
                        };
                } // TIERS 5-6: RAINBOW WOODS, LAKE HINNOM, BANANA GROVE, DEEP JUNGLE //
                else if (Z.NewTier <= 6)
                {
                    Tracks =
                        new string[] {
                            "Lair5-6_PMDSky_SpacialCliffs",
                            "Lair5-6_PMDSky_DarkWasteland",
                            "Lair5-6_PMDSky_IcicleForest",
                            "Lair5-6_PMDSky_SpacialCliffs",
                            "Lair5-6_PMDSky_DarkWasteland",
                            "Lair5-6_PMDSky_IcicleForest",
                            "Lair5-6_PSMD_EchoesOfTheMysticalForest",
                            "Lair5-6_Elona_OverworldField1Remastered"
                        };
                } // TIER 7: PALLADIUM REEF, BAROQUE RUINS // Just a fallback, no Lair there pretty much
                else if (Z.NewTier == 7)
                {
                    Tracks =
                        new string[] {
                            "Lair7_PMDSky_FortuneRavine",
                            "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                            "Lair7_PSMD_MysteryJungle"
                        };
                } // TIER 8: MOON STAIR
                else if (Z.NewTier == 8)
                {
                    Tracks =
                        new string[] {
                            "Lair8_Elona_MesheraAlphaTheDeformedAngel",
                            "Lair8_Elona_ZeomeTheFalseProphet",
                            "Lair8_TheLegendOfHeroes_HollowLightOfTheSealedLand"
                        };
                }
            } // THE LAIR OF OBOROQORU, LEGENDARY APE GOD
            else if (Z.HasBuilder("ApegodCave"))
            {
                toPatch = "yes";

                // Strata 1-5
                if (Z.Z <= 15)
                {
                    Tracks =
                        new string[] {
                            "LairOboroqoru_PMDSky_FortuneRavine",
                            "LairOboroqoru_PMDSky_ThroughTheSeaOfTime"
                        };
                } // Strata 6-8
                else if (Z.Z <= 18)
                {
                    Tracks =
                        new string[] {
                            "LairOboroqoru_PMDRTDX_SkyTowerRemastered"
                        };
                } // Strata 9: Oboroqoru's floor
                else if (Z.Z == 19)
                {
                    Tracks =
                        new string[] { "LairOboroqoru_PSMD_SecondDarkMatter" };
                }
            } /*
            *****************************************************
            ******************* OVERLAND RUINS ******************
            *****************************************************
            */
            else if (Z.HasBuilder("OverlandRuins"))
            {
                // TIER (0-)1: SALT MARSHES, DESERT CANYONS //
                if (Z.NewTier <= 1)
                {
                    if (Z.GetRegion() == "Saltmarsh")
                    {
                        Tracks =
                            new string[] {
                                "Ruins_WildARMs_AfterTheChaosAndDestruction",
                                "Ruins_PMDRRT_MtThunderPeak"
                            };
                    }
                    else if (Z.GetRegion() == "DesertCanyon")
                    {
                        Tracks =
                            new string[] {
                                "Ruins_WildARMsAF_AfterTheChaosAndDestruction",
                                "Ruins_PMDRRT_MtThunderPeak"
                            };
                    }
                    else
                    {
                        Tracks =
                            new string[] {
                                "Ruins_WildARMs_AfterTheChaosAndDestruction",
                                "Ruins_WildARMsAF_AfterTheChaosAndDestruction",
                                "Ruins_PMDRRT_MtThunderPeak"
                            };
                    }
                } // TIER 2: SALT DESERTS, HILLS, FLOWER FIELDS //
                else if (Z.NewTier == 2)
                {
                    Tracks =
                        new string[] {
                            "Ruins_WildARMs_AfterTheChaosAndDestruction",
                            "Ruins_FinalFantasy7_AnxiousHeart"
                        };
                } // TIERS 3-4: JUNGLES, RUINS, RIVERS, MOUNTAINS //
                else if (Z.NewTier <= 4)
                {
                    Tracks =
                        new string[] {
                            "Ruins_WildARMsAF_AfterTheChaosAndDestruction",
                            "Ruins_PMDSky_HiddenHighland",
                            "Ruins_PMDSky_HiddenHighland"
                        };
                } // TIERS 5-6: RAINBOW WOODS, LAKE HINNOM, DEEP JUNGLE, BANANA GROVE //
                else if (Z.NewTier <= 6)
                {
                    Tracks =
                        new string[] {
                            "Ruins_WildARMsAF_AfterTheChaosAndDestruction",
                            "Ruins_PMDSky_HiddenHighlandRemastered",
                            "Ruins_PMDSky_HiddenHighlandRemastered",
                            "Ruins_Bleach_NothingCanBeExplained"
                        };
                } // TIER 7: PALLADIUM REEF, BAROQUE RUINS // Same as Lairs, no Ruins pretty much
                else if (Z.NewTier == 7)
                {
                    Tracks =
                        new string[] {
                            "Ruins_PSMD_Voidlands",
                            "Ruins_PMDSky_DeepDarkCraterRemastered",
                            "Ruins_PSMD_Voidlands"
                        };
                } // TIER 8: MOON STAIR
                else if (Z.NewTier == 8)
                {
                    Tracks =
                        new string[] {
                            "Ruins_FinalFantasy4_TheLunariansRemastered",
                            "Ruins_PSMD_Voidlands"
                        };
                }
            } /*
            *****************************************************
            ******************* HISTORIC SITES ******************
            *****************************************************
            */
            else if (Z.HasBuilder("SultanDungeon"))
            {
                // FIFTH PERIOD, TIERS 0-1 //
                if (Z.NewTier <= 1)
                {
                    Tracks =
                        new string[] {
                            "default",
                            "HistoricSite5-1_Mozart_Lacrimosa",
                            "HistoricSite5-1_BrahmsSymphony3Op90_PocoAllegretto",
                            "HistoricSite5-1_MozartPianoConcerto23Adagio",
                            "HistoricSite5-1_PMDRTDX_MtThunderPeak"
                        };
                } // FIFTH PERIOD, TIER 2 //
                else if (Z.NewTier == 2)
                {
                    Tracks =
                        new string[] {
                            "HistoricSite5-2_ShirenMD3_CentipedesDen",
                            "HistoricSite5-2_ShirenMD3_InnerKarakuriMansion",
                            "HistoricSite5-2_ShirenMD3_InnerKarakuriMansion",
                            "HistoricSite5-2_PMDRRT_GreatCanyon",
                            "default"
                        };
                } // FOURTH PERIOD, TIERS 3-4 //
                else if (Z.NewTier <= 4)
                {
                    Tracks =
                        new string[] {
                            "HistoricSite4_FinalFantasy6_Terra",
                            "HistoricSite4_ChronoCross_Shore",
                            "HistoricSite4_ShirenMD3_Hourai",
                            "HistoricSite4_FinalFantasy7_MainTheme",
                            "default"
                        };
                } // THIRD PERIOD, TIERS 5-6: RAINBOW WOOD, LAKE HINNOM
                else if (
                    Z.NewTier <= 6 &&
                    (
                    Z.GetRegion() == "Fungal" || Z.GetRegion() == "LakeHinnom"
                    )
                )
                {
                    Tracks =
                        new string[] {
                            "HistoricSite3_FairyTailEnding_LonelyPerson",
                            "HistoricSite3_TheLegendOfHeroes_TheWhereaboutsOfTheStars",
                            "HistoricSite3_FinalFantasy10HD_YunasDecision",
                            "RuinsRegion_TalesOfMajEyal_Mystery",
                            "HistoricSite3_PMDBRT_FrostyGrottoRemastered"
                        };
                } // THIRD PERIOD, TIERS 5-6: BANANA GROVE, DEEP JUNGLE
                else if (Z.NewTier <= 6)
                {
                    Tracks =
                        new string[] {
                            "AsphaltMines_PMDBRT_MtBlazeRemix",
                            "HistoricSite3_LordOfTheRings_BreakingOfTheFellowship",
                            "TombOfTheEaters_ThePanpipers_LonelyShepherd",
                            "HistoricSite3_PokemonSunMoon_Ending"
                        };
                } // SECOND PERIOD, TIER 7 //
                else if (Z.NewTier == 7)
                {
                    Tracks =
                        new string[] {
                            "HistoricSite2_NieRAutomata_War&WarVocals",
                            "HistoricSite2_SteinsGate_Ending1",
                            "HistoricSite2_BindingOfIsaacExcelsior_Ascent",
                            "default"
                        };
                } // FIRST PERIOD, TIER 8 //
                else if (Z.NewTier == 8)
                {
                    Tracks =
                        new string[] {
                            "HistoricSite1_NieRAutomata_TheWeightOfTheWorldJapanese",
                            "HistoricSite1_NieRAutomata_TheWeightOfTheWorldJapanese",
                            "HistoricSite1_NieRAutomata_TheWeightOfTheWorldEnglish",
                            "HistoricSite1_FinalFantasy10_SutekiDaNe",
                            "HistoricSite1_NieRAutomata_TheWeightOfTheWorldJapanese",
                            "HistoricSite1_TheLegendOfHeroes_TheWhereaboutsOfLight"
                        };
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
                if (
                    region == "BananaGrove" ||
                    Z.DisplayName.Contains("banana grove")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "BananaGrove_ZeldaOOT_GerudoValleyRemastered",
                                "BananaGrove_PokemonSunMoon_VastPoniCanyon",
                                "BananaGrove_TouhouGW_WelcomeToYoukaiTemple",
                                "BananaGrove_PSMD_FireIslandVolcano"
                            };
                    } // Subterranean Banana Grove
                    else
                    {
                        Tracks =
                            new string[] {
                                "BananaGrove_ZeldaOOT25thAnniv_GerudoValley",
                                "BananaGrove_ZeldaOOT25thAnniv_GerudoValley",
                                "BananaGrove_PokemonSunMoon_VastPoniCanyonRemix"
                            };
                    }
                } // BAROQUE RUINS
                else if (
                    region == "BaroqueRuins" ||
                    Z.DisplayName.Contains("baroque ruins")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "BaroqueRuins_TouhouGW_MysticDream~SnowOrCherryPetal",
                                "BaroqueRuins_Elona_Dungeon14",
                                "BaroqueRuins_PSMD_PrehistoricRuins",
                                "BaroqueRuins_BindingOfIsaacRepented_Crevice"
                            };
                    } // Subterranean Baroque Ruins
                    else
                    {
                        Tracks =
                            new string[] {
                                "BaroqueRuins_Elona_Dungeon14",
                                "Underground_Elona_Dungeon15"
                            };
                    }
                } // DEEP JUNGLE
                else if (
                    region == "DeepJungle" ||
                    Z.DisplayName.Contains("deep jungle")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "DeepJungle_PMDSky_TreeshroudForest",
                                "DeepJungle_PSMD_ForebodingForest",
                                "DeepJungle_TheLegendOfHeroes_TetracyclicTower",
                                "DeepJungle_BindingOfIsaacRepented_AqueousSorrow"
                            };
                    } // Subterranean Deep Jungle
                    else
                    {
                        Tracks =
                            new string[] {
                                "DeepJungle_PMDSky_TreeshroudForest",
                                "BethesdaSusa_PMDSky_SkyPeakSnowfield",
                                "DeepJungle_PSMD_ForebodingForestRemix"
                            };
                    }
                } // DESERT CANYON
                else if (
                    region == "DesertCanyon" ||
                    Z.DisplayName.Contains("desert canyon")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "DesertCanyon_TouhouGW_HiganRetour~RiversideView",
                                "DesertCanyon_PMDSky_MtHorn",
                                "DesertCanyon_PMDGTI_StompstumpPeak",
                                "DesertCanyon_PMDBRT_GreatCanyonRemastered"
                            };
                    } // Subterranean Desert Canyon
                    else
                    {
                        Tracks =
                            new string[] {
                                "DesertCanyon_PMDSky_AmpPlains",
                                "RustWells_ShirenMD1DS_TaintedPath",
                                "DesertCanyon_PMDBRT_GreatCanyonRemix"
                            };
                    }
                } // FLOWER FIELDS
                else if (
                    region == "Flowerfields" ||
                    Z.DisplayName.Contains("flower fields")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "FlowerFields_EtrianMD1_ChalkyWoods",
                                "FlowerFields_TouhouGW_StrangeEverydayLifeOfTheFlyingShrineMaiden",
                                "FlowerFields_TouhouGW_TheGensokyoTheGodsLoved"
                            };
                    } // Subterranean Flower Fields
                    else
                    {
                        Tracks =
                            new string[] {
                                "Jungle_TalesOfMajEyal_WorldOfIce",
                                "LakeHinnom_TalesOfMajEyal_RainyDay"
                            };
                    }
                } // HILLS
                else if (region == "Hills" || Z.DisplayName.Contains("hills"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "Hills_PMDGTI_RaggedMountain",
                                "Hills_PMDGTI_HazyPass",
                                "Hills_TheLegendOfHeroes_SecretGreenPassage"
                            };
                    } // Subterranean Hills
                    else
                    {
                        Tracks =
                            new string[] {
                                "Hills_PMDGTI_RaggedMountainRemix",
                                "RustedArchway_PokemonBW_Route10",
                                "Hills_TheLegendOfHeroes_SecretGreenPassage"
                            };
                    }
                } // JUNGLE
                else if (region == "Jungle" || Z.DisplayName.Contains("jungle")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "Jungle_TouhouGW_RetrospectiveKyoto",
                                "Jungle_TouhouGW_MagusNight",
                                "Jungle_PSMD_LushForest",
                                "Jungle_BindingOfIsaacRepented_Agony"
                            };
                    } // Subterranean Jungle
                    else
                    {
                        Tracks =
                            new string[] {
                                "Jungle_PSMD_LushForestRemix",
                                "Jungle_BindingOfIsaacExcelsior_SixFeetUnder",
                                "Jungle_BindingOfIsaacRepented_Agony"
                            };
                    }
                } // LAKE HINNOM
                else if (
                    region == "LakeHinnom" || Z.DisplayName.Contains("Hinnom")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "LakeHinnom_TouhouGW_DancingWaterDrops",
                                "LakeHinnom_DonkeyKongCountry_AquaticAmbience",
                                "LakeHinnom_PMDBRT_MtFreezeRemastered",
                                "LakeHinnom_BindingOfIsaacRepented_Torrent"
                            };
                    } // Subterranean Lake Hinnom
                    else
                    {
                        Tracks =
                            new string[] {
                                "LakeHinnom_EtrianMD_WaterfallWoodlands",
                                "LakeHinnom_TalesOfMajEyal_RainyDay"
                            };
                    }
                } // MOON STAIR
                else if (
                    region == "MoonStair" || Z.DisplayName.Contains("Stair")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "MoonStair_FinalFantasy7_YouCanHearTheCryOfThePlanetRemix",
                                "MoonStair_FinalFantasy7_ThoseChosenByThePlanetRemastered",
                                "BethesdaSusa_PSMD_TreeofLifeTrunk",
                                "MoonStair_BindingOfIsaacRepented_Incision",
                                "default"
                            };
                    } // Subterranean stair
                    else
                    {
                        Tracks =
                            new string[] {
                                "MoonStair_FinalFantasy7_ThoseChosenByThePlanetRemastered2",
                                "MoonStair_PMDBRT_MtThunderPeakRemastered",
                                "BethesdaSusa_PSMD_TreeofLifeTrunk"
                            };
                    }
                } // MOUNTAINS
                else if (
                    region == "Mountains" ||
                    Z.DisplayName.Contains("mountains")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "Mountains_PMDGTI_Holehills",
                                "Mountains_PMDGTI_HazyPassHighlands",
                                "Mountains_PMDBRT_MtThunderRemastered"
                            };
                    } // Subterranean Mountains
                    else
                    {
                        Tracks =
                            new string[] {
                                "Mountains_PMDRRT_MtThunder",
                                "Mountains_PMDGTI_IllusoryHazyPass",
                                "Mountains_PMDGTI_Holehills"
                            };
                    }
                } // PALLADIUM REEF
                else if (
                    region == "PalladiumReef" || Z.DisplayName.Contains("Reef")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "PalladiumReef_PMDBRT_MtFreezePeakRemastered2",
                                "PalladiumReef_PSMD_DepthsOfTheSubmergedCave",
                                "PalladiumReef_DonkeyKongCountry_AquaticAmbienceBardcoreCover"
                            };
                    } // Subterranean reef
                    else
                    {
                        Tracks =
                            new string[] {
                                "PalladiumReef_Elona_Dungeon1-5",
                                "PalladiumReef_PMDBRT_MtFreezePeak",
                                "PalladiumReef_PSMD_DepthsOfTheSubmergedCave"
                            };
                    }
                } // RAINBOW WOOD
                else if (
                    region == "Fungal" ||
                    Z.DisplayName.Contains("Rainbow Wood")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "RainbowWood_Tangledeep_MiraiTheHeroine",
                                "RainbowWood_Tangledeep_MysteriesOfTime",
                                "RainbowWood_Elona_Dungeon6-10"
                            };
                    } // Subterranean Rainbow Wood
                    else
                    {
                        Tracks =
                            new string[] {
                                "RainbowWood_Elona_Dungeon5-9",
                                "RainbowWood_DivinityOS2_MaraisExsanguesFortJoyBridge",
                                "RainbowWood_BindingOfIsaacRepentance_Stargazer"
                            };
                    }
                } // RIVERS
                else if (region == "Water" || Z.DisplayName.Contains("river"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "Rivers_CastlevaniaCurseOfDarkness_MortviaFountain",
                                "Rivers_NieRAutomata_CityRuinsRaysOfLightVocal",
                                "Rivers_FinalFantasy10HD_SilenceBeforeTheStorm",
                                "Rivers_BindingOfIsaacRepented_ParishedExistence"
                            };
                    } // Subterranean rivers
                    else
                    {
                        Tracks =
                            new string[] {
                                "Rivers_CastlevaniaCurseOfDarkness_GaribaldiCourtyard",
                                "Rivers_NieRAutomata_CityRuinsRaysOfLight",
                                "Rivers_TalesOfMajEyal_TakingFlight"
                            };
                    }
                } // RUINS
                else if (region == "ruins" || Z.DisplayName.Contains("ruins"))
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "RuinsRegion_PMDGTI_TyrianMazeInnerChamber",
                                "RuinsRegion_PMDRRT_BuriedRelic",
                                "RuinsRegion_CastlevaniaDawnOfSorrow_MinesAbandonnées",
                                "RuinsRegion_BindingOfIsaacRepented_Sepulchre"
                            };
                    } // Subterranean Ruins
                    else
                    {
                        Tracks =
                            new string[] {
                                "RuinsRegion_TalesOfMajEyal_Mystery",
                                "RuinsRegion_PMDGTI_TyrianMazeInnerChamber"
                            };
                    }
                } // SALT DUNES
                else if (
                    region == "Saltdunes" ||
                    Z.DisplayName.Contains("salt desert")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "SaltDesert_PMDSky_QuicksandPit",
                                "SaltDesert_PMDSky_NorthernDesert",
                                "SaltDesert_PMDGTI_WitheredSavannah",
                                "SaltDesert_BindingOfIsaacRepented_Predicament"
                            };
                    } // Subterranean desert
                    else
                    {
                        Tracks =
                            new string[] {
                                "TremblingDunes_PMDSky_UpperSteamCave",
                                "SaltDesert_Persona5_WhenMotherWasThere",
                                "SaltDesert_PMDGTI_ScorchingDesert"
                            };
                    }
                } // SALT MARSH
                else if (
                    region == "Saltmarsh" ||
                    Z.DisplayName.Contains("salt marsh")
                )
                {
                    // Surface
                    if (Z.Z == 10)
                    {
                        Tracks =
                            new string[] {
                                "SaltMarsh_TouhouGW_FragrantPlants",
                                "SaltMarsh_PSMD_PoliwrathRiver",
                                "SaltMarsh_PSMD_SchoolForest",
                                "SaltMarsh_PMDSky_FoggyForest",
                                "SaltMarsh_BindingOfIsaacRepented_LostInGuilt"
                            };
                    } // Subterranean marsh
                    else
                    {
                        Tracks =
                            new string[] {
                                "SaltMarsh_PSMD_NoeTown",
                                "LakeHinnom_EtrianMD_WaterfallWoodlands",
                                "SaltMarsh_BindingOfIsaacRepented_LostInGuilt"
                            };
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
                    Tracks =
                        new string[] {
                            "TombOfTheEaters_CastlevaniaDawnofSorrow_LePinacle",
                            "Underground_BindingOfIsaacWrathOfTheLamb_Sacrificial",
                            "Underground_BindingOfIsaacWrathOfTheLamb_AMournerUntoSheol",
                            "RuinsRegion_TalesOfMajEyal_Mystery",
                            "SaltMarsh_BindingOfIsaacRepented_LostInGuilt"
                        };
                } // Tier 3
                else if (Z.NewTier == 3)
                {
                    Tracks =
                        new string[] {
                            "Underground_CastlevaniaCurseOfDarkness_AiolonCaveTemple",
                            "HistoricSite2_BindingOfIsaacExcelsior_Ascent",
                            "MoonStair_PMDBRT_MtThunderPeakRemastered",
                            "Underground_BindingOfIsaacRepented_DesolateAbyss",
                            "RuinsRegion_TalesOfMajEyal_Mystery"
                        };
                } // Tier 4
                else if (Z.NewTier == 4)
                {
                    Tracks =
                        new string[] {
                            "TombOfTheEaters_CastlevaniaDawnOfSorrow_CondemnedTower",
                            "RainbowWood_Tangledeep_MysteriesOfTime",
                            "Underground_BindingOfIsaacAntibirth_Morphine",
                            "TombOfTheEaters_PMDSky_SealedRuin",
                            "BaroqueRuins_TouhouGW_MysticDream~SnowOrCherryPetal"
                        };
                } // Tier 5
                else if (Z.NewTier == 5)
                {
                    Tracks =
                        new string[] {
                            "Underground_PMDSky_VastIceMountain",
                            "Lair5-6_PMDSky_IcicleForest",
                            "AsphaltMines_PMDSky_SpringCaveDepths",
                            "BaroqueRuins_PSMD_PrehistoricRuins",
                            "Hills_TheLegendOfHeroes_SecretGreenPassage",
                            "SaltDesert_PMDGTI_ScorchingDesert"
                        };
                } // Tier 6
                else if (Z.NewTier == 6)
                {
                    Tracks =
                        new string[] {
                            "Underground_FinalFantasy4Advance_Zeromus",
                            "BethesdaSusa_Tangledeep_BanditBattle",
                            "BethesdaSusa_PMDSky_SkyPeakSnowfield",
                            "Underground_PMDSky_SealedRuinPit",
                            "AsphaltMines_PMDBRT_MtBlazeRemix"
                        };
                } // Tier 7
                else if (Z.NewTier == 7)
                {
                    Tracks =
                        new string[] {
                            "Lair8_Elona_ZeomeTheFalseProphet",
                            "Underground_FinalFantasy4SNES_LunarSubterrane",
                            "AsphaltMines_ChocoboEB_GuardianDarkness",
                            "BethesdaSusa_PMDGTI_GreatGlacierCrystalTower",
                            "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                            "EynRoj_PMDRRT_SkyTower"
                        };
                } // Tier 8
                else if (Z.NewTier == 8)
                {
                    Tracks =
                        new string[] {
                            "Underground_Elona_Dungeon15",
                            "Lair8_Elona_ZeomeTheFalseProphet",
                            "Lair8_TheLegendOfHeroes_HollowLightOfTheSealedLand",
                            "Underground_FinalFantasy4SNES_LunarSubterrane",
                            "Underground_Elona_Dungeon15",
                            "AsphaltMines_PMDBRT_MagmaCavernPitRemix",
                            "EynRoj_PMDSky_TemporalTower",
                            "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                            "Lair8_TheLegendOfHeroes_HollowLightOfTheSealedLand"
                        };
                }
            }
        }

        /*
        --<------------- END OF WHERE YOU EDIT --------<----- */
        public bool IsStartingVillage(string villageFaction)
        {
            HistoricEntitySnapshot villageSnapshot;
            bool IsStartingVillage;

            villageSnapshot =
                Qud.API.HistoryAPI.GetVillageSnapshot(villageFaction);

            IsStartingVillage =
                villageSnapshot
                    .GetProperty("isVillageZero", "false")
                    .EqualsNoCase("true");

            return IsStartingVillage;
        }

        public bool IsAbandonedVillage(string villageFaction)
        {
            HistoricEntitySnapshot villageSnapshot;

            villageSnapshot =
                Qud.API.HistoryAPI.GetVillageSnapshot(villageFaction);

            if (villageSnapshot.GetProperty("abandoned") == "true")
            {
                return true;
            }
            return false;
        }

        public bool ShouldPatchTrackIn(Zone Z)
        {
            setTrackListFor (Z);

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

            if (Tracks != null)
            {
                index = Custom_Soundtrack_Random.Next(0, Tracks.Length - 1);
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

                    int zSubstrLen =
                        currentZone.Length > 5 ? 5 : currentZone.Length;
                    int prevSubstrLen =
                        previousZone.Length > 5 ? 5 : previousZone.Length;

                    string formattedPrevZone =
                        previousZone.Substring(0, prevSubstrLen);
                    string formattedCurZone =
                        currentZone.Substring(0, zSubstrLen);

                    if (formattedPrevZone != formattedCurZone)
                    {
                        previousTrack = "";
                        timeSincePrevious = TimeSpan.Zero;
                    }
                    else if (
                        (
                        currentTime < maxTime ||
                        Z.HasBuilder("VillageOutskirts")
                        ) &&
                        Tracks.Contains(previousTrack)
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
                        }
                        else
                        {
                            isSameTrack = "yes";
                        }
                    }
                }

                // XRL.Messages.MessageQueue.AddPlayerMessage (currentZone);
                // XRL.Messages.MessageQueue.AddPlayerMessage (trackToPlay);
                trackData = new string[] { trackToPlay, isSameTrack };
                previousTrack = trackToPlay;
                previousZone = currentZone;
                previousZ = Z.Z;
                previousTime = DateTime.Now;
                return trackData;
            }
            else
            {
                previousTrack = "default";
                previousZone = currentZone;
                previousZ = Z.Z;
                previousTime = DateTime.Now;
                return null;
            }
        }
    }
}
