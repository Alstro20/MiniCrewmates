using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MiniCrewmates
{
    public class modPlayer : ModPlayer
    {
        public bool CyanCrewmatePet;

        public override void ResetEffects()
        {
            CyanCrewmatePet = false;
        }
    }
}
