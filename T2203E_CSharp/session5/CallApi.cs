using System;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
namespace T2203E_CSharp.session5
{
	public class CallApi
	{
		public async Task<Product> FetchData()
		{
			string url = "https://dummyjson.com/products/1";

			HttpClient client = new HttpClient();
			var rs = await client.GetAsync(url);
			if (rs.StatusCode == HttpStatusCode.OK)
			{
				string responseText = await rs.Content.ReadAsStringAsync();
				Product p = JsonConvert.DeserializeObject<Product>(responseText);
				return p;
			}
            return null;
		}
	}
}

