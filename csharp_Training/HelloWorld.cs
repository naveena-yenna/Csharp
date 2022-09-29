using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Training
{
    [TestClass]
    public class HelloWorld
    {
        [TestMethod]
        public void WriteOnConsole()
        {
            Console.Write("welcome to zenq");
        }
    }
}
