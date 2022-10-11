using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
	public class API
	{


		private static string RESTURL = "https://jsonmock.hackerrank.com/api/food_outlets";

		public static List<string> getRelevantFoodOutlets(string city, int maxCost)
		{
			int page = 1;
			List<String> cityList = new List<string>();
			try
			{
				cityList = getCities(city, page, maxCost);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception " + e);
			}
			return cityList;
		}

		public static List<string> getCities(string city, int page, int maxcost)
		{

			List<string> cityList = new List<string>();
			string cityName = null;
			string response = getResponsePerPage(RESTURL, city, page);

			var jsonResponse = JsonConvert.DeserializeObject<JObject>(response);
			int totalPages = jsonResponse.Value<int>("total_pages");//["total_pages"];
			dynamic data = jsonResponse.Value<JArray>("data");//jsonResponse.getAsJsonArray("data");


			foreach (var e in data)
			{
				  if(Convert.ToInt32(e.Value<string>("estimated_cost")) < maxcost)
				{
					cityName = e.Value <string>("city");//e.getAsJsonObject().get("name").getAsString();
					Console.WriteLine("cityName " + cityName);
					cityList.Add(cityName);
				}

			}
			return totalPages == page ? cityList : getCities(city, page + 1, maxcost);
		}

		public static string getResponsePerPage(string endpoint, string city, int page)
		{

			string newurl = endpoint + "?city=" + city + "&page=" + page;
			string result = string.Empty;
			Console.WriteLine("New Url " + newurl);
			Uri url = new Uri(newurl);
			using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
			{
				client.BaseAddress = new Uri(endpoint);
				HttpResponseMessage response = client.GetAsync("?city=" + city + "&page=" + page).Result;
				response.EnsureSuccessStatusCode();
				if(response.StatusCode != HttpStatusCode.OK)
				{
					throw new Exception("Error in reading data with status "+ response.StatusCode);
				}
				result = response.Content.ReadAsStringAsync().Result;
				Console.WriteLine("Result: " + result);
			}
			return result;

		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			//		BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
			//        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

			string city = "Denver";// Console.ReadLine();

			int maxCost = 1;//Convert.ToInt32(Console.ReadLine());
			List<string> result =API. getRelevantFoodOutlets(city, maxCost);

			        for (int i = 0; i<result.Count; i++) {
			            Console.WriteLine(result);

			//            if (i != result.size() - 1) {
			//                bufferedWriter.write("\n");
			//            }
			//        }

			//        bufferedWriter.newLine();

			//bufferedReader.close();
			//bufferedWriter.close();
			//    }
			//}

		}
	}
}
