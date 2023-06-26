namespace DungeonsOfDoom.Core.Characters
{
    class Alien : Monster
    {
        public Alien() : base("Alien", "👽", 25, 5) 
        {
        }
        public override void Attack(Character player)
        {
            int attack = 5;
            if ( player.Health >= Health * 2)
            {
                AttackDmg = 1;
            }
            player.Health = player.Health - attack;


        }
    }
}
