public class QuickSortAlgorithm
{
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            // Ordena recursivamente los elementos antes y después de la partición
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Elegimos el último elemento como pivote
        int i = (low - 1); // Índice del elemento más pequeño

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                // Intercambia arr[i] y arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Intercambia arr[i+1] y el pivote (arr[high])
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }
}