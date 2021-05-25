using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace MiniCrewmates.Buffs
{
    class CyanCrewmatePet : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Cyan Mini Crewmate");
            Description.SetDefault("A Cyan Crewmate is following you!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer < modPlayer>().CyanCrewmatePet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.CyanCrewmatePet>()] <= 0;
            if(petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.CyanCrewmatePet>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
