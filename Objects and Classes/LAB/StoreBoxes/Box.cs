namespace StoreBoxes
{
    public class Box
    {
        public Box()
        {
            this.Item = new Item();
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
