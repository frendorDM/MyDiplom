using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.OutputModels
{
    public class DeviceOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specifications { get; set; }
    }
}
