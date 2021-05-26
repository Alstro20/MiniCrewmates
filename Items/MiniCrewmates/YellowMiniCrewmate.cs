using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCrewmates.Items
{
    class YellowMiniCrewmate : CyanMiniCrewmate
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Mini Crewmate");
        }
    }
}
