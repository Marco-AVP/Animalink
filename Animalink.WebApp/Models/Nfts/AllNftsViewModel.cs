using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.WebApp.Models.Nfts
{
    public class AllNftsViewModel
    {
        public List<FullTemplateDataPoco> AllTemplatesDataPocos { get; set; }

        public AllNftsViewModel()
        {
            AllTemplatesDataPocos = new List<FullTemplateDataPoco>();
        }


    }
}
