namespace LAB.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }

        public string  InvoceNumber { get; set; }

        public float Total { get; set; }

        public Customer Customer { get; set; }
        public int  Customerid { get; set; }
    }
}
