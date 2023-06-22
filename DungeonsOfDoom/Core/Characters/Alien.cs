namespace DungeonsOfDoom.Core.Characters
{
    class Alien : Monster
    {
        public Alien() : base("Alien", "👽", 20)
        {
        }
        public override void Attack(Character player)
        {
            int attack = 5;
            if ( player.Health > Health * 2)
            {
                attack = 1;
            }
            player.Health = player.Health - attack;


        }
    }
}
