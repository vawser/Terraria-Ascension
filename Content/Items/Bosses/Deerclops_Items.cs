using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Content.Items.Bosses;

public class PewMaticHorn_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.PewMaticHorn;
    }

    public override void SetDefaults(Item entity)
    {
        entity.useAnimation = 12; // was 15
        entity.useTime = 12; // was 15
    }
}

public class WeatherPain_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WeatherPain;
    }

    public override void SetDefaults(Item entity)
    {
        entity.damage = 20; // was 13
    }
}

public class LucyTheAxe_GlobalItem : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.LucyTheAxe;
    }

    public override void SetDefaults(Item entity)
    {
        entity.crit = 24; // was 14
    }
}
