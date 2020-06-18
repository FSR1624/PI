using System;
using System.Collections.Generic;

namespace FirmaMvc.Models
{
    public partial class KategorijaZaposlenik
    {
        public int Id { get; set; }
        public int ZaposlenikId { get; set; }
        public int KategorijaId { get; set; }

        public virtual KategorijaPoslova Kategorija { get; set; }
    }
}
