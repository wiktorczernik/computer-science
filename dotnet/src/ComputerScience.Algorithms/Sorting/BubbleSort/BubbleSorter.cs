using ComputerScience.Algorithms.Sorting;

namespace ComputerScience.Algorithms;

public class BubbleSorter : BaseSorter
{
    public override void Sort(int[] arr)
    {
        int i, j, temp;
        bool swapped;
        
        for (i = 0; i < arr.Length - 1; i++)
        {
            swapped = false;
            for (j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped) break;
        }
    }
}