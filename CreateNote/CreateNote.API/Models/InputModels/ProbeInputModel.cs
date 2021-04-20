using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.InputModels
{
    public class ProbeInputModel
    {
        [Required(ErrorMessage = "Name is empty")]
        public string Name { get; set; }
        public string Specifications { get; set; }
    }
}
