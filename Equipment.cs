using System.ComponentModel.DataAnnotations;

namespace ScientificLaboratory.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }

        [Required]
        public string EquipmentName { get; set; }

        public string InventoryNumber { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int ProjectId { get; set; }

        public string Status { get; set; }
    }
}