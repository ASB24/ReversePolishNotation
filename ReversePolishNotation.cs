using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
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
        //Esta funcion determina si la entrada de tanto el usuario como los casos de prueba son validos para ser tokenizados y resolvidos
        public bool getInput(string expresion)
        {
            for(int i = 0; i < expresion.Length; i++)
            {
                if ( expresion[i] == ' ' && expresion[i + 1] == ' ' ||
                     expresion[i] != logicalOperators.AND &&
                     expresion[i] != logicalOperators.OR && 
                     expresion[i] != logicalOperators.CON &&
                     (expresion[i] > 'a' && expresion[i] < 'z') &&
                     !Char.IsLower(expresion[i]))
                {
                    return false;
                }
            }
            return true;
        }
        /*
         Esta función toma como entrada una cadena que denota la expresión
         postfija y la descompone en cadenas que contienen operandos y operadores
         y los va acumulando en un arreglo de cadenas que se da como salida 
         conjuntamente con la longitud del mismo
         */
        public void tokenizeinput(string postFixExp, string[] splitStr) => splitStr = postFixExp.Split(" ");
        /*
         Esta función toma como entrada un arreglo de cadenas y la longitud
         del mismo. Este debe contener los componentes (operandos y operadores)
         que componen la expresión postfija en el mismo orden en que fueron detectados.
         La función deberá usar una pila para computar determinar si se trata o no
         de una formula bien formada en notacio'n polaca inversa.
        */
        public int parseFormula(string[] splitStr)
        {
            Stack wff = new Stack();

            return 0;
        }
    }
}
