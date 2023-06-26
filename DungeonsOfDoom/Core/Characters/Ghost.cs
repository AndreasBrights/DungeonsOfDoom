namespace DungeonsOfDoom.Core.Characters
{
    class Ghost : Monster
    {
        public Ghost() : base("Ghost", "👻", 15, 10)
        {
        }
        public override void Attack(Character player)
        {
            int attack = 10;
            player.Health = player.Health - attack;


        }
    }
}
