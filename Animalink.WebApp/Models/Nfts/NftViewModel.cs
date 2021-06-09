using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.WebApp.Models.Nfts
{
    public class NftViewModel
    {
        public List<TemplateDataPoco> NftDataPocos { get; set; }


        public NftViewModel()
        {
            NftDataPocos = new List<TemplateDataPoco>();
        }

    }
}
