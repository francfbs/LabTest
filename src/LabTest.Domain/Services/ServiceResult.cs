using System;

namespace LabTest.Domain.Services
{
    public class ServiceResult
    {
        public ServiceResult(bool success, object data)
        {
            Success = success;
            Data = data;
        }
        public bool Success { get; }
        public Object Data { get; }
    }

    
}