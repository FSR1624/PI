using System;
using System.Collections.Generic;

namespace FirmaMvc.Models
{
    public partial class CertifikatZaposlenik
    {
        public int Id { get; set; }
        public int? ZaposlenikId { get; set; }
        public int? CertifikatId { get; set; }

        public virtual Certifikati Certifikat { get; set; }
    }
}
