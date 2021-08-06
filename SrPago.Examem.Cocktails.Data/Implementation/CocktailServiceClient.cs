using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using SrPago.Examen.Cocktails.Model;

namespace SrPago.Examem.Cocktails.DataAccess.Implementation
{
    /// <summary>
    /// Class for cocktail service
    /// </summary>
    public class CocktailServiceClient
    {
        private const string URL_BASE = "https://www.thecocktaildb.com/";

        /// <summary>
        /// Obtain sub types drinks
        /// </summary>
        /// <param name="filter">filter for request</param>
        /// <param name="topic">topic for map response</param>
        /// <returns>Drinks filters sub type</returns>
        public DrinksFilter GetListbyParameter(char filter, string topic)
        {
            var client = new RestClient(URL_BASE);
            var request = new RestRequest(string.Format("api/json/v1/1/list.php?{0}=list", filter), DataFormat.Json);
            var response = client.Get(request);
            return JsonConvert.DeserializeObject<DrinksFilter>(response.Content.Replace(topic, ""));
        }

        /// <summary>
        /// Get list of drinks by filters
        /// </summary>
        /// <param name="filter">filter</param>
        /// <param name="criteria">sub filter</param>
        /// <returns></returns>
        public DrinksSubFilter GetListByFilters(char filter, string criteria)
        {
            var client = new RestClient(URL_BASE);
            var request = new RestRequest(string.Format("api/json/v1/1/list.php?{0}={1}", filter, criteria), DataFormat.Json);
            var response = client.Get(request);
            return JsonConvert.DeserializeObject<DrinksSubFilter>(response.Content);
        }

        /// <summary>
        /// Get drink detail
        /// </summary>
        /// <param name="id">Id drink</param>
        /// <param name="filter">filter</param>
        /// <returns></returns>
        public DrinkDetail GetDrinkDetail(string id, char filter)
        {
            var client = new RestClient(URL_BASE);
            var request = new RestRequest(string.Format("api/json/v1/1/lookup.php?{0}={1}", filter, id), DataFormat.Json);
            var response = client.Get(request);
            return JsonConvert.DeserializeObject<DrinkDetail>(response.Content);
        }

        /// <summary>
        /// Get lis by search name
        /// </summary>
        /// <param name="name">Drink name</param>
        /// <returns></returns>
        public DrinksSubFilter GetListByName(string name)
        {
            var client = new RestClient(URL_BASE);
            var request = new RestRequest(string.Format("api/json/v1/1/search.php?s={0}", name), DataFormat.Json);
            var response = client.Get(request);
            return JsonConvert.DeserializeObject<DrinksSubFilter>(response.Content);
        }
    }
}
