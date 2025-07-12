using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.damage = 11;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 12;
        entity.autoReuse = true;
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
        entity.damage = 12;
        entity.autoReuse = true;
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
        entity.damage = 12;
        entity.autoReuse = true;
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
        entity.damage = 12;
        entity.autoReuse = true;
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
        entity.damage = 14;
        entity.autoReuse = true;
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
        entity.damage = 15;
        entity.autoReuse = true;
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
        entity.damage = 15;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 12;
        entity.autoReuse = true;
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
        entity.damage = 14;
        entity.autoReuse = true;
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
        entity.damage = 16;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 14;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 15;
        entity.autoReuse = true;
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
        entity.damage = 15;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.autoReuse = true;
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
        entity.damage = 16;
        entity.autoReuse = true;
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
        entity.damage = 14;
        entity.autoReuse = true;
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
        entity.damage = 18;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 18;
        entity.autoReuse = true;
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
        entity.damage = 16;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.crit = 20;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.useTime = 25;
        entity.useAnimation = 25;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.autoReuse = true;
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
        entity.useTime = 40;
        entity.useAnimation = 40;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.autoReuse = true;
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
        entity.damage = 22;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.useTime = 25;
        entity.useAnimation = 25;
        entity.autoReuse = true;
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
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
    }
}

public class FieryGreatsword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FieryGreatsword; // Volcano
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 40;
        entity.useTime = 32;
        entity.useAnimation = 32;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.autoReuse = true;
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
        entity.damage = 32;
        entity.autoReuse = true;
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
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 15;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 30;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 35;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
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
        entity.damage = 10;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 18;
        entity.useTime = 25;
        entity.useAnimation = 25;
        entity.autoReuse = true;
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
        entity.damage = 25;
        entity.useTime = 25;
        entity.useAnimation = 25;
        entity.autoReuse = true;
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
        entity.damage = 20;
        entity.autoReuse = true;
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
        entity.damage = 35;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.velocity = new Vector2(10, 10);
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
        entity.damage = 18;
        entity.velocity = new Vector2(14, 14);
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
        entity.damage = 22;
        entity.velocity = new Vector2(14, 14);
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
        entity.damage = 20;
        entity.velocity = new Vector2(12, 12);
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
        entity.damage = 22;
        entity.velocity = new Vector2(12, 12);
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
        entity.damage = 40;
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
        entity.damage = 30;
        entity.velocity = new Vector2(15, 15);
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
        entity.damage = 15;
        entity.crit = 20;
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
        entity.damage = 20;
        entity.crit = 20;
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
        entity.damage = 20;
        entity.crit = 20;
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
        entity.crit = 20;
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
        entity.damage = 35;
        entity.crit = 20;
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
        entity.damage = 60;
        entity.crit = 20;
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
        entity.damage = 70;
        entity.crit = 30;
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
        entity.damage = 25;
        entity.useTime = 15;
        entity.useAnimation = 15;
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
        entity.damage = 150;
        entity.autoReuse = true;
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
        entity.damage = 150;
        entity.autoReuse = true;
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
        entity.damage = 150;
        entity.autoReuse = true;
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
        entity.damage = 130;
        entity.autoReuse = true;
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
        entity.damage = 120;
        entity.autoReuse = true;
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
        entity.damage = 130;
        entity.autoReuse = true;
    }
}

public class DD2SquireDemonSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DD2SquireDemonSword; // Brand of the Inferno
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 125;
        entity.autoReuse = true;
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
        entity.damage = 100;
        entity.autoReuse = true;
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
        entity.damage = 120;
        entity.autoReuse = true;
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
        entity.damage = 80;
        entity.autoReuse = true;
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
        entity.damage = 100;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 80;
        entity.autoReuse = true;
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
        entity.damage = 90;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 100;
        entity.autoReuse = true;
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
        entity.damage = 90;
        entity.useTime = 30;
        entity.useAnimation = 30;
        entity.autoReuse = true;
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
        entity.damage = 75;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 75;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.crit = 20;
        entity.knockBack = 1.0f;
        entity.autoReuse = true;
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
        entity.damage = 70;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
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
        entity.damage = 65;
        entity.autoReuse = true;
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
        entity.damage = 75;
        entity.useTime = 12;
        entity.useAnimation = 12;
        entity.autoReuse = true;
    }
}

public class DeathSickle_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DeathSickle;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.autoReuse = true;
    }
}
public class SlapHand_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.SlapHand;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 50;
        entity.crit = 50;
        entity.autoReuse = true;
    }
}
public class Bladetongue_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Bladetongue;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.useTime = 25;
        entity.useAnimation = 25;
        entity.autoReuse = true;
    }
}
public class Cutlass_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Cutlass;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.useTime = 10;
        entity.useAnimation = 10;
        entity.autoReuse = true;
    }
}
public class BeamSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BeamSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.useTime = 16;
        entity.useAnimation = 16;
        entity.autoReuse = true;
    }
}
public class IceSickle_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.IceSickle;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.useTime = 22;
        entity.useAnimation = 22;
        entity.autoReuse = true;
    }
}
public class MythrilSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MythrilSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
    }
}
public class WaffleIron_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WaffleIron;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 75;
        entity.autoReuse = true;
    }
}
public class Seedler_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Seedler;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class PalladiumSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PalladiumSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
    }
}
public class Frostbrand_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Frostbrand;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
    }
}
public class BluePhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BluePhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class GreenPhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.GreenPhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class OrangePhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.OrangePhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class PurplePhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PurplePhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class RedPhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.RedPhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class WhitePhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WhitePhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class YellowPhasesaber_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.YellowPhasesaber;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.autoReuse = true;
    }
}
public class CobaltSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CobaltSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
    }
}
public class PearlwoodSword_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PearlwoodSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 10;
        entity.autoReuse = true;
    }
}
public class TaxCollectorsStickOfDoom_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TaxCollectorsStickOfDoom;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 50;
        entity.autoReuse = true;
    }
}

