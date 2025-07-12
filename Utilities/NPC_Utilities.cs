using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;

namespace Ascension.Utilities;

public class NpcUtil
{
    private static readonly List<int> BossNPCs = new List<int>()
    {
        // --- Pre-HM ---
        NPCID.KingSlime,

        NPCID.EyeofCthulhu,

        NPCID.EaterofWorldsHead,
        NPCID.EaterofWorldsBody,
        NPCID.EaterofWorldsTail,

        NPCID.BrainofCthulhu,

        NPCID.QueenBee,

        NPCID.Deerclops,

        NPCID.SkeletronHead,
        NPCID.SkeletronHand,

        NPCID.DungeonGuardian,

        NPCID.WallofFlesh,
        NPCID.WallofFleshEye,
        NPCID.TheHungry,
        NPCID.TheHungryII,

        // --- HM ---
        NPCID.QueenSlimeBoss,

        NPCID.Retinazer,
        NPCID.Spazmatism,

        NPCID.TheDestroyer,
        NPCID.TheDestroyerBody,
        NPCID.TheDestroyerTail,

        NPCID.SkeletronPrime,
        NPCID.PrimeCannon,
        NPCID.PrimeSaw,
        NPCID.PrimeVice,
        NPCID.PrimeLaser,

        NPCID.Plantera,
        NPCID.PlanterasHook,
        NPCID.PlanterasTentacle,

        NPCID.Golem,
        NPCID.GolemHead,
        NPCID.GolemFistLeft,
        NPCID.GolemFistRight,
        NPCID.GolemHeadFree,

        NPCID.HallowBoss, // Empress of Light

        NPCID.DukeFishron,

        NPCID.CultistBoss,
        NPCID.CultistBossClone,
        NPCID.AncientCultistSquidhead,
        NPCID.CultistDragonBody1,
        NPCID.CultistDragonBody2,
        NPCID.CultistDragonBody3,
        NPCID.CultistDragonBody4,
        NPCID.CultistDragonHead,
        NPCID.CultistDragonTail,
        NPCID.AncientLight,
        NPCID.AncientDoom,

        NPCID.MoonLordCore,
        NPCID.MoonLordFreeEye,
        NPCID.MoonLordHand,
        NPCID.MoonLordHead,
        NPCID.MoonLordLeechBlob,

        // --- Event ---
        NPCID.PirateShip,
        NPCID.PirateShipCannon,

        NPCID.MartianSaucer,
        NPCID.MartianSaucerCannon,
        NPCID.MartianSaucerCore,
        NPCID.MartianSaucerTurret,

        NPCID.Everscream,
        NPCID.SantaNK1,
        NPCID.IceQueen,

        NPCID.MourningWood,
        NPCID.Pumpking,
        NPCID.PumpkingBlade,

        NPCID.DD2Betsy,
    };

