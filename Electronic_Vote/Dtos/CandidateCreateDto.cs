using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_Vote.Dtos
{
    public class CandidateCreateDto
    {
        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDay { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string IdentificationNumber { get; set; }
        public string Description { get; set; }
    }
}
