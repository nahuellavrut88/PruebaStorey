namespace Storey.Entities
{
    public class Category
    {
        //public int Id { get; set; }
        public string Categoria { get; set; }
        public List<Item> Item { get; set; }

        public Category() {
            Item = new();        
        }
    }
}
