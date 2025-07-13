using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Ascension.Content.Players;

// Credit to RedRam567 (https://github.com/RedRam567/PlayerLightMod)
public class PlayerLight : ModPlayer
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