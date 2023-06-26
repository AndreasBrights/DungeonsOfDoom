using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    class GlovesOfMetal : Item
    {
        public GlovesOfMetal() : base("Gloves of Metal")
        {
           
        }
        public override void Use(Player player)
        {
            player.AttackDmg += 10;

        }
    }
}
