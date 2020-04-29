using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

class HttpProgram
{
    static readonly HttpClient client = new HttpClient();

    public static void Download()
    {
        Task<string> downloadHomePage = MainRequest();
        string response = downloadHomePage.Result;
        Console.WriteLine(response);
    }

    static async Task<string> MainRequest()
    {
        // Call asynchronous network methods in a try/catch block to handle exceptions.
        try
        {
            HttpResponseMessage response = await client.GetAsync("http://www.google.com/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);

            return responseBody;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            return "";
        }
    }
}
