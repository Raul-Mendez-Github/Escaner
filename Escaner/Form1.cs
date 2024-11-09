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
                //D  O  λ  $  L  e  d pc  p  s
          /*q0*/{{1, 2, 3, 4, 5, 5, 6,12,12, 0}, // Error 102
          /*q1*/ {1, 2, 3, 4, 5, 5, 6,12,12, 0}, // Delimitador
          /*q2*/ {1, 2, 3, 4, 5, 5, 6,12,12, 0}, // Operador
          /*q3*/ {1, 2, 3, 4, 5, 5, 6,12,12, 0}, // λ
          /*q4*/ {1, 2, 3, 4, 5, 5, 6,12,12, 0}, // $
          /*q5*/ {1, 2, 3, 4, 5, 5, 5,12,12, 0}, // Identificador
          /*q6*/ {1, 2, 3, 4,12,10, 6, 7, 9, 0}, // Constante
          /*q7*/ {1, 2, 3, 4,12,12, 8,12,12, 0}, // Error 102
          /*q8*/ {1, 2, 3, 4,12,10, 8,12, 9, 0}, // Constante
          /*q9*/ {1, 2, 3, 4,12,12,12,12,12, 0}, // Constante
         /*q10*/ {1, 2, 3, 4,12,12,11,12,12, 0}, // Error 102
         /*q11*/ {1, 2, 3, 4,12,12,11,12,12, 0}, // Constante
         /*q12*/ {1, 2, 3, 4,12,12,12,12,12, 0}};// Error 102

        // Asignar el tipo del token (El profe asignó estos números como "Tipo")
        Dictionary<int, string> tipoToken = new Dictionary<int, string>
        {
            { 1, "Identificador" },
            { 2, "λ" },
            { 3, "Constante" },
            { 4, "$" },
            { 5, "Delimitador" },
            { 6, "Regla" },
            { 7, "Operador" }
        };
        // Asignar Tipo y Codigo a los tokens de un solo caracter
        Dictionary<char, (int, int)> codigoToken = new Dictionary<char, (int, int)>
        {
            { '(', (5, 50) }, { ')', (5, 51) }, { ';', (5, 52) }, // Delimitador
            { '+', (7, 70) }, { '-', (7, 71) }, { '*', (7, 72) }, { '/', (7, 73) }, // Operador
            { '$', (4, 199) },
            { 'λ', (2, 99) }
        };
        // Funcion para 
        public int IndiceCaracter(char caracter)
        {
            if (caracter == '(' || caracter == ')' || caracter == ';') return 0;
            if (caracter == '+' || caracter == '-' || caracter == '*' || caracter == '/') return 1;
            if (caracter == 'λ') return 2;
            if (caracter == '$') return 3;
            if (char.IsLetter(caracter) && !(caracter == 'E' || caracter == 'e')) return 4;
            if (caracter == 'E' || caracter == 'e') return 5;
            if (char.IsDigit(caracter)) return 6;
            if (caracter == '.' ||  caracter == ',') return 7;
            if (caracter == '%') return 8;
            if (caracter == '\n') return 9;
            return -1; // Error 101, Simbolo desconocido
        }
        Dictionary<int, string>  error = new Dictionary<int, string>
        {
                { 100, "100 - Sin errores" },
                { 101, "Error 101 - Símbolo Desconocido" },
                { 102, "Error 102 - Elemento Inválido" }
        };
    public Form1()
        {
            InitializeComponent();
        }

        private void ValidarTexto(RichTextBox rtb, DataGridView tablaLexica, DataGridView tablaIdentificadores, DataGridView tablaConstantes)
        {
            string cadena = rtb.Text, token = "";
            int estado = 0, contador = 0, numeroCadena = 1, numeroLinea = 1;

            lblError.Text = error[100];

            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];
                if (IndiceCaracter(caracter) == -1)
                {
                    lblError.Text = error[101] + " en linea " + numeroLinea.ToString();
                    ResaltarCaracter(rtb, caracter, Color.Red);
                    return;
                }

                if (IndiceCaracter(caracter) < 4)
                {
                    AgregarToken(contador, numeroLinea, token, estado);
                }
            }

        }

        private void AgregarToken(int numToken, int numLinea, string token, int estado)
        {
            if (token == "") return;
            
        }

        private void ResaltarCaracter(RichTextBox rtb, char caracterAResaltar, Color colorResaltado)
        {
            int posicionOriginal = rtb.SelectionStart;

            for (int i = 0; i < rtb.Text.Length; i++)
            {
                if (rtb.Text[i] == caracterAResaltar)
                {
                    rtb.Select(i, 1);
                    rtb.SelectionColor = colorResaltado;
                }
            }
            rtb.SelectionStart = posicionOriginal;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = rtb.ForeColor;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cajaDeTexto.Text = "";
            lblError.Text = "100 - Sin error";
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ValidarTexto(cajaDeTexto, tablaLexica, tablaIdentificadores, tablaConstantes);
        }
    }
}
