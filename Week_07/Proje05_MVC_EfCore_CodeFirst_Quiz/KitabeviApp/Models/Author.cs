using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KitabeviApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int DogumYili { get; set; }
        public char Cinsiyet { get; set; }
    }
}