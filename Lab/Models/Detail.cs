namespace LAB.Models
{
    public class Detail
    {
        public int Id { get; set; }

        public int Amount { get; set; }
        public float Price { get; set; }

        public float SubTotal { get; set; }

        public Product Product { get; set; }

        public int  ProductId { get; set; }
        public Invoice Invoice { get; set; }
        public int InvoiceId { get; set; }
      
    }
}
