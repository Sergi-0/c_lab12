using System.ComponentModel.DataAnnotations;

namespace ScientificLaboratory.Models
{
    public class Researcher
    {
        public int ResearcherId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Specialization { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime HireDate { get; set; }
    }
}