using LabTest.Domain.Entities;
using LabTest.Domain.Interfaces.Repositories;
using SpecificationExpress;

namespace LabTest.Domain.Services.Specifications
{
    public class UpdateBrandNameMustBeUnique : ISpecification<Brand>
    {
        private readonly IBrandRepository _brandRepository;

        public UpdateBrandNameMustBeUnique(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public bool IsSatisfiedBy(Brand obj)
        {
            var brand = _brandRepository.GetByName(obj.Name);
            return brand == null || brand.Id == obj.Id;
        }
    }
}
