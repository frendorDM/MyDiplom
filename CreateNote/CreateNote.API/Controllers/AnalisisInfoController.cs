using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CreateNote.API.Models.OutputModels;
using CreateNote.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace CreateNote.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnalisisInfoController : ControllerBase
    {

        private IAnalisisInfoService _analisisInfoService;
        private IMapper _mapper;
        public AnalisisInfoController(IAnalisisInfoService analisisInfoService, IMapper mapper)
        {
            _analisisInfoService = analisisInfoService;
            _mapper = mapper;
        }

        [HttpGet("failedCase/{id}")]
        public ActionResult<CountTestingOutputModel> GetTestingFailedCaseByIdObject(int id)
        {
            var testingCase = _mapper.Map<CountTestingOutputModel>(_analisisInfoService.GetCountFailedTesting(id));
            return testingCase;
        }

        [HttpGet("successfulCase/{id}")]
        public ActionResult<CountTestingOutputModel> GetTestingCaseSuccessfulByIdObject(int id)
        {
            var testingCase = _mapper.Map<CountTestingOutputModel>(_analisisInfoService.GetCountSuccessfulTesting(id));
            return testingCase;
        }

    }
}
