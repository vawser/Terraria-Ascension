using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Ascension.Common.Systems;


public class PlayerManaRegenTweak : ModSystem
{
    public override void Load()
    {
        Terraria.On_Player.UpdateManaRegen += ASC_UpdateManaRegen;
    }

    private void ASC_UpdateManaRegen(On_Player.orig_UpdateManaRegen orig, Player self)
    {
        // Mana Booster from Nebula Armor
        if (self.nebulaLevelMana > 0)
        {
            int num = 6;

            self.nebulaManaCounter += self.nebulaLevelMana;

            if (self.nebulaManaCounter >= num)
            {
                self.nebulaManaCounter -= num;

                ++self.statMana;

                if (self.statMana >= self.statManaMax2)
                {
                    self.statMana = self.statManaMax2;
                }
            }
        }
        else
        {
            self.nebulaManaCounter = 0;
        }

        // Mana Regeneration Delay
        if ((double)self.manaRegenDelay > 0.0)
        {
            --self.manaRegenDelay;

            self.manaRegenDelay -= self.manaRegenDelayBonus;

            if (self.manaRegenBuff)
            {
                --self.manaRegenDelay;
            }

            if (self.usedArcaneCrystal)
            {
                self.manaRegenDelay -= 0.05f;
            }
        }

        // Mana Regeneration buff: Maximum regeneration delay to use
        if (self.manaRegenBuff && (double)self.manaRegenDelay > 20.0)
        {
            self.manaRegenDelay = 20f;
        }

        if ((double)self.manaRegenDelay <= 0.0)
        {
            self.manaRegenDelay = 0.0f;
            self.manaRegen = self.statManaMax2 / 3 + 1 + self.manaRegenBonus;

            if (self.manaRegenBuff)
            {
                self.manaRegen += self.statManaMax2 / 3;
            }

            if (self.usedArcaneCrystal)
            {
                self.manaRegen += self.statManaMax2 / 50;
            }

            float num = (float)((double)self.statMana / (double)self.statManaMax2 * 0.8 + 0.2);

            if (self.manaRegenBuff)
            {
                num = 1f;
            }

            self.manaRegen = (int)((double)self.manaRegen * (double)num * 1.15);
        }
        else
        {
            self.manaRegen = 0;
        }

        self.manaRegenCount += self.manaRegen;

        while (self.manaRegenCount >= 120)
        {
            bool flag = false;

            self.manaRegenCount -= 120;

            if (self.statMana < self.statManaMax2)
            {
                ++self.statMana;

                flag = true;
            }
            if (self.statMana >= self.statManaMax2)
            {
                if (self.whoAmI == Main.myPlayer & flag)
                {
                    SoundEngine.PlaySound(SoundID.MaxMana);

                    for (int index1 = 0; index1 < 5; ++index1)
                    {
                        int index2 = Dust.NewDust(self.position, self.width, self.height, 45, Alpha: (int)byte.MaxValue, newColor: new Color(), Scale: (float)Main.rand.Next(20, 26) * 0.1f);
                        Main.dust[index2].noLight = true;
                        Main.dust[index2].noGravity = true;
                        Dust dust = Main.dust[index2];
                        dust.velocity = Vector2.Multiply(dust.velocity, 0.5f);
                    }
                }
                self.statMana = self.statManaMax2;
            }
        }
    }
}


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
