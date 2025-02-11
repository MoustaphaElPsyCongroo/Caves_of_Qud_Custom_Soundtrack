using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Custom_Soundtrack.ManageTracks
{
    [Serializable]
    public class UserTrackList
    {
        public IDictionary<string, List<string>> Tracks = new Dictionary<string, List<string>>()
        {
            {
                "Asphalt Mines_0-4_Upper shafts",
                new List<string> { "AsphaltMines_BindingOfIsaacRepentance_Fissure" }
            },
            {
                "Asphalt Mines_5_Ancient Bones",
                new List<string> { "AsphaltMines_PMDBRT_MtBlazePeakRemastered" }
            },
            {
                "Asphalt Mines_6-8_Middle Shafts",
                new List<string> { "AsphaltMines_PMDBRT_MtBlazeRemix" }
            },
            {
                "Asphalt Mines_9-12_Deep Shafts",
                new List<string> { "AsphaltMines_PMDRRT_MagmaCavern" }
            },
            {
                "Asphalt Mines_13-18_Darkunder",
                new List<string> { "AsphaltMines_PMDSky_SpringCaveDepths" }
            },
            {
                "Asphalt Mines_19_Great Sea",
                new List<string> { "AsphaltMines_PMDRRT_MtBlazePeakRemastered" }
            },
            {
                "Asphalt Mines_20-30_Tunnels of Ur & Swilling Vast",
                new List<string>
                {
                    "AsphaltMines_BindingOfIsaacAntibirth_Flashpoint_BBasement",
                    "AsphaltMines_ChocoboEB_GuardianDarkness",
                    "AsphaltMines_BindingOfIsaacAntibirth_Flashpoint_BBasement",
                    "AsphaltMines_ChocoboEB_GuardianDarkness",
                    "AsphaltMines_PMDBRT_MagmaCavernPitRemix"
                }
            },
            {
                "Grit Gate_0",
                new List<string> { "GritGate_PSMD_RevelationMountainPart1" }
            },
            {
                "Grit Gate_1-2_Lower Tunnels",
                new List<string> { "GritGate_CastlevaniaCOD_EneomaosMachineTower" }
            },
            {
                "Grit Gate_3_Gate Entrance",
                new List<string>
                {
                    "GritGate_PMDSky_TemporalSpire",
                    "GritGate_PMDSky_TemporalSpire",
                    "default"
                }
            },
            {
                "Grit Gate_4_Barathrum's Study",
                new List<string> { "GritGate_PokemonDPP_ProfRowanLaboratory" }
            },
            {
                "Bethesda Susa_0-1_Ruined Wharf",
                new List<string> { "BethesdaSusa_PMDGTI_GreatGlacierWesternSpire" }
            },
            {
                "Bethesda Susa_2_Healing Pools 1: Jotun, Who Parts Limbs",
                new List<string> { "BethesdaSusa_PokemonRSE_EliteFourBattle" }
            },
            {
                "Bethesda Susa_3_Healing Pools 2: Fjorn-Josef, Who Knits The Icy Lattice",
                new List<string> { "BethesdaSusa_Tangledeep_BanditBattle" }
            },
            {
                "Bethesda Susa_4_Healing Pools 3: Haggabah, Who Plies The Umbral Path",
                new List<string> { "BethesdaSusa_DivinityOS2_TheBattleForDivinity" }
            },
            {
                "Bethesda Susa_5_Abandoned Ward 1",
                new List<string> { "default" }
            },
            {
                "Bethesda Susa_6-10_Ruined Ward",
                new List<string>
                {
                    "BethesdaSusa_PMDSky_VastIceMountainPeak",
                    "BethesdaSusa_PMDGTI_GreatGlacierCrystalTower"
                }
            },
            {
                "Bethesda Susa_11-12_Abandoned Ward 2",
                new List<string> { "BethesdaSusa_PSMD_TreeOfLifeTrunk" }
            },
            {
                "Bethesda Susa_13_Cybernetics Ward",
                new List<string> { "BethesdaSusa_PMDSky_SkyPeakSnowfield" }
            },
            {
                "Bethesda Susa_14-15_Cryobarrios",
                new List<string> { "BethesdaSusa_PMDBRT_FrostyGrotto" }
            },
            {
                "Bethesda Susa_16_Temple of the Rock",
                new List<string> { "BethesdaSusa_PMDGTI_GreatGlacierWesternSpire" }
            },
            {
                "Bey Lah",
                new List<string>
                {
                    "BeyLah_WildArms_APersonsWarmth",
                    "BeyLah_ShirenMD2_BambooVillage",
                    "BeyLah_WildArmsAF_VillageoftheElw"
                }
            },
            {
                "Charred Tree",
                new List<string>
                {
                    "CharredTree_PMDRRT_RunAwayFugitives",
                    "CharredTree_PMDBRT_PartingFarewell",
                    "CharredTree_PMDSky_Réminiscences"
                }
            },
            {
                "Girsh Nephilim Cradles_Rermadon",
                new List<string>
                {
                    "CradleOfRermadon_LibraryOfRuina_TheReverberationEnsembleAsiyah"
                }
            },
            {
                "Girsh Nephilim Cradles_Shug'ruith",
                new List<string> { "Lair8_Elona_MesheraAlphaTheDeformedAngel" }
            },
            {
                "Girsh Nephilim Cradles_Qas and Qon",
                new List<string> { "CradleOfQasAndQon_PMDSky_PalkiaOnslaughRemastered" }
            },
            {
                "Girsh Nephilim Cradles_Agolgot",
                new List<string> { "HistoricSite1_NierAutomata_Simone" }
            },
            {
                "Girsh Nephilim Cradles_Bethsaida",
                new List<string> { "CradleOfBethsaida_TheBindingOfIsaacAntibirth_TerminalLucidity" }
            },
            {
                "Eyn Roj and Crystalline Roots_0",
                new List<string> { "EynRoj_PSMD_WitheredTreeOfLife" }
            },
            {
                "Eyn Roj and Crystalline Roots_1-9",
                new List<string> { "EynRoj_PSMD_TreeOfLifeRoots" }
            },
            {
                "Eyn Roj and Crystalline Roots_10-19",
                new List<string> { "EynRoj_PMDBRT_SkyTowerRemastered" }
            },
            {
                "Eyn Roj and Crystalline Roots_20-29",
                new List<string> { "EynRoj_PMDSky_TemporalSpireRemastered" }
            },
            {
                "Eyn Roj and Crystalline Roots_30-40",
                new List<string> { "EynRoj_PSMD_TreeOfLifeTrunkRemastered" }
            },
            {
                "Ezra",
                new List<string> { "Ezra_ShirenMD5_KeidaiNight", "default" }
            },
            {
                "Golgotha_0-1_Trash Chutes 1",
                new List<string> { "Golgotha_BindingOfIsaacRepentance_NightSoil_Dross" }
            },
            {
                "Golgotha_2-4_Trash Chutes 2-4",
                new List<string>
                {
                    "Golgotha_BindingOfIsaacRepentance_NightSoil_Dross",
                    "Golgotha_BindingOfIsaacAntibirth_HallowedGround_Downpour"
                }
            },
            {
                "Golgotha_5_Cloaca",
                new List<string> { "Golgotha_DivinityOS2_QuirkyBones_Slow" }
            },
            {
                "Gyl",
                new List<string> { "Gyl_DivinityOS2_Rivellon" }
            },
            {
                "Joppa",
                new List<string> { "Joppa_Haffner_Dom", "default", "Joppa_Haffner_Dom" }
            },
            {
                "Ruins of Joppa",
                new List<string> { "Joppa_Ruins_WildArms_AloneInTheWorld" }
            },
            {
                "Kyakukya",
                new List<string>
                {
                    "Kyakukya_WildArms_Town",
                    "Kyakukya_WildArms_ToTheEndWilderness"
                }
            },
            {
                "Omonporch_Court of the Sultans",
                new List<string> { "Omonporch_DivinityOS2_SanctuaryOfAmadia" }
            },
            {
                "Omonporch_Twin Gates",
                new List<string> { "Omonporch_DivinityOS2_ArxSquareAlt2" }
            },
            {
                "Red Rock_0",
                new List<string> { "RedRock_ShirenMD2_OldMine" }
            },
            {
                "Red Rock_1",
                new List<string> { "RedRock_ShirenMD2_CavernInTheCliff" }
            },
            {
                "Red Rock_2",
                new List<string> { "RedRock_ShirenMD2_TableMountain1" }
            },
            {
                "Red Rock_3",
                new List<string> { "RedRock_ShirenMD1SNES_TableMountain3" }
            },
            {
                "Red Rock_4",
                new List<string> { "RedRock_ShirenMD1SNES_WaterfallCavern" }
            },
            {
                "Rust Wells_0",
                new List<string> { "RustWells_ShirenMD1DS_TaintedPath" }
            },
            {
                "Rust Wells_1",
                new List<string>
                {
                    "RustWells_ShirenMD1DS_TaintedPath",
                    "RustWells_PMDGTI_WithinTheCragsOfLament",
                    "RustWells_CavernsOfXaskazien2_m05",
                    "RustWells_ShirenMD2_IceCave"
                }
            },
            {
                "Rust Wells_2-4",
                new List<string>
                {
                    "RustWells_PMDGTI_WithinTheCragsOfLament",
                    "RustWells_CavernsOfXaskazien2_m05",
                    "RustWells_ShirenMD2_IceCave"
                }
            },
            {
                "Rusted Archway_0",
                new List<string> { "RustedArchway_FinalFantasy10HD_Sprouting" }
            },
            {
                "Rusted Archway_1-2",
                new List<string>
                {
                    "RustedArchway_FinalFantasy10HD_Sprouting",
                    "RustedArchway_PokemonBW_Route10"
                }
            },
            {
                "Rusted Archway_3",
                new List<string> { "RustedArchway_PokemonHgSs_Route26" }
            },
            {
                "Rusted Archway_4",
                new List<string> { "RustedArchway_Reborn_Succession" }
            },
            {
                "Stillgrounds",
                new List<string>
                {
                    "Stiltgrounds_BindingOfIsaacRebirth_EverlastingHymn",
                    "Stiltgrounds_BindingOfIsaacWrathOfTheLamb_LamentOfTheAngel",
                    "Stiltgrounds_BindingOfIsaacRebirth_EverlastingHymn",
                    "Stiltgrounds_BindingOfIsaacAntibirth_TheThief"
                }
            },
            {
                "Six Day Stilt",
                new List<string>
                {
                    "SixDayStilt_DivinityOS2_Temple",
                    "SixDayStilt_Elona_ShrineOfGuardian"
                }
            },
            {
                "The Hydropon",
                new List<string> { "TheHydropon_DivinityOS2_FinalDepartureEnding" }
            },
            {
                "Tomb_of_the_Eaters_Liminal Way",
                new List<string> { "TombOfTheEaters_WildArms_KishumFlame" }
            },
            {
                "Tomb_of_the_Eaters_Spindle Channel",
                new List<string> { "TombOfTheEaters_ZeldaNes_Opening" }
            },
            {
                "Tomb_of_the_Eaters_0_Grand Vestibule",
                new List<string>
                {
                    "TombOfTheEaters_ShirenMD5_TowerMiracleKiseki2",
                    "TombOfTheEaters_PSMD_RevelationMountainOrchestral"
                }
            },
            {
                "Tomb_of_the_Eaters_0_Access corridors and structural ribs",
                new List<string> { "TombOfTheEaters_DivinityOS2_QuirkyBones" }
            },
            {
                "Tomb_of_the_Eaters_1_Banana grove passage to the tomb",
                new List<string> { "TombOfTheEaters_WildArms_KishumFlame" }
            },
            {
                "Tomb_of_the_Eaters_1_Folk Catacombs",
                new List<string>
                {
                    "TombOfTheEaters_PMDSky_SteamCave",
                    "TombOfTheEaters_PSMD_AncientBarrow",
                    "default",
                    "TombOfTheEaters_TalesOfMajEyal_TheAncients"
                }
            },
            {
                "Tomb_of_the_Eaters_+1_Crematory",
                new List<string>
                {
                    "TombOfTheEaters_BindingOfIsaacAntibirth_MachineInTheWalls",
                    "TombOfTheEaters_CastlevaniaDawnofSorrow_LePinacle"
                }
            },
            {
                "Tomb_of_the_Eaters_+1_Columbarium",
                new List<string> { "TombOfTheEaters_PMDSky_SealedRuin" }
            },
            {
                "Tomb_of_the_Eaters_+2_Lower Crypts: Warriors and Tutors",
                new List<string> { "TombOfTheEaters_CastlevaniaDawnOfSorrow_CondemnedTower" }
            },
            {
                "Tomb_of_the_Eaters_+3_Upper Crypts: Priests and Royal families",
                new List<string>
                {
                    "TombOfTheEaters_Albinioni_AdagioInGMinor",
                    "TombOfTheEaters_Albinioni_AdagioInGMinor",
                    "TombOfTheEaters_TouhouGW_WindGodGirl",
                    "TombOfTheEaters_CavernsOfXaskazien2_m08"
                }
            },
            {
                "Tomb_of_the_Eaters_+4-+5_Sultan Tomb",
                new List<string> { "TombOfTheEaters_GaryMoore_TheLoner" }
            },
            {
                "Tomb_of_the_Eaters_+6-+7_Sultan Tomb",
                new List<string> { "TombOfTheEaters_Bach_Concerto5Largo" }
            },
            {
                "Tomb_of_the_Eaters_+8-+9_Sultan Tomb",
                new List<string> { "TombOfTheEaters_ThePanpipers_LonelyShepherd" }
            },
            {
                "Tomb_of_the_Eaters_The Unfinished Tomb",
                new List<string> { "TombOfTheEaters_RichardClayderman_LoveStory" }
            },
            {
                "Thin World",
                new List<string> { "ThinWorld_BindingOfIsaacRepented_GuardiansGift", }
            },
            {
                "Trembling Dunes",
                new List<string> { "TremblingDunes_PMDSky_UpperSteamCave" }
            },
            {
                "Tzimtzlum",
                new List<string>
                {
                    "Tzimtzlum_PMDRTDX_DeepSeaCurrent",
                    "Tzimtzlum_PMDRTDX_DeepSeaCurrent",
                    "default"
                }
            },
            {
                "Waterlogged Tunnel",
                new List<string>
                {
                    "WaterloggedTunnel_PMDSky_WaterfallCave",
                    "RuinsRegion_TalesOfMajEyal_Mystery"
                }
            },
            {
                "Yd Freehold",
                new List<string>
                {
                    "YdFreehold_PokemonRSE_DewfordTown",
                    "YdFreehold_FinalFantasy7_AheadOnOurWay"
                }
            },
            {
                "Random Villages_Abandoned starting village (very rare)",
                new List<string> { "VillageStartingAbandoned_JoaquinRodrigo_ConciertoDeAranjuez" }
            },
            {
                "Random Villages_Abandoned village",
                new List<string>
                {
                    "VillageAbandoned_DragonQuestVIII_Remembrances",
                    "VillageAbandoned_NarutoShippuden_Loneliness",
                    "VillageAbandoned_FinalFantasy4DS_ThemeOfSorrow",
                    "VillageAbandoned_SteinsGate_Farewell",
                    "VillageAbandoned_PSMD_WithinTheSadness",
                    "VillageAbandoned_TheLegendOfHeroes_InMyHeart"
                }
            },
            {
                "Random Villages_Starting village",
                new List<string>
                {
                    "VillageStarting_WildArms_IntoTheWilderness",
                    "default",
                    "VillageStarting_WildArms_IntoTheWilderness",
                    "VillageStarting_TouhouGW_TheBulletReporter",
                    "default",
                    "VillageStarting_WildArms_IntoTheWilderness",
                }
            },
            {
                "Random Villages_Desert Canyon village",
                new List<string>
                {
                    "VillageDesertCanyon_ZeldaOcarinaOfTime_KakarikoVillage",
                    "VillageDesertCanyon_PokemonSunMoon_RanchOhana"
                }
            },
            {
                "Random Villages_Salt Desert village",
                new List<string>
                {
                    "VillageSaltDunes_DivinityOS2_FortJoyBattleTambura",
                    "VillageSaltDunes_DivinityOS2_FortJoyBattleTambura",
                    "VillageSaltDunes_TheLegendOfHeroes_AmberAmourLute"
                }
            },
            {
                "Random Villages_Salt Marshes village",
                new List<string>
                {
                    "VillageSaltMarsh_PSMD_SchoolForestLofiRemix",
                    "VillageSaltMarsh_PSMD_SchoolForestLofiRemix",
                    "VillageSaltMarsh_TheLegendOfHeroes_ACatRelaxingInTheSunRemastered"
                }
            },
            {
                "Random Villages_Hills village",
                new List<string>
                {
                    "VillageHills_FinalFantasy6PR_KidsRunThroughTheCityCorner",
                    "VillageHills_PokemonBW2_VillageBridge",
                    "VillageHills_FinalFantasy6PR_KidsRunThroughTheCityCorner"
                }
            },
            {
                "Random Villages_Rivers village",
                new List<string>
                {
                    "VillageRivers_Bach_AirOnTheGString",
                    "VillageRivers_PokemonORAS_OceanicMuseum",
                    "VillageRivers_Bach_AirOnTheGString"
                }
            },
            {
                "Random Villages_Banana Grove village",
                new List<string>
                {
                    "VillageBananaGrove_TheLegendOfHeroes_GoInGoodCheer",
                    "VillageBananaGrove_PMDGTI_PokemonParadiseFinal",
                    "VillageBananaGrove_WildArmsAF_Town"
                }
            },
            {
                "Random Villages_Rainbow Woods village",
                new List<string>
                {
                    "VillageRainbowWood_BradWhitePierreGill_Lullaby",
                    "VillageRainbowWood_BindingOfIsaacAntibirth_JourneyFromAJarToTheSky"
                }
            },
            {
                "Random Villages_Lake Hinnom village",
                new List<string> { "VillageLakeHinnom_PokemonBW_UndellaTown" }
            },
            {
                "Random Villages_Palladium Reef village",
                new List<string>
                {
                    "VillagePalladiumReef_PMDBRT_MtFreezePeakRemastered",
                    "VillagePalladiumReef_PMDBRT_MtFreezePeakRemastered",
                    "VillagePalladiumReef_Elona_Ruins"
                }
            },
            {
                "Random Villages_Mountains village",
                new List<string>
                {
                    "VillageMountains_ShirenMD5_IoriVillage",
                    "VillageMountains_PokemonDPP_EternaCityNight"
                }
            },
            {
                "Random Villages_Flower Fields village",
                new List<string>
                {
                    "VillageFlowerFields_PokemonHgSs_NationalPark",
                    "VillageFlowerFields_PokemonDPP_FloaromaTownDay"
                }
            },
            {
                "Random Villages_Jungle village",
                new List<string>
                {
                    "VillageJungle_PSMD_PartnersThemeLofiRemix",
                    "VillageJungle_PokemonDPP_EternaForest"
                }
            },
            {
                "Random Villages_Deep Jungle village",
                new List<string>
                {
                    "VillageDeepJungle_PMDSky_HiddenLand",
                    "VillageDeepJungle_ShirenMD3_OtsutsukiVillageAncient"
                }
            },
            {
                "Random Villages_Ruins village",
                new List<string>
                {
                    "VillageRuins_DivinityOS2_TheBlackPits",
                    "VillageRuins_FinalFantasy7_InfiltratingShinra"
                }
            },
            {
                "Random Villages_Baroque Ruins village",
                new List<string>
                {
                    "VillageBaroqueRuins_DivinityOS2_MysteriousTrails",
                    "VillageBaroqueRuins_JimmyThackery_TheBarbersGuitar",
                    "VillageBaroqueRuins_DivinityOS2_MysteriousTrails"
                }
            },
            {
                "Random Villages_Moon Stairs village",
                new List<string>
                {
                    "VillageMoonStair_FinalFantasy7_YouCanHearTheCryOfThePlanet",
                    "VillageMoonStair_FinalFantasy7_TheGreatNorthernCaveRemastered"
                }
            },
            {
                "Goatfolk Villages",
                new List<string>
                {
                    "GoatfolkVillage_DivinityOS2_FortJoyBattleBansuri",
                    "GoatfolkVillage_FinalFantasy4_BossBattle",
                    "GoatfolkVillage_PokemonOrigins_WildBattle",
                    "GoatfolkVillage_PokemonBW_GymLeaderBattle",
                    "GoatfolkVillage_PokemonDPP_TeamGalaxyAdminBattle",
                    "GoatfolkVillage_PokemonDPP_GymLeaderBattle",
                    "GoatfolkVillage_PokemonRSE_GymLeaderBattle",
                    "GoatfolkVillage_PokemonBW_EliteFourBattle",
                    "GoatfolkVillage_FinalFantasy10_BattleTheme",
                    "GoatfolkVillage_PokemonSunMoon_LegendsRedBlueBattle",
                    "GoatfolkVillage_FinalFantasy6_TheDecisiveBattle"
                }
            },
            {
                "Goatfolk Haunts",
                new List<string>
                {
                    "GoatfolkHaunts_FinalFantasy4DS_TheDreadfulFight",
                    "GoatfolkHaunts_FinalFantasy4SNES_BossBattle",
                    "GoatfolkHaunts_FinalFantasy5GBA_BattleTheme",
                    "GoatfolkHaunts_PokemonSunMoon_EliteFourBattle",
                    "GoatfolkHaunts_PokemonBW2_GymLeaderBattle",
                    "GoatfolkHaunts_PokemonRSE_KyogreGroudonRayquaza",
                    "GoatfolkHaunts_PokemonDPP_ChampionCynthia",
                    "GoatfolkHaunts_PokemonOrigins_ChampionBlue"
                }
            },
            {
                "Razed Goatfolk Village",
                new List<string> { "GoatfolkRazed_Terminator2_MainTheme" }
            },
            {
                "Lairs_Lair Merchants (workshops, kitchens, etc)",
                new List<string>
                {
                    "LairMerchant_ShirenMD2_Track8",
                    "LairMerchant_DivinityOS2_RedPrinceTheme",
                    "LairMerchant_PSMD_DrilburCoalMine"
                }
            },
            {
                "Lairs_Tier (0-)1_Salt Marshes lairs",
                new List<string>
                {
                    "Lair0-1_ChocoboMD-EB_FestivalOfTheHunt",
                    "Lair0-1_FinalFantasy7_J-E-N-O-V-A",
                    "Lair0-1_CastlevaniaCurseOfDarkness_AbandonedCastle",
                    "Lair0-1_TouhouGW_KobitoOfTheShiningNeedle",
                    "Lair0-1_PokemonSunMoon_VictoryRoad"
                }
            },
            {
                "Lairs_Tier 2_Flower Fields lairs",
                new List<string>
                {
                    "Lair2_Touhou_FallOfFall",
                    "Lair2_Touhou_Kids Festival~Innocent Treasures",
                    "Lair2_Touhou_AkyusUntouchedScoreVol5~ThemeOfEasternStory",
                    "Lair2_Touhou_FallOfFall",
                }
            },
            {
                "Lairs_Tier 2_Salt Deserts & Hills lairs",
                new List<string>
                {
                    "Lair2_CastlevaniaDawnOfSorrow_ClocherMaudit",
                    "Lair2_DivinityOS2_TavernFight",
                    "Lair2_TouhouGW_BloomNobly~BorderOfLife",
                    "Lair2_DivinityOS2_TheShadowPrince",
                    "Lair2_CavernsOfXaskazien2_m06"
                }
            },
            {
                "Lairs_Tier 3-4_Ruins lairs",
                new List<string>
                {
                    "Lair4_ChocoboEB_GuardianFlame2",
                    "Lair4_PMDRRT_MagmaCavernPit",
                    "Lair4_FinalFantasy7_ThoseWhoFightFurther",
                    "Lair7_TalesOfMajEyal_Far away"
                }
            },
            {
                "Lairs_Tier 3-4_Jungle lairs",
                new List<string>
                {
                    "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                    "Lair3-4_BindingOfIsaacAntibirth_Allnoise",
                    "Lair3_PSMD_MysteryJungle",
                    "Lair3_CavernsOfXaskazien2_m07"
                }
            },
            {
                "Lairs_Tier 3-4_Rivers lairs",
                new List<string>
                {
                    "Lair3-4_BindingOfIsaacAntibirth_Allnoise",
                    "Lair4_FinalFantasy15_StandYourGround",
                    "Lair4_Bleach_FadeToBlackB13a",
                    "Lair3-4_BindingOfIsaacAntibirth_Allnoise"
                }
            },
            {
                "Lairs_Tier 3-4_Mountains lairs",
                new List<string>
                {
                    "Lair4_Bleach_FadeToBlackB13a",
                    "Lair4_PMDRRT_MtBlaze",
                    "Lair4_PMDRRT_MtBlaze",
                    "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                    "Lair4_Bleach_FadeToBlackB13a"
                }
            },
            {
                "Lairs_Tier 5-6_Rainbow Woods lairs",
                new List<string>
                {
                    "Lair5_Tangledeep_EarthenLabyrinth",
                    "Lair5-6_PMDSky_IcicleForest",
                    "Lair5_PSMD_GlacierPalaceEasternSpire"
                }
            },
            {
                "Lairs_Tier 5-6_Lake Hinnom lairs",
                new List<string>
                {
                    "Lair5-6_PMDSky_SpatialCliffs",
                    "Lair5-6_PMDSky_DarkWasteland",
                    "Lair5-6_PMDSky_IcicleForest"
                }
            },
            {
                "Lairs_Tier 5-6_Banana Grove lairs",
                new List<string>
                {
                    "SaltDesert_PMDGTI_ScorchingDesert",
                    "AsphaltMines_PMDSky_SpringCaveDepths",
                    "Lair5-6_CavernsOfXaskazien2_m09"
                }
            },
            {
                "Lairs_Tier 7_Paladium Reef lairs",
                new List<string>
                {
                    "Lair7_PMDSky_FortuneRavine",
                    "Lair7_PMDRTDX_MagmaCavernPit",
                    "Underground_TalesOfMajEyal_Sinestra"
                }
            },
            {
                "Lairs_Tier 7_Baroque Ruins lairs",
                new List<string>
                {
                    "Lair7_ChocoboEB_GuardianFlame1",
                    "Lair7_BindingOfIsaacRepentance_Absentia",
                    "Lair7_TalesOfMajEyal_Far away",
                    "Underground_TalesOfMajEyal_Sinestra"
                }
            },
            {
                "Lairs_Tier 8_Moon Stair lairs",
                new List<string>
                {
                    "Lair8_Elona_ZeomeTheFalseProphet",
                    "Lair8_Elona_MesheraAlphaTheDeformedAngel",
                    "Lair8_Elona_ZeomeTheFalseProphet",
                    "Lair8_TheLegendOfHeroes_HollowLightOfTheSealedLand",
                    "Lair8_TheLegendOfHeroes_HollowLightOfTheSealedLand"
                }
            },
            {
                "Lairs_The Lair of Oboroqoru, Legendary Ape God_1-5",
                new List<string> { "LairOboroqoru_PMDSky_FortuneRavine" }
            },
            {
                "Lairs_The Lair of Oboroqoru, Legendary Ape God_6-8",
                new List<string> { "LairOboroqoru_PMDRTDX_SkyTowerRemastered" }
            },
            {
                "Lairs_The Lair of Oboroqoru, Legendary Ape God_9_Oboroqoru's Floor",
                new List<string> { "LairOboroqoru_PSMD_SecondDarkMatter" }
            },
            {
                "Overland Ruins_Tier (0-)1_Salt Marshes ruins",
                new List<string>
                {
                    "Ruins_WildArms_AfterTheChaosAndDestruction",
                    "Ruins_PMDBRT_MtThunderPeak"
                }
            },
            {
                "Overland Ruins_Tier (0-)1_Desert Canyon ruins",
                new List<string>
                {
                    "Ruins_WildArms_AfterTheChaosAndDestruction",
                    "Ruins_PMDRRT_MtThunderPeak",
                    "Ruins_PMDRRT_MtThunderPeak"
                }
            },
            {
                "Overland Ruins_Tier (0-)1_Fallback (most likely never used)",
                new List<string>
                {
                    "Ruins_WildArms_AfterTheChaosAndDestruction",
                    "Ruins_PMDRRT_MtThunderPeak"
                }
            },
            {
                "Overland Ruins_Tier 2_Flower Fields ruins",
                new List<string>
                {
                    "Ruins_Bleach_HereToStay",
                    "Ruins_Bleach_HereToStay",
                    "Ruins_BleachNeverMeantToBelong2ndMovement"
                }
            },
            {
                "Overland Ruins_Tier 2_Hills & Salt Desert ruins",
                new List<string>
                {
                    "Ruins_WildArms_AfterTheChaosAndDestruction",
                    "Ruins_FinalFantasy7_AnxiousHeart"
                }
            },
            {
                "Overland Ruins_Tier 3-4_Jungle ruins",
                new List<string>
                {
                    "Ruins_PMDSky_HiddenHighland",
                    "Ruins_PMDSky_TreeshroudForest",
                    "Ruins_WildArmsAF_AfterTheChaosAndDestruction",
                    "BeyLah_WildArmsAF_VillageoftheElw",
                    "Ruins_WildArmsAF_AfterTheChaosAndDestruction",
                    "BeyLah_WildArmsAF_VillageoftheElw",
                    "Ruins_PMDRRT_MtThunderPeak"
                }
            },
            {
                "Overland Ruins_Tier 3-4_Rivers ruins",
                new List<string>
                {
                    "Ruins_ChocoboEB_GuardianWater1",
                    "Ruins_BindingOfIsaacRepentance_RiverOfDespair",
                    "Ruins_WildArms_AfterTheChaosAndDestruction"
                }
            },
            {
                "Overland Ruins_Tier 3-4_Mountains ruins",
                new List<string>
                {
                    "Ruins_WildArmsAF_AfterTheChaosAndDestruction",
                    "Ruins_PMDSky_HiddenHighland",
                    "Ruins_Bleach_NothingCanBeExplainedVocal"
                }
            },
            {
                "Overland Ruins_Tier 5-6_Rainbow Woods & Lake Hinnom ruins",
                new List<string>
                {
                    "Ruins_ChocoboEB_GuardianWater1",
                    "Ruins_TalesOfMajEyal_WorldOfIce"
                }
            },
            {
                "Overland Ruins_Tier 5-6_Deep Jungle & Banana Grove ruins",
                new List<string>
                {
                    "Ruins_WildArmsAF_AfterTheChaosAndDestruction",
                    "Ruins_PMDSky_HiddenHighlandRemastered",
                    "Ruins_Bleach_NothingCanBeExplained"
                }
            },
            {
                "Overland Ruins_Tier 7_Palladium Reef ruins",
                new List<string>
                {
                    "Ruins_PMDSky_UpperSteamCave",
                    "Ruins_PMDSky_UpperSteamCave",
                    "Ruins_PSMD_Voidlands"
                }
            },
            {
                "Overland Ruins_Tier 7_Baroque Ruins ruins",
                new List<string>
                {
                    "Ruins_PSMD_Voidlands",
                    "Ruins_PMDSky_DeepDarkCraterRemastered",
                    "Ruins_PMDSky_DeepDarkCraterRemastered"
                }
            },
            {
                "Overland Ruins_Tier 7_Moon Stair ruins",
                new List<string>
                {
                    "Ruins_FinalFantasy4_TheLunariansRemastered",
                    "Ruins_FinalFantasy4_TheLunariansRemastered",
                    "Ruins_PSMD_Voidlands"
                }
            },
            {
                "Historic Sites_5th Period, Tier 1_Salt Marshes & Desert Canyon historic sites",
                new List<string>
                {
                    "HistoricSite5-2_TheBindingOfIsaacWrathOfTheLamb_Repentant",
                    "HistoricSite5-2_ChocoboMD_RevelationsOfTheOracles",
                    "default",
                    "HistoricSite5-1_PMDRTDX_MtThunderPeak",
                }
            },
            {
                "Historic Sites_5th Period, Tier 2_Flower Fields historic sites",
                new List<string>
                {
                    "Joppa_Ruins_WildArms_AloneInTheWorld",
                    "HistoricSite5-1_Mozart_Lacrimosa",
                    "HistoricSite5-1_DivinityOS2_PathOfTheGodwoken",
                    "HistoricSite5-1_MozartPianoConcerto23Adagio"
                }
            },
            {
                "Historic Sites_5th Period, Tier 2_Salt Desert & Hills historic sites",
                new List<string>
                {
                    "HistoricSite5-2_NierAutomata_MemoriesOfDust",
                    "HistoricSite5-2_ShirenMD3_InnerKarakuriMansion",
                    "HistoricSite5-2_PMDRRT_GreatCanyonRemastered2"
                }
            },
            {
                "Historic Sites_4th Period, Tiers 3-4_Jungle historic sites (guaranteed)",
                new List<string>
                {
                    "HistoricSite4_FinalFantasy6_WalkToNarshe",
                    "HistoricSite4_Martika_ToySoldiers",
                    "HistoricSite4_FinalFantasy7_MainTheme",
                    "HistoricSite4_ChronoCross_Shore"
                }
            },
            {
                "Historic Sites_4th Period, Tiers 3-4_Mountains historic sites",
                new List<string>
                {
                    "HistoricSite4_ShirenMD3_Hourai",
                    "HistoricSite4_FinalFantasy4_FabulRemastered",
                    "HistoricSite4_Elona_Palmia",
                    "HistoricSite4_FinalFantasy4_RedWingsRemastered",
                }
            },
            {
                "Historic Sites_4th Period, Tiers 3-4_Ruins historic sites",
                new List<string>
                {
                    "HistoricSite4_FinalFantasy4_RedWings",
                    "HistoricSite4_BindingOfIsaacAntibirth_Mithraeum",
                    "HistoricSite4_BindingOfIsaacRepentance_Carrion",
                    "HistoricSite4_ChronoTrigger_CorridorsOfTime"
                }
            },
            {
                "Historic Sites_4th Period, Tiers 3-4_Rivers historic sites",
                new List<string>
                {
                    "Rivers_NierAutomata_CityRuinsRaysOfLightVocal",
                    "HistoricSite4_Parano_MrLEV12Part1",
                    "Underground_BindingOfIsaacAntibirth_Morphine",
                    "HistoricSite4_Beethoven_Concerto5Emperor2ndMovement"
                }
            },
            {
                "Historic Sites_3rd Period, Tiers 5-6_Rainbow Woods historic sites",
                new List<string>
                {
                    "HistoricSite3_FinalFantasy10_YunasDecision",
                    "HistoricSite3_TheLegendOfHeroes_TheWhereaboutsOfTheStars",
                    "RuinsRegion_TalesOfMajEyal_Mystery",
                    "HistoricSite3_PMDSky_ForANewLife",
                    "HistoricSite3_Bleach_ARequiem",
                    "HistoricSite3_NierAutomata_VagueHope"
                }
            },
            {
                "Historic Sites_3rd Period, Tiers 5-6_Lake Hinnom historic sites",
                new List<string>
                {
                    "HistoricSite3_FinalFantasy10_TidusTheme",
                    "HistoricSite3_FinalFantasy10HD_YunasTheme",
                    "HistoricSite3_PMDSky_ForANewLife",
                    "RainbowWood_DivinityOS2_MaraisExsanguesFortJoyBridge"
                }
            },
            {
                "Historic Sites_3rd Period, Tiers 5-6_Banana Grove historic sites",
                new List<string>
                {
                    "HistoricSite3_Tangledeep_TheGreatSandVilla",
                    "HistoricSite3_DivinityOS2_FortJoyBattleOud",
                    "TombOfTheEaters_ThePanpipers_LonelyShepherd",
                    "HistoricSite3_DivinityOS2_DancingWithTheSourceOud",
                    "HistoricSite3_HansZimmer_Time",
                    "HistoricSite3_Tangledeep_TheGreatSandVilla"
                }
            },
            {
                "Historic Sites_3rd Period, Tiers 5-6_Deep Jungle historic sites",
                new List<string>
                {
                    "HistoricSite3_HansZimmer_Time",
                    "HistoricSite3_Tangledeep_EternalVerdantWaltz",
                    "HistoricSite3_Bleach_SoundscapeToArdor",
                    "HistoricSite3_HansZimmer_Time"
                }
            },
            {
                "Historic Sites_2nd Period, Tier 7_Baroque Ruins historic sites",
                new List<string>
                {
                    "HistoricSite2_NierAutomata_War&WarVocals",
                    "HistoricSite2_BindingOfIsaacExcelsior_Ascent",
                    "HistoricSite2_NierAutomata_ThisCannotContinue"
                }
            },
            {
                "Historic Sites_2nd Period, Tier 7_Palladium Reef historic sites",
                new List<string>
                {
                    "HistoricSite2_ChocoboEB_GuardianWater2",
                    "HistoricSite2_PMDSky_VastIceMountain",
                    "HistoricSite2_TalesOfMajEyal_TakingFlight",
                    "HistoricSite2_EtrianMD_WaterfallWoodlands",
                    "HistoricSite2_PMDSky_VastIceMountain",
                    "HistoricSite2_ChocoboEB_GuardianWater2"
                }
            },
            {
                "Historic Sites_1st Period, Tier 8_Moon Stair historic sites",
                new List<string>
                {
                    "HistoricSite1_NierAutomata_Simone",
                    "HistoricSite1_NierAutomata_TheWeightOfTheWorldJapanese",
                    "HistoricSite1_NierAutomata_Simone",
                    "HistoricSite1_FinalFantasy10_SutekiDaNe",
                    "HistoricSite1_TheLegendOfHeroes_TheWhereaboutsOfLight",
                    "HistoricSite1_NierAutomata_Simone"
                }
            },
            {
                "World Map terrain_Banana Grove terrain_0",
                new List<string>
                {
                    "BananaGrove_ZeldaOOT_GerudoValleyRemastered",
                    "BananaGrove_PokemonSunMoon_VastPoniCanyon",
                    "BananaGrove_TouhouGW_WelcomeToYoukaiTemple",
                    "BananaGrove_Elona_LostIrvaOverworld1"
                }
            },
            {
                "World Map terrain_Banana Grove terrain_Subterranean",
                new List<string>
                {
                    "BananaGrove_ZeldaOOT25thAnniv_GerudoValley",
                    "BananaGrove_ZeldaOOT25thAnniv_GerudoValley",
                    "BananaGrove_PokemonSunMoon_VastPoniCanyonRemix"
                }
            },
            {
                "World Map terrain_Baroque Ruins terrain_0",
                new List<string>
                {
                    "BaroqueRuins_TouhouGW_MysticDream~SnowOrCherryPetal",
                    "BaroqueRuins_Elona_Dungeon14",
                    "Music/Deep Dawn",
                    "BaroqueRuins_PSMD_PrehistoricRuins",
                    "BaroqueRuins_BindingOfIsaacRepented_Crevice"
                }
            },
            {
                "World Map terrain_Baroque Ruins terrain_Subterranean",
                new List<string> { "BaroqueRuins_Elona_Dungeon14", "Underground_Elona_Dungeon15" }
            },
            {
                "World Map terrain_Deep Jungle terrain_0",
                new List<string>
                {
                    "DeepJungle_PSMD_ForebodingForest",
                    "DeepJungle_TheLegendOfHeroes_TetracyclicTower",
                    "DeepJungle_BindingOfIsaacRepented_AqueousSorrow"
                }
            },
            {
                "World Map terrain_Deep Jungle terrain_Subterranean",
                new List<string>
                {
                    "BethesdaSusa_PMDSky_SkyPeakSnowfield",
                    "DeepJungle_PSMD_ForebodingForestRemix"
                }
            },
            {
                "World Map terrain_Desert Canyon terrain_0",
                new List<string>
                {
                    "DesertCanyon_TouhouGW_HiganRetour~RiversideView",
                    "DesertCanyon_PMDSky_MtHorn",
                    "DesertCanyon_PMDGTI_StompstumpPeak",
                    "DesertCanyon_PMDBRT_GreatCanyonRemastered",
                    "DesertCanyon_PMDGTI_Holehills"
                }
            },
            {
                "World Map terrain_Desert Canyon terrain_Subterranean",
                new List<string>
                {
                    "DesertCanyon_PMDSky_AmpPlains",
                    "RustWells_ShirenMD1DS_TaintedPath",
                    "DesertCanyon_PMDBRT_GreatCanyonRemix"
                }
            },
            {
                "World Map terrain_Flower Fields terrain_0",
                new List<string>
                {
                    "FlowerFields_EtrianMD1_ChalkyWoods",
                    "FlowerFields_TouhouGW_StrangeEverydayLifeOfTheFlyingShrineMaiden",
                    "FlowerFields_TouhouGW_TheGensokyoTheGodsLoved"
                }
            },
            {
                "World Map terrain_Flower Fields terrain_Subterranean",
                new List<string>
                {
                    "Ruins_TalesOfMajEyal_WorldOfIce",
                    "LakeHinnom_TalesOfMajEyal_RainyDay"
                }
            },
            {
                "World Map terrain_Hills terrain_0",
                new List<string>
                {
                    "Hills_PMDGTI_RaggedMountain",
                    "Hills_PMDGTI_HazyPass",
                    "Hills_TheLegendOfHeroes_SecretGreenPassage"
                }
            },
            {
                "World Map terrain_Hills terrain_Subterranean",
                new List<string>
                {
                    "Hills_PMDGTI_RaggedMountainRemix",
                    "RustedArchway_PokemonBW_Route10",
                    "Hills_TheLegendOfHeroes_SecretGreenPassage"
                }
            },
            {
                "World Map terrain_Jungle terrain_0",
                new List<string>
                {
                    "Jungle_TouhouGW_RetrospectiveKyoto",
                    "Jungle_TouhouGW_MagusNight",
                    "Jungle_PSMD_LushForest",
                    "Jungle_BindingOfIsaacRepented_Agony"
                }
            },
            {
                "World Map terrain_Jungle terrain_Subterranean",
                new List<string>
                {
                    "Jungle_PSMD_LushForestRemix",
                    "Jungle_BindingOfIsaacExcelsior_SixFeetUnder",
                    "Jungle_BindingOfIsaacRepented_Agony"
                }
            },
            {
                "World Map terrain_Lake Hinnom terrain_0",
                new List<string>
                {
                    "LakeHinnom_TouhouGW_DancingWaterDrops",
                    "LakeHinnom_DonkeyKongCountry_AquaticAmbience",
                    "LakeHinnom_PMDBRT_MtFreezeRemastered",
                    "LakeHinnom_BindingOfIsaacRepented_Torrent"
                }
            },
            {
                "World Map terrain_Lake Hinnom terrain_Subterranean",
                new List<string>
                {
                    "HistoricSite2_EtrianMD_WaterfallWoodlands",
                    "LakeHinnom_TalesOfMajEyal_RainyDay"
                }
            },
            {
                "World Map terrain_Moon Stair terrain_0",
                new List<string>
                {
                    "MoonStair_FinalFantasy7_YouCanHearTheCryOfThePlanetRemix",
                    "MoonStair_FinalFantasy7_ThoseChosenByThePlanetRemastered",
                    "BethesdaSusa_PSMD_TreeOfLifeTrunk",
                    "MoonStair_BindingOfIsaacRepented_Incision",
                    "default"
                }
            },
            {
                "World Map terrain_Moon Stair terrain_Roaming Keter of Chavah, the Tree of Life",
                new List<string> { "EynRojRoamingKeter_PSMD_TreeOfLifeTrunkRemix" }
            },
            {
                "World Map terrain_Moon Stair terrain_Subterranean",
                new List<string>
                {
                    "MoonStair_FinalFantasy7_ThoseChosenByThePlanetRemastered2",
                    "MoonStair_PMDBRT_MtThunderPeakRemastered",
                    "BethesdaSusa_PSMD_TreeOfLifeTrunk"
                }
            },
            {
                "World Map terrain_Mountains terrain_0",
                new List<string>
                {
                    "Mountains_PMDGTI_DaybreakRidge",
                    "Mountains_PMDGTI_HazyPassHighlands",
                    "Mountains_PMDBRT_MtThunderRemastered"
                }
            },
            {
                "World Map terrain_Mountains terrain_Subterranean",
                new List<string>
                {
                    "Mountains_PMDRRT_MtThunder",
                    "Mountains_PMDGTI_IllusoryHazyPass"
                }
            },
            {
                "World Map terrain_Palladium Reef terrain_0",
                new List<string>
                {
                    "PalladiumReef_PMDBRT_MtFreezePeakRemastered2",
                    "PalladiumReef_PSMD_DepthsOfTheSubmergedCave",
                    "PalladiumReef_DonkeyKongCountry_AquaticAmbienceBardcoreCover"
                }
            },
            {
                "World Map terrain_Palladium Reef terrain_Subterranean",
                new List<string>
                {
                    "PalladiumReef_Elona_Dungeon1",
                    "PalladiumReef_PMDBRT_MtFreezePeak",
                    "PalladiumReef_PSMD_DepthsOfTheSubmergedCave"
                }
            },
            {
                "World Map terrain_Rainbow Woods terrain_0",
                new List<string>
                {
                    "RainbowWood_Tangledeep_MiraiTheHeroine",
                    "RainbowWood_Tangledeep_MysteriesOfTime",
                    "RainbowWood_Elona_Dungeon6"
                }
            },
            {
                "World Map terrain_Rainbow Woods terrain_Subterranean",
                new List<string>
                {
                    "RainbowWood_Elona_Dungeon5",
                    "RainbowWood_DivinityOS2_MaraisExsanguesFortJoyBridge",
                    "RainbowWood_BindingOfIsaacRepentance_Stargazer"
                }
            },
            {
                "World Map terrain_Rivers terrain_0",
                new List<string>
                {
                    "Rivers_CastlevaniaCurseOfDarkness_MortviaFountain",
                    "Rivers_NierAutomata_CityRuinsRaysOfLightVocal",
                    "Rivers_FinalFantasy10HD_SilenceBeforeTheStorm",
                    "Rivers_BindingOfIsaacRepented_ParishedExistence"
                }
            },
            {
                "World Map terrain_Rivers terrain_Subterranean",
                new List<string>
                {
                    "Rivers_CastlevaniaCurseOfDarkness_GaribaldiCourtyard",
                    "Rivers_NierAutomata_CityRuinsRaysOfLight"
                }
            },
            {
                "World Map terrain_Ruins terrain_0",
                new List<string>
                {
                    "Music/Deep Dawn",
                    "RuinsRegion_PMDGTI_TyrianMazeInnerChamber",
                    "RuinsRegion_PMDRRT_BuriedRelic",
                    "RuinsRegion_TheBindingOfIsaacAntibirth_FaultLines",
                    "RuinsRegion_BindingOfIsaacRepented_Sepulchre",
                    "Music/Deep Dawn"
                }
            },
            {
                "World Map terrain_Ruins terrain_Subterranean",
                new List<string>
                {
                    "RuinsRegion_PMDGTI_KilioneaRoad",
                    "RuinsRegion_PMDGTI_TyrianMazeInnerChamber",
                    "RuinsRegion_TalesOfMajEyal_Mystery"
                }
            },
            {
                "World Map terrain_Salt Desert terrain_0",
                new List<string>
                {
                    "SaltDesert_BindingOfIsaacRepented_Predicament",
                    "SaltDesert_PMDSky_QuicksandPit",
                    "SaltDesert_PMDSky_NorthernDesert",
                    "SaltDesert_PMDGTI_WitheredSavannah",
                    "SaltDesert_BindingOfIsaacRepented_Predicament"
                }
            },
            {
                "World Map terrain_Salt Desert terrain_Subterranean",
                new List<string>
                {
                    "SaltDesert_Persona5_WhenMotherWasThere",
                    "SaltDesert_PMDGTI_ScorchingDesert"
                }
            },
            {
                "World Map terrain_Salt Marshes terrain_0",
                new List<string>
                {
                    "SaltMarsh_BindingOfIsaacRepented_LostInGuilt",
                    "SaltMarsh_TouhouGW_FragrantPlants",
                    "SaltMarsh_PSMD_PoliwrathRiver",
                    "SaltMarsh_PSMD_SchoolForest",
                    "SaltMarsh_PMDSky_FoggyForest",
                    "SaltMarsh_TheBindingOfIsaacAntibirth_InnocenceGlitched",
                    "SaltMarsh_BindingOfIsaacRepented_LostInGuilt"
                }
            },
            {
                "World Map terrain_Salt Marshes terrain_Subterranean",
                new List<string>
                {
                    "SaltMarsh_PSMD_NoeTown",
                    "Underground_BindingOfIsaacWrathOfTheLamb_Sacrificial"
                }
            },
            {
                "Underground_Tier 2 (formula starts at 2)",
                new List<string>
                {
                    "TombOfTheEaters_CastlevaniaDawnofSorrow_LePinacle",
                    "Underground_BindingOfIsaacWrathOfTheLamb_Sacrificial",
                    "Underground_BindingOfIsaacWrathOfTheLamb_AMournerUntoSheol",
                    "RuinsRegion_TalesOfMajEyal_Mystery",
                    "SaltMarsh_BindingOfIsaacRepented_LostInGuilt"
                }
            },
            {
                "Underground_Tier 3",
                new List<string>
                {
                    "Underground_CastlevaniaCurseOfDarkness_AiolonCaveTemple",
                    "HistoricSite2_BindingOfIsaacExcelsior_Ascent",
                    "MoonStair_PMDBRT_MtThunderPeakRemastered",
                    "Underground_BindingOfIsaacRepented_DesolateAbyss",
                    "RuinsRegion_TalesOfMajEyal_Mystery"
                }
            },
            {
                "Underground_Tier 4",
                new List<string>
                {
                    "TombOfTheEaters_CastlevaniaDawnOfSorrow_CondemnedTower",
                    "RainbowWood_Tangledeep_MysteriesOfTime",
                    "Underground_BindingOfIsaacAntibirth_Morphine",
                    "TombOfTheEaters_PMDSky_SealedRuin",
                    "BaroqueRuins_TouhouGW_MysticDream~SnowOrCherryPetal"
                }
            },
            {
                "Underground_Tier 5",
                new List<string>
                {
                    "HistoricSite2_PMDSky_VastIceMountain",
                    "Lair5-6_PMDSky_IcicleForest",
                    "AsphaltMines_PMDSky_SpringCaveDepths",
                    "BaroqueRuins_PSMD_PrehistoricRuins",
                    "Hills_TheLegendOfHeroes_SecretGreenPassage",
                    "SaltDesert_PMDGTI_ScorchingDesert"
                }
            },
            {
                "Underground_Tier 6",
                new List<string>
                {
                    "Underground_FinalFantasy4Advance_Zeromus",
                    "BethesdaSusa_PMDSky_SkyPeakSnowfield",
                    "Underground_PMDSky_SealedRuinPit",
                    "Lair3_CavernsOfXaskazien2_m07",
                    "BethesdaSusa_PMDGTI_GreatGlacierCrystalTower",
                    "AsphaltMines_PMDBRT_MtBlazeRemix",
                    "TombOfTheEaters_TalesOfMajEyal_TheAncients"
                }
            },
            {
                "Underground_Tier 7",
                new List<string>
                {
                    "Lair8_Elona_ZeomeTheFalseProphet",
                    "Underground_FinalFantasy4SNES_LunarSubterrane",
                    "AsphaltMines_ChocoboEB_GuardianDarkness",
                    "Lair3-4-7_FinalFantasy8_DontBeAfraid",
                    "Lair7_BindingOfIsaacRepentance_Absentia",
                    "TombOfTheEaters_CavernsOfXaskazien2_m08",
                    "Lair8_TheLegendOfHeroes_HollowLightOfTheSealedLand"
                }
            },
            {
                "Underground_Tier 8",
                new List<string>
                {
                    "Underground_Elona_Dungeon15",
                    "Lair8_Elona_ZeomeTheFalseProphet",
                    "AsphaltMines_PMDSky_SpringCaveDepths",
                    "Underground_FinalFantasy4SNES_LunarSubterrane",
                    "AsphaltMines_PMDBRT_MagmaCavernPitRemix",
                    "Underground_TalesOfMajEyal_Sinestra",
                    "EynRoj_PMDSky_TemporalTower",
                    "Underground_Elona_Dungeon15",
                    "Lair7_TalesOfMajEyal_Far away"
                }
            },
        };
    }
}
