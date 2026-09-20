using System.Data;

namespace ComputerScience.Algorithms.Sorting;

public static class SorterFactory
{
    public static T Create<T>() where T : BaseSorter
    {
        var sorter = (T?)Activator.CreateInstance(typeof(T));
        if (sorter == null) throw new NoNullAllowedException();
        return sorter;
    }
}