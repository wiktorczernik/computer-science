using ComputerScience.Algorithms.Sorting;
using ComputerScience.Algorithms.Sorting.InsertionSort;
using ComputerScience.Algorithms.Sorting.SelectionSort;

namespace ComputerScience.Algorithms.Tests.Sorting;

using Xunit;


public class SortingTests
{
    private static Random _rnd = new Random();


    [Fact]
    public void BubbleSort() => ShuffledTest<BubbleSorter>();
    [Fact]
    public void InsertionSort() => ShuffledTest<InsertionSorter>();
    [Fact]
    public void SelectionSort() => ShuffledTest<SelectionSorter>();
    
    
    private void ShuffledTest<T>() where T : BaseSorter => GenericTest<T>();
    private void GenericTest<T>() where T : BaseSorter
    {
        var actual = CreateRandomArray(10000, 1000);
        var expected = actual.OrderBy(x => x).ToArray();
        var sorter = SorterFactory.Create<T>();
        
        sorter.Sort(actual);
        Assert.Equal(expected, actual);
    }
    private int[] CreateRandomArray(int max, int count)
    {
        return Enumerable.Range(0, count).Select(x => _rnd.Next(0, max)).ToArray();
    }
}