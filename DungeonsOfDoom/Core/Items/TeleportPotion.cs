using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    class TeleportPotion : Item
    {
        public TeleportPotion() : base("Teleport Potion")
        {
        }

        public override void Use(Player player)
        {
            player.AttackDmg += 10;

        }
    }
}
