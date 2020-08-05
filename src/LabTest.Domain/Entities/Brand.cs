namespace LabTest.Domain.Entities
{
    public class Brand
    {
        public Brand(string name)
        {
            Name = name;
        }

        protected Brand() { }

        public int Id { get; }
        public string Name { get; }
    }
}