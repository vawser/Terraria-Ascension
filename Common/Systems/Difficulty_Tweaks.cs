using Ascension.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Common.Systems;

public class DifficultyTweaks : ModSystem
{
    public override void Load()
    {
        Terraria.On_NPC.ScaleStats_ApplyGameMode += ASC_ScaleStats_ApplyGameMode;
    }

    private static void ASC_ScaleStats_ApplyGameMode(On_NPC.orig_ScaleStats_ApplyGameMode orig, NPC self, GameModeData gameModeData)
    {
        int ignoreScaling = self.type < 0 ? 0 : (NPCID.Sets.ProjectileNPC[self.type] ? 1 : 0);

        // Apply scaling for this NPC
        if (ignoreScaling == 0)
        {
            // Life
            self.lifeMax = (int)(self.lifeMax * 1.0f);

            // Knockback Resistance
            self.knockBackResist *= gameModeData.KnockbackToEnemiesMultiplier;

            // Money Drop
            self.value = self.value * 5.0f;

            if (gameModeData.IsMasterMode)
            {
                // Damage
                if (NpcUtil.IsBossNPC(self))
                {
                    self.damage = (int)(self.damage * 2.0f);
                }
                else
                {
                    self.damage = (int)(self.damage * 3.0f);
                }
            }
            else if(gameModeData.IsExpertMode)
            {
                // Damage
                if (NpcUtil.IsBossNPC(self))
                {
                    self.damage = (int)(self.damage * 1.5f);
                }
                else
                {
                    self.damage = (int)(self.damage * 2.0f);
                }
            }
        }
    }
}
