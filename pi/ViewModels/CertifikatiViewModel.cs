using System.Collections.Generic;
using FirmaMvc.Models;
using FirmaMvc.ViewModels;

namespace FirmaMvc.ViewModels
{
    public class CertifikatiViewModel
    {
        public IEnumerable<Certifikati> certifikati { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public CertifikatiFilter Filter { get; set; }
    }
}