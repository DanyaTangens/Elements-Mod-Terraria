using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.IO;
using Terraria.ID;

namespace Elements
{
    public class Elements : Mod
    {
        public void Items() //public override void SetModInfo(out string name, ref ModProperties properties)
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true //name = "learn";
                                      //properties.Autoload = true;         
            };
        }
    }
}