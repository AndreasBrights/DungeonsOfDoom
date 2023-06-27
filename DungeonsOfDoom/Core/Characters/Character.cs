namespace DungeonsOfDoom.Core.Characters
{
    abstract class Character
    {
        public Character(int health, int attackDmg)
        {
            MaxHealth = health;
            Health = health;
            AttackDmg = attackDmg;
        }
        public bool IsAlive { get { return Health > 0; } }
        public int MaxHealth { get; set; }
        public int AttackDmg { get; set; }
        public int health;
        public virtual int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                    health = 0;
                else if (value > MaxHealth)
                    health = MaxHealth;
                else
                    health = value;
            }
        }

        public abstract void Attack(Character opponent);

    }
}
