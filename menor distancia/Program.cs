using System;
using System.Text;

class Program
{
    static void Main()
    {
        int[] array1 = { 30,32,3,6,8,7,10,3,4,7};
        int[] array2 = { 9,25,1,5,15,14,9,5,11,2 };
        
        int resultado = MenorDistancia(array1, array2);
        Console.WriteLine($"A menor distância entre dois números dos arrays é: {resultado}");
    }

    static int MenorDistancia(int[] array1, int[] array2)
    {
        Array.Sort(array1);
        Array.Sort(array2);

        int menorDistancia = int.MaxValue;
        int a1 = 0, a2 = 0;

        while (a1 < array1.Length && a2 < array2.Length)
        {
            int valor1 = array1[a1];
            int valor2 = array2[a2];
            int distanciaAtual = Math.Abs(valor1 - valor2);

            if (distanciaAtual < menorDistancia)
            {
                menorDistancia = distanciaAtual;
            }

            if (valor1 < valor2)
            {
                a1++;
            }
            else
            {
                a2++;
            }
        }

        return menorDistancia;
    }
}
