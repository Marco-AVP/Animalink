using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class NftTemplate : NamedEntity
    {
        public bool IsPublished { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Taxonomy { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string Description { get; set; }
        public int NumberOfExistingAnimals { get; set; }
        public string Collection { get; set; }
        public string Schema { get; set; }
        public decimal Price { get; set; }
        public int Supply { get; set; }
        public string ImageReference { get; set; }


        public NftTemplate(Guid id, bool isDeleted, DateTime createdAt, DateTime updatedAt, string name) : base(id, isDeleted, createdAt, updatedAt, name)
        {

        }
    }
}
