using System;
using System.Linq;
using FirmaMvc.Models;

namespace FirmaMvc.ViewModels{

    public class KategorijaPoslovaFilter : IPageFilter{

        public int? Id { get; set; }

        public string Naziv { get; set; }
        public bool IsEmpty(){
            bool active = Id.HasValue;
            return !active;
        }
        public override string ToString(){
            return string.Format("{0}-{1}",
            Id,
            Naziv);
        }
        public static KategorijaPoslovaFilter FromString(string s){
            var filter = new KategorijaPoslovaFilter();
            try{
                var arr = s.Split('-', StringSplitOptions.None);
                filter.Id = string.IsNullOrWhiteSpace(arr[0]) ? new int?() : int.Parse(arr[0]);
            }
            catch{

            }
            return filter;
        }

        public IQueryable<KategorijaPoslova> Apply(IQueryable<KategorijaPoslova> query){
            if (Id.HasValue)
                {
                    query = query.Where(c => c.Id == Id.Value);
                }
                return query;
        }
    }
}