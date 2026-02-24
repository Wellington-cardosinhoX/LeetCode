using System.Net.Http.Headers;

namespace ExercicesC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(fibonacciGerar(5));
            //Console.WriteLine(gerarFatorial(5));


            //int resultado = CountEvens([2, 4, 5, 8]);
            //Console.WriteLine($"Quantidade de números pares: {resultado}");

            //Console.WriteLine(FindMax([1, 67, 33, 55]));



            Console.WriteLine(RepeatLetter(['a', 'a', 'b', 'c', 'c', 'd']));



        }

        public static List<int> fibonacciGerar(int n)
        {
            List<int> lista = new List<int>();

            if (n <= 0)
            {
                throw new Exception("Não pode ser menor ou igual a 0");
            }

            lista.Add(0);

            if (n == 1)
            {
                return lista;
            }

            lista.Add(1);

            for (int i = 2; i <= n; i++)
            {
                int proximo = lista[i - 1] + lista[i - 2];
                lista.Add(proximo);
            }

            return lista;
        }

        public static int gerarFatorial(int n)
        {
            if (n <= 0)
            {
                throw new Exception("Não pode ser menor ou igual a 0");
            }

            int resultado = 1;

            for (int i = n; i > 1; i--)
            {
                resultado = resultado * i;
            }

            return resultado;
        }


        public static int CountEvens(int[] nums)
        {
            int contador = 0;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    contador++;
                }
            }

            return contador;
        }


        public static int FindMax(int[] numeros)
        {
            int maior = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > maior)
                {
                    maior = numero;
                }
            }

            return maior;
        }

        public static bool DuplicateVerify(int[] nums)
        {
            HashSet<int> resultado = new HashSet<int>();

            foreach (int numero in nums)
            {
                if (resultado.Contains(numero))
                {
                    return true;
                }

                resultado.Add(numero);
            }

            return false;
        }


        public static char RepeatLetter(char[] text)
        {
            Dictionary<char, int> contador = new Dictionary<char, int>();

            // Contar quantas vezes cada caractere aparece
            foreach (char c in text)
            {
                if (contador.ContainsKey(c))
                {
                    contador[c]++;
                }
                else
                {
                    contador[c] = 1;
                }
            }

            foreach (char c in text)
            {
                if (contador[c] == 1)
                {
                    return c;
                }
            }

            return '\0';
        }
    }
}
