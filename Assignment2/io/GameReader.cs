using System.IO;
using System.Threading.Tasks;
using Assignment2.game;

namespace Assignment2.io
{
    public class GameReader : IGameReader
    {
        private readonly string _inputFile;

        public GameReader(string inputFile)
        {
            _inputFile = inputFile;
        }

        public async Task<IWinnable> ReadFromFileAsync()
        {
            var lines = await File.ReadAllLinesAsync(_inputFile);
            var game = new Game(lines);

            return game;
        }
    }
}
