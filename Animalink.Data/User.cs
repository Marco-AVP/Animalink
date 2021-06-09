using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class User : Entity
    {
        [Column(TypeName = "varchar(255)")]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(1000)")]
        public string ImageReference { get; set; }


        public List<Sale> Sales { get; set; }

        public User()
        {

        }

    }
}
