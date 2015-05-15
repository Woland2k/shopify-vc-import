﻿using System.Runtime.Serialization;
using Altsoft.ShopifyImportModule.Data.Models.Shopify.Base;

namespace Altsoft.ShopifyImportModule.Data.Models.Shopify
{
    [DataContract]
    public class ShopifyOption : ShopifyEntity
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "position")]
        public int Position { get; set; }

        [DataMember(Name = "product_id")]
        public long ProductId { get; set; }
    }
}