using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Common.Systems;

public class MagicSicknessTweak : ModPlayer
{
    public override void PreUpdateBuffs()
    {
        if(Player.HasBuff(BuffID.ManaSickness))
        {
            Player.ClearBuff(BuffID.ManaSickness);
        }
    }
}