#endregion

#region Hard Mode - Yoyos

public class Terrarian_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Terrarian;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 150;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class TheEyeOfCthulhu_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TheEyeOfCthulhu;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 130;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class Kraken_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Kraken;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 110;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class RedsYoyo_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.RedsYoyo;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class ValkyrieYoyo_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ValkyrieYoyo;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class Yelets_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Yelets;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class Code2_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Code2;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 75;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class Gradient_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Gradient;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class Amarok_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Amarok;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class HelFire_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.HelFire;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}

public class FormatC_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FormatC;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}
public class Chik_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Chik;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 55;
        entity.knockBack = 0.1f;
        entity.autoReuse = true;
    }
}
#endregion

#region Hard Mode - Spears

public class NorthPole_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.NorthPole;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 120;
        entity.autoReuse = true;
    }
}

public class ObsidianSwordfish_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ObsidianSwordfish;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.autoReuse = true;
    }
}

public class Gungnir_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Gungnir;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.autoReuse = true;
    }
}

public class MushroomSpear_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MushroomSpear;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 90;
        entity.autoReuse = true;
    }
}

public class AdamantiteGlaive_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.AdamantiteGlaive;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.autoReuse = true;
    }
}

public class ChlorophytePartisan_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ChlorophytePartisan;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 90;
        entity.autoReuse = true;
    }
}

public class TitaniumTrident_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.TitaniumTrident;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.autoReuse = true;
    }
}

public class OrichalcumHalberd_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.OrichalcumHalberd;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.autoReuse = true;
    }
}

public class MythrilHalberd_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MythrilHalberd;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 70;
        entity.autoReuse = true;
    }
}

public class MonkStaffT2_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MonkStaffT2; // Ghastly Glaive
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.autoReuse = true;
    }
}

public class CobaltNaginata_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.CobaltNaginata;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.autoReuse = true;
    }
}

public class PalladiumPike_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PalladiumPike;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.autoReuse = true;
    }
}

#endregion

#region Hard Mode - Boomerangs

public class PaladinsHammer_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PaladinsHammer;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.crit = 25;
        entity.autoReuse = true;
    }
}

public class BouncingShield_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.BouncingShield; // Sergeant United Shield
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 85;
        entity.autoReuse = true;
    }
}

public class PossessedHatchet_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PossessedHatchet;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.autoReuse = true;
    }
}

public class LightDisc_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.LightDisc;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 75;
        entity.autoReuse = true;
    }
}

public class Bananarang_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Bananarang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 60;
        entity.autoReuse = true;
    }
}

public class FlyingKnife_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FlyingKnife;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 75;
        entity.autoReuse = true;
    }
}

#endregion

#region Hard Mode - Flails

public class FlowerPow_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.FlowerPow;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 120;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class DripplerFlail_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DripplerFlail;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 110;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class DaoofPow_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DaoofPow;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class GolemFist_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.GolemFist;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class Anchor_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Anchor;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class Flairon_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Flairon;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 75;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class ChainGuillotines_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ChainGuillotines;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 65;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

public class KOCannon_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.KOCannon;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 55;
        entity.crit = 20;
        entity.autoReuse = true;
    }
}

#endregion

#region Hard Mode - Others

public class Zenith_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Zenith;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 150;
        entity.crit = 4;
        entity.autoReuse = true;
    }
}

public class DayBreak_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.DayBreak;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 150;
        entity.autoReuse = true;
    }
}

public class MonkStaffT3_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MonkStaffT3; // Sky Dragon's Fury
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 140;
        entity.autoReuse = true;
    }
}

public class ShadowJoustingLance_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ShadowJoustingLance;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 200;
        entity.crit = 25;
        entity.autoReuse = true;
    }
}

public class SolarEruption_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.SolarEruption;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.autoReuse = true;
    }
}

public class HallowJoustingLance_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.HallowJoustingLance;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 200;
        entity.crit = 25;
        entity.autoReuse = true;
    }
}

public class PiercingStarlight_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PiercingStarlight;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.autoReuse = true;
    }
}

public class ScourgeoftheCorruptor_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ScourgeoftheCorruptor;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 80;
        entity.useTime = 16;
        entity.useAnimation = 16;
        entity.autoReuse = true;
    }
}

public class JoustingLance_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.JoustingLance;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 150;
        entity.crit = 25;
        entity.autoReuse = true;
    }
}

public class MonkStaffT1_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MonkStaffT1; // Sleepy Octopod
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 75;
        entity.autoReuse = true;
    }
}

public class ShadowFlameKnife_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.ShadowFlameKnife;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 50;
        entity.autoReuse = true;
    }
}

public class VampireKnives_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.VampireKnives;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 40;
        entity.autoReuse = true;
    }
}

public class Arkhalis_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Arkhalis;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 100;
        entity.useTime = 15;
        entity.useAnimation = 15;
        entity.autoReuse = true;
    }
}

#endregion