namespace Assignment2.game.winStrategy
{
    public class HorizontalWinStrategy : IWinStrategy
    {
        private readonly IFieldAccessor _fieldAccessor;
        private readonly int _rowIndicator;

        public HorizontalWinStrategy(IFieldAccessor fieldAccessor, int rowIndicator)
        {
            _fieldAccessor = fieldAccessor;
            _rowIndicator = rowIndicator;
        }

        public bool HasWinner()
        {
            return "XO".Contains(_fieldAccessor.GetField(0, _rowIndicator))
                && _fieldAccessor.GetField(0, _rowIndicator) == _fieldAccessor.GetField(1, _rowIndicator)
                && _fieldAccessor.GetField(0, _rowIndicator) == _fieldAccessor.GetField(2, _rowIndicator);
        }

        public string GetWinner()
        {
            return _fieldAccessor.GetField(0, _rowIndicator);
        }
    }
}
