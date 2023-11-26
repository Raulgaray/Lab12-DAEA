namespace LAB.Models
{
    public class Product 
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public bool IsActive { get; set; }

        //public Categoria? Categoria { get; set; }
        //public int? CategoriaId { get; set; }


    }
}
