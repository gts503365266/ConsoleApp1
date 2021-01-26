using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await GetContents();
            Console.WriteLine("Hello World!");
            await SayHello();
        }
        static async Task GetContents()
        {
            string requestUrl = "http://www.youtube.com";
            HttpClient httpClient = new HttpClient();
            string contents = await httpClient.GetStringAsync(requestUrl);
            Console.WriteLine(contents);
        }
        static async Task SayHello()
        {
            Console.WriteLine("Say Hello");
        }
    }
}
