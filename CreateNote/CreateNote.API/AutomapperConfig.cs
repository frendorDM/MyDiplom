using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CreateNote.API.Models.InputModels;
using CreateNote.API.Models.OutputModels;
using CreateNote.Core.Models;

namespace CreateNote.API
{
    public class AutomapperConfig : Profile
    {
        private const string _dateFormat = "dd.MM.yyyy";
        private const string _dateFormatWithTime = "dd.MM.yyyy H:mm:ss";

        public AutomapperConfig()
        {
            CreateMap<DeviceDto, DeviceOutputModel>();
            CreateMap<DeviceInputModel, DeviceDto>();

            CreateMap<ProbeDto, ProbeOutputModel>();
            CreateMap<ProbeInputModel, DeviceDto>();

            CreateMap<ObjectDto, ObjectOutputModel>();
            CreateMap<ObjectInputModel, ObjectDto>();

            CreateMap<ParametersDto, ParametersOutputModel>();
            CreateMap<ParametersInputModel, ParametersDto>();

            CreateMap<CountTestingDto, CountTestingOutputModel>();
        }
    }
}
