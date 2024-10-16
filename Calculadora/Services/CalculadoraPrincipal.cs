using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraPrincipal
    {
        
        private List<string> historico;
        private string data;
        public CalculadoraPrincipal(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            historico.Insert(0, "resultado:" + resultado + "data:" + data);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            historico.Insert(0, "resultado:" + resultado + "data:" + data);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            historico.Insert(0, "resultado:" + resultado + "data:" + data);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 /num2;
            historico.Insert(0, "resultado:" + resultado + "data:" + data);
            return resultado;
        }

        public List<string> Historico()
        {
            return historico.Take(3).ToList();
        }
        
    }
}