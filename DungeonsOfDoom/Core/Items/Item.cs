﻿using DungeonsOfDoom.Core.Characters;

namespace DungeonsOfDoom.Core.Items
{
    abstract class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public virtual void Use(Player player)
        {
        }
    }
}
