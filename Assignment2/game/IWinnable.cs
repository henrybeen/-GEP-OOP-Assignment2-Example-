namespace Assignment2.game
{
    public interface IWinnable
    {
        bool HasWinner();
        string GetWinner();
        string GetNextPlayer();
    }
}
