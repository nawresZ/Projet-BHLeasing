using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetBHLeasing.Models
{
    public class Profil
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id_profil { get; set; }

        [Required]
        [StringLength(255)]
        public string? Designation { get; set; }

        [Required]
        public int b_systeme { get; set; }

        [Required]
        public int id_user_modif { get; set; }

        [Required]
        public DateTime date_user_creat { get; set; }

        [Required]
        public DateTime date_user_modif { get; set; }

        // Navigation property for UTILISATEURS
        public ICollection<Utilisateur>? Utilisateurs { get; set; }
    }
}
