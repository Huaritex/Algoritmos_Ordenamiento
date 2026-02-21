using System;

public class ShellSort
{
    public static void Ordenar(int[] arreglo)
    {
        int n = arreglo.Length;

        // Comenzamos con una brecha grande y la reducimos a la mitad en cada paso
        for (int brecha = n / 2; brecha > 0; brecha /= 2)
        {
            // Realizamos una ordenación por inserción para esta brecha
            for (int i = brecha; i < n; i++)
            {
                int temp = arreglo[i];
                int j;

                // Desplazamos los elementos anteriores que son mayores que temp
                for (j = i; j >= brecha && arreglo[j - brecha] > temp; j -= brecha)
                {
                    arreglo[j] = arreglo[j - brecha];
                }

                // Colocamos temp en su posición correcta
                arreglo[j] = temp;
            }
        }
    }

    public static void Main()
    {
        int[] datos = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Original: " + string.Join(", ", datos));

        Ordenar(datos);

        Console.WriteLine("Ordenado: " + string.Join(", ", datos));
    }
}