namespace Assignment2.game.winStrategy
{
    public class VerticalWinStrategy : IWinStrategy
    {
        private readonly IFieldAccessor _fieldAccessor;
        private readonly int _columnIndicator;

        public VerticalWinStrategy(IFieldAccessor fieldAccessor, int columnIndicator)
        {
            _fieldAccessor = fieldAccessor;
            _columnIndicator = columnIndicator;
        }

        public bool HasWinner()
        {
            return "XO".Contains(_fieldAccessor.GetField(_columnIndicator, 0))
                && _fieldAccessor.GetField(_columnIndicator, 0) == _fieldAccessor.GetField(_columnIndicator, 1)
                && _fieldAccessor.GetField(_columnIndicator, 0) == _fieldAccessor.GetField(_columnIndicator, 2);
        }

        public string GetWinner()
        {
            return _fieldAccessor.GetField(_columnIndicator, 0);
        }
    }
}
