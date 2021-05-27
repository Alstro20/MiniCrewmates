using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MiniCrewmates.Items.MiniCrewmates
{
    [AutoloadEquip(EquipType.Head)]
    class BlueMiniCrewmate : CyanMiniCrewmate
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Mini Crewmate");
            Tooltip.SetDefault("Now in hat form!");
        }

        public override void SetDefaults()
        {
            item.vanity = true;
        }
    }
}
