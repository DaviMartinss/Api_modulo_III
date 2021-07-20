using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API_APOSTILA.Resources
{
    public class SaveProductResource
    {
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}