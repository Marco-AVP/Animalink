using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Animalink.Services
{
    public class AtomicAssets
    {

        public async Task<string> GetTemplateById(string collectionName, string templateId) 
        {

            WebClient client = new WebClient();

            var result = client.DownloadString($"https://wax.api.atomicassets.io/atomicassets/v1/templates/{collectionName}/{templateId}");

            return result;
        }

        public async Task<string> GetAllTemplatesInCollection(string collectionName)
        {

            WebClient client = new WebClient();

            var result = client.DownloadString($"https://wax.api.atomicassets.io/atomicassets/v1/templates?collection_name={collectionName}");

            return result;
        }

    }
}
