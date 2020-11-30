using System.Threading.Tasks;
using Assignment2.game;
using Assignment2.io;

namespace Assignment2
{
    public class Algorithm
    {
        private readonly IGameReader _gameReader;
        private readonly IOutputWriter _outputWriter;

        public Algorithm(IGameReader gameReader, IOutputWriter outputWriter)
        {
            _gameReader = gameReader;
            _outputWriter = outputWriter;
        }

        public async Task RunAsync()
        {
            var game = await _gameReader.ReadFromFileAsync();

            var output = CalculateOutputASync(game);

            await _outputWriter.WriteOutputAsync(output);
        }

        private string CalculateOutputASync(IWinnable game)
        {
            if (game.HasWinner())
            {
                return $"WINNER {game.GetWinner()}";
            }

            return $"NEXTMOVE {game.GetNextPlayer()}";
        }
    }
}
