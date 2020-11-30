using System.Threading.Tasks;
using Assignment2.game;

namespace Assignment2.io
{
    public interface IGameReader
    {
        Task<IWinnable> ReadFromFileAsync();
    }
}