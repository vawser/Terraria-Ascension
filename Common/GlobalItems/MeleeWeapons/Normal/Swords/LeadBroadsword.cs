using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Common.GlobalItems.MeleeWeapons;

public class LeadBroadsword : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.LeadBroadsword;
    }

    public override void SetDefaults(Item entity)
    {
        entity.StatsModifiedBy.Add(Mod);

        entity.damage = 14;
        entity.autoReuse = true;
    }
}