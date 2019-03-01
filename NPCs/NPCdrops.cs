using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Elements.NPCs
{
    public class NPCdrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {        
            if ((Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneOverworldHeight) && !(Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach))
            {
                if (Main.rand.NextFloat(1) < 0.1f) //10%
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Terra"), Main.rand.Next(1,2));
                }
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight)
            {
                if (Main.rand.NextFloat(1) < 0.1f) //10%
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Ignis"), Main.rand.Next(1, 2));
                }
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight)
            {
                if (Main.rand.NextFloat(1) < 0.1f) //10%
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Aer"), Main.rand.Next(1, 2));
                }
            }
            if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach)
            {
                if (Main.rand.NextFloat(1) < 0.1f) //10%
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Aqua"), Main.rand.Next(1, 2));
                }
            }
        }
    }
}
       /*

            if (npc.type == NPCID.Vulture)   //this is where you choose the npc you want
            {
                if (Main.rand.Next(11) == 0 && Main.netMode != 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
                {
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FeatherVulture"), Main.rand.Next(1, 2)); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                    }
                }
            }


        }
    }

}
   /*   //THIS IS AN EXAMPLE OF HOW TO MAKE ITEMS DROP FROM ALL NPCs IN A SPECIFIC BIOME
               if (Main.hardMode)     //this make the item drop only in hardmode
               {
                   if (Main.player[Main.myPlayer].ZoneCorrupt)          //this is where you choose what biome you whant the item to drop. ZoneCorrupt is in Corruption
                   {
                       if (Main.rand.Next(9) == 0)      //this is the item rarity, so 9 = 1 in 10 chance that the npc will drop the item.
                       {
                           Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.VileMushroom, Main.rand.Next(5, 10));//this is where you set what item to drop ,ItemID.VileMushroom is an example of how to add vanila items , Main.rand.Next(5, 10) it's the quantity,so it will chose a number from 5 to 10 
                       }
                       //THIS IS AN EXAMPLE HOW TO ADD A SECOND DORP
                       if (Main.rand.Next(2) == 0) //this is the item rarity, so 2 is 1 in 3 chance that the npc will drop the item.
                       {
                           {
                               Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GunName"), 1); //this is where you set what item to drop, mod.ItemType("GunName") is an example of how to add your custom item. and 1 is the amount
                           }
                       }
                   }
               }
               else    //else if it's not hardmode this will happen
               {
                   if (Main.player[Main.myPlayer].ZoneCorrupt)  //so again if the player is in corruption
                   {
                       if (Main.rand.Next(2) == 0)    //   the item has a 1 in 3 chance to drop
                       {
                           Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.VileMushroom, Main.rand.Next(5, 8));
                       }
                   }

               } */
       //THIS IS AN EXAMPLE OF HOW TO MAKE ITEMS DROP FROM VANILA NPCs

/*      if (npc.type == NPCID.Vulture)   //this is where you choose the npc you want
      {
          if (Main.rand.Next(4) == 0) //this is the item rarity, so 4 is 1 in 5 chance that the npc will drop the item.
          {
              {
                  Item.NewItem((int) npc.position.X, (int) npc.position.Y, npc.width, npc.height, mod.ItemType("FeatherVulture"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
              }
          }
      }

      /*
               //THIS IS AN EXAMPLE OF HOW TO MAKE ITEMS DROP FROM NPCs IN CUSTOM BIOME
               if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].GetModPlayer<MyPlayer>(mod).ZoneCustomBiome) //change MyPlayer with your myplayer.cs name and ZoneCustomBiome with your zone name
               {
                   if (Main.rand.Next(2) == 0) //this is the item rarity, so 2 is 1 in 3 chance that the npc will drop the item.
                   {
                       {
                           Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofMight, 1); //this is where you set what item to drop
                       }
                   }
               }

               //THIS IS AN EXAMPLE OF HOW TO MAKE ITEMS DROP FROM CUSTOM NPCs

               if (npc.type == mod.NPCType("NpcName"))//this is how you add your custom npc
               {
                   if (Main.rand.Next(2) == 0) //this is the item rarity, so 2 is 1 in 3 chance that the npc will drop the item.
                   {
                       {
                           Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CustomSword"), 1); //this is where you set what item to drop, mod.ItemType("CustomSword") is an example of how to add your custom item. and 1 is the amount
                       }
                   }
               } */
