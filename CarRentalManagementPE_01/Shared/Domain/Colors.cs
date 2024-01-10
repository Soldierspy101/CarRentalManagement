using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementPE_01.Shared.Domain
{
    public class Colors: BaseDomainModel
    {
        [Required]
        public string? Name { get; set; }
    }
}
