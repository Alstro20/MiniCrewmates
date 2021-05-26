using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCrewmates.Items
{
    class GreenMiniCrewmate : CyanMiniCrewmate
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Mini Crewmate");
        }
    }
}
