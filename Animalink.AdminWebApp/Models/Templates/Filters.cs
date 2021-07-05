using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Templates
{
    public class Filters
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

        public List<Filters> GetTemplateTypeList { get; set; }
        public List<Filters> GetRarityList { get; set; }
        public List<Filters> GetSchemaList { get; set; }
        public List<Filters> GetCollectionList { get; set; }

        public string[] TemplateTypeList { get; set; }
        public string[] RarityList { get; set; }
        public string[] SchemaList { get; set; }
        public string[] CollectionList { get; set; }

    }
}

