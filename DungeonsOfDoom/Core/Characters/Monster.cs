namespace DungeonsOfDoom.Core.Characters
{
    abstract class Monster : Character, IPortable
    {
        public Monster(string name, string face, int health, int attackDmg) : base(health, attackDmg) 
        {
            Name = name;
            Face = face;
            MonsterCounter++;
            AttackDmg = attackDmg; //lagt till
        }

        public string Name { get; set; }
        public string Face { get; set; }
        public static int MonsterCounter { get; private set; }

        public override int Health
        {
            get { return base.Health; }
            set 
            { 
                base.Health = value;
                if (Health <= 0)
                    MonsterCounter--;
            }
        }

        public override void Attack(Character player)
        {
            player.Health -= AttackDmg; //kortat ner lite
        }

    }
}
