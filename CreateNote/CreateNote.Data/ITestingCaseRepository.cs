using System;
using System.Collections.Generic;
using System.Text;
using CreateNote.Core.Models;

namespace CreateNote.Data
{
    public interface ITestingCaseRepository
    {
        int AddDevice(DeviceDto device);
        List<TestingCaseDto> GetTestingCaseByIdObject(int id);
        int AddProbe(ProbeDto probe);
        int AddObject(ObjectDto object1);
        int AddParameters(ParametersDto parameters);
        TestingCaseDto GetParametersByIdObject(int id)


    }
}
