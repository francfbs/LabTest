using LabTest.Domain.Interfaces.Repositories;
using SpecificationExpress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabTest.Domain.Services
{
    public abstract class ServiceBase
    {
        private readonly IUnitOfWork _uow;

        protected List<string> Errors;

        public ServiceBase(IUnitOfWork uow)
        {
            _uow = uow;
            Errors = new List<string>();
        }

        public ServiceResult OkResult(object data = null)
        {
            return new ServiceResult(true, data);
        }

        public ServiceResult FailResult(List<string> errors)
        {
            return new ServiceResult(false, null, errors);
        }

        public bool ValidateBusinessRules(List<SpecificationError> errors)
        {
            if(errors.Any())
            {
                foreach (var e in errors)
                {
                    Errors.Add(e.ErrorMessage);
                }
                return false;
            }

            return true;
        }

        protected bool Commit()
        {
            try
            {
                return _uow.Commit();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                return false;
            }
        }
    }
}
