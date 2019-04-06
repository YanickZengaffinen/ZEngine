namespace ZEngine.Items.Impl.Core
{
    /// <summary>
    /// Standard implementation of <see cref="IItem"/>
    /// </summary>
    public class Item : IItem
    {
        public long ID { get; }

        public string Name { get; }

        public Item(long id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
