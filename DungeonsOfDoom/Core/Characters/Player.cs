using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Characters
{
    class Player : Character
    {
        public const int MaxHealth = 30;

        public Player() : base(MaxHealth)
        {
            Backpack = new List<Item>();
        }

        public List<Item> Backpack { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
