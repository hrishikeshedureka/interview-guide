using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public interface IFileWriter
    {
        void WriteFile(string message);
    }
}
