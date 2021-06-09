using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Nfts
{
    public class TemplatesViewModel
    {
        public List<TemplateDataPoco> AllTemplatesDataPocos { get; set; }

        public TemplatesViewModel()
        {
            AllTemplatesDataPocos = new List<TemplateDataPoco>();
        }
    }
}
