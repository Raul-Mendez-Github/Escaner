using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaner
{
    public partial class Form1 : Form
    {
        int[,] TT =
                //D  O  λ  $  L  e  d pc  p
          /*q0*/{{1, 2, 3, 4, 5, 5, 6,12,12}, // Error 102
          /*q1*/ {1, 2, 3, 4, 5, 5, 6,12,12}, // Delimitador
          /*q2*/ {1, 2, 3, 4, 5, 5, 6,12,12}, // Operador
          /*q3*/ {1, 2, 3, 4, 5, 5, 6,12,12}, // λ
          /*q4*/ {1, 2, 3, 4, 5, 5, 6,12,12}, // $
          /*q5*/ {1, 2, 3, 4, 5, 5, 5,12,12}, // Identificador
          /*q6*/ {1, 2, 3, 4,12,10, 6, 7, 9}, // Constante
          /*q7*/ {1, 2, 3, 4,12,12, 8,12,12}, // Error 102
          /*q8*/ {1, 2, 3, 4,12,10, 8,12, 9}, // Constante
          /*q9*/ {1, 2, 3, 4,12,12,12,12,12}, // Constante
         /*q10*/ {1, 2, 3, 4,12,12,11,12,12}, // Error 102
         /*q11*/ {1, 2, 3, 4,12,12,11,12,12}, // Constante
         /*q12*/ {1, 2, 3, 4,12,12,12,12,12}};// Error 102


        Dictionary<int, string> tipoToken = new Dictionary<int, string>
        {
            {1, "Identificador"},
            {2, "λ"},
            {3, "Constante"},
            {4, "$"},
            {5, "Delimitador"},
            {6, "Regla"},
            {7, "Operador"}
        };
        Dictionary<char, (int, int)> codigoToken = new Dictionary<char, (int, int)>
        {
            { '(', (5, 50) }, { ')', (5, 51) }, { ';', (5, 52) },
            { '+', (7, 70) }, { '-', (7, 71) }, { '*', (7, 72) }, { '/', (7, 73) },
            { '$', (4, 199) },
            { 'λ', (2, 99) }
        };
        public int IndiceToken(char caracter)
        {
            int tipo = codigoToken[caracter].Item1;
            if (tipo == 5) return 0;
            if (tipo == 7) return 1;
            if (tipo == 2) return 2;
            if (tipo == 4) return 3;
            if (char.IsLetter(caracter) && !(caracter == 'E' || caracter == 'e')) return 4;
            if (caracter == 'E' || caracter == 'e') return 5;
            if (char.IsDigit(caracter)) return 6;
            if (caracter == '.' ||  caracter == ',') return 7;
            if (caracter == '%') return 8;
            return -1; // Error 101, Simbolo desconocido
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
