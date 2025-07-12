using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace Ascension.Content.Items.Weapons;

#region Normal Mode - Swords
public class CopperShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CopperShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 5;
    }
}

public class WoodenSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WoodenSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 7;
    }
}

public class TinShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TinShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 7;
    }
}

public class RichMahoganySword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.RichMahoganySword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 8;
    }
}

public class BorealWoodSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BorealWoodSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 8;
    }
}

public class PalmWoodSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PalmWoodSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 8;
    }
}

public class CactusSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CactusSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
    }
}

public class CopperBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CopperBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 9;
    }
}

public class IronShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.IronShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 8;
    }
}

public class TinBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TinBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
    }
}

public class LeadShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.LeadShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 9;
    }
}

public class SilverShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.SilverShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 9;
    }
}

public class Umbrella_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Umbrella;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
    }
}

public class BreathingReed_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BreathingReed;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
    }
}

public class EbonwoodSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.EbonwoodSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class ShadewoodSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ShadewoodSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class IronBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.IronBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 12;
    }
}

public class TungstenShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TungstenShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
    }
}

public class LeadBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.LeadBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 13;
    }
}

public class SilverBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.SilverBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class TungstenBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TungstenBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class GoldShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.GoldShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 12;
    }
}

public class ZombieArm_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ZombieArm;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 15;
    }
}

public class Ruler_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Ruler;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 12;
    }
}

public class BladedGlove_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BladedGlove;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class AshWoodSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.AshWoodSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 13;
    }
}

public class GoldBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.GoldBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 15;
    }
}

public class PlatinumShortsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PlatinumShortsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 13;
    }
}

public class AntlionClaw_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.AntlionClaw;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 16;
    }
}

public class StylistKilLaKillScissorsIWish_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.StylistKilLaKillScissorsIWish;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class PlatinumBroadsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PlatinumBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 16;
    }
}

public class Flymeal_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Flymeal;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 15;
    }
}

public class Gladius_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Gladius;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 15;
    }
}

public class BoneSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BoneSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 19;
    }
}

public class Katana_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Katana;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 18;
    }
}

public class CandyCaneSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CandyCaneSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 19;
    }
}

public class IceBlade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.IceBlade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 17;
    }
}

public class BatBat_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BatBat;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 36;
    }
}

public class LightsBane_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.LightsBane;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 16;
    }
}

public class TentacleSpike_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TentacleSpike;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 20;
    }
}

public class DyeTradersScimitar_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DyeTradersScimitar;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 20;
    }
}

public class BloodButcherer_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BloodButcherer;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 22;
    }
}

public class Starfury_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Starfury;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 25;
    }
}

public class EnchantedSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.EnchantedSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 23;
    }
}

public class PurpleClubberfish_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PurpleClubberfish;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 35;
    }
}

public class FalconBlade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FalconBlade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 25;
    }
}

public class BladeofGrass_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BladeofGrass;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 18;
    }
}

public class BluePhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BluePhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 26;
    }
}

public class GreenPhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.GreenPhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 26;
    }
}

public class OrangePhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.OrangePhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 26;
    }
}

public class PurplePhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PurplePhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 26;
    }
}

public class RedPhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.RedPhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 26;
    }
}

public class WhitePhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WhitePhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class YellowPhaseblade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.YellowPhaseblade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class FieryGreatsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FieryGreatsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 40;
    }
}

public class BeeKeeper_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BeeKeeper;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 30;
    }
}

public class TragicUmbrella_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TragicUmbrella;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 15;
    }
}

public class Muramasa_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Muramasa;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 24;
    }
}

public class NightsEdge_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.NightsEdge;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 40;
    }
}

#endregion

#region Normal Mode - Yoyos

public class WoodYoyo_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WoodYoyo;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 9;
    }
}

public class Rally_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Rally;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class CorruptYoyo_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CorruptYoyo; // Malaise
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 16;
    }
}

public class CrimsonYoyo_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CrimsonYoyo; // Artery
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 17;
    }
}

