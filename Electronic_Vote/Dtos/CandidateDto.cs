using System;
using System.ComponentModel.DataAnnotations;

namespace Electronic_Vote.Dtos
{
    public class CandidateDto
    {
        public int id { get; set; }

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
