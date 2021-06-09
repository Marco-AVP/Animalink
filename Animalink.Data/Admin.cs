using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class Admin : Entity
    {
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string UserName { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set; }


        public Admin()
        {

        }

    }
}
