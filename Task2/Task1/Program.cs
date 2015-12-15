using System;
using System.Linq;

namespace Serialization
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var port = Console.ReadLine();
            var uri = "http://127.0.0.1:" + port;
            var client = new HttpClientWrapper { BaseAddress = new Uri(uri)};
            if (!client.Ping()) return;
            var input = client.GetInputData<Input>();
            var output = new Output
            {
                SumResult = Utils.Sum(input.Sums)*input.K,
                MulResult = Utils.Multiplication(input.Muls),
                SortedInputs = Utils.Concat(input.Sums, input.Muls).OrderBy(x => x).ToArray()
            };
            client.WriteAnswer(output);
        }
    }
}
