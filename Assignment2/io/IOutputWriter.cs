using System.Threading.Tasks;

namespace Assignment2.io
{
    public interface IOutputWriter
    {
        Task WriteOutputAsync(string output);
    }
}
