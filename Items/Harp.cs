using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elements.Items
{
    public class Harp : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aer Sword");
            Tooltip.SetDefault("This is a modded sword\nThis is the second tooltip.");
        }

        public override void SetDefaults()
        {

           // item.damage = 20; // Base Damage of the Weapon
            //item.melee = true; // Weapon Class Type
            item.width = 40; // Hitbox Width
            item.height = 38; // Hitbox Height
            item.useTime = 10; // Speed before reuse
            item.useAnimation = 10; // Animation Speed
            item.useStyle = 5; // 1 = Broadsword 
            item.value = 5000; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item26; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.DirtBlock, 10); // Ingredient for crafing
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.WorkBenches); // Tile / Workstation
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
