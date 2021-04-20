using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.OutputModels
{
    public class ObjectOutputModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Surface { get; set; }
        public string Specifications { get; set; }
    }
}
