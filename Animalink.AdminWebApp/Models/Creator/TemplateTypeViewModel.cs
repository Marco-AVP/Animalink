using Animalink.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Creator
{
    public class TemplateTypeViewModel
    {

        public Guid TemplateTypeId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }


        public void FromTemplateType(TemplateType templateType)
        {
            TemplateTypeId = templateType.Id;
            Name = templateType.Name;
        }

        public TemplateType ToTemplateType(TemplateType dBTemplateType)
        {
            dBTemplateType.Id = TemplateTypeId;
            dBTemplateType.Name = Name;

            return dBTemplateType;
        }
    }
}
