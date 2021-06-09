using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class NftTemplate : Entity
    {
        public bool IsPublished { get; set; }
        public DateTime PublishedAt { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(2000)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Collection { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Schema { get; set; }
        [Column(TypeName = "decimal(18,8)")]
        public decimal Price { get; set; }
        public int MaxSupply { get; set; }
        [Column(TypeName = "varchar(1000)")]
        public string ImageReference { get; set; }
        public bool IsTransferable { get; set; }
        public bool IsBurnable { get; set; }
        public int NumberAvailable { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string NftType { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Rarity { get; set; }
        public int? RarityLevel { get; set; }
        public int AtomicAssetsId { get; set; }


        [ForeignKey("Animal")]
        public Guid? AnimalId { get; set; }  // can be Null


        public NftTemplate()
        {

        }

   
    }
}
