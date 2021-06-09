using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos
{
    public class GeneralStatisticsPoco  // used to present the stats in presentation
    {
        public string MostSoldAnimal { get; set; }
        public string MostValuableAnimal { get; set; }
        public string RarestAnimal { get; set; }
        public string LessRareAnimal { get; set; }
        public int NumberOfSpeciesAvailable { get; set; }
        public int NumberOfNftsLeastConcerned { get; set; }
        public int NumberOfNftsNearThreatened { get; set; }
        public int NumberOfNftsVulnerable { get; set; }
        public int NumberOfNftsEndangered { get; set; }
        public int NumberOfNftsECriticallyEndangered { get; set; }
        public int NumberOfNftsExtinctInTheWild { get; set; }
        public int NumberOfNftsExtinct { get; set; }

    }
}
