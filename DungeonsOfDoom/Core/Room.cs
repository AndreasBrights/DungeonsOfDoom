using DungeonsOfDoom.Core.Characters;
using DungeonsOfDoom.Core.Items;

namespace DungeonsOfDoom.Core
{
    class Room
    {
        public Monster MonsterInRoom { get; set; }
        public Item ItemInRoom { get; set; }
    }
}
