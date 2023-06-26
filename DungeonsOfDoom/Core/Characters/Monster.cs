using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core.Characters
{
    abstract class Monster : Character
    {
        public Monster(string name, string face, int health) : base(health)
        {
            Name = name;
            Face = face;
            MonsterCounter++;
        }
        //  public static List<Monster> MonsterCounter { get; set; }
        public static int MonsterCounter { get; set; }
        public string Name { get; }
        public string Face { get; set; }

    }
}
