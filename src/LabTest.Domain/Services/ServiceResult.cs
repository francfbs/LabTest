using System;
using System.Collections.Generic;

namespace LabTest.Domain.Services
{
    public class ServiceResult
    {
        public ServiceResult(bool success, object data = null, List<string> erros = null)
        {
            Success = success;
            Data = data;
            Errors = erros;
        }
        public bool Success { get; }
        public object Data { get; }

        public List<string> Errors { get; }
    }

    
}