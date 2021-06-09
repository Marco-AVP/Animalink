﻿using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Animalink.Data
{
    public class Sale : Entity
    {
        [Column(TypeName = "varchar(255)")]
        public string NftName { get; set; }
        [Column(TypeName = "decimal(18,8)")]
        public decimal OriginalPrice { get; set; }
        [Column(TypeName = "decimal(18,8)")]
        public decimal SoldBy { get; set; }
        public int MintNumber { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("NftTemplate")]
        public Guid NftTemplateId { get; set; }


        public Sale()
        {

        }
    }
}