    public static bool IsBossNPC(NPC self)
    {
        if (BossNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> SolarNPCs = new List<int>()
    {
        NPCID.SolarCrawltipedeHead,
        NPCID.SolarCrawltipedeBody,
        NPCID.SolarCrawltipedeTail,
        NPCID.SolarDrakomire,
        NPCID.SolarDrakomireRider,
        NPCID.SolarSroller,
        NPCID.SolarSolenian,
        NPCID.SolarSpearman,
        NPCID.SolarCorite,
    };
    public static bool IsSolarNPC(NPC self)
    {
        if (SolarNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> VortexNPCs = new List<int>()
    {
        NPCID.VortexRifleman,
        NPCID.VortexHornetQueen,
        NPCID.VortexHornet,
        NPCID.VortexLarva,
        NPCID.VortexSoldier,
    };

    public static bool IsVortexNPC(NPC self)
    {
        if (VortexNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> NebulaNPCs = new List<int>()
    {
        NPCID.NebulaBrain,
        NPCID.NebulaHeadcrab,
        NPCID.NebulaBeast,
        NPCID.NebulaSoldier
    };

    public static bool IsNebulaNPC(NPC self)
    {
        if (NebulaNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> StardustNPCs = new List<int>()
    {
        NPCID.StardustWormHead,
        NPCID.StardustWormBody,
        NPCID.StardustWormTail,
        NPCID.StardustCellBig,
        NPCID.StardustCellSmall,
        NPCID.StardustJellyfishBig,
        NPCID.StardustJellyfishSmall,
        NPCID.StardustSpiderBig,
        NPCID.StardustSpiderSmall,
        NPCID.StardustSoldier
    };

    public static bool IsStardustNPC(NPC self)
    {
        if (StardustNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> PumpkinMoonNPCs = new List<int>()
    {
        305, // Scarecrow
        306, // Scarecrow (v2)
        307, // Scarecrow (v3)
        308, // Scarecrow (v4)
        309, // Scarecrow (v5)
        310, // Scarecrow (v6)
        311, // Scarecrow (v7)
        312, // Scarecrow (v8)
        313, // Scarecrow (v9)
        314, // Scarecrow (v10),
        326, // Splinterling
        329, // Hellhound
        330, // Poltergeist
        316, // Headless Horseman

        NPCID.MourningWood,
        NPCID.Pumpking,
        NPCID.PumpkingBlade,
    };
    public static bool IsPumpkinMoonNPC(NPC self)
    {
        if (PumpkinMoonNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> FrostMoonNPCs = new List<int>()
    {
        341, // Present Mimic
        352, // Flocko
        342, // Gingerbread Man
        338, // Zombie Elf
        339, // Beard Zombie Elf
        340, // Girl Zombie Elf
        350, // Elf Archer
        348, // Nutcracker
        349, // Spinning Nutcracker
        343, // Yeti
        347, // Elf Copter
        351, // Krampus

        NPCID.Everscream,
        NPCID.SantaNK1,
        NPCID.IceQueen,
    };

    public static bool IsFrostMoonNPC(NPC self)
    {
        if (FrostMoonNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> OldOnesArmyNPCs = new List<int>()
    {
        552, // Etherian Goblin (T1)
        553, // Etherian Goblin (T2)
        554, // Etherian Goblin (T3)
        555, // Etherian Goblin Bomber (T1)
        556, // Etherian Goblin Bomber (T2)
        557, // Etherian Goblin Bomber (T3)
        561, // Etherian Javelin Thrower (T1)
        562, // Etherian Javelin Thrower (T2)
        563, // Etherian Javelin Thrower (T3)
        558, // Etherian Wyvern (T1)
        559, // Etherian Wyvern (T2)
        560, // Etherian Wyvern (T3)
        564, // Dark Mage (T1)
        565, // Dark Mage (T3)
        566, // Old One's Skeleton (T1)
        567, // Old One's Skeleton (T3)

        572, // Kobold (T2)
        573, // Kobold (T3)
        570, // Drakin (T2)
        571, // Drakin (T3)
        574, // Kobold Glider (T2)
        575, // Kobold Glider (T2)
        568, // Wither Beast (T2)
        569, // Wither Beast (T2)
        576, // Ogre (T2)
        577, // Ogre (T2)

        578, // Etherian Lightning Bug

        NPCID.DD2Betsy,
    };

    public static bool IsOldOnesArmyNPC(NPC self)
    {
        if (OldOnesArmyNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> PirateNPCs = new List<int>()
    {
        NPCID.PirateCorsair,
        NPCID.PirateDeckhand,
        NPCID.PirateDeadeye,
        NPCID.PirateCrossbower,
        NPCID.PirateCaptain,
        NPCID.Parrot,
        NPCID.PirateGhost,
        NPCID.PirateShip,
        NPCID.PirateShipCannon,
    };

    public static bool IsPirateNPC(NPC self)
    {
        if (PirateNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }

    private static readonly List<int> MartianNPCs = new List<int>()
    {
        NPCID.MartianSaucer,
        NPCID.MartianSaucerCannon,
        NPCID.MartianSaucerCore,
        NPCID.MartianSaucerTurret,
        NPCID.Scutlix,
        NPCID.ScutlixRider,
        NPCID.MartianWalker,
        NPCID.MartianDrone,
        NPCID.GigaZapper,
        NPCID.MartianEngineer,
        NPCID.MartianOfficer,
        NPCID.RayGunner,
        NPCID.GrayGrunt,
        NPCID.BrainScrambler,
        NPCID.MartianTurret
    };

    public static bool IsMartianNPC(NPC self)
    {
        if (MartianNPCs.Contains(self.type))
        {
            return true;
        }

        return false;
    }
}
