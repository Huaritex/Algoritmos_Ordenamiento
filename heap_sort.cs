public class HeapSortAlgorithm
{
    public static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        // Construye el Max-Heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }

        // Extrae elementos del Heap uno por uno
        for (int i = n - 1; i > 0; i--)
        {
            // Mueve la raíz actual al final
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // Llama a max heapify en el heap reducido
            Heapify(arr, i, 0);
        }
    }

    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i; // Inicializa el más grande como la raíz
        int left = 2 * i + 1; 
        int right = 2 * i + 2; 

        // Si el hijo izquierdo es mayor que la raíz
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        // Si el hijo derecho es mayor que el más grande hasta ahora
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        // Si el más grande no es la raíz, intercambia y continúa
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            Heapify(arr, n, largest);
        }
    }
}