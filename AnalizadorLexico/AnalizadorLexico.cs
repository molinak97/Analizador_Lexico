using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class AnalizadorLexico
    {
        private LinkedList<Token> Salida;
        private int estado;
        private String auxiliarLexico;

        public LinkedList<Token> escanear(String entrada)
        {
            entrada = entrada + "$";
            Salida = new LinkedList<Token>();
            estado = 0;
            auxiliarLexico = "";
            Char caracter;
            for (int i = 0; i < entrada.Length; i++)
            {
                caracter = entrada.ElementAt(i);
                switch (estado)
                {
                    case 0:
                        if (char.IsDigit(caracter))
                        {
                            estado = 1;
                            auxiliarLexico += caracter;
                        }
                        else if (char.IsLetter(caracter))
                        {
                            // Este estado queda pendiente definirlo
                            estado = 2;
                            auxiliarLexico += caracter;
                        }
                        else if (caracter == ';')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.PuntoComa);
                        }
                        else if (caracter == ',')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.Coma);
                        }
                        else if (caracter == '(')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.ParentesisIzquierdo);
                        }
                        else if (caracter == ')')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.ParentesisDerecho);
                        }
                        else if (caracter == '{')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.LlaveIzquierda);
                        }
                        else if (caracter == '}')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.LlaveDerecha);
                        }
                        else if (caracter == '*')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorMultiplicador);
                        }
                        else if (caracter == '/')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorMultiplicador);
                        }
                        else if (caracter == '+')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorSuma);
                        }
                        else if (caracter == '-')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorSuma);
                        }
                        else
                        {
                            if (caracter == '$' && i == entrada.Length - 1)
                            {
                                Console.WriteLine("Analisis exitoso!");
                            }
                            else
                            {
                                auxiliarLexico += caracter;
                                agregarToken(Token.Tipo.Error);
                                Console.WriteLine("Error");
                            }
                        }
                        break;
                    case 1:
                        if (char.IsDigit(caracter))
                        {
                            estado = 1;
                            auxiliarLexico+= caracter;
                            //auxiliarLexico += caracter;
                        }
                        else if (caracter.CompareTo('.') == 0)
                        {
                            estado = 2;
                            auxiliarLexico += caracter;
                        }
                        else
                        {
                            agregarToken(Token.Tipo.Constante);
                            i -= 1;
                        }
                        break;
                    case 2:
                        if (Char.IsDigit(caracter))
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else
                        {
                            Console.WriteLine("Error lexico con:" + caracter + "despues del punto se esperaban mas numeros");
                            estado = 0;
                        }
                        break;
                    case 3:
                        if (Char.IsDigit(caracter))
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else
                        {
                            agregarToken(Token.Tipo.Constante);
                        }
                        break;

                }
            }
            return Salida;

        }

        public void agregarToken(Token.Tipo tipo)
        {
            Salida.AddLast(new Token(tipo, auxiliarLexico));
            auxiliarLexico = "";
            estado = 0;
        }
        public void imprimirListaToken(LinkedList<Token> lista)
        {
            foreach (Token item in lista)
            {
                Console.WriteLine(item.GetTipo() + " <--> " + item.Getval());
            }
        }
    }
}
