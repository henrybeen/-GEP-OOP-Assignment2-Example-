using System.Threading.Tasks;
using Assignment2.io;

namespace Assignment2
{
    class Program
    {
        static async Task  Main()
        {
            var gameReader = new GameReader(@"C:\src\Assignment2\data\input.txt");
            var outputWriter = new OutputWriter(@"C:\src\Assignment2\data\output.txt");

            var algorithm = new Algorithm(gameReader, outputWriter);

            await algorithm.RunAsync();
        }
    }
}
