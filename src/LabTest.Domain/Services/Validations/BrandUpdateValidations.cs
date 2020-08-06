using LabTest.Domain.Entities;
using LabTest.Domain.Interfaces.Repositories;
using LabTest.Domain.Services.Specifications;
using SpecificationExpress;

namespace LabTest.Domain.Services.Validations
{
    public class BrandUpdateValidations : Validator<Brand>
    {
        public BrandUpdateValidations(IBrandRepository brandRepository)
        {
            Add(new Rule<Brand>(new UpdateBrandNameMustBeUnique(brandRepository), "Brand name is already registered!"));
            // put here more rules if necessary
        }
    }
}
