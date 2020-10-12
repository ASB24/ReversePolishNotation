using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ReversePolishNotation
{
    static class logicalOperators
    {
        public const char AND = '∧';
        public const char OR = '∨';
        public const char CON = '→';
    }
    class ReversePolishNotation
    {
        public bool getInput(string expresion)
        {
            expresion.Trim().Replace(" ", "").Replace("(", "").Replace(")", "");
            foreach(char i in expresion)
            {
                if (i != logicalOperators.AND || i != logicalOperators.OR || i != logicalOperators.CON || !Char.IsLower(i)) return false;
            }
            return true;
        }
        /*
         Esta función toma como entrada una cadena que denota la expresión
         postfija y la descompone en cadenas que contienen operandos y operadores
         y los va acumulando en un arreglo de cadenas que se da como salida 
         conjuntamente con la longitud del mismo
         */
        public void tokenizeinput(string postFixExp, string[] splitStr, int inputLength)
        {

        }
        /*
         Esta función toma como entrada un arreglo de cadenas y la longitud
         del mismo. Este debe contener los componentes (operandos y operadores)
         que componen la expresión postfija en el mismo orden en que fueron detectados.
         La función deberá usar una pila para computar determinar si se trata o no
         de una formula bien formada en notacio'n polaca inversa.
         */
        public int parseFormula(string[] splitStr, int inputLength)
        {
            return 0;
        }
    }
}
