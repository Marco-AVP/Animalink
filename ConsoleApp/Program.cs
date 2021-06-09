using Animalink.Business.Nfts;
using Animalink.Data.Pocos.Nfts;
using Animalink.Services;
using Animalink.WebApp.Models.Nfts;
using System;
using System.Net;
using System.Text.Json;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var atomicAssets = new AtomicAssets();
            //var resultTemplates = atomicAssets.GetAllTemplatesInCollection("mavp4thearte");
            //var atomicAssetsData = new RootList<TemplateData>();
            //atomicAssetsData = JsonSerializer.Deserialize<RootList<TemplateData>>(resultTemplates.Result);

            var atomicAssets = new AtomicAssets();
            var resultTemplate = atomicAssets.GetTemplateById("mavp4thearte", 151352);
            var atomicAssetsData = new Root<TemplateData>();
            atomicAssetsData = JsonSerializer.Deserialize<Root<TemplateData>>(resultTemplate.Result);
            var allNftsModel = new AllNftsViewModel();


            
                var nftTemplateData = new TemplateDataPoco();

                nftTemplateData.AtomicAssetsId = (int)Int64.Parse(atomicAssetsData.data.template_id);
                nftTemplateData.NftName = atomicAssetsData.data.name;
                nftTemplateData.Price = 1111;
                nftTemplateData.NumberAvailable = (int)Int64.Parse(atomicAssetsData.data.max_supply) - (int)Int64.Parse(atomicAssetsData.data.issued_supply);
                nftTemplateData.ImageReference = atomicAssetsData.data.immutable_data.img;
                allNftsModel.AllTemplatesDataPocos.Add(nftTemplateData);
            

            foreach (var item in allNftsModel.AllTemplatesDataPocos)
            {
                Console.WriteLine("Asset ID: " + item.AtomicAssetsId);
                Console.WriteLine("Name: " + item.NftName);
                Console.WriteLine("Price: " + item.Price);
                Console.WriteLine("Number Available: " + item.NumberAvailable);
                Console.WriteLine("Img ref: " + item.ImageReference);
                Console.WriteLine("|||");
            }

            Console.WriteLine("|||");

        }
    }
}
