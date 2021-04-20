using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.InputModels
{
    public class ObjectInputModel
    {
        [Required(ErrorMessage = "Name is empty")]
        public string Name { get; set; }
        public string Material { get; set; }
        public string Surface { get; set; }
        public string Specifications { get; set; }
        
    }
}
