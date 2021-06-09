using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos
{
    public class AdminStatisticsPoco // used to present the stats in presentation
    {
        public int TotalNumberOfNfts { get; set; }
        public int TotalNumberOfNftsSold { get; set; }
        public decimal TotalValueMade { get; set; }
        public int TotalNumberOfAnimals { get; set; }
        public int TotalNumberOfSpecies{ get; set; }
        public decimal TotalValueDonated{ get; set; }
        public decimal ValueDonatedByPartner{ get; set; }
        public int TotalNumberOfUsers{ get; set; }
    }
}
