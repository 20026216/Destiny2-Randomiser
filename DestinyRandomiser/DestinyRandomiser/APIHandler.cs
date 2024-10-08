using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace DestinyRandomiser
{
    public class APIHandler
    {
        private string api_key;
        private string client_id;
        private string client_secret;
        private string auth_url = "https://www.bungie.net/en/OAuth/Authorize";
        private string tokenurl = "https://www.bungie.net/platform/app/oauth/token";
        private string redirect_url = "https://github.com/20026216/Destiny2-Randomiser.git";
        private string getUserDetailsUrl = "https://www.bungie.net/Platform/User/GetCurrentBungieNetUser/";

        public APIHandler(string apiKey, string clientId, string clientSecret)
        {
            api_key = apiKey;
            client_id = clientId;
            client_secret = clientSecret;
        }

        public async Task GetUserDetailsAsync(string accessToken)
        {
            using (var client = new HttpClient())
            {
                
                client.DefaultRequestHeaders.Add("X-API-KEY", api_key);
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

                
                var response = await client.GetAsync(getUserDetailsUrl);

                
                Console.WriteLine($"RESPONSE STATUS: {response.StatusCode}");
                Console.WriteLine($"RESPONSE REASON: {response.ReasonPhrase}");

                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"RESPONSE TEXT: \n{responseContent}");
            }
        }

    }


}
