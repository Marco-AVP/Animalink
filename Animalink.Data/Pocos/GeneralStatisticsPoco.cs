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
        public int NumberOfTemplatesLeastConcerned { get; set; }
        public int NumberOfTemplatesNearThreatened { get; set; }
        public int NumberOfTemplatesVulnerable { get; set; }
        public int NumberOfTemplatesEndangered { get; set; }
        public int NumberOfTemplatesCriticallyEndangered { get; set; }
        public int NumberOfTemplatesExtinctInTheWild { get; set; }
        public int NumberOfTemplatesExtinct { get; set; }

    }
}
