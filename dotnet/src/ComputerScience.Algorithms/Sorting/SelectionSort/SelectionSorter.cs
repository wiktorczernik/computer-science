namespace ComputerScience.Algorithms.Sorting.SelectionSort;

public class SelectionSorter : BaseSorter
{
    public override void Sort(int[] arr)
    {
        int i, j, minI, temp;

        // Traverse the entire array, excluding the last element.
        for (i = 0; i < arr.Length - 1; i++)
        {
            // Assume that current element is the minimum.
            minI = i;

            // Search for the minimum element in the unsorted part.
            for (j = i + 1; j < arr.Length; j++)
            {
                // Remember it, if found. 
                if (arr[j] < arr[minI])
                {
                    minI = j;
                }
            }

            // Swap the minimum element with the current one, if found.
            if (minI != i)
            {
                temp = arr[i];
                arr[i] = arr[minI]; 
                arr[minI] = temp;
            }
        }
    }
}