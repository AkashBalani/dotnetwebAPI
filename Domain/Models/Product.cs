namespace lab5.API.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; } // Example of Enum, Notice the E in front of the ClassName

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
