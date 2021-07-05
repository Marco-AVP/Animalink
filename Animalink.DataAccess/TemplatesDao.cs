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
    public class TemplatesDao
    {

        // Add get template by animal name, make generic method (dont repeat code)

        // Get All Full Templates
        public async Task<List<FullTemplateDataPoco>> GetAllFullTemplates()
        {
            using var context = new AnimalinkDBContext();

            var query = (from template in context.Templates
                         select template);


            return await (from dbTemplate in query

                          join a in context.Animals on dbTemplate.AnimalId equals a.Id into ani
                          from animal in ani.DefaultIfEmpty()

                          join t in context.TemplateTypes on dbTemplate.TemplateTypeId equals t.Id into type
                          from templateType in type.DefaultIfEmpty()

                          join r in context.Rarities on dbTemplate.RarityId equals r.Id into rar
                          from rarity in rar.DefaultIfEmpty()

                          join s in context.Schemas on dbTemplate.SchemaId equals s.Id into sche
                          from schema in sche.DefaultIfEmpty()

                          join c in context.Collections on dbTemplate.CollectionId equals c.Id into colle
                          from collection in colle.DefaultIfEmpty()

                          select new FullTemplateDataPoco
                          {
                              Id = dbTemplate.Id,
                              AtomicAssetsId = dbTemplate.AtomicAssetsId,
                              Name = dbTemplate.Name,
                              Description = dbTemplate.Description,
                              Collection = collection.Name,
                              Schema = schema.Name,
                              Price = dbTemplate.Price,
                              MaxSupply = dbTemplate.MaxSupply,
                              ImageReference = dbTemplate.ImageReference,
                              IsDeleted = dbTemplate.IsDeleted,
                              IsTransferable = dbTemplate.IsTransferable,
                              IsBurnable = dbTemplate.IsBurnable,
                              IsPublished = dbTemplate.IsPublished,
                              PublishedAt = dbTemplate.PublishedAt,
                              NumberAvailable = dbTemplate.NumberAvailable,
                              TemplateType = templateType.Name,
                              Rarity = rarity.Name,
                              RarityLevel = rarity.Level,
                              //Animal Attributes
                              Taxonomy = animal.Taxonomy,
                              Species = animal.Species,
                              Habitat = animal.Habitat,
                              IUCN = animal.IUCN,
                              IUCNAcronym = animal.IUCNAcronym

                          }).ToListAsync();
        }


        //Get All Full Templates by Filters
        public async Task<List<FullTemplateDataPoco>> GetAllFullTemplatesByFilters(string templateName, Guid? templateTypeId, Guid? rarityId, Guid? schemaId, Guid? collectionId)
        {
            using var context = new AnimalinkDBContext();

            var query = (from template in context.Templates
                         select template);

            if (templateName != null)
            {
                query = query.Where(i => i.Name == templateName);

            }
            if (templateTypeId != null)
            {
                query = query.Where(i => i.TemplateTypeId == templateTypeId);

            }
            if (rarityId != null)
            {
                query = query.Where(i => i.RarityId == rarityId);
            }
            if (schemaId != null)
            {
                query = query.Where(i => i.SchemaId == schemaId);
            }
            if (collectionId != null)
            {
                query = query.Where(i => i.CollectionId == collectionId);
            }

            //if (templateTypeId != null)
            //{
            //    query = query.Where(i => i.TemplateTypeId == templateTypeId);

            //    query.Where(i => i.TemplateTypeId == var1 || i.TemplateTypeId == var2)
            //}


            return await (from dbTemplate in query

                          join a in context.Animals on dbTemplate.AnimalId equals a.Id into ani
                          from animal in ani.DefaultIfEmpty()

                          join t in context.TemplateTypes on dbTemplate.TemplateTypeId equals t.Id into type
                          from templateType in type.DefaultIfEmpty()

                          join r in context.Rarities on dbTemplate.RarityId equals r.Id into rar
                          from rarity in rar.DefaultIfEmpty()

                          join s in context.Schemas on dbTemplate.SchemaId equals s.Id into sche
                          from schema in sche.DefaultIfEmpty()

                          join c in context.Collections on dbTemplate.CollectionId equals c.Id into colle
                          from collection in colle.DefaultIfEmpty()

                          select new FullTemplateDataPoco
                          {
                              Id = dbTemplate.Id,
                              AtomicAssetsId = dbTemplate.AtomicAssetsId,
                              Name = dbTemplate.Name,
                              Description = dbTemplate.Description,
                              Price = dbTemplate.Price,
                              MaxSupply = dbTemplate.MaxSupply,
                              ImageReference = dbTemplate.ImageReference,
                              IsDeleted = dbTemplate.IsDeleted,
                              IsTransferable = dbTemplate.IsTransferable,
                              IsBurnable = dbTemplate.IsBurnable,
                              IsPublished = dbTemplate.IsPublished,
                              PublishedAt = dbTemplate.PublishedAt,
                              NumberAvailable = dbTemplate.NumberAvailable,
                              // other data
                              CollectionId = collection.Id,
                              Collection = collection.Name,
                              SchemaId = schema.Id,
                              Schema = schema.Name,
                              TemplateTypeId = templateType.Id,
                              TemplateType = templateType.Name,
                              RarityId = rarity.Id,
                              Rarity = rarity.Name,
                              RarityLevel = rarity.Level,
                              //Animal Attributes
                              AnimalId = animal.Id,
                              AnimalName = animal.Name,
                              Taxonomy = animal.Taxonomy,
                              Species = animal.Species,
                              Habitat = animal.Habitat,
                              IUCN = animal.IUCN,
                              IUCNAcronym = animal.IUCNAcronym

                          }).ToListAsync();

            //if existe um filtro de texto ativado
            //query = query.Where(e => e.NftName.Contains())

            //query = query.Skip(10).Take(10);


        }



        //Get All Full Templates by TemplateType
        public async Task<List<FullTemplateDataPoco>> GetAllFullTemplatesByType(Guid templateTypeId)
        {
            using var context = new AnimalinkDBContext();

            var query = (from template in context.Templates
                         select template);

            if(templateTypeId != null)
            {
                query = query.Where(i => i.TemplateTypeId == templateTypeId);
            }


            return await (from dbTemplate in query
                            
                            join a in context.Animals on dbTemplate.AnimalId equals a.Id into ani
                            from animal in ani.DefaultIfEmpty()

                            join t in context.TemplateTypes on dbTemplate.TemplateTypeId equals t.Id into type
                            from templateType in type.DefaultIfEmpty()

                            join r in context.Rarities on dbTemplate.RarityId equals r.Id into rar
                            from rarity in rar.DefaultIfEmpty()

                            join s in context.Schemas on dbTemplate.SchemaId equals s.Id into sche
                            from schema in sche.DefaultIfEmpty()

                            join c in context.Collections on dbTemplate.CollectionId equals c.Id into colle
                            from collection in colle.DefaultIfEmpty()

                          select new FullTemplateDataPoco
                            {
                                Id = dbTemplate.Id,
                                AtomicAssetsId = dbTemplate.AtomicAssetsId,
                                Name = dbTemplate.Name,
                                Description = dbTemplate.Description,
                                Collection = collection.Name,
                                Schema = schema.Name,
                                Price = dbTemplate.Price,
                                MaxSupply = dbTemplate.MaxSupply,
                                ImageReference = dbTemplate.ImageReference,
                                IsDeleted = dbTemplate.IsDeleted,
                                IsTransferable = dbTemplate.IsTransferable,
                                IsBurnable = dbTemplate.IsBurnable,
                                IsPublished = dbTemplate.IsPublished,
                                PublishedAt = dbTemplate.PublishedAt,
                                NumberAvailable = dbTemplate.NumberAvailable,
                                TemplateType = templateType.Name,
                                Rarity = rarity.Name,
                                RarityLevel = rarity.Level,
                                //Animal Attributes
                                Taxonomy = animal.Taxonomy,
                                Species = animal.Species,
                                Habitat = animal.Habitat,
                                IUCN = animal.IUCN,
                                IUCNAcronym = animal.IUCNAcronym

                          }).ToListAsync();
        }


        //Get All Full Templates by Template Name
        public async Task<List<FullTemplateDataPoco>> GetAllFullTemplatesByName(string templateName)
        {
            using var context = new AnimalinkDBContext();

            var query = (from template in context.Templates
                         select template);

            if (templateName != null)
            {
                query = query.Where(i => i.Name == templateName);
            }

            return await (from dbTemplate in query

                          join a in context.Animals on dbTemplate.AnimalId equals a.Id into ani
                          from animal in ani.DefaultIfEmpty()

                          join t in context.TemplateTypes on dbTemplate.TemplateTypeId equals t.Id into type
                          from templateType in type.DefaultIfEmpty()

                          join r in context.Rarities on dbTemplate.RarityId equals r.Id into rar
                          from rarity in rar.DefaultIfEmpty()

                          join s in context.Schemas on dbTemplate.SchemaId equals s.Id into sche
                          from schema in sche.DefaultIfEmpty()

                          join c in context.Collections on dbTemplate.CollectionId equals c.Id into colle
                          from collection in colle.DefaultIfEmpty()

                          select new FullTemplateDataPoco
                          {
                              Id = dbTemplate.Id,
                              AtomicAssetsId = dbTemplate.AtomicAssetsId,
                              Name = dbTemplate.Name,
                              Description = dbTemplate.Description,
                              Collection = collection.Name,
                              Schema = schema.Name,
                              Price = dbTemplate.Price,
                              MaxSupply = dbTemplate.MaxSupply,
                              ImageReference = dbTemplate.ImageReference,
                              IsDeleted = dbTemplate.IsDeleted,
                              IsTransferable = dbTemplate.IsTransferable,
                              IsBurnable = dbTemplate.IsBurnable,
                              IsPublished = dbTemplate.IsPublished,
                              PublishedAt = dbTemplate.PublishedAt,
                              NumberAvailable = dbTemplate.NumberAvailable,
                              TemplateType = templateType.Name,
                              Rarity = rarity.Name,
                              RarityLevel = rarity.Level,
                              //Animal Attributes
                              Taxonomy = animal.Taxonomy,
                              Species = animal.Species,
                              Habitat = animal.Habitat,
                              IUCN = animal.IUCN,
                              IUCNAcronym = animal.IUCNAcronym

                          }).ToListAsync();
        }


        // Get Full Template by Id
        public async Task<FullTemplateDataPoco> GetFullTemplateById(Guid templateId)   
        {
            using var context = new AnimalinkDBContext();

            var query = (from dbTemplate in context.Templates
                         where dbTemplate.Id == templateId

                         join a in context.Animals on dbTemplate.AnimalId equals a.Id into ani
                         from animal in ani.DefaultIfEmpty()

                         join t in context.TemplateTypes on dbTemplate.TemplateTypeId equals t.Id into type
                         from templateType in type.DefaultIfEmpty()

                         join r in context.Rarities on dbTemplate.RarityId equals r.Id into rar
                         from rarity in rar.DefaultIfEmpty()

                         join s in context.Schemas on dbTemplate.SchemaId equals s.Id into sche
                         from schema in sche.DefaultIfEmpty()

                         join c in context.Collections on dbTemplate.CollectionId equals c.Id into colle
                         from collection in colle.DefaultIfEmpty()

                         select new FullTemplateDataPoco
                         {
                            Id = dbTemplate.Id,
                            AtomicAssetsId = dbTemplate.AtomicAssetsId,
                            Name = dbTemplate.Name,
                            Description = dbTemplate.Description,
                            Collection = collection.Name,
                            Schema = schema.Name,
                            Price = dbTemplate.Price,
                            MaxSupply = dbTemplate.MaxSupply,
                            ImageReference = dbTemplate.ImageReference,
                            IsDeleted = dbTemplate.IsDeleted,
                            IsTransferable = dbTemplate.IsTransferable,
                            IsBurnable = dbTemplate.IsBurnable,
                            IsPublished = dbTemplate.IsPublished,
                            PublishedAt = dbTemplate.PublishedAt,
                            NumberAvailable = dbTemplate.NumberAvailable,
                            TemplateType = templateType.Name,
                            Rarity = rarity.Name,
                            RarityLevel = rarity.Level,
                            //Animal Attributes
                            Taxonomy = animal.Taxonomy,
                            Species = animal.Species,
                            Habitat = animal.Habitat,
                            IUCN = animal.IUCN,
                            IUCNAcronym = animal.IUCNAcronym

                         });


            return await query.SingleOrDefaultAsync();
        }

    }
}
