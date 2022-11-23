using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitabeviApp.Web.ViewModels
{
    public class KitapListViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int BasimYili { get; set; }
        public int SayfaSayisi { get; set; }
        public string YazarAd { get; set; }
        public string KategoriAd { get; set; }
        public int YazarId { get; set; }
        public int KategoriId { get; set; }
    }
}