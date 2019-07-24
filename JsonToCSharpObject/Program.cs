using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonToCSharpObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("https://jsonplaceholder.typicode.com/todos/1");
            var text1 = client.DownloadString("http://jsonplaceholder.typicode.com/users/1");

            Users users = JsonConvert.DeserializeObject<Users>(text);

            Console.WriteLine("userId = "+users.userId );
            Console.WriteLine("id= "+ users.id);
            Console.WriteLine("title = "+users.title);
            Console.WriteLine("completed = "+users.completed);
            Console.WriteLine("======================================================");
            Console.WriteLine();
            Console.WriteLine(text1);
            Console.ReadLine();
        }
    }
}