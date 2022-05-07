using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Places
{
    public class PlacesAPI
    {
        private static HttpClient Client { get; set; }
        public static string API_KEY = null;
        public static string BASE_ADDRESS = "https://maps.googleapis.com/maps/api/place/";
        public static string ZERO_RESULTS = "ZERO_RESULTS";

        /// <summary>
        /// Simply initializes this handler
        /// </summary>
        public static void Init(string apiKey)
        {
            API_KEY = apiKey;
            Client = new HttpClient();
            Client.BaseAddress = new Uri(BASE_ADDRESS);
        }


        /// <summary>
        /// This function returns the next page of results based on the token per that api call
        /// </summary>
        /// <param name="token">The token that reperesents the next page of results for this query</param>
        /// <returns>The next page of data (as one page can only have 20 results)</returns>
        public static async Task<Page> GetNextPlacesPageByState(string token)
        {
            Page response = null;

            string url = string.Format("textsearch/json?" +
                "pagetoken={0}" +
                "&key={1}",
                token,
                API_KEY);
            try
            {
                var responseCode = await Client.GetAsync(url);
                if (responseCode.IsSuccessStatusCode)
                {
                    string stringifiedResponse = await responseCode.Content.ReadAsStringAsync();
                    Console.WriteLine("Stringified JSON response next page: " + stringifiedResponse);
                    response = JsonConvert.DeserializeObject(stringifiedResponse, typeof(Page)) as Page;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message.ToString());
                return response;
            }

            return response;
        }

        /// <summary>
        /// This function retrieves all places based on inputted state and user query
        /// </summary>
        /// <param name="input">The keywords and phrases used in the query</param>
        /// <param name="state">The location to search in</param>
        /// <returns>A page which is a deserialized object containing the list of places</returns>
        public static async Task<Page> GetPlacesPageByState(string input, string state)
        {
            Page response = null;

            string formattedQuery = "\"" + input + string.Format(" in {0}", state) + "\"";

            string url = string.Format("textsearch/json?" +
                "query={0}" +
                "&key={1}", 
                formattedQuery,
                API_KEY);
            try
            {
                var responseCode = await Client.GetAsync(url);
                if (responseCode.IsSuccessStatusCode)
                {
                    string stringifiedResponse = await responseCode.Content.ReadAsStringAsync();
                    //Console.WriteLine("Stringified JSON response: " + stringifiedResponse);
                    response = JsonConvert.DeserializeObject(stringifiedResponse, typeof(Page)) as Page;
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message.ToString());
                return response;
            }

            return response;
        }


        /// <summary>
        /// Get in depth details of a place
        /// </summary>
        /// <param name="placeId">The unique id corresponding to a place</param>
        /// <returns>The deserialized detail object which contains all the fields relating to the query</returns>
        public static async Task<Detail> GetDetailsByPlaceId(string placeId)
        {
            Detail detail = null;
            string url = string.Format("details/json?placeid={0}&key={1}&fields=" +
                "name%2C" +
                "address_components%2C" +
                "formatted_phone_number%2C" +
                "formatted_address%2C" +
                "business_status%2C" + 
                "website",
                placeId,
                API_KEY);

            try
            {
                var responseCode = await Client.GetAsync(url);
                if (responseCode.IsSuccessStatusCode)
                {
                    string stringifiedDetail = await responseCode.Content.ReadAsStringAsync();
                    //Console.WriteLine("striginfied details: " + stringifiedDetail);
                    detail = (JsonConvert.DeserializeObject(stringifiedDetail, typeof(Place)) as Place).Details;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message.ToString());
                return detail;
            }

            return detail;
        }
    }
}
