using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb3_LudwigOleby.Models
{
    public partial class TblPersonal
    {
        [Key]
        public int PersonalId { get; set; }
        public string FörNamn { get; set; }
        public string EfterNamn { get; set; }
        public int Telefon { get; set; }
        public string Roll { get; set; }
    }
}
