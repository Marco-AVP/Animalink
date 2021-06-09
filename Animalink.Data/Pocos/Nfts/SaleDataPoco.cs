using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos.Nfts
{
    public class SaleDataPoco
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid AssetId { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal SoldBy { get; set; }
        public int MintNumber { get; set; }

    }
}
