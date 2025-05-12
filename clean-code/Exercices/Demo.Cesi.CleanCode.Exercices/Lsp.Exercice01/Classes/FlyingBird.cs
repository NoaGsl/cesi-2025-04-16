using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Exercice01.Classes
{
    internal class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
