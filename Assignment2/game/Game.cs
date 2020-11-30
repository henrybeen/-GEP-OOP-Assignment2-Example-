using System.Linq;
using Assignment2.game.winStrategy;

namespace Assignment2.game
{
    public class Game : IWinnable, IFieldAccessor
    {
        private readonly string _allPositions;
        private readonly IWinStrategy[] _strategies;

        public Game(string[] lines)
        {
            _allPositions = string.Concat(lines);

            _strategies = new IWinStrategy[]
            {
                new HorizontalWinStrategy(this, 0),
                new HorizontalWinStrategy(this, 1),
                new HorizontalWinStrategy(this, 2),
                new VerticalWinStrategy(this, 0),
                new VerticalWinStrategy(this, 1),
                new VerticalWinStrategy(this, 2),
                new CrossLeftTopStrategy(this),
                new CrossRightTopStrategy(this)
            };
        }

        public bool HasWinner()
        {
            return _strategies
                .Any(x => x.HasWinner());
        }

        public string GetWinner()
        {
            return _strategies
                .First(x => x.HasWinner())
                .GetWinner();
        }

        public string GetNextPlayer()
        {
            var xCount = _allPositions.Count(c => c == 'X');
            var oCount = _allPositions.Count(c => c == 'O');

            return xCount == oCount
                ? "X"
                : "O";
        }

        public string GetField(int column, int row)
        {
            return _allPositions[column + (3 * row)].ToString();
        }
    }
}
