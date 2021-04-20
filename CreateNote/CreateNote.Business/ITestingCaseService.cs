using System;
using System.Collections.Generic;
using System.Text;
using CreateNote.Core.Models;

namespace CreateNote.Business
{
    public interface ITestingCaseService
    {
        int AddDevice(DeviceDto deviceDto);
        int AddProbe(ProbeDto probeDto);
        int AddObject(ObjectDto object1);
        int AddParameters(ParametersDto parameters);
        List<TestingCaseDto> GetTestingCaseByIdObject(int id);
        TestingCaseDto GetParametersByIdObject(int id);
    }
}
