using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Characters
{
    class Player : Character
    {
        public const int MaxHealth = 20;

        int attackDmg = 10;
        public Player() : base(MaxHealth)
        {
            Backpack = new List<Item>();
        }

        public List<Item> Backpack { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }
        public override void Attack(Character monster)
        {
            bool itemInBackPack = true;
            do
            {

                for (int i = 0; i < Backpack.Count; i++)
                {
                    if (Backpack[i] is GlovesOfMetal)
                    {
                        itemInBackPack = true; break;
                    }
                }
                attackDmg = attackDmg + 10;

            } while (itemInBackPack == false);



            monster.Health = monster.Health - attackDmg;

        }
    }
}
