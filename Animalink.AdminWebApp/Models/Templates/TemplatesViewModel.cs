using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Templates
{
    public class TemplatesViewModel 
    {
 
        public Guid? TemplateId { get; set; }
        public string TemplateName { get; set; }
        public Guid? TemplateTypeId { get; set; }
        public string TemplateType { get; set; }
        public Guid? RarityId { get; set; }
        public string Rarity { get; set; }
        public Guid? SchemaId { get; set; }
        public string Schema { get; set; }
        public Guid? CollectionId { get; set; }
        public string Collection { get; set; }

        public List<TemplatesViewModel> GetTemplateNameList { get; set; }
        public List<TemplatesViewModel> GetTemplateTypeList { get; set; }
        public List<TemplatesViewModel> GetRarityList { get; set; }
        public List<TemplatesViewModel> GetSchemaList { get; set; }
        public List<TemplatesViewModel> GetCollectionList { get; set; }

        public string[] TemplateNameList { get; set; }
        public string[] TemplateTypeList { get; set; }
        public string[] RarityList { get; set; }
        public string[] SchemaList { get; set; }
        public string[] CollectionList { get; set; }

        public List<FullTemplateDataPoco> AllTemplatesDataPocos { get; set; }

        public TemplatesViewModel()
        {
            AllTemplatesDataPocos = new List<FullTemplateDataPoco>();
        }
    }
}
