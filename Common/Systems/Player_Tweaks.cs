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


public class PlayerMovementTweak : ModPlayer
{
    public override void PostUpdateMiscEffects()
    {
        // 120% vanilla movement speed
        Player.moveSpeed *= 1.2f;

        // 200% vanilla mining speed
        Player.pickSpeed *= (float)0.5;

        // 200% vanilla wall place speed
        Player.wallSpeed *= (float)0.5;
    }
}

// Credit to RedRam567 (https://github.com/RedRam567/PlayerLightMod)
public class PlayerLightTweak : ModPlayer
{
    public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
    {
        if (Ascension.ConfigClient.LightBrightness < Ascension.ConfigServer.LightBrightness)
        {
            if (Ascension.ConfigClient.LightEnabled)
            {
                Lighting.AddLight(drawInfo.Position, Ascension.ConfigClient.LightColor);
            }
        }
        else
        {
            if (Ascension.ConfigServer.LightEnabled)
            {
                Lighting.AddLight(drawInfo.Position, Ascension.ConfigServer.LightColor);
            }
        }

    }
}