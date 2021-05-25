using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialMod.Items
{
    class YellowMiniCrewmate : CyanMiniCrewmate
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Mini Crewmate");
        }
    }
}