public class JungleYoyo_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.JungleYoyo; // Amazon
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 18;
    }
}

public class Code1_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Code1;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 21;
    }
}

public class HiveFive_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.HiveFive;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 1241;
    }
}

public class Valor_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Valor;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 28;
    }
}

public class Cascade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Cascade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 27;
    }
}


#endregion

#region Normal Mode - Spears

public class Spear_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Spear;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 8;
    }
}

public class ThunderSpear_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ThunderSpear;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class Trident_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Trident;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 14;
    }
}

public class TheRottedFork_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TheRottedFork;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 17;
    }
}

public class Swordfish_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Swordfish;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 19;
    }
}

public class DarkLance_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DarkLance;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 34;
    }
}

#endregion

#region Normal Mode - Boomerangs

public class WoodenBoomerang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WoodenBoomerang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
    }
}

public class EnchantedBoomerang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.EnchantedBoomerang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 17;
    }
}

public class Shroomerang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Shroomerang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 23;
    }
}

public class FruitcakeChakram_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FruitcakeChakram;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 19;
    }
}

public class BloodyMachete_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BloodyMachete;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 20;
    }
}

public class IceBoomerang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.IceBoomerang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 21;
    }
}

public class ThornChakram_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ThornChakram;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 25;
    }
}

public class Flamarang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Flamarang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 49;
    }
}

public class Trimarang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Trimarang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 21;
    }
}

public class CombatWrench_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CombatWrench;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 25;
    }
}

#endregion

#region Normal Mode - Flails

public class ChainKnife_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ChainKnife;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 12;
    }
}

public class Mace_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Mace;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 18;
    }
}

public class FlamingMace_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FlamingMace;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 18;
    }
}

public class BallOHurt_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BallOHurt;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 30;
    }
}

public class TheMeatball_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TheMeatball;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 34;
    }
}

public class BlueMoon_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BlueMoon;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 54;
    }
}

public class Sunfury_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Sunfury;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 64;
    }
}

#endregion

#region Normal Mode - Others

public class Terragrim_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Terragrim;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 17;
    }
}

#endregion

#region Hard Mode - Swords

public class Meowmere_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Meowmere;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 200;
    }
}

public class DD2SquireBetsySword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DD2SquireBetsySword; // Flying Dragon
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 180;
    }
}

public class StarWrath_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.StarWrath;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 170;
    }
}

public class TheHorsemansBlade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TheHorsemansBlade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 150;
    }
}

public class Keybrand_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Keybrand;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 105;
    }
}

public class InfluxWaver_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.InfluxWaver;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DD2SquireDemonSword; // Brand of the Inferno
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 95;
    }
}

public class ChlorophyteClaymore_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ChlorophyteClaymore;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 95;
    }
}

public class ChristmasTreeSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ChristmasTreeSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 86;
    }
}

public class PsychoKnife_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PsychoKnife;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 85;
    }
}

public class TerraBlade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TerraBlade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 85;
    }
}

public class Excalibur_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Excalibur;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 72;
    }
}

public class TrueExcalibur_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TrueExcalibur;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 72;
    }
}

public class BreakerBlade_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BreakerBlade;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
    }
}

public class TrueNightsEdge_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TrueNightsEdge;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
    }
}

public class AdamantiteSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.AdamantiteSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 61;
    }
}

public class TitaniumSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TitaniumSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 61;
    }
}

public class FetidBaghnakhs_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FetidBaghnakhs;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
    }
}

public class OrichalcumSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.OrichalcumSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 59;
    }
}

public class HamBat_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.HamBat;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 57;
    }
}

public class ChlorophyteSaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ChlorophyteSaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 57;
    }
}

#endregion

#region Hard Mode - Yoyos

public class DeathSickle_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DeathSickle;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

#endregion

#region Hard Mode - Spears

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

#endregion

#region Hard Mode - Boomerangs

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

#endregion

#region Hard Mode - Flails

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

#endregion

#region Hard Mode - Others

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

public class XXX_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.XXX;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 11;
    }
}

#endregion