﻿using Newtonsoft.Json;
using SnipeSharp.Attributes;
using SnipeSharp.Common;
using SnipeSharp.Endpoints.EndpointHelpers;
using SnipeSharp.JsonConverters;
using System.Collections.Generic;
using System.Linq;

namespace SnipeSharp.Endpoints.Models
{
    public class Asset : CommonEndpointModel
    {

        [JsonProperty("name")]
        [OptionalRequestHeader("name")]
        public new string Name { get; set; }

        [JsonProperty("asset_tag")]
        [RequiredRequestHeader("asset_tag")]
        public string AssetTag { get; set; }

        [JsonProperty("serial")]
        [OptionalRequestHeader("serial")]
        public string Serial { get; set; }

        [JsonProperty("model")]
        [OptionalRequestHeader("model_id")]
        public Model Model { get; set; }

        [JsonProperty("model_number")]
        [OptionalRequestHeader("model_number")]
        public string ModelNumber { get; set; }

        [JsonProperty("status_label")]
        [RequiredRequestHeader("status_id")]
        public StatusLabel StatusLabel { get; set; }

        [JsonProperty("category")]
        [OptionalRequestHeader("category_id")]
        public Category Category { get; set; }

        [JsonProperty("manufacturer")]
        [OptionalRequestHeader("manufacturer_id")]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("supplier")]
        [OptionalRequestHeader("supplier_id")]
        public Supplier Supplier { get; set; }

        [JsonProperty("notes")]
        [OptionalRequestHeader("notes")]
        public string Notes { get; set; }

        [JsonProperty("company")]
        [OptionalRequestHeader("company")]
        public Company Company { get; set; }

        [JsonProperty("location")]
        [OptionalRequestHeader("location_id")]
        public Location Location { get; set; }

        [JsonProperty("rtd_location")]
        [OptionalRequestHeader("rtd_location_id")]
        public Location RtdLocation { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("assigned_to")]
        [OptionalRequestHeader("assigned_to")]
        public User AssignedTo { get; set; }

        private string _warrantyMonths;

        [JsonProperty("warranty_months")]
        [OptionalRequestHeader("warranty_months")]
        public string WarrantyMonths
        {
            get { return _warrantyMonths; }
            set
            {

                _warrantyMonths = (value != null) ? value.Replace(" months", "") : null;
            }
        }

        [JsonProperty("warranty_expires")]
        public ResponseDate WarrantyExpires { get; set; }

        [JsonProperty("deleted_at")]
        public ResponseDate DeletedAt { get; set; }

        [JsonProperty("purchase_date")]
        [OptionalRequestHeader("purchase_date")]
        [JsonConverter(typeof(ResponseDateTimeConverter))]
        public ResponseDate PurchaseDate { get; set; }

        [JsonProperty("expected_checkin")]
        public ResponseDate ExpectedCheckin { get; set; }

        [JsonProperty("last_checkout")]
        [OptionalRequestHeader("last_checkout")]
        public ResponseDate LastCheckout { get; set; }

        [JsonProperty("purchase_cost")]
        [OptionalRequestHeader("purchase_cost")]
        public string PurchaseCost { get; set; }

        [JsonProperty("user_can_checkout")]
        public bool UserCanCheckout { get; set; }

        [JsonProperty("order_number")]
        [OptionalRequestHeader("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("custom_fields")]
        [JsonConverter(typeof(CustomFieldConverter))]
        public Dictionary<string,string> CustomFields { get; set; }

        public AssetCheckoutRequest CheckoutRequest { get; set; }

        public override Dictionary<string, string> BuildQueryString()
        {
            // TODO: Move Checkout logic here
            Dictionary<string, string> values = new Dictionary<string, string>();
            var baseValues = base.BuildQueryString();

            return baseValues;
        }

    }
}
