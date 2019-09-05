using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Token
    {
        public enum Tipo
        {
            Error = -1,
            Identificador,
            PuntoComa,
            Coma,
            ParentesisIzquierdo,
            ParentesisDerecho,
            LlaveIzquierda,
            LlaveDerecha,
            Igual,
            If,
            While,
            Return,
            Else,
            Constante,
            OperadorSuma,
            OperadorNot,
            OperadorMultiplicador,
            OperadorRel,
            OperadorIgualdad,
            OperadorAnd,
            OperadorOr,
            Pesos
        }
        private Tipo tipoToken;
        private String valor;

        public Token(Tipo TipoDelToken, string val)
        {
            this.tipoToken = TipoDelToken;
            this.valor = val;
        }
        public String Getval()
        {
            return valor;
        }
        public String GetID()
        {
            return this.tipoToken.GetHashCode().ToString();
        }
        public String GetTipo()
        {
            switch (tipoToken)
            {
                case Tipo.Error:/**/
                    return "Error";
                case Tipo.Identificador:
                    return "Identificador";
                case Tipo.PuntoComa:/**/
                    return "PuntoComa";
                case Tipo.Coma:/**/
                    return "Coma";
                case Tipo.ParentesisIzquierdo:/**/
                    return "ParentesisIzquierdo";
                case Tipo.ParentesisDerecho:/**/
                    return "ParentesisDerecho";
                case Tipo.LlaveIzquierda:/**/
                    return "LlaveIzquierda";
                case Tipo.LlaveDerecha:/**/
                    return "LlaveDerecha";
                case Tipo.Igual:/**/
                    return "Igual";
                case Tipo.If:/**/
                    return "If";
                case Tipo.While:/**/
                    return "While";
                case Tipo.Return:/**/
                    return "Return";
                case Tipo.Else:/**/
                    return "Else";
                case Tipo.Constante:/**/
                    return "Constante";
                case Tipo.OperadorSuma:/**/
                    return "OperadorSuma";
                case Tipo.OperadorNot:/**/
                    return "OperadorNot";
                case Tipo.OperadorMultiplicador:/**/
                    return "OperadorMultiplicador";
                case Tipo.OperadorRel:/**/
                    return "OperadorRel";
                case Tipo.OperadorIgualdad:/**/
                    return "OperadorIgualdad";
                case Tipo.OperadorAnd:/**/
                    return "OperadorAnd";
                case Tipo.OperadorOr:/**/
                    return "OperadorOr";
                case Tipo.Pesos:/**/
                    return "Pesos";
                default:
                    return "";                 
            }
        }
    }
}
