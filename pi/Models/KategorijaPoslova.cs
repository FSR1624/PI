using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirmaMvc.Models
{
    public partial class KategorijaPoslova
    {
        public KategorijaPoslova()
        {
            KategorijaZaposlenik = new HashSet<KategorijaZaposlenik>();
        }

       // [Display(Name = "ID Kategorije Posla", Prompt = "Unesite ID")]
        public int Id { get; set; }
        [Display(Name = "Naziv Kategorije posla", Prompt = "Unesite Naziv")]
        public string Naziv { get; set; }

        public virtual ICollection<KategorijaZaposlenik> KategorijaZaposlenik { get; set; }
    }
}
