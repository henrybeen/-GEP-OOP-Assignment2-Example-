using System.IO;
using System.Threading.Tasks;

namespace Assignment2.io
{
    public class OutputWriter : IOutputWriter
    {
        private readonly string _fileName;

        public OutputWriter(string fileName)
        {
            _fileName = fileName;
        }

        public async Task WriteOutputAsync(string output)
        {
            await File.WriteAllTextAsync(_fileName, output);
        }
    }
}
