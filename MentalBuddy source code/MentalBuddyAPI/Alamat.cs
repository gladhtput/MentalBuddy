using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using SimpleJson;

namespace MentalBuddyAPI
{
    public class Alamat
    {
        public static String[] GetKotaList(string province_id)
        {
            List<string> returnList = new List<string>();
            var client = new RestClient("https://api.rajaongkir.com/starter/city");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            request.AddParameter("province", province_id);
            IRestResponse response = client.Execute(request);
            JsonObject rajaObj = (JsonObject)SimpleJson.SimpleJson.DeserializeObject(response.Content);
            JsonObject contentObj = (JsonObject)rajaObj["rajaongkir"];
            JsonArray cityArray = (JsonArray)contentObj["results"];
            foreach (JsonObject city in cityArray)
            {
                returnList.Add((string)city["city_name"]);
            }
            return returnList.ToArray();
        }

        public static Provinsi[] GetProvinsiList()
        {
            List<Provinsi> provincelIst = new List<Provinsi>();
            var client = new RestClient("https://api.rajaongkir.com/starter/province");
            var request = new RestRequest(Method.GET);
            request.AddHeader("key", "c31a7ac4eaed9d6d966f5af4cf2aa4b9");
            IRestResponse response = client.Execute(request);
            JsonObject rajaObj = (JsonObject)SimpleJson.SimpleJson.DeserializeObject(response.Content);
            JsonObject contentObj = (JsonObject)rajaObj["rajaongkir"];
            JsonArray cityArray = (JsonArray)contentObj["results"];
       
            foreach (JsonObject city in cityArray)
            {
                provincelIst.Add(new Provinsi((string)city["province_id"],(string)city["province"]));
            }
            return provincelIst.ToArray();
        }
    }
}
