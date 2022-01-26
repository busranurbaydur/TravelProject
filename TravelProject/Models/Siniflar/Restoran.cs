using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject.Models.Siniflar
{
    public class Restoran
    {
        [Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Adresi { get; set; }
        public string YemekCesidi { get; set; }
        public string FotoUrl { get; set; }
    }
}