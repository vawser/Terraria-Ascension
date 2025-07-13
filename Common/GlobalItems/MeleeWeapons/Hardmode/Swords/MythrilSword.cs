using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Common.GlobalItems.MeleeWeapons;

public class MythrilSword : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.MythrilSword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.StatsModifiedBy.Add(Mod);

        entity.damage = 70;
        entity.useTime = 20;
        entity.useAnimation = 20;
        entity.autoReuse = true;
    }
}