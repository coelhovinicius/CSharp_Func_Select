/* FUNC - Exemplo com Select
 * 
 * Exemplo: Fazer um programa que, a partir de uma lista de produtos, gere uma
 *          nova lista contendo os nomes dos produtos em caixa alta. 
 *          Para isso, usamos a funcao Select.
 */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using System.Linq; // Necessario para usarmos a funcao Select
using Aula225_Func_Select.Entities;

namespace Aula225_Func_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = NameToUpper; /* Delegate para uma funcao que recebe um tipo "Product" e retorna 
            /* um tipo "string" */
            Func<Product, string> func = p => p.Name.ToUpper(); // Usando expressao Lambda
            //Func<Product, string> func = p => { return p.Name.ToUpper(); }; // Sintaxe alternativa

            //List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); // Expressao Lambda direto no Select
            // Aplica a funcao "NameToUpper" a cada elemento da lista, produzindo uma colecao de elementos
            List<string> result = list.Select(func).ToList(); // Usando a variavel do Delegate
            //List<string> result = list.Select(NameToUpper).ToList(); // "ToList" converte de IEnumerable, nesse caso

            foreach (string s in result) // Para cada elemento da lista
            {
                Console.WriteLine(s);
            }
        }

        static string NameToUpper(Product p) // Funcao para receber o nome e retornar em caixa alta
        {
            return p.Name.ToUpper();
        }
    }
}
