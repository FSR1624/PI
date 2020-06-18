using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaMvc.Models
{
    public partial class Certifikati
    {

        public Certifikati()
        {
            CertifikatZaposlenik = new HashSet<CertifikatZaposlenik>();
        }
     //   [Display(Name = "ID Certifikata", Prompt = "Unesite ID")]
      //  [Required(ErrorMessage = "ID Certifikata je obvezno polje")]
        public int Id { get; set; }

        [Display(Name = "Naziv Certifikata", Prompt = "Unesite Naziv")]
        public string Naziv { get; set; }

        [Display(Name = "Opis Certifikata", Prompt = "Unesite Opis")]
        public string Opis { get; set; }

        public virtual ICollection<CertifikatZaposlenik> CertifikatZaposlenik { get; set; }
    }
}
