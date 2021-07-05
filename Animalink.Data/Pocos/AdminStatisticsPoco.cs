using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos
{
    public class AdminStatisticsPoco // used to present the stats in presentation
    {
        public int TotalNumberOfAssets { get; set; }
        public int TotalNumberOfAssetsSold { get; set; }
        public int TotalNumberOfAnimals { get; set; }
        public int TotalNumberOfSpecies{ get; set; }
        public decimal TotalValueMade { get; set; }
        public decimal TotalValueDonated { get; set; }
        public int TotalNumberOfUsers { get; set; }
    }
}
