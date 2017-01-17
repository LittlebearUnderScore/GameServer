﻿namespace LeagueSandbox.GameServer.Enums
{
    public enum BuffType
    {
        Internal,
        Aura,
        CombatEnchancer,
        CombatDehancer,
        SpellShield,
        Stun,
        Invisibility,
        Silence,
        Taunt,
        Polymorph,
        Slow,
        Snare,
        Damage,
        Heal,
        Haste,
        SpellImmunity,
        PhysicalImmunity,
        Invulnerability,
        Sleep,
        NearSight,
        Frenzy,
        Fear,
        Charm,
        Poison,
        Suppression,
        Blind,
        Counter,
        Shred,
        Flee,
        Knockup,
        Knockback,
        Disarm
    }

    public enum Champion
    {
        Unknown = -1,
        Aatrox = 0,
        Ahri = 1,
        Akali = 2,
        Alistar = 3,
        Amumu = 4,
        Anivia = 5,
        Annie = 6,
        Ashe = 7,
        AurelionSol = 8,
        Azir = 9,
        Bard = 10,
        Blitzcrank = 11,
        Brand = 12,
        Braum = 13,
        Caitlyn = 14,
        Camille = 15,
        Cassiopeia = 16,
        Chogath = 17,
        Corki = 18,
        Darius = 19,
        Diana = 20,
        DrMundo = 21,
        Draven = 22,
        Ekko = 23,
        Elise = 24,
        Evelynn = 25,
        Ezreal = 26,
        FiddleSticks = 27,
        Fiora = 28,
        Fizz = 29,
        Galio = 30,
        Gangplank = 31,
        Garen = 32,
        Gnar = 33,
        Gragas = 34,
        Graves = 35,
        Hecarim = 36,
        Heimerdinger = 37,
        Illaoi = 38,
        Irelia = 39,
        Ivern = 40,
        Janna = 41,
        JarvanIV = 42,
        Jax = 43,
        Jayce = 44,
        Jhin = 45,
        Jinx = 46,
        Kalista = 47,
        Karma = 48,
        Karthus = 49,
        Kassadin = 50,
        Katarina = 51,
        Kayle = 52,
        Kennen = 53,
        Khazix = 54,
        Kindred = 55,
        Kled = 56,
        KogMaw = 57,
        Leblanc = 58,
        LeeSin = 59,
        Leona = 60,
        Lissandra = 61,
        Lucian = 62,
        Lulu = 63,
        Lux = 64,
        Malphite = 65,
        Malzahar = 66,
        Maokai = 67,
        MasterYi = 68,
        MissFortune = 69,
        Mordekaiser = 70,
        Morgana = 71,
        Nami = 72,
        Nasus = 73,
        Nautilus = 74,
        Nidalee = 75,
        Nocturne = 76,
        Nunu = 77,
        Olaf = 78,
        Orianna = 79,
        Pantheon = 80,
        Poppy = 81,
        Quinn = 82,
        Rammus = 83,
        RekSai = 84,
        Renekton = 85,
        Rengar = 86,
        Riven = 87,
        Rumble = 88,
        Ryze = 89,
        Sejuani = 90,
        Shaco = 91,
        Shen = 92,
        Shyvana = 93,
        Singed = 94,
        Sion = 95,
        Sivir = 96,
        Skarner = 97,
        Sona = 98,
        Soraka = 99,
        Swain = 100,
        Syndra = 101,
        TahmKench = 102,
        Taliyah = 103,
        Talon = 104,
        Taric = 105,
        Teemo = 106,
        Thresh = 107,
        Tristana = 108,
        Trundle = 109,
        Tryndamere = 110,
        TwistedFate = 111,
        Twitch = 112,
        Udyr = 113,
        Urgot = 114,
        Varus = 115,
        Vayne = 116,
        Veigar = 117,
        Velkoz = 118,
        Vi = 119,
        Viktor = 120,
        Vladimir = 121,
        Volibear = 122,
        Warwick = 123,
        MonkeyKing = 124,
        Xerath = 125,
        XinZhao = 126,
        Yasuo = 127,
        Yorick = 128,
        Zac = 129,
        Zed = 130,
        Ziggs = 131,
        Zilean = 132,
        Zyra = 133
    }

    public enum ClickType
    {
        Attack,
        Move
    }

    public enum CollisionFlags : short
    {
        None = 0,
        Grass = 1,
        Wall = 2,
        Building = 64,
        Prop = 128,
        GlobalVision = 256
    }

    public enum DamageHitType
    {
        Invulnerable = 0,
        Dodge = 2,
        Critical = 3,
        Normal = 4,
        Miss = 5
    }

    public enum DamageType
    {
        Physical,
        Magical,
        True,
        Mixed
    }

    public enum DampenerState
    {
        Alive = 0,
        Destroyed = 1
    }

    public enum DifficultyType
    {
        Intro,
        Tutorial,
        Newbie,
        Intermediate,
        Advanced,
        Uber
    }

    public enum Emote
    {
        Dance,
        Taunt,
        Laugh,
        Joke,
        Toggle
    }

    public enum GameEventId
    {
        OnDelete,
        OnSpawn,
        OnDie,
        OnKill,
        OnChampionDie,
        OnChampionLevelUp,
        OnChampionKillPre,
        OnChampionKill,
        OnChampionKillPost,
        OnChampionSingleKill,
        OnChampionDoubleKill,
        OnChampionTripleKill,
        OnChampionQuadraKill,
        OnChampionPentaKill,
        OnChampionUnrealKill,
        OnFirstBlood,
        OnDamageTaken,
        OnDamageGiven,
        OnSpellCast1,
        OnSpellCast2,
        OnSpellCast3,
        OnSpellCast4,
        OnSpellAvatarCast1,
        OnSpellAvatarCast2,
        OnGoldSpent,
        OnGoldEarned,
        OnItemConsumeablePurchased,
        OnCriticalStrike,
        OnAce,
        OnReincarnate,
        OnChangeChampion,
        OnDampenerKill,
        OnDampenerDie,
        OnDampenerRespawnSoon,
        OnDampenerRespawn,
        OnDampenerDamage,
        OnTurretKill,
        OnTurretDie,
        OnTurretDamage,
        OnMinionKill,
        OnMinionDenied,
        OnNeutralMinionKill,
        OnSuperMonsterKill,
        OnAcquireRedBuffFromNeutral,
        OnAcquireBlueBuffFromNeutral,
        OnHQKill,
        OnHQDie,
        OnHeal,
        OnCastHeal,
        OnBuff,
        OnCrowdControlDealt,
        OnKillingSpree,
        OnKillingSpreeSet1,
        OnKillingSpreeSet2,
        OnKillingSpreeSet3,
        OnKillingSpreeSet4,
        OnKillingSpreeSet5,
        OnKillingSpreeSet6,
        OnKilledUnitOnKillingSpree,
        OnKilledUnitOnKillingSpreeSet1,
        OnKilledUnitOnKillingSpreeSet2,
        OnKilledUnitOnKillingSpreeSet3,
        OnKilledUnitOnKillingSpreeSet4,
        OnKilledUnitOnKillingSpreeSet5,
        OnKilledUnitOnKillingSpreeSet6,
        OnKilledUnitOnKillingSpreeDoubleKill,
        OnKilledUnitOnKillingSpreeTripleKill,
        OnKilledUnitOnKillingSpreeQuadraKill,
        OnKilledUnitOnKillingSpreePentaKill,
        OnKilledUnitOnKillingSpreeUnrealKill,
        OnDeathAssist,
        OnQuit,
        OnLeave,
        OnReconnect,
        OnGameStart,
        OnAssistingSpreeSet1,
        OnAssistingSpreeSet2,
        OnChampionTripleAssist,
        OnChampionPentaAssist,
        OnPing,
        OnPingPlayer,
        OnPingBuilding,
        OnPingOther,
        OnEndGame,
        OnSpellLevelup1,
        OnSpellLevelup2,
        OnSpellLevelup3,
        OnSpellLevelup4,
        OnSpellEvolve1,
        OnSpellEvolve2,
        OnSpellEvolve3,
        OnSpellEvolve4,
        OnItemPurchased,
        OnItemSold,
        OnItemRemoved,
        OnItemUndo,
        OnItemCallout,
        OnItemGroupChange,
        OnItemChange,
        OnUndoEnabledChange,
        OnShopItemSubstitutionChange,
        OnShopMenuOpen,
        OnShopMenuClose,
        OnSurrenderVoteStart,
        OnSurrenderVote,
        OnSurrenderVoteAlready,
        OnSurrenderFailedVotes,
        OnSurrenderTooEarly,
        OnSurrenderAgreed,
        OnSurrenderSpam,
        OnSurrenderEarlyAllowed,
        OnEqualizeVoteStart,
        OnEqualizeVote,
        OnEqualizeVoteAlready,
        OnEqualizeFailedVotes,
        OnEqualizeTooEarly,
        OnEqualizeNotEnoughGold,
        OnEqualizeNotEnoughLevels,
        OnEqualizeAgreed,
        OnEqualizeSpam,
        OnPause,
        OnPauseResume,
        OnMinionsSpawn,
        OnStartGameMessage1,
        OnStartGameMessage2,
        OnStartGameMessage3,
        OnStartGameMessage4,
        OnStartGameMessage5,
        OnAlert,
        OnScoreboardOpen,
        OnAudioEventFinished,
        OnNexusCrystalStart,
        OnCapturePointNeutralized_A,
        OnCapturePointNeutralized_B,
        OnCapturePointNeutralized_C,
        OnCapturePointNeutralized_D,
        OnCapturePointNeutralized_E,
        OnCapturePointCaptured_A,
        OnCapturePointCaptured_B,
        OnCapturePointCaptured_C,
        OnCapturePointCaptured_D,
        OnCapturePointCaptured_E,
        OnCapturePointFiveCap,
        OnVictoryPointThreshold1,
        OnVictoryPointThreshold2,
        OnVictoryPointThreshold3,
        OnVictoryPointThreshold4,
        OnMinionKillVictoryThreshold1,
        OnMinionKillVictoryThreshold2,
        OnTurretKillVictoryThreshold1,
        OnTurretKillVictoryThreshold2,
        OnReplayFastForwardStart,
        OnReplayFastForwardEnd,
        OnReplayOnKeyframeFinished,
        OnReplayDestroyAllObjects,
        OnKillDragon,
        OnKillDragon_Spectator,
        OnKillDragonSteal,
        OnKillWorm,
        OnKillWorm_Spectator,
        OnKillWormSteal,
        OnKillSpiderBoss,
        OnKillSpiderBoss_Spectator,
        OnCaptureAltar,
        OnCaptureAltar_Spectator,
        OnPlaceWard,
        OnKillWard,
        OnMinionAscended,
        OnChampionAscended,
        OnClearAscended,
        OnGameStatEvent,
        OnRelativeTeamColorChange
    }

    public enum GameMapId
    {
        OldSummonersRift = 1,
        CrystalScar = 8,
        TwistedTreeline = 10,
        SummonersRift = 11,
        HowlingAbyss = 12
    }

    public enum GameMode
    {
        Running = 2,
        Paused = 3,
        Finished = 4
    }

    public enum GameObjectCharacterState
    {
        CanAttack = 1,
        CanCast = 2,
        CanMove = 4,
        Immovable = 8,
        IsStealth = 16,
        RevealSpecificUnit = 32,
        Taunted = 64,
        Feared = 128,
        Fleeing = 256,
        Surpressed = 512,
        Asleep = 1024,
        NearSight = 2048,
        Ghosted = 4096,
        GhostProof = 8192,
        Charmed = 16384,
        NoRender = 32768,
        DodgePiercing = 131072,
        DisableAmbientGold = 262144,
        DisableAmbientXP = 524288,
        ForceRenderParticles = 65536
    }

    public enum GameObjectCombatType
    {
        Melee = 1,
        Ranged = 2
    }

    public enum GameObjectOrder
    {
        HoldPosition = 1,
        MoveTo = 2,
        AttackUnit = 3,
        AutoAttackPet = 4,
        AutoAttack = 5,
        MovePet = 6,
        AttackTo = 7,
        Stop = 10
    }

    public enum GameObjectTeam
    {
        Unknown = 0,
        Order = 100,
        Chaos = 200,
        Neutral = 300
    }

    public enum GameObjectType
    {
        NeutralMinionCamp,
        obj_AI_Base,
        FollowerObject,
        FollowerObjectWithLerpMovement,
        AIHeroClient,
        obj_AI_Marker,
        obj_AI_Minion,
        LevelPropAI,
        obj_AI_Turret,
        obj_GeneralParticleEmitter,
        MissileClient,
        DrawFX,
        UnrevealedTarget,
        obj_LampBulb,
        obj_Barracks,
        obj_BarracksDampener,
        obj_AnimatedBuilding,
        obj_Building,
        obj_Levelsizer,
        obj_NavPoint,
        obj_SpawnPoint,
        obj_Lake,
        obj_HQ,
        obj_InfoPoint,
        LevelPropGameObject,
        LevelPropSpawnerPoint,
        obj_Shop,
        obj_Turret,
        GrassObject,
        obj_Ward,
        GameObject,
        Unknown
    }

    public enum GameType
    {
        Normal,
        Dominion,
        Tutorial,
        ARAM,
        FirstBlood,
        Ascension,
        KingPoro,
        Sandbox // xD
    }

    public enum ItemId
    {
        Unknown = 0,
        BootsOfSpeed = 1001,
        FaerieCharm = 1004,
        RejuvenationBead = 1006,
        GiantsBelt = 1011,
        CloakOfAgility = 1018,
        BlastingWand = 1026,
        SapphireCrystal = 1027,
        RubyCrystal = 1028,
        ClothArmor = 1029,
        ChainVest = 1031,
        NullMagicMantle = 1033,
        LongSword = 1036,
        Pickaxe = 1037,
        BFSword = 1038,
        HuntersMachete = 1039,
        Dagger = 1042,
        RecurveBow = 1043,
        BrawlersGloves = 1051,
        AmplifyingTome = 1052,
        VampiricScepter = 1053,
        DoransShield = 1054,
        DoransBlade = 1055,
        DoransRing = 1056,
        NeedlesslyLargeRod = 1058,
        ProspectorsBlade = 1062,
        ProspectorsRing = 1063,
        DoransShield_Showdown = 1074,
        DoransBlade_Showdown = 1075,
        DoransRing_Showdown = 1076,
        SpiritStone = 1080,
        HealthPotion = 2003,
        ManaPotion = 2004,
        TotalBiscuitOfRejuvenation_Pre314 = 2009,
        TotalBiscuitOfRejuvenation_Post314 = 2010,
        ElixirOfFortitude = 2039,
        IchorOfRage = 2040,
        CrystallineFlask = 2041,
        VisionWard = 2043,
        StealthWard = 2044,
        RubySightstone = 2045,
        OraclesExtract = 2047,
        IchorOfIllumination = 2048,
        Sightstone = 2049,
        ExplorersWard = 2050,
        GuardiansHorn = 2051,
        PoroSnax = 2052,
        RaptorCloak = 2053,
        ElixirOfRuin = 2137,
        ElixirOfIron = 2138,
        ElixirOfSorcery = 2139,
        ElixirOfWrath = 2140,
        AbyssalScepter = 3001,
        ArchangelsStaff = 3003,
        Manamune = 3004,
        AtmasImpaler = 3005,
        BerserkersGreaves = 3006,
        ArchangelsStaff_CrystalScar = 3007,
        Manamune_CrystalScar = 3008,
        BootsOfSwiftness = 3009,
        CatalystTheProtector = 3010,
        SorcerersShoes = 3020,
        FrozenMallet = 3022,
        TwinShadows_NoPassive = 3023,
        GlacialShroud = 3024,
        IcebornGauntlet = 3025,
        GuardianAngel = 3026,
        RodOfAges = 3027,
        ChaliceOfHarmony = 3028,
        RodOfAges_CrystalScar = 3029,
        InfinityEdge = 3031,
        LastWhisper = 3035,
        SeraphsEmbrace = 3040,
        MejaisSoulstealer = 3041,
        Muramana = 3042,
        Muramana_CrystalScar = 3043,
        Phage = 3044,
        PhantomDancer = 3046,
        NinjaTabi = 3047,
        SeraphsEmbrace_CrystalScar = 3048,
        ZekesHerald = 3050,
        Ohmwrecker = 3056,
        Sheen = 3057,
        BannerOfCommand = 3060,
        SpiritVisage = 3065,
        Kindlegem = 3067,
        SunfireCape = 3068,
        TalismanOfAscension = 3069,
        TearOfTheGoddess = 3070,
        TheBlackCleaver = 3071,
        TheBloodthirster = 3072,
        TearOfTheGoddess_CrystalScar = 3073,
        RavenousHydra_MeleeOnly = 3074,
        Thornmail = 3075,
        Tiamat_MeleeOnly = 3077,
        TrinityForce = 3078,
        WardensMail = 3082,
        WarmogsArmor = 3083,
        OverlordsBloodmail = 3084,
        RunaansHurricane_RangedOnly = 3085,
        Zeal = 3086,
        StatikkShiv = 3087,
        RabadonsDeathcap = 3089,
        WoogletsWitchcap = 3090,
        WitsEnd = 3091,
        FrostQueensClaim = 3092,
        AvariceBlade = 3093,
        NomadsMedallion = 3096,
        TargonsBrace = 3097,
        Frostfang = 3098,
        LichBane = 3100,
        Stinger = 3101,
        BansheesVeil = 3102,
        LordVanDammsPillager = 3104,
        AegisOfTheLegion = 3105,
        MadredsRazors = 3106,
        FiendishCodex = 3108,
        FrozenHeart = 3110,
        MercurysTreads = 3111,
        OrbOfWinter = 3112,
        AetherWisp = 3113,
        ForbiddenIdol = 3114,
        NashorsTooth = 3115,
        RylaisCrystalScepter = 3116,
        BootsOfMobility = 3117,
        WickedHatchet = 3122,
        ExecutionersCalling = 3123,
        GuinsoosRageblade = 3124,
        DeathfireGrasp = 3128,
        SwordOfTheDivine = 3131,
        TheBrutalizer = 3134,
        VoidStaff = 3135,
        HauntingGuise = 3136,
        DervishBlade = 3137,
        MercurialScimitar = 3139,
        QuicksilverSash = 3140,
        SwordOfTheOccult = 3141,
        YoumuusGhostblade = 3142,
        RanduinsOmen = 3143,
        BilgewaterCutlass = 3144,
        HextechRevolver = 3145,
        HextechGunblade = 3146,
        LiandrysTorment = 3151,
        WillOfTheAncients = 3152,
        BladeOfTheRuinedKing = 3153,
        WrigglesLantern = 3154,
        Hexdrinker = 3155,
        MawOfMalmortius = 3156,
        ZhonyasHourglass = 3157,
        IonianBootsOfLucidity = 3158,
        GrezsSpectralLantern = 3159,
        FeralFlare = 3160,
        Morellonomicon = 3165,
        BonetoothNecklace_Yellow1 = 3166,
        BonetoothNecklace_Yellow2 = 3167,
        BonetoothNecklace_Yellow3 = 3168,
        BonetoothNecklace_Yellow4 = 3169,
        MoonflairBlade = 3170,
        BonetoothNecklace_Yellow5 = 3171,
        Zephyr = 3172,
        AthenesUnholyGrail = 3174,
        HeadOfKhazix_Yellow = 3175,
        OdynsVeil = 3180,
        SanguineBlade = 3181,
        Entopy = 3184,
        TheLightbringer = 3185,
        HextechSweeper = 3187,
        BlackfireTorch = 3188,
        LocketOfTheIronSolari = 3190,
        SeekersArmguard = 3191,
        TheHexCoreMk1 = 3196,
        TheHexCoreMk2 = 3197,
        PerfectHexCore = 3198,
        PrototypeHexCore = 3200,
        QuillCoal_Sight = 3204,
        QuillCoal_Ward = 3205,
        SpiritOfTheSpectralWraith = 3206,
        SpiritOfTheAncientGolem_Ward = 3207,
        SpiritOfTheAncientGolem_Sight = 3208,
        SpiritOfTheElderLizard = 3209,
        SpectresCowl = 3211,
        MikaelsCrucible = 3222,
        EnchantmentHomeguard_BerserkersGreaves = 3250,
        EnchantmentCaptain_BerserkersGreaves = 3251,
        EnchantmentFuror_BerserkersGreaves = 3252,
        EnchantmentDistortion_BerserkersGreaves = 3253,
        EnchantmentAlacricity_BerserkersGreaves = 3254,
        EnchantmentHomeguard_SorcerersShoes = 3255,
        EnchantmentCaptain_SorcerersShoes = 3256,
        EnchantmentFuror_SorcerersShoes = 3257,
        EnchantmentDistortion_SorcerersShoes = 3258,
        EnchantmentAlacricity_SorcerersShoes = 3259,
        EnchantmentHomeguard_NinjaTabi = 3260,
        EnchantmentCaptain_NinjaTabi = 3261,
        EnchantmentFuror_NinjaTabi = 3262,
        EnchantmentDistortion_NinjaTabi = 3263,
        EnchantmentAlacricity_NinjaTabi = 3264,
        EnchantmentHomeguard_MercurysTreads = 3265,
        EnchantmentCaptain_MercurysTreads = 3266,
        EnchantmentFuror_MercurysTreads = 3267,
        EnchantmentDistortion_MercurysTreads = 3268,
        EnchantmentAlacricity_MercurysTreads = 3269,
        EnchantmentHomeguard_BootsOfMobility = 3270,
        EnchantmentCaptain_BootsOfMobility = 3271,
        EnchantmentFuror_BootsOfMobility = 3272,
        EnchantmentDistortion_BootsOfMobility = 3273,
        EnchantmentAlacricity_BootsOfMobility = 3274,
        EnchantmentHomeguard_IonianBootsOfLucidity = 3275,
        EnchantmentCaptain_IonianBootsOfLucidity = 3276,
        EnchantmentFuror_IonianBootsOfLucidity = 3277,
        EnchantmentDistortion_IonianBootsOfLucidity = 3278,
        EnchantmentAlacricity_IonianBootsOfLucidity = 3279,
        EnchantmentHomeguard_BootsOfSwiftness = 3280,
        EnchantmentCaptain_BootsOfSwiftness = 3281,
        EnchantmentFuror_BootsOfSwiftness = 3282,
        EnchantmentDistortion_BootsOfSwiftness = 3283,
        EnchantmentAlacricity_BootsOfSwiftness = 3284,
        TwinShadows_PassiveTrapDetection = 3290,
        AncientCoin = 3301,
        RelicShield = 3302,
        SpellthiefsEdge = 3303,
        WardingTotem_Trinket = 3340,
        SweepingLens_Trinket = 3341,
        ScryingOrb_Trinket = 3342,
        SoulAnchor_Trinket = 3345,
        GreaterStealthTotem_Trinket = 3361,
        GreaterVisionTotem_Trinket = 3362,
        FarsightOrb_Trinket = 3363,
        OraclesLens_Trinket = 3364,
        FaceOfTheMountain = 3401,
        BonetoothNecklace_Red1 = 3405,
        BonetoothNecklace_Red2 = 3406,
        BonetoothNecklace_Red3 = 3407,
        BonetoothNecklace_Red4 = 3408,
        BonetoothNecklace_Red5 = 3409,
        HeadOfKhazix_Red = 3410,
        BonetoothNecklace_Blue1 = 3411,
        BonetoothNecklace_Blue2 = 3412,
        BonetoothNecklace_Blue3 = 3413,
        BonetoothNecklace_Blue4 = 3414,
        BonetoothNecklace_Blue5 = 3415,
        HeadOfKhazix_Blue = 3416,
        BonetoothNecklace_Unknown1 = 3417,
        BonetoothNecklace_Unknown2 = 3418,
        BonetoothNecklace_Unknown3 = 3419,
        BonetoothNecklace_Unknown4 = 3420,
        BonetoothNecklace_Unknown5 = 3421,
        HeadOfKhazix_Unknown = 3422,
        BonetoothNecklace_Revive1 = 3450,
        BonetoothNecklace_Revive2 = 3451,
        BonetoothNecklace_Revive3 = 3452,
        BonetoothNecklace_Revive4 = 3453,
        BonetoothNecklace_Revive5 = 3454,
        HeadOfKhazix_Revive = 3455,
        GoldenTranscendence = 3460,
        ArdentCenser = 3504,
        EssenceReaver = 3508,
        TheBlackSpear = 3599,
        StalkersBlade = 3706,
        EnchantmentWarrior_ChilingSmite = 3707,
        EnchantmentMagus_ChilingSmite = 3708,
        EnchantmentJuggernaut_ChilingSmite = 3709,
        EnchantmentDevourer_ChilingSmite = 3710,
        PoachersKnife = 3711,
        RangersTrailblazer = 3713,
        EnchantmentWarrior_ChallengingSmite = 3714,
        SkirmishersSabre = 3715,
        EnchantmentMagus_ChallengingSmite = 3716,
        EnchantmentJuggernaut_ChallengingSmite = 3717,
        EnchantmentDevourer_ChallengingSmite = 3718,
        EnchantmentWarrior_ScavengingSmite = 3719,
        EnchantmentMagus_ScavengingSmite = 3720,
        EnchantmentJuggernaut_ScavengingSmite = 3721,
        EnchantmentDevourer_ScavengingSmite = 3722,
        EnchantmentWarrior_BlastingSmite = 3723,
        EnchantmentMagus_BlastingSmite = 3724,
        EnchantmentJuggernaut_BlastingSmite = 3725,
        EnchantmentDevourer_BlastingSmite = 3726,
        RighteousGlory = 3800,
        CrystallineBracer = 3801
    }

    public enum MasteryPage
    {
        Offense = 116,
        Defense = 117,
        Utility = 118
    }


}