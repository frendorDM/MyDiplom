using System;
using System.Collections.Generic;
using System.Text;

namespace CreateNote.Core.Models
{
    public class TestingCaseDto
    {
        public int id { get; set; }
        public UserDto User { get; set; }
        public ObjectDto Object { get; set; }
        public DeviceDto Device { get; set; }
        public ParametersDto Pararmeters { get; set; }
        public ProbeDto Probe { get; set; }
        public DateTime Data { get; set; }
        public int Length { get; set; }
        public string Comment { get; set; }
        public DateTime Time_testing { get; set; }

    }
}
