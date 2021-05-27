using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniCrewmates.Items
{
    class CyanCrewmatePet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Crewmate Pet");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = ModContent.ProjectileType<Projectiles.Pets.CyanCrewmatePet>();
            item.buffType = ModContent.BuffType<Buffs.CrewmatePetBuff>();
        }

        public override void AddRecipes()
        {
            //Recipe goes here for pet
        }

        public override void UseStyle(Player player)
        {            
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }

        }
    }
}
