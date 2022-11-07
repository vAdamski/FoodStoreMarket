using Newtonsoft.Json;
using FoodStoreMarket.Persistance;

namespace WebApi.IntegratinTests.Common
{
    public class Utilities
    {
        public static async Task<T> GetResponseContent<T>(HttpResponseMessage response)
        {
            var stringResponse = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<T>(stringResponse);

            return result;
        }
        public static void InitilizeDbForTests(FoodStoreMarketDbContext context)
        {
           
        }
    }
}
