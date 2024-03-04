using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetBHLeasing.Models
{
    public class Utilisateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int id_user { get; set; }

        [Required]
        [ForeignKey("ID_PROFIL")]
        public Profil? Profil { get; set; }

        [StringLength(100)]
        public string nom { get; set; }

        [StringLength(100)]
        public string Prenom { get; set; }

        [Required]
        [StringLength(100)]
        public string login { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [Required]
        [StringLength(10)]
        public string? abreviation { get; set; }

        [Required]
        public int id_user_responsable { get; set; }

        [Required]
        [StringLength(10)]
        public string? statut { get; set; }

        [Required]
        public int b_modifier_ptf { get; set; }

        [StringLength(255)]
        public string? mail { get; set; }

        public DateTime? date_derniers_acces { get; set; }

        [Required]
        public int id_user_modif { get; set; }

        [Required]
        public DateTime date_user_creat { get; set; }

        [Required]
        public DateTime date_user_modif { get; set; }

        public int matricule { get; set; }

        [StringLength(20)]
        public string? rib { get; set; }

        [Required]
        public int id_departement { get; set; }


        public ICollection<His_Relances>? HisRelances { get; set; }
    }
}