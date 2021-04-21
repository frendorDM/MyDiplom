using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using CreateNote.Core.Config;
using System.Data.SqlClient;
using CreateNote.Core.Models;
using Dapper;
using System.Linq;

namespace CreateNote.Data
{
    public class TestingCaseRepository : BaseRepository, ITestingCaseRepository
    {
        public TestingCaseRepository(IOptions<AppSettingsConfig> options) : base(options)
        {
            _connection = new SqlConnection(_connectionString);
        }
        public int AddDevice(DeviceDto device)
        {
            var result = _connection
                .QuerySingle<int>("Device_Add",
                new
                {
                    name = device.Name,
                    specifications = device.Specifications
                },
                commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }

        public List<TestingCaseDto> GetTestingCaseByIdObject(int id)
        {
            var testingCaseDictionary = new Dictionary<int, TestingCaseDto>();
            var testingCase = _connection
                .Query<TestingCaseDto, UserDto, ObjectDto, DeviceDto, ParametersDto, ProbeDto, TestingCaseDto>(
                "call Testingcase_SelectByObjectId",
                (testingCase, user, object1, device, pararmeters, probe) =>
                {
                    if (!testingCaseDictionary.TryGetValue(testingCase.id, out TestingCaseDto testingCaseEntry))
                    {
                        testingCaseEntry = testingCase;
                        testingCaseEntry.User = user;
                        testingCaseEntry.Object = object1;
                        testingCaseEntry.Device = device;
                        testingCaseEntry.Pararmeters = pararmeters;
                        testingCaseEntry.Probe = probe;
                        testingCaseDictionary.Add(testingCaseEntry.id, testingCaseEntry);
                    }
                    return testingCaseEntry;
                },
                new { objectId = id },
                splitOn: "id",
                commandType: System.Data.CommandType.StoredProcedure)
                .ToList();
            return testingCase;
        }

        public int AddProbe(ProbeDto probe) 
        {
            var result = _connection
                .QuerySingle<int>("Probe_Add",
                new
                {
                    name = probe.Name,
                    specifications = probe.Specifications
                },
                commandType: System.Data.CommandType.StoredProcedure);
            return result;
         
        }
        public int AddObject(ObjectDto object1)
        {
            var result = _connection
                .QuerySingle<int>("Object_Add",
                new
                {
                    name = object1.Name,
                    material = object1.Material,
                    surface = object1.Surface,
                    specifications = object1.Specifications
                },
                commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
        public int AddParameters(ParametersDto parameters)
        {
            var result = _connection
                .QuerySingle<int>("Parameters_Add",
                new
                {
                    rz = parameters.Rz,
                    ra = parameters.Ra,
                    rmax = parameters.Rmax,
                    sm = parameters.Sm,
                    s = parameters.S,
                    image = parameters.Image
                },
                commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
        public TestingCaseDto GetParametersByIdObject(int id)
        {
            var testingCaseEntry = new TestingCaseDto();
            var testingCase = _connection
                .Query<TestingCaseDto, ObjectDto, ParametersDto, TestingCaseDto>(
                "Parameters_SelectByObjectId",
                (testingCase, object1, pararmeters) =>
                {
                    if (testingCaseEntry.id == 0)
                    {
                        testingCaseEntry = testingCase;
                        testingCaseEntry.Object = object1;
                        testingCaseEntry.Pararmeters = pararmeters;
                    }
                    return testingCaseEntry;
                },
                new { objectId = id },
                splitOn: "id",
                commandType: System.Data.CommandType.StoredProcedure)
                .FirstOrDefault(); ;
            return testingCase;
        }
    }
}
