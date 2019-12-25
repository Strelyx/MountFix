using Terraria;
using Terraria.ModLoader;

namespace MountFix
{
    class FixesPlayer : ModPlayer
    {
        public override void PreUpdate()
        {
            if(player.wingTimeMax > 0)
            {
                player.noFallDmg = true;
            }
        }
    }
}
