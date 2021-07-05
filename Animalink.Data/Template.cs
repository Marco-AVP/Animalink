using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class Template : Entity
    {
        
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(2000)")]
        public string Description { get; set; }

        public int? AtomicAssetsId { get; set; }

        [Column(TypeName = "decimal(18,8)")]
        public decimal Price { get; set; }

        public int MaxSupply { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string ImageReference { get; set; }

        public bool IsTransferable { get; set; }

        public bool IsBurnable { get; set; }

        public bool? IsPublished { get; set; }

        public DateTime? PublishedAt { get; set; }

        public int? NumberAvailable { get; set; }

        


        [ForeignKey("Animal")]
        public Guid? AnimalId { get; set; }  // can be Null

        [ForeignKey("TemplateType")]
        public Guid TemplateTypeId { get; set; }

        [ForeignKey("Rarity")]
        public Guid RarityId { get; set; }

        [ForeignKey("Schema")]
        public Guid SchemaId { get; set; }

        [ForeignKey("Collection")]
        public Guid CollectionId { get; set; }
        


        public Template()
        {

        }

   
    }
}
