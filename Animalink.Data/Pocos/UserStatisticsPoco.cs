using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data.Pocos
{
    public class UserStatisticsPoco  // used to present the stats in presentation
    {
        public int TotalNumberOfAssetsBought { get; set; }
        public int TotalContributionToPartners { get; set; } 
        public DateTime MemberSince { get; set; }

    }
}
