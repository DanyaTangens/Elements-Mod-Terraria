using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elements
{
    public class ElementsPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool minionName = false;
        public bool Pet = false;
        public static bool hasProjectile;

        public override void ResetEffects()
        {
            minionName = false;
            Pet = false;
        }
        public override void SetupStartInventory(IList<Item> items)
        {
            items.Clear();

            Item item0 = new Item();
            item0.SetDefaults(ItemID.CopperShortsword);
            item0.stack = 1;
            items.Add(item0);

            Item item1 = new Item();
            item1.SetDefaults(ItemID.CopperPickaxe);
            item1.stack = 1;
            items.Add(item1);

            Item item2 = new Item();
            item2.SetDefaults(ItemID.CopperAxe);
            item2.stack = 1;
            items.Add(item2);

            Item item = new Item();
            item.SetDefaults(mod.ItemType("ScrollofChoice"));
            item.stack = 1;
            items.Add(item);

        }
    }
}