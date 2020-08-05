using System;
using System.Collections.Generic;
using System.Text;

namespace LabTest.Domain.Services
{
    public abstract class ServiceBase
    {
        public ServiceResult OkResult(object data)
        {
            return new ServiceResult(true, data);
        }

        public ServiceResult FailResult(object data)
        {
            return new ServiceResult(false, data);
        }
    }
}
