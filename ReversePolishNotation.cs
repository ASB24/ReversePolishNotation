using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata.Ecma335;
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
        //Retorna si el caracter analizado es un operador lógico o no
        public bool isLogical(char c)
        {
            if (c == logicalOperators.AND || c == logicalOperators.OR || c == logicalOperators.CON) return true;
            return false;
        }

        //Determina si la expresión en notación polaca es válida, tanto si las proposiciones son letras minusculas
        //como la validación del orden de la expresión.
        public bool validateFormula(string formula)
        {
            for (int i = 0; i < formula.Length; i++)
            {
                if (formula[i] == ' ' && formula[i + 1] == ' ') return false;
                else if (formula[i] == ' ') continue;
                else if (Char.IsUpper(formula[i])) return false;
                else if (Char.IsLetter(formula[i]) && Char.IsLetter(formula[i + 1])) return false;
                else if (!isLogical(formula[i]) && !Char.IsLetter(formula[i])) return false;
            }
            return true;
        }
        /*
         Esta función toma como entrada una cadena que denota la expresión
         postfija y la descompone en cadenas que contienen operandos y operadores
         y los va acumulando en un arreglo de cadenas que se da como salida 
         conjuntamente con la longitud del mismo
         */
        public string[] tokenizeInput(string postFixExp)
        {
            return postFixExp.Split(" ");
        }

        /*
         Esta función toma como entrada un arreglo de cadenas y la longitud
         del mismo. Este debe contener los componentes (operandos y operadores)
         que componen la expresión postfija en el mismo orden en que fueron detectados.
         La función deberá usar una pila para computar determinar si se trata o no
         de una formula bien formada en notacio'n polaca inversa.
        */
        public bool parseFormula(string[] splitStr) 
        {
            Stack wff = new Stack();
            foreach (string c in splitStr)
            {
                if (Char.IsLetter(c[0])) wff.Push(c[0]);
                else
                {
                    try
                    {
                        for(int i = 0; i < 2; i++)
                        {
                            if (Convert.ToChar(wff.Peek()) == '*' || Char.IsLetter(Convert.ToChar(wff.Peek()))) wff.Pop();
                        }
                        wff.Push('*');
                    }
                    catch (InvalidOperationException) //Stack está vacio
                    {
                        return false;
                    }
                }
            }
            if (wff.Count == 1) return true;
            return false;
        }
    }
}
