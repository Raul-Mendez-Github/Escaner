using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaner
{
    internal class TokenDinamico
    {
        public HashSet<int> Linea { get; set; }
        public string Token { get; set; }
        public int Codigo {  get; set; }
    }
}
