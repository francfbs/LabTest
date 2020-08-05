namespace LabTest.Domain.Entities
{
    public class Vehicle
    {
        public Vehicle(decimal value, int yearModel, string fuel, int brandId, int modelId)
        {
            Value = value;
            YearModel = yearModel;
            Fuel = fuel;
            BrandId = brandId;
            ModelId = modelId;
        }

        public int Id { get; }
        public decimal Value { get; }
        public int YearModel { get; }
        public string Fuel { get; }
        public int BrandId { get; }
        public int ModelId { get; }
        
        public Brand Brand { get; }
        public Model Model { get; }
    }
}