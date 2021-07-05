using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Templates
{
    public class DetailsTemplateViewModel
    {
        public FullTemplateDataPoco TemplateDataPoco { get; set; }

        public DetailsTemplateViewModel()
        {
            TemplateDataPoco = new FullTemplateDataPoco();
        }
    }
}
