using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TroyTrivia.Business.Interactors
{
    public class HttpInteractor
    {
        public static async Task<string> GetResponseFromUrl(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        return await content.ReadAsStringAsync();
                    }
                }
            }

        }
    }
}
