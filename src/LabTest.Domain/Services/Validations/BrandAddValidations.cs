using LabTest.Domain.Entities;
using LabTest.Domain.Interfaces.Repositories;
using LabTest.Domain.Services.Specifications;
using SpecificationExpress;

namespace LabTest.Domain.Services.Validations
{
    public class BrandAddValidations : Validator<Brand>
    {
        public BrandAddValidations(IBrandRepository brandRepository)
        {
            Add(new Rule<Brand>(new BrandNameMustBeUnic(brandRepository), "Brand name is already registered!"));
            // put here more rules if necessary
        }
    }
}
