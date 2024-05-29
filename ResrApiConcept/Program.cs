using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace ResrApiConcept
{
    public class Program
    {
        public async static Task Main()
        {
            await GetResult();
            Console.Read();
        }

        private static async Task GetResult()
        {
            HttpClient client = new HttpClient() { BaseAddress = new Uri("https://api.wheretheiss.at/") };

            var apiResponse = await client.GetAsync("v1/25544");

            if (apiResponse.IsSuccessStatusCode)
            {
                //Read the content as string
                var apiContent = await apiResponse.Content.ReadAsStringAsync();

                var deserilizeData = JsonConvert.DeserializeObject<Whether>(apiContent);

                Console.WriteLine($"Lattitude : {deserilizeData.latitude} ====== longitude : {deserilizeData.longitude}");
            }
            else
            {
                Console.WriteLine($"Error {apiResponse.StatusCode}");
            }
        }
    }
}
