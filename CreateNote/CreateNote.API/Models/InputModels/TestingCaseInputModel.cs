using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreateNote.API.Models.InputModels
{
    public class TestingCaseInputModel
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int UserId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int SurfaceId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int ObjectId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int DeviceId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int ParametersId { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int ProbeId { get; set; }
        [Required]
        public string Date { get; set; }
        public int Length { get; set; }
        public string Comment { get; set; }
        [Required]
        public string Time_testing { get; set; }

    }
}
