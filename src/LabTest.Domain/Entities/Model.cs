namespace LabTest.Domain.Entities
{
    public class Model
    {
        public Model(string name, int brandId)
        {
            Name = name;
            BrandId = brandId;
        }

        public int Id { get; }
        public string Name { get; }
        public int BrandId { get; }
        public Brand Brand { get; }
    }
}