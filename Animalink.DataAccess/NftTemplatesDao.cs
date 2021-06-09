using Animalink.Data;
using Animalink.Data.Context;
using Animalink.Data.Pocos.Nfts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalink.DataAccess
{
    public class NftTemplatesDao
    {
        public async Task<List<TemplateDataPoco>> GetAllNftTemplates(string nftType)
        {
            using var context = new AnimalinkDBContext();

            var query = (from nftTemplate in context.NftTemplates
                         select nftTemplate);

            if(nftType != null)
            {
                query = query.Where(i => i.NftType == nftType);
            }

            return await (from nftTemplate in query
                            
                            join a in context.Animals on nftTemplate.AnimalId equals a.Id into ani
                            from animal in ani.DefaultIfEmpty()
                            select new TemplateDataPoco
                            {
                                Id = nftTemplate.Id,
                                AtomicAssetsId = nftTemplate.AtomicAssetsId,
                                IsPublished = nftTemplate.IsPublished,
                                PublishedAt = nftTemplate.PublishedAt,
                                NftName = nftTemplate.Name, 
                                Description = nftTemplate.Description,
                                Collection = nftTemplate.Collection,
                                Schema = nftTemplate.Schema,
                                Price = nftTemplate.Price,
                                MaxSupply = nftTemplate.MaxSupply,
                                ImageReference = nftTemplate.ImageReference,
                                IsTransferable = nftTemplate.IsTransferable,
                                IsBurnable = nftTemplate.IsBurnable,
                                NumberAvailable = nftTemplate.NumberAvailable,
                                NftType = nftTemplate.NftType,
                                Rarity = nftTemplate.Rarity,
                                RarityLevel = nftTemplate.RarityLevel,
                                //Animal Attributes
                                Taxonomy = animal.Taxonomy,
                                Species = animal.Species,
                                Habitat = animal.Habitat,
                                IUCN = animal.IUCN,
                                IUCNAcronym = animal.IUCNAcronym

                                }).ToListAsync();
        }


        public async Task<TemplateDataPoco> GetNftTemplate(Guid nftId)   
        {
            using var context = new AnimalinkDBContext();

            return await (from nftTemplate in context.NftTemplates
                           where nftTemplate.Id == nftId
                           join a in context.Animals on nftTemplate.AnimalId equals a.Id into ani
                           from animal in ani.DefaultIfEmpty()
                           select new TemplateDataPoco
                           {
                               Id = nftTemplate.Id,
                               AtomicAssetsId = nftTemplate.AtomicAssetsId,
                               IsPublished = nftTemplate.IsPublished,
                               PublishedAt = nftTemplate.PublishedAt,
                               NftName = nftTemplate.Name, 
                               Description = nftTemplate.Description,
                               Collection = nftTemplate.Collection,
                               Schema = nftTemplate.Schema,
                               Price = nftTemplate.Price,
                               MaxSupply = nftTemplate.MaxSupply,
                               ImageReference = nftTemplate.ImageReference,
                               IsTransferable = nftTemplate.IsTransferable,
                               IsBurnable = nftTemplate.IsBurnable,
                               NumberAvailable = nftTemplate.NumberAvailable,
                               NftType = nftTemplate.NftType,
                               Rarity = nftTemplate.Rarity,
                               RarityLevel = nftTemplate.RarityLevel,
                               //Animal Attributes
                               Taxonomy = animal.Taxonomy,
                               Species = animal.Species,
                               Habitat = animal.Habitat,
                               IUCN = animal.IUCN,
                               IUCNAcronym = animal.IUCNAcronym

                           }).SingleOrDefaultAsync();
        }




        //public async Task<List<NftDataPoco>> GetAllAnimalNftTemplates()   //inner join,  devolve apenas NFTs que tenham 1 animal ID
        //{
        //    using var context = new AnimalinkDBContext();

        //    var allNfts = (from nftTemplate in context.NftTemplates

        //                   join animal in context.Animals on nftTemplate.AnimalId equals animal.Id
        //                   select new NftDataPoco
        //                   {
        //                       IsPublished = nftTemplate.IsPublished,
        //                       PublishedAt = nftTemplate.PublishedAt,
        //                       NftName = nftTemplate.Name, //------------------ if animal.name == null
        //                       Description = nftTemplate.Description,
        //                       Collection = nftTemplate.Collection,
        //                       Schema = nftTemplate.Schema,
        //                       Price = nftTemplate.Price,
        //                       MaxSupply = nftTemplate.MaxSupply,
        //                       ImageReference = nftTemplate.ImageReference,
        //                       IsTransferable = nftTemplate.IsTransferable,
        //                       IsBurnable = nftTemplate.IsBurnable,
        //                       NumberAvailable = nftTemplate.NumberAvailable,
        //                       NftType = nftTemplate.NftType,
        //                       Rarity = nftTemplate.Rarity,
        //                       RarityLevel = nftTemplate.RarityLevel,
        //                       //Animal Attributes
        //                       Taxonomy = animal.Taxonomy,
        //                       Species = animal.Species,
        //                       Habitat = animal.Habitat,
        //                       IUCN = animal.IUCN,
        //                       IUCNAcronym = animal.IUCNAcronym

        //                   }).ToList();
        //    return allNfts;
        //}
    }
}
