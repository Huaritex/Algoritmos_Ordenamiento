public class MergeSortAlgorithm
{
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            
            // Ordena la primera y segunda mitad
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            
            // Une las mitades ordenadas
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copia los datos a los arreglos temporales
        for (int x = 0; x < n1; ++x) L[x] = arr[left + x];
        for (int y = 0; y < n2; ++y) R[y] = arr[mid + 1 + y];

        int i = 0, j = 0, k = left;
        
        // Mezcla los arreglos temporales de vuelta al original
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // Copia los elementos restantes si los hay
        while (i < n1)
        {
            arr[k] = L[i];
            i++; k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++; k++;
        }
    }
}