using LabTest.Domain.Entities;
using LabTest.Domain.Interfaces.Repositories;
using LabTest.Domain.Interfaces.Services;
using LabTest.Domain.Services.Validations;
using System.Transactions;

namespace LabTest.Domain.Services
{
    public class VehicleService : ServiceBase, IVehicleService
    {
        private readonly IBrandRepository _brandRepository;

        public VehicleService(IUnitOfWork uow, IBrandRepository brandRepository) : base(uow)
        {
            _brandRepository = brandRepository;
        }

        public ServiceResult Add(Vehicle vehicle)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult Update(Vehicle vehicle)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult AddBrand(Brand brand)
        {
            if (!ValidateBusinessRules(new BrandAddValidations(_brandRepository).Validate(brand)))
                return FailResult(Errors);

            _brandRepository.Add(brand);

            if(Commit()) return OkResult(brand);

            return FailResult(Errors);
        }

        public ServiceResult UpdateBrand(Brand brand)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult DeleteBrand(int brandId)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult AddModel(Model model)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult UpdateModel(Model model)
        {
            throw new System.NotImplementedException();
        }

        public ServiceResult DeleteModel(int modelId)
        {
            throw new System.NotImplementedException();
        }
    }
}