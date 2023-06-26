using DungeonsOfDoom.Core.Characters;
using System.Reflection.Metadata;

namespace DungeonsOfDoom.Core.Items
{
    class TeleportPotion : Item
    {
        public TeleportPotion() : base("Teleport Potion")
        {
        }
        public override void Use(Player player)
        {
            player.Health += 5;
            player.X = Random.Shared.Next(Program.WorldWidth);
            player.Y = Random.Shared.Next(Program.WorldHeight);

        }
    }
}
