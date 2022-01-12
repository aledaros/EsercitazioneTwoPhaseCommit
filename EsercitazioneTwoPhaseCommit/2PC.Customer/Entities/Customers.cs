namespace _2PC.Customer.Entities
{
    public class Customers
    {
        public Customers(int id, double fondo)
        {
            Id=id;
            Fondo=fondo;
        }

        public int Id { get; set; }
        public double Fondo { get; set; }
    }
}
