namespace DungeonsOfDoom.Core.Characters
{
    abstract class Character
    {
        public Character(int health, int attackDmg)
        {
            maxHealth = health;
            Health = health;
            AttackDmg = attackDmg;
        }
        public bool IsAlive { get { return Health > 0; } }
        public int MaxHealth;
        public int maxHealth { get; set; }
        public int AttackDmg { get; set; }
        public int Health;
        public int health
        {
            get { return Health; }
            set
            {
                if (value >= 0 && value <= maxHealth)
                    Health = value;
            }
        }

        public abstract void Attack(Character opponent);

    }
}
