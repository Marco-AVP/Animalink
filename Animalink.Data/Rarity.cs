using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class Rarity : Entity
    {
        public string Name { get; set; }
        public string IUCN { get; set; }
        public int Level { get; set; }
        public string NftType { get; set; }
        

    }
}
