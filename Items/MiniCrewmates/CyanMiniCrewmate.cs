using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;

namespace MiniCrewmates.Items.MiniCrewmates
{
    public class CyanMiniCrewmate : ModItem
    {
        /*
         * 
         * NOTE that ALL mini crewmates inherit their properties from this class.
         * Changing anything other than the name will affect ALL mini crewmates.
         * 
         */

        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("TutorialSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("among us");
            DisplayName.SetDefault("Cyan Mini Crewmate");
        }
        
        public override void SetDefaults()
        {
            //base.SetDefaults();
            item.width = 20;
            item.height = 20;
            item.value = 20000;
            item.rare = ItemRarityID.Green;

            item.useTime = 20;
            item.useAnimation = 60;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.autoReuse = true;

            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AmongUs").WithPitchVariance(.4f);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteorHelmet, 1);
            recipe.AddIngredient(ItemID.MeteorLeggings, 1);
            recipe.AddIngredient(ItemID.Bone, 1);

            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
