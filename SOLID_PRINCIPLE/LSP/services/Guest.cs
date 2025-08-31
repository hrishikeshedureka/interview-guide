using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.services
{
    public class Guest : IFileWriter
    {
        public void WriteFile(string message)
        {
            // Guests can write files, but they cannot read them.
            // This violates the Liskov Substitution Principle.
            Console.WriteLine("Guest writing: " + message);
        }
        // Note: No ReadFile method here, which is a violation of LSP
        // because it does not fulfill the contract of IFileReader.
    }
}
