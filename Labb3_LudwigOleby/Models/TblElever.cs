using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb3_LudwigOleby.Models
{
    public partial class TblElever
    {
        public int ElevId { get; set; }
        public string FörNamn { get; set; }
        public string EfterNamn { get; set; }
        public int Telefon { get; set; }
        public string Klass { get; set; }
    }
}
