using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class Animal : Entity
    {
        public string AnimalName { get; set; }
        public string Taxonomy { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string IUCN { get; set; }
        public string IUCNAcronym { get; set; }


        public ICollection<NftTemplate> NftTemplates { get; set; }

        public Animal()
        {

        }
    }
}
