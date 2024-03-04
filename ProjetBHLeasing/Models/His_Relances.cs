using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetBHLeasing.Models
{
    public class His_Relances
    {
        [Key]
        public int id_his_relance { get; set; }

        [Required]
        public int id_relance { get; set; }

        [Required]
        public int id_campagne { get; set; }

        [Required]
        public int id_ptf { get; set; }

        [Required]
        public int id_sinistre { get; set; }

        [StringLength(10)]
        public string? code_client { get; set; }

        [Required]
        public int id_action { get; set; }

        [Required]
        public int id_sort { get; set; }

        public DateTime? date_traitement { get; set; }

        public DateTime? date_rdv { get; set; }

        public double montant { get; set; }

        [Required]
        public int id_disponibilite { get; set; }

        [Required]
        public int id_solvabilite { get; set; }

        [Required]
        public int id_moralite { get; set; }

        [StringLength(4000)]
        public string observation { get; set; }

        [StringLength(4000)]
        public string infos { get; set; }

        [ForeignKey("ID_USER_MODIF")]
        public Utilisateur? UserModif { get; set; }
        [Required]
        public DateTime date_user_creat { get; set; }

        [Required]
        public DateTime date_user_modif { get; set; }

        public DateTime? date_derniere_relance { get; set; }

        public DateTime? date_prochaine_relance { get; set; }

        [StringLength(20)]
        public string? provenance { get; set; }

        [Required]
        public int IdProvenance { get; set; }


    }
}