namespace DungeonsOfDoom.Core.Characters
{
    abstract class Monster : Character
    {
        public Monster(string name, string face, int health, int attackDmg) : base(health, attackDmg)
        {
            Name = name;
            Face = face;
        }

        public string Name { get; }
        public string Face { get; set; }

    }
}
