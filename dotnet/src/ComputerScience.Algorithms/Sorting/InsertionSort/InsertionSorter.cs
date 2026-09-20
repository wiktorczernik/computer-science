namespace ComputerScience.Algorithms.Sorting.InsertionSort;

public class InsertionSorter : BaseSorter
{
    public override void Sort(int[] arr)
    {
        int i, j, key;

        // arr[0 .. i - 1] is the sorted part and arr[i .. end] is not.
        // First element is treated as it was sorted.
        for (i = 1; i < arr.Length; i++)
        {
            key = arr[i];

            // Elements that are larger than key are shifted to right.
            for (j = i - 1; j >= 0 && arr[j] > key; j--)
            {
                arr[j + 1] = arr[j];
            }

            // Move key into gap created by shifting.
            arr[j + 1] = key;
        }
    }
}