using System;
using System.Collections.Generic;
using CreateNote.Core.Models;
using CreateNote.Data;

namespace CreateNote.Business
{
    public class TestingCaseService : ITestingCaseService
    {

        private ITestingCaseRepository _testingCaseRepository;

        public TestingCaseService
            (
            ITestingCaseRepository testingCaseRepository
            )
        {
            _testingCaseRepository = testingCaseRepository;
        }
        public int AddDevice(DeviceDto deviceDto)
        {
            var result = _testingCaseRepository.AddDevice(deviceDto);
            return result;
        }
        public int AddObject(ObjectDto objectDto)
        {
            var result = _testingCaseRepository.AddObject(objectDto);
            return result;
        }
        public int AddProbe(ProbeDto probeDto)
        {
            var result = _testingCaseRepository.AddProbe(probeDto);
            return result;
        }
        public int AddParameters(ParametersDto parametersDto)
        {
            var result = _testingCaseRepository.AddParameters(parametersDto);
            return result;
        }
        public List<TestingCaseDto> GetTestingCaseByIdObject(int id)
        {
            return _testingCaseRepository.GetTestingCaseByIdObject(id);
        }
        public TestingCaseDto GetParametersByIdObject(int id)
        {
            return _testingCaseRepository.GetParametersByIdObject(id);
        }
    }
}
