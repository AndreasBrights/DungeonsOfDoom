using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Characters
{
    class Player : Character
    {

        public const int MaxHealth = 40;
        
        public Player() : base(MaxHealth, 10)
        {
            Backpack = new List<Item>();
            AttackDmg = AttackDmg;

        }

        public List<Item> Backpack { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }
        public override void Attack(Character monster)
        {

            monster.Health = monster.Health - AttackDmg;
        }

    }
}
