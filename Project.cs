using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScientificLaboratory.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Budget { get; set; }

        public int LeadResearcherId { get; set; }
    }
}