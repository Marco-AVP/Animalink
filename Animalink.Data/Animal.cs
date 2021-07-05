using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class Animal : Entity
    {
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Taxonomy { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Species { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Habitat { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string IUCN { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string IUCNAcronym { get; set; }


        public ICollection<Template> Templates { get; set; }

        public Animal()
        {

        }
    }
}
