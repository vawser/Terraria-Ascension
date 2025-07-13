using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Common.GlobalItems.MeleeWeapons;

public class WoodenBoomerang : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.WoodenBoomerang;
    }

    public override void SetDefaults(Item entity)
    {
        entity.StatsModifiedBy.Add(Mod);

        entity.damage = 10;
        entity.velocity = new Vector2(10, 10);
    }
}