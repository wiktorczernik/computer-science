namespace ComputerScience.Algorithms.Sorting.MergeSort;

public class MergeSorter : BaseSorter
{
    public override void Sort(int[] arr)
    {
        MergeSort(arr, 0, arr.Length - 1);
    }

    private void Merge(int[] arr, int l, int m, int r)
    {
        // Create temporary arrays
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];

        int i, j, k;

        
        // Copy values to temporary arrays
        for (i = 0; i < n1; i++)
        {
            L[i] = arr[l + i];
        }
        for (j = 0; j < n2; j++)
        {
            R[j] = arr[m + j + 1];
        }

        i = 0; 
        j = 0;
        k = l;
        
        // Sort && copy to the original array.
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

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
    private void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            // Calculate the middle point.
            int m = l + (r - l) / 2;
            
            // Divide
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            
            // Conquer
            Merge(arr, l, m, r);
        }
    }
}