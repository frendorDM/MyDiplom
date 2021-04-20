using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.OutputModels
{
    public class ParametersOutputModel
    {
        public int id { get; set; }
        public string Rz { get; set; }
        public string Ra { get; set; }
        public string Rmax { get; set; }
        public string Sm { get; set; }
        public string S { get; set; }
        public string Image { get; set; }
    }
}
