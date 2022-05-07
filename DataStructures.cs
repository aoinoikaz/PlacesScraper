using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Places
{

    public class Business
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FormattedAddress { get; set; }
        public string WebsiteUrl { get; set; }
        public string Status { get; set; }

        /* 
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
         */

        // TODO: Break down adddress components
    }


    public class Page
    { 
        [JsonProperty("results")]
        public List<Place> Places { get; set; }

        [JsonProperty("next_page_token")]
        public string Next { get; set; }

        [JsonProperty("status")]
        public string RequestStatus { get; set; }

    }


    public class Place
    {
        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("result")]
        public Detail Details { get; set; }
    }


    public class Detail
    {
        [JsonProperty("business_status")]
        public string BusinessStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("formatted_phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("website")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("address_components")]
        public List<AddressComponent> AddressComponents { get; set; }
        
    }


    public class AddressComponent
    {
        [JsonProperty("long_name")]
        public string LongName { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
