using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FIAP_MVC.Models
{
    public class Spell
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("MVC_User")]
        public int UserId { get; set; }
        public Casting CastingSpell { get; set; }
    }
}
