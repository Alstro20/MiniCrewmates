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
    class sus : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("sus");
            Tooltip.SetDefault("When the player is sus");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 420;
            item.rare = ItemRarityID.Green;
        }

        public override void AddRecipes()
        {
            //Recipe 1 (using rotten chunks)
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuspiciousLookingEye, 2);
            recipe.AddIngredient(ItemID.RottenChunk, 4);

            recipe.AddTile(TileID.DemonAltar);

            recipe.SetResult(this, 3);
            recipe.AddRecipe();

            //Recipe 2 (using Vertebrae)
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuspiciousLookingEye, 2);
            recipe.AddIngredient(ItemID.Vertebrae, 4);

            recipe.AddTile(TileID.DemonAltar);

            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
