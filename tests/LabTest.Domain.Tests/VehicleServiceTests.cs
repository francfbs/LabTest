using LabTest.Domain.Entities;
using LabTest.Domain.Interfaces.Repositories;
using LabTest.Domain.Services;
using Moq;
using System;
using Xunit;

namespace LabTest.Domain.Tests
{
    public class VehicleServiceTests
    {
        private readonly Mock<IVehicleRepository> VehicleRepository = new Mock<IVehicleRepository>();
        private readonly Mock<IBrandRepository> BrandRepository = new Mock<IBrandRepository>();
        private readonly Mock<IUnitOfWork> UoW = new Mock<IUnitOfWork>();

        private Brand NewValidBrand = new Brand("A Brand");

        [Fact]
        public void Should_AddBrand_Success()
        {
            BrandRepository.Setup(r => r.Add(It.IsAny<Brand>())).Returns(NewValidBrand);
            UoW.Setup(u => u.Commit()).Returns(true);

            var service = new VehicleService(UoW.Object, BrandRepository.Object);

            var result = service.AddBrand(NewValidBrand);

            Assert.True(result.Success);
        }

        [Fact]
        public void Should_ReturnError_If_BrandName_AlreadyExists()
        {
            //BrandRepository.Setup(r => r.Add(It.IsAny<Brand>())).Returns(NewValidBrand);
            BrandRepository.Setup(r => r.GetByName(It.IsAny<string>())).Returns(NewValidBrand);
            //UoW.Setup(u => u.Commit()).Returns(true);

            var service = new VehicleService(UoW.Object, BrandRepository.Object);

            var result = service.AddBrand(NewValidBrand);

            Assert.False(result.Success);
            Assert.Single(result.Errors);
        }

        [Fact]
        public void Should_ReturnErrorOnSaveThrows()
        {
            BrandRepository.Setup(r => r.Add(It.IsAny<Brand>())).Returns(NewValidBrand);
            UoW.Setup(u => u.Commit()).Throws(new Exception("DataBase Error"));

            var service = new VehicleService(UoW.Object, BrandRepository.Object);

            var result = service.AddBrand(NewValidBrand);

            Assert.False(result.Success);
            Assert.Single(result.Errors);
        }
    }
}
