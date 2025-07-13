using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Ascension.Common.Systems;

public class BaseTweaks : ModPlayer
{
    public override void PostUpdateMiscEffects()
    {
        // 120% vanilla movement speed
        Player.moveSpeed *= 1.2f;

        // 200% vanilla mining speed
        Player.pickSpeed *= (float)0.5;

        // 200% vanilla wall place speed
        Player.wallSpeed *= (float)0.5;

        // 200% vanilla tile place speed
        Player.tileSpeed *= (float)0.5;
    }
}

