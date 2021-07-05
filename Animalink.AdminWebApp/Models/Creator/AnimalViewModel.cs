using Animalink.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Creator
{
    public class AnimalViewModel
    {
        //[Required]
        public Guid AnimalId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Taxonomy { get; set; }
        [Required]
        [MaxLength(255)]
        public string Species { get; set; }
        [Required]
        [MaxLength(255)]
        public string Habitat { get; set; }
        [Required]
        [MaxLength(255)]
        public string IUCN { get; set; }
        [Required]
        [MaxLength(255)]
        public string IUCNAcronym { get; set; }


        public void FromAnimal(Animal animal)
        {
            AnimalId = animal.Id;
            Name = animal.Name;
            Taxonomy = animal.Taxonomy;
            Species = animal.Species;
            Habitat = animal.Habitat;
            IUCN = animal.IUCN;
            IUCNAcronym = animal.IUCNAcronym;
        }

        public Animal ToAnimal(Animal dBAnimal)
        {
            dBAnimal.Id = AnimalId; ;
            dBAnimal.Name = Name;
            dBAnimal.Taxonomy = Taxonomy;
            dBAnimal.Species = Species;
            dBAnimal.Habitat = Habitat;
            dBAnimal.IUCN = IUCN;
            dBAnimal.IUCNAcronym = IUCNAcronym;

            return dBAnimal;
        }
    }
}
