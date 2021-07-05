using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class Rarity : Entity
    {
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }
        public int Level { get; set; }


        public ICollection<Template> Templates { get; set; }

        public Rarity()
        {

        }
    }
}
