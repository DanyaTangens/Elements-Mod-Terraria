using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elements.Items.Other
{
    public class ScrollofChoice : ModItem
    {
        public override void SetDefaults()
        {

            item.width = 30;
            item.height = 32;
            item.maxStack = 1;
            item.value = 1;
            item.rare = 1;

        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scroll of Choice");
            Tooltip.SetDefault("Choose wisely");
        }

    }
}
