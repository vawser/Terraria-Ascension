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
        int ftwAddition = 0;

        // For the Worthy seed
        if(Main.getGoodWorld)
        {
            ftwAddition = 1;
        }

        // Apply scaling for this NPC
        if (ignoreScaling == 0)
        {
            // Knockback Resistance
            self.knockBackResist += gameModeData.KnockbackToEnemiesMultiplier;

            // Journey
            if (gameModeData.IsJourneyMode)
            {
                // Life
                self.lifeMax = (int)(self.lifeMax * 1.0f);

                // Damage
                self.damage = (int)(self.damage * 1.0f);

                // Money Drop
                self.value = self.value * 1.0f;
            }

            // Classic
            if(!gameModeData.IsJourneyMode && !gameModeData.IsExpertMode && !gameModeData.IsMasterMode)
            {
                // Life
                self.lifeMax = (int)(self.lifeMax * 1.0f + ftwAddition);

                // Damage
                self.damage = (int)(self.damage * 1.0f + ftwAddition);

                // Money Drop
                self.value = self.value * 3.0f + ftwAddition;
            }

            // Expert: +50% damage taken, +300% money drop
            if (gameModeData.IsExpertMode && !gameModeData.IsMasterMode)
            {
                // Life
                self.lifeMax = (int)(self.lifeMax * 1.0f + ftwAddition);

                // Damage
                if (NpcUtil.IsBossNPC(self))
                {
                    self.damage = (int)(self.damage * 1.5f + ftwAddition);
                }
                else
                {
                    self.damage = (int)(self.damage * 2.0f + ftwAddition);
                }

                // Money Drop
                self.value = self.value * 4.0f + ftwAddition;
            }

            // Master: +100% damage taken, +400% money drop
            if (gameModeData.IsMasterMode)
            {
                // Life
                self.lifeMax = (int)(self.lifeMax * 1.0f + ftwAddition);

                // Damage
                if (NpcUtil.IsBossNPC(self))
                {
                    self.damage = (int)(self.damage * 2.0f + ftwAddition);
                }
                else
                {
                    self.damage = (int)(self.damage * 3.0f + ftwAddition);
                }

                // Money Drop
                self.value = self.value * 5.0f + ftwAddition;
            }
        }
    }
}
