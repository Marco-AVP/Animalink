using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class Partner : Entity
    {
        [Column(TypeName = "varchar(255)")]
        public string PartnerName { get; set; }
        [Column(TypeName = "varchar(2000)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(1000)")]
        public string ImageReference { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string WebsiteURL { get; set; }


       public Partner()
        {

        }
    }
}
