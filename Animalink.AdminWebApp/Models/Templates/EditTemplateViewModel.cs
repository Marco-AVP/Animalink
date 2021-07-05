using Animalink.Data;
using Animalink.Data.Pocos.Nfts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animalink.AdminWebApp.Models.Templates
{
    public class EditTemplateViewModel
    {
        //[Required]
        public Guid TemplateId { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        public int MaxSupply { get; set; }
        [Required]
        [MaxLength(1000)]
        public string ImageReference { get; set; }
        [Required]
        public bool IsDeleted { get; set; } //remove?
        [Required]
        public bool IsTransferable { get; set; }
        [Required]
        public bool IsBurnable { get; set; }
        [Required]
        public bool? IsPublished { get; set; } //remove?


        [Required]
        [MaxLength(255)]
        public Guid Schema { get; set; }
        [Required]
        [MaxLength(255)]
        public Guid Collection { get; set; }
        [Required]
        [MaxLength(255)]
        public Guid TemplateType { get; set; }
        [Required]
        [MaxLength(255)]
        public Guid Rarity { get; set; }




        public void  FromFullTemplate(FullTemplateDataPoco fullTemplate)
        {
            TemplateId = fullTemplate.Id;
            
            Name = fullTemplate.Name;
            Description = fullTemplate.Description;
            
            Price = fullTemplate.Price;
            MaxSupply = fullTemplate.MaxSupply;
            ImageReference = fullTemplate.ImageReference;
            IsDeleted = fullTemplate.IsDeleted;
            IsPublished = fullTemplate.IsPublished;
            IsTransferable = fullTemplate.IsTransferable;
            IsBurnable = fullTemplate.IsBurnable;

            Collection = fullTemplate.CollectionId;
            Schema = fullTemplate.SchemaId;
            TemplateType = fullTemplate.TemplateTypeId;
            Rarity = fullTemplate.RarityId;
        }

        public Template ToTemplate(Template dBTemplate)
        {
            dBTemplate.Id = TemplateId;

            dBTemplate.Name = Name;
            dBTemplate.Description = Description;
            
            dBTemplate.Price = Price;
            dBTemplate.MaxSupply = MaxSupply;
            dBTemplate.ImageReference = ImageReference;
            dBTemplate.IsDeleted = IsDeleted;
            dBTemplate.IsPublished = IsPublished;
            dBTemplate.IsTransferable = IsTransferable;
            dBTemplate.IsBurnable = IsBurnable;

            dBTemplate.CollectionId = Collection;
            dBTemplate.SchemaId = Schema;
            dBTemplate.TemplateTypeId = TemplateType;
            dBTemplate.RarityId = Rarity;

            return dBTemplate;
        }


        //IsPublished Name
        //Description
        //Collection
        //Schema
        //Price
        //MaxSupply
        //ImageReference
        //IsTransferable 
        //IsBurnable
        //NftType
        //Rarity
        //RarityLevel

    }
}
