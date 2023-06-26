namespace DungeonsOfDoom.Core.Items
{
    abstract class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void Use(Player player);
        
    }
}
