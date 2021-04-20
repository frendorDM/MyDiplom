using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using CreateNote.Core.Config;
using CreateNote.Core.Models;
using Dapper;
using Microsoft.Extensions.Options;

namespace CreateNote.Data
{
    public class AnalisisInfoRepository: BaseRepository, IAnalisisInfoRepository

    {
        public AnalisisInfoRepository(IOptions<AppSettingsConfig> options) : base(options)
        {
            _connection = new SqlConnection(_connectionString);
        }

        public CountTestingDto GetCountFailedTesting(int id)
        {
            var countFailedTesting = _connection
                .QuerySingleOrDefault<CountTestingDto>(
                "CountFailedTesting_SelectByObjectId",
                param: new { id }, commandType: System.Data.CommandType.StoredProcedure);
            return countFailedTesting;
        }
        public CountTestingDto GetCountSuccessfulTesting(int id)
        {
            var countFailedTesting = _connection
                .QuerySingleOrDefault<CountTestingDto>(
                "CountSuccessfulTesting_SelectByObjectId",
                param: new { id }, commandType: System.Data.CommandType.StoredProcedure);
            return countFailedTesting;
        }

    }
}
