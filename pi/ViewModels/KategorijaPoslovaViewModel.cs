using System.Collections.Generic;
using FirmaMvc.Models;
using FirmaMvc.ViewModels;

namespace FirmaMvc.ViewModels
{
    public class KategorijaPoslovaViewModel
    {
        public IEnumerable<KategorijaPoslova> kategorijaposlova { get; set; }
        public PagingInfo PagingInfo { get; set; }

        public KategorijaPoslovaFilter Filter { get; set; }
    }
}