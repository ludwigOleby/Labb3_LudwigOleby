using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Labb3_LudwigOleby.Models
{
    public partial class TblBetyg
    {
        public int BetygId { get; set; }
        public int LärarId { get; set; }
        public string Kurs { get; set; }
        public DateTime BetygsDatum { get; set; }
        public string Slutbetyg { get; set; }

        public virtual TblElever Betyg { get; set; }
        public virtual TblPersonal Lärar { get; set; }
    }
}
