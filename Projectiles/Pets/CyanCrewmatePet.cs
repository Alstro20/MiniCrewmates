using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniCrewmates.Projectiles.Pets
{
    class CyanCrewmatePet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Crewmate Pet");
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            modPlayer modPlayer = player.GetModPlayer<modPlayer>();
            if (player.dead)
            {
                modPlayer.CyanCrewmatePet = false;
            }
            if (modPlayer.CyanCrewmatePet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
