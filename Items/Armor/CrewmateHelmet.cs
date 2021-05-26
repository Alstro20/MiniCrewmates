using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MiniCrewmates.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    class CrewmateHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Work in poggers.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Green;
            item.defense = 6; //TODO: give this a good value
        }

        //TODO: Enable this once all armor pieces are in
        /*public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<CrewmateChestplate>() && legs.type == ModContent.ItemType<CrewmateLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "sus";
            player.allDamage -= 0.2f;
        }*/

        //TODO: add recipe
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteorHelmet, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
