using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Services
{

    public class Collection
    {
        public string collection_name { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string author { get; set; }
        public bool allow_notify { get; set; }
        public List<string> authorized_accounts { get; set; }
        public List<object> notify_accounts { get; set; }
        public double market_fee { get; set; }
        public string created_at_block { get; set; }
        public string created_at_time { get; set; }
    }

    public class Format
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Schema
    {
        public string schema_name { get; set; }
        public List<Format> format { get; set; }
        public string created_at_block { get; set; }
        public string created_at_time { get; set; }
    }

    public class ImmutableData
    {
        public string Hex { get; set; }
        public string RGB { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string Rarity { get; set; }
    }

    public class Template
    {
        //public int MaxSupply
        //{
        //    get { return Int32.Parse(max_supply); }
        //}

        public string template_id { get; set; }
        public string max_supply { get; set; }
        public bool is_transferable { get; set; }
        public bool is_burnable { get; set; }
        public string issued_supply { get; set; }
        public ImmutableData immutable_data { get; set; }
        public string created_at_time { get; set; }
        public string created_at_block { get; set; }
    }

    public class MutableData
    {
    }

    public class AssetData
    {
        public string Hex { get; set; }
        public string RGB { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public string Rarity { get; set; }
        public string contract { get; set; }
        public string asset_id { get; set; }
        public string owner { get; set; }
        public bool is_transferable { get; set; }
        public bool is_burnable { get; set; }
        public Collection collection { get; set; }
        public Schema schema { get; set; }
        public Template template { get; set; }
        public MutableData mutable_data { get; set; }
        public ImmutableData immutable_data { get; set; }
        public string template_mint { get; set; }
        public List<object> backed_tokens { get; set; }
        public object burned_by_account { get; set; }
        public object burned_at_block { get; set; }
        public object burned_at_time { get; set; }
        public string updated_at_block { get; set; }
        public string updated_at_time { get; set; }
        public string transferred_at_block { get; set; }
        public string transferred_at_time { get; set; }
        public string minted_at_block { get; set; }
        public string minted_at_time { get; set; }
        public AssetData data { get; set; }
    }

    public class TemplateData
    {
        public int? MaxSupply
        {
            get 
            {
                if (max_supply == null) return null;
                return Int32.Parse(max_supply); 
            }
            set { max_supply = value.ToString(); }
        }

        public int? IssuedSupply
        {
            get 
            {
                if (issued_supply == null) return null;
                return Int32.Parse(issued_supply); 
            }
            set { issued_supply = value.ToString(); }
        }

        public string contract { get; set; }
        public string template_id { get; set; }
        public bool is_transferable { get; set; }
        public bool is_burnable { get; set; }
        internal string issued_supply { get; set; }
        internal string max_supply { get; set; }
        public Collection collection { get; set; }
        public Schema schema { get; set; }
        public ImmutableData immutable_data { get; set; }
        public string created_at_time { get; set; }
        public string created_at_block { get; set; }
        public string name { get; set; }
    }

    public class Root <T>
    {
        public bool success { get; set; }
        public T data { get; set; }
        public long query_time { get; set; }
    }


}
