using System.ComponentModel.DataAnnotations;

namespace ProjetBHLeasing.Models
{
    public class Client
    {
        [Key]
        public int IDrow { get; set; }
        public String clientId { get; set; }
        public string? observations { get; set; }
        public double? montant { get; set; }
        public DateTime? dateReglement { get; set; }

        public DateTime? dateAppel { get; set; }
        public enum resultatsEnum
        {
            [Display(Name = "CLASSE")]
            CLASSE = 3,
            [Display(Name = "CLASSEBHL")]
            CLASSEBHL = 3,
            [Display(Name = "CLASSETCC")]
            CLASSETCC = 3,
            [Display(Name = "CLIENT_INJ")]
            CLIENT_INJ = 2,
            [Display(Name = "CONTESTARI")]
            CONTESTARI = 8,
            [Display(Name = "FAUXNUMERO")]
            FAUXNUMERO = 14,
            [Display(Name = "INJOIN")]
            INJOIN = 7,
            [Display(Name = "NRP")]
            NRP = 7,
            [Display(Name = "OCCUPE")]
            OCCUPE = 10,
            [Display(Name = "RAPPEL")]
            RAPPEL = 18,
            [Display(Name = "RELANCE")]
            RELANCE = 4,
            [Display(Name = "TEL_ETEINT")]
            TEL_ETEINT = 17,
            [Display(Name = "TEL_DERANG")]
            TEL_DERANG = 12,
            [Display(Name = "REPONDEUR")]
            REPONDEUR = 16
        }

        public resultatsEnum resultats { get; set; }

        public int idAction { get; set; }

        public Client()
        {
            idAction = 1;
        }
    }
}
