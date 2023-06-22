namespace DungeonsOfDoom.Core.Characters
{
    abstract class Character
    {
        public Character(int health)
        {
            Health = health;
        }

        public int Health { get; set; }
        public bool IsAlive { get { return Health > 0; } }
    }
}
