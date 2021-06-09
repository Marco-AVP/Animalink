using Animalink.Data.Pocos.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.WebApp.Models.Partners
{
    public class AllPartnersViewModel
    {
        public List<PartnerDataPoco> PartnersDataPocos { get; set; }

        public AllPartnersViewModel()
        {
            PartnersDataPocos = new List<PartnerDataPoco>();
        }
    }
}
