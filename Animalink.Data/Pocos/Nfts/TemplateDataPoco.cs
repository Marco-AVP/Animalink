using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.Data.Pocos.Nfts
{
    public class TemplateDataPoco // used to present Nfts in presentation
    {
        public Guid Id { get; set; }
        public int? AtomicAssetsId { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishedAt { get; set; }
        public string NftName { get; set; }
        public string Description { get; set; }
        public string Collection { get; set; }
        public string Schema { get; set; }
        public decimal Price { get; set; }
        public int MaxSupply { get; set; }
        public string ImageReference { get; set; }
        public bool IsTransferable { get; set; }
        public bool IsBurnable { get; set; }
        public int NumberAvailable { get; set; }
        public string NftType { get; set; }
        public string Rarity { get; set; }
        public int? RarityLevel { get; set; }

        //Animal Attributes
        public string Taxonomy { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string IUCN { get; set; }
        public string IUCNAcronym { get; set; }

    }
}
