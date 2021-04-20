using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CreateNote.API.Models.InputModels;
using CreateNote.API.Models.OutputModels;
using CreateNote.Business;
using CreateNote.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreateNote.API.Controllers
{
    public class TestingCaseController : ControllerBase
    {
        private ITestingCaseService _testingCaseService;
        private IMapper _mapper;
        public TestingCaseController(ITestingCaseService testingCaseService, IMapper mapper)
        {
            _testingCaseService = testingCaseService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<DeviceOutputModel> CreateDevice([FromBody] DeviceInputModel device)
        {
            var id = _testingCaseService.AddDevice(_mapper.Map<DeviceDto>(device));
            //var result = _mapper.Map<DeviceOutputModel>(_testingCaseService.GetDeviceById(id));
            return Ok(id);
        }

        [HttpPost]
        public ActionResult<ProbeOutputModel> CreateProbe([FromBody] ProbeInputModel probe)
        {
            var id = _testingCaseService.AddProbe(_mapper.Map<ProbeDto>(probe));
            //var result = _mapper.Map<DeviceOutputModel>(_testingCaseService.GetDeviceById(id));
            return Ok(id);
        }
        [HttpPost]
        public ActionResult<ObjectOutputModel> CreateObject([FromBody] ObjectInputModel object1)
        {
            var id = _testingCaseService.AddObject(_mapper.Map<ObjectDto>(object1));
            //var result = _mapper.Map<DeviceOutputModel>(_testingCaseService.GetDeviceById(id));
            return Ok(id);
        }
        [HttpPost]
        public ActionResult<ParametersOutputModel> CreateParameters([FromBody] ParametersInputModel parameters)
        {
            var id = _testingCaseService.AddProbe(_mapper.Map<ProbeDto>(parameters));
            //var result = _mapper.Map<DeviceOutputModel>(_testingCaseService.GetDeviceById(id));
            return Ok(id);
        }
        [HttpGet]
        public ActionResult<TestingCaseOutputModel> GetTestingCaseByIdObject(int id) 
        {
            var testingCase = _mapper.Map<TestingCaseOutputModel>(_testingCaseService.GetTestingCaseByIdObject(id));
            return testingCase;
        }

        [HttpGet]
        public ActionResult<TestingCaseOutputModel> GetParametersByIdObject(int id)
        {
            var testingCase = _mapper.Map<TestingCaseOutputModel>(_testingCaseService.GetParametersByIdObject(id));
            return testingCase;
        }
    }
}
