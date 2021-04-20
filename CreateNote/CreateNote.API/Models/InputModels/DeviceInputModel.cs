using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CreateNote.API.Models.InputModels
{
    public class DeviceInputModel
    {
        [Required(ErrorMessage = "Name is empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is empty")]
        public string Specifications { get; set; }
    }
}
