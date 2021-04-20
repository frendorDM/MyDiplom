using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.OutputModels
{
    public class TestingCaseOutputModel
    {
        public int Id { get; set; }
        public UserOutputModel User { get; set; }
        public ObjectOutputModel Object { get; set; }
        public DeviceOutputModel Device { get; set; }
        public ParametersOutputModel Parameters { get; set; }
        public ProbeOutputModel Probe { get; set; }
        public string Date { get; set; }
        public int Length { get; set; }
        public string Comment { get; set; }
        public string Time_testing { get; set; }

    }
}
