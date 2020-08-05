using LabTest.Domain.Entities;
using LabTest.Domain.Services;

namespace LabTest.Domain.Interfaces.Services
{
    public interface IVehicleService
    {
        ServiceResult Add(Vehicle vehicle);
        ServiceResult Update(Vehicle vehicle);
        ServiceResult Delete(int id);
        
        ServiceResult AddBrand(Brand brand);
        ServiceResult UpdateBrand(Brand brand);
        ServiceResult DeleteBrand(int brandId);
        
        ServiceResult AddModel(Model model);
        ServiceResult UpdateModel(Model model);
        ServiceResult DeleteModel(int modelId);
    }
}