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
        StringBuilder sbIdentificador = new StringBuilder();
        StringBuilder sbConstante = new StringBuilder();
        int i = 1;

        List<TokenDinamico> identificadores = new List<TokenDinamico>();
        List<TokenDinamico> constantes = new List<TokenDinamico>();

        int[,] TT =
                //D  O  λ  $  L  e  d pc  p  s
          /*q0*/{{1, 2, 3, 4, 5, 5, 6,12,12, 0},
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

        // Asignar el tipo del token
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
        // Funcion para devolver el indice de columna por caracter en la tabla de transiciones
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
        Dictionary<int, string> error = new Dictionary<int, string>
        {
                { 100, "100 - Sin errores" },
                { 101, "Error 101 - Símbolo Desconocido" },
                { 102, "Error 102 - Elemento Inválido" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Reiniciar variable de indice
            i = 1;

            // Refrescar resaltados de caja de texto
            string respaldoTexto = cajaDeTexto.Text;
            cajaDeTexto.Text = "";
            cajaDeTexto.Text = respaldoTexto;

            // Reiniciar componentes y cadenas acumuladoras
            tablaIdentificadores.Rows.Clear();
            tablaConstantes.Rows.Clear();
            tablaLexica.Rows.Clear();
            sbIdentificador.Clear();
            sbConstante.Clear();
            identificadores.Clear();
            constantes.Clear();

            // Llamar a validar el texto
            ValidarTexto(cajaDeTexto, tablaLexica, tablaIdentificadores, tablaConstantes);
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Reiniciar componentes
            cajaDeTexto.Text = "";
            lblError.Text = "100 - Sin errores";
            tablaConstantes.Rows.Clear();
            tablaIdentificadores.Rows.Clear();
            tablaLexica.Rows.Clear();
        }

        private void ValidarTexto(RichTextBox rtb, DataGridView tablaLexica, DataGridView tablaIdentificadores, DataGridView tablaConstantes)
        {
            string[] lineas = rtb.Text.Split('\n'); // Separar por líneas
            lblError.Text = error[100];
            int numeroLinea = 1;

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                {
                    numeroLinea++;
                    continue;
                }

                // Validar sintaxis con pila
                var resultado = ValidarConPila(linea.Trim());

                if (!resultado.Item1) // Si es inválida
                {
                    // Agregar a tabla de constantes con el error
                    tablaConstantes.Rows.Add(numeroLinea, linea, resultado.Item2);
                    ResaltarCadena(rtb, linea, Color.Yellow); // Resaltar error
                }
                else
                {
                    // Agregar a tabla de identificadores
                    tablaIdentificadores.Rows.Add(numeroLinea, linea, "Expresión válida");
                }

                // Realizar análisis léxico para tokens válidos
                AnalizarTokens(linea, numeroLinea, tablaLexica, tablaIdentificadores, tablaConstantes);
                numeroLinea++;
            }
        }

        private bool ExisteToken(List<TokenDinamico> tokens, string token)
        {
            return tokens.Any(t => t.Token == token);
        }

        // Metodos para agregar dato a tablas
        private void AgregarRawATablaLexica(int linea, string token, int tipo, int codigo)
        {
            if (token == "") return;

            tablaLexica.Rows.Add(i++, linea, token, tipo, codigo);
        }
        private void AgregarRawATablaIdentificadores(string token, int codigo, string lineas)
        {
            if (token == "") return;

            tablaIdentificadores.Rows.Add(token, codigo, lineas);
        }
        private void AgregarRawATablaConstantes(string token, int codigo, string lineas)
        {
            if (token == "") return;

            tablaConstantes.Rows.Add(token, codigo, lineas);
        }
        // Metodo resaltar un caracter
        private void ResaltarCaracter(RichTextBox rtb, char caracterAResaltar, Color colorResaltado)
        {
            int posicionOriginal = rtb.SelectionStart;

            for (int i = 0; i < rtb.Text.Length; i++)
            {
                if (rtb.Text[i] == caracterAResaltar)
                {
                    rtb.Select(i, 1);
                    rtb.SelectionBackColor = colorResaltado;
                }
            }
            rtb.SelectionStart = posicionOriginal;
            rtb.SelectionLength = 0;
            rtb.SelectionBackColor = Color.White;
        }
        // Metodo resaltar cadena
        private void ResaltarCadena(RichTextBox rtb, string cadenaAResaltar, Color colorResaltado)
        {
            int posicionOriginal = rtb.SelectionStart;
            int longitudCadena = cadenaAResaltar.Length;

            if (string.IsNullOrEmpty(cadenaAResaltar) || longitudCadena > rtb.Text.Length)
                return;

            int posicionActual = 0;
            while ((posicionActual = rtb.Text.IndexOf(cadenaAResaltar, posicionActual)) != -1)
            {
                rtb.Select(posicionActual, longitudCadena);
                rtb.SelectionBackColor = colorResaltado;
                posicionActual += longitudCadena;
            }
            rtb.SelectionStart = posicionOriginal;
            rtb.SelectionLength = 0;
            rtb.SelectionBackColor = Color.White;
        }
        private void AgregarToken(ref StringBuilder token, int codigoInicial, ref List<TokenDinamico>listaTokens, int numeroLinea)
        {
            if (token.ToString() == "") return; // Si el token no esta vacio

            string textoToken = token.ToString(); // Guardar su texto

            // Obtener su codigo (nuevo o existente)
            int codigo = listaTokens.Any(c => c.Token == textoToken)
                    ? listaTokens.FirstOrDefault(c => c.Token == textoToken).Codigo
                    : listaTokens.Count + codigoInicial;

            // Agregar token a la tabla lexica
            AgregarRawATablaLexica(numeroLinea, textoToken, codigoInicial == 201 ? 3 : 1, codigo);

            // Si es nuevo token
            if (!ExisteToken(listaTokens, textoToken))
            {
                TokenDinamico resultadoToken = new TokenDinamico
                {
                    Linea = new HashSet<int>(),
                    Token = textoToken,
                    Codigo = listaTokens.Count + codigoInicial
                };
                resultadoToken.Linea.Add(numeroLinea);
                // Agregarlo a la lista de tokens
                listaTokens.Add(resultadoToken);
            }
            else // Si ya existe
            {
                // Agregarle el nuevo numero de linea
                listaTokens.FirstOrDefault(c => c.Token == textoToken).Linea.Add(numeroLinea);
            }
            token.Clear();
        }

        private (bool, string) ValidarConPila(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            bool esperandoOperando = true; // Determina si esperamos un operando o un operador
            char ultimoChar = '\0';

            for (int i = 0; i < expresion.Length; i++)
            {
                char c = expresion[i];

                if (c == ' ')
                    continue;

                if (c == '(')
                {
                    pila.Push(c);
                    esperandoOperando = true;
                }
                else if (c == ')')
                {
                    if (pila.Count == 0 || pila.Peek() != '(')
                        return (false, "Error: Paréntesis de cierre sin apertura");
                    pila.Pop();
                }
                else if ("+-*/".Contains(c))
                {
                    if (esperandoOperando)
                        return (false, "Error: Operador sin operando previo");
                    esperandoOperando = true;
                }
                else if (char.IsLetterOrDigit(c))
                {
                    if (!esperandoOperando && ultimoChar != '(' && !"*/+-".Contains(ultimoChar))
                        return (false, "Error: Falta operador entre operandos");
                    esperandoOperando = false;
                }
                else
                {
                    return (false, $"Error: Símbolo desconocido '{c}'");
                }

                ultimoChar = c;
            }

            if (pila.Count > 0)
                return (false, "Error: Paréntesis abiertos sin cerrar");

            if (esperandoOperando)
                return (false, "Error: Expresión incompleta");

            return (true, "Expresión válida");
        }

        private void AnalizarTokens(string linea, int numeroLinea, DataGridView tablaLexica, DataGridView tablaIdentificadores, DataGridView tablaConstantes)
        {
            sbIdentificador.Clear();
            sbConstante.Clear();

            foreach (char c in linea)
            {
                if (char.IsLetter(c))
                {
                    sbIdentificador.Append(c);
                }
                else if (char.IsDigit(c))
                {
                    sbConstante.Append(c);
                }
                else
                {
                    // Procesar acumuladores al encontrar delimitadores u operadores
                    if (sbIdentificador.Length > 0)
                        AgregarToken(ref sbIdentificador, 101, ref identificadores, numeroLinea);
                    if (sbConstante.Length > 0)
                        AgregarToken(ref sbConstante, 201, ref constantes, numeroLinea);

                    if (codigoToken.ContainsKey(c))
                        AgregarRawATablaLexica(numeroLinea, c.ToString(), codigoToken[c].Item1, codigoToken[c].Item2);
                }
            }

            // Procesar tokens restantes
            if (sbIdentificador.Length > 0)
                AgregarToken(ref sbIdentificador, 101, ref identificadores, numeroLinea);
            if (sbConstante.Length > 0)
                AgregarToken(ref sbConstante, 201, ref constantes, numeroLinea);
        }

        private void tablaIdentificadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaConstantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
