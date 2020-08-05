using LabTest.Domain.Entities;
using LabTest.Domain.Interfaces.Repositories;
using SpecificationExpress;

namespace LabTest.Domain.Services.Specifications
{
    public class BrandNameMustBeUnic : ISpecification<Brand>
    {
        private readonly IBrandRepository _brandRepository;

        public BrandNameMustBeUnic(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public bool IsSatisfiedBy(Brand obj)
        {
            return _brandRepository.GetByName(obj.Name) == null;
        }
    }
}
