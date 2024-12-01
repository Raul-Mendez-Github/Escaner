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
        
        bool hayError = false;


        int[,] TTLexica =
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

        string[,] TablaSintactica =
            //    (       p     )     r    ;    $
        /*P*/{{"(FA;P", "F;P", ""  , ""  , "" , "λ"},
        /*A*/ {"P)"   , "P)" , ")G", ""  , "" , "" },
        /*F*/ {"(FA"  , "OG" , ""  , ""  , "" , "" },
        /*G*/ {""     , ""   , "λ" , "RF", "λ", "λ" },
        /*O*/ {""     , "p"  , ""  , ""  , "" , ""},
        /*R*/ {""     , ""   , ""  , "r" , "" , "" }};

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
        public int IndiceCodigo(int codigo)
        {
            if (codigo == 50) return 0; // (
            if (codigo == 51) return 1; // )
            if (codigo > 100) return 2; // Operando
            if (codigo >= 70 && codigo <= 73) return 3; // Operador
            return -1;
        }
        public int IndiceRegla(char regla)
        {
            if (regla == 'P') return 0;
            if (regla == 'A') return 1;
            if (regla == 'F') return 2;
            if (regla == 'G') return 3;
            if (regla == 'O') return 4;
            if (regla == 'R') return 5;
            return -1;
        }
        
        public char TokenPorCodigo(int codigo)
        {
            if (codigo == 50) return '('; 
            if (codigo > 100) return 'p';
            if (codigo == 51) return ')';
            if (codigo >= 70 && codigo <= 73) return 'r';
            if (codigo == 52) return ';';
            if (codigo == 199) return '$';
            return ' ';
        }
        Dictionary<int, string> error = new Dictionary<int, string>
        {
                { 100, "100 - Sin errores" },
                { 101, "Error 1:101 - Símbolo Desconocido" },
                { 102, "Error 1:102 - Elemento Inválido" },
                { 103, "Error 2:103 - Inicio con parentesis de cierre" },
                { 104, "Error 2:104 - Falta operando" },
                { 105, "Error 2:105 - Falta operador" },
                { 106, "Error 2:106 - Faltan parentesis de apertura" },
                { 107, "Error 2:107 - Faltan parentesis de cierre" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            hayError = false;

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
            tablaExpresiones.Rows.Clear();

            // Llamar a validar el texto
            AnalisisLexico(cajaDeTexto, tablaLexica, tablaIdentificadores, tablaConstantes);
            if (!hayError) AnalisisSintactico();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Reiniciar componentes
            cajaDeTexto.Text = "";
            lblError.Text = "100 - Sin errores";
            tablaConstantes.Rows.Clear();
            tablaIdentificadores.Rows.Clear();
            tablaLexica.Rows.Clear();
            tablaExpresiones.Rows.Clear();
        }

        private void AnalisisLexico(RichTextBox rtb, DataGridView tablaLexica, DataGridView tablaIdentificadores, DataGridView tablaConstantes)
        {
            string cadena = rtb.Text + '\n';
            int estado = 0, numeroLinea = 1, estadoAnterior = 0;
            lblError.Text = error[100];

            // Recorrer la cadena
            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];

                // Detectar espacios y separarlos
                if (caracter == ' ')
                {
                    // Si se está acumulando un identificador o constante, separarlos
                    if (estado == 5) // Identificador
                    {
                        AgregarToken(ref sbIdentificador, 101, ref identificadores, numeroLinea);
                        estado = 0; // Reinicia el estado
                    }
                    else if (estado >= 6) // Constante
                    {
                        AgregarToken(ref sbConstante, 201, ref constantes, numeroLinea);
                        estado = 0; // Reinicia el estado
                    }
                    continue;
                }

                if (IndiceCaracter(caracter) == -1) // Detectar cadenas invalidas (fuera del diccionario)
                {
                    lblError.Text = error[101] + " en linea " + numeroLinea.ToString();
                    hayError = true;
                    ResaltarCaracter(rtb, caracter, Color.Yellow);
                    return;
                }
                else
                {
                    // Guardar el estado actual y pasar al siguiente
                    estadoAnterior = estado;
                    estado = TTLexica[estado, IndiceCaracter(caracter)];

                    // Si el nuevo estado indica identificador
                    if (estado == 5)
                    {
                        // Acumular el caracter en la cadena de identificador
                        sbIdentificador.Append(caracter);

                        // Si el caracter es el ultimo
                        if (i == cadena.Length - 1)
                        {
                            // Agregar el identificador a la lista de identificadores
                            AgregarToken(ref sbIdentificador, 101, ref identificadores, numeroLinea);
                        }
                    }
                    else if (estado >= 6) // Si el nuevo estado es numerico
                    {
                        // Si el caracter es el ultimo
                        if (i == cadena.Length - 1)
                        {
                            // Si el estado anterior fue invalido
                            if (estadoAnterior == 7 || estadoAnterior == 10 || estadoAnterior == 12)
                            {
                                // Saltar error
                                lblError.Text = error[102] + " en linea " + numeroLinea.ToString();
                                hayError = true;
                                ResaltarCadena(cajaDeTexto, sbConstante.ToString(), Color.Yellow);
                                return;
                            }
                            // Si no, agregar la constante a la lista de constantes
                            AgregarToken(ref sbConstante, 201, ref constantes, numeroLinea);
                            AgregarToken(ref sbIdentificador, 101, ref identificadores, numeroLinea);
                        }
                        // Acumular el caracter en la cadena de contante 
                        sbConstante.Append(caracter);
                    }
                    // Si el token es de caracter unico, hay un salto de linea o el caracter es el ultimo
                    else if (IndiceCaracter(caracter) < 4 || IndiceCaracter(caracter) == 9 || i == cadena.Length - 1)
                    {
                        // Si el estado anterior fue invalido
                        if (estadoAnterior == 7 || estadoAnterior == 10 || estadoAnterior == 12)
                        {
                            // Saltar error
                            lblError.Text = error[102] + " en linea " + numeroLinea.ToString();
                            hayError = true;
                            ResaltarCadena(cajaDeTexto, sbConstante.ToString(), Color.Yellow);
                            return;
                        }
                        // Llamar los metodos de agregacion de token dinamico
                        AgregarToken(ref sbConstante, 201, ref constantes, numeroLinea);
                        AgregarToken(ref sbIdentificador, 101, ref identificadores, numeroLinea);

                        // Si el caracter es salto de linea, aumentar el numero de linea
                        if (IndiceCaracter(caracter) == 9) numeroLinea++;
                        // Si no, agregarlo a la tabla lexica
                        else AgregarRawATablaLexica(numeroLinea, caracter.ToString(), codigoToken[caracter].Item1, codigoToken[caracter].Item2);
                    }
                }
            }
            // Agregar contantes e identificadores de las listas a las tablas
            foreach (var constante in constantes)
            {
                AgregarRawATablaConstantes(constante.Token, constante.Codigo, string.Join(", ", constante.Linea));
            }
            foreach(var identificador in identificadores)
            {
                AgregarRawATablaIdentificadores(identificador.Token, identificador.Codigo, string.Join(", ", identificador.Linea));
            }
        }

        private void AnalisisSintactico()
        {
            Stack<char> pila = new Stack<char>();
            pila.Push('$');
            pila.Push('P');
            tablaLexica.Rows.Add(i++, 0, '$', 0, 199); // Asegúrate de agregar el símbolo de fin correctamente
            int APUN = 0;

            while (pila.Count != 0)
            {
                char X = pila.Pop();
                char K = TokenPorCodigo(Convert.ToInt32(tablaLexica.Rows[APUN].Cells[4].Value));

                if (EsTerminal(X) || X == '$')
                {
                    if (X == K)
                    {
                        APUN++;

                        if (APUN == tablaLexica.Rows.Count)
                        {
                            MessageBox.Show("Análisis sintáctico completado con éxito.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"ERROR: Terminal no coincide. Esperado: {X}, encontrado: {K}");
                        return;
                    }
                }
                else
                {
                    int fila = IndiceRegla(X);
                    int columna = IndiceColumna(K);

                    if (fila != -1 && columna != -1 && !string.IsNullOrEmpty(TablaSintactica[fila, columna]))
                    {
                        string produccion = TablaSintactica[fila, columna];
                        if (produccion != "λ") // Si la producción no es λ
                        {
                            for (int j = produccion.Length - 1; j >= 0; j--)
                            {
                                pila.Push(produccion[j]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"ERROR: No hay producción para {X}, {K}.");
                        return;
                    }
                }
            }

        }

        // Método para determinar si un símbolo es terminal
        private bool EsTerminal(char simbolo)
        {
            return simbolo == '(' || simbolo == 'p' || simbolo == ')' || simbolo == 'r' || simbolo == ';' || simbolo == '$';
        }

        // Método para obtener el índice de la columna correspondiente al símbolo
        private int IndiceColumna(char simbolo)
        {
            switch (simbolo)
            {
                case '(': return 0;
                case 'p': return 1;
                case ')': return 2;
                case 'r': return 3;
                case ';': return 4;
                case '$': return 5;
                default: return -1;
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
    }
}