//using Animalink.Data.Base;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Text;

//namespace Animalink.Data
//{
//    public class Rarity : Entity  
//    {
//        [Column(TypeName = "varchar(255)")]
//        public string RarityName { get; set; }
//        [Column(TypeName = "varchar(255)")]
//        public string IUCN { get; set; }
//        [Column(TypeName = "varchar(255)")]
//        public string IUCNAcronym { get; set; }
//        public int? Level { get; set; }

        
//        public ICollection<NftTemplate> NftTemplates { get; set; }

//        public Rarity()
//        {

//        }
//    }
//}
