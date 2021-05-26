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
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BabyDino);
            aiType = ProjectileID.BabyDino;
            projectile.width = 40;
            projectile.height = 40;
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
