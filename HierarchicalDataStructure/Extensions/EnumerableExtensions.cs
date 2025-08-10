using System.Windows.Controls;

namespace HierarchicalDataStructure.Extensions
{
    internal static class EnumerableExtensions
    {
        internal static void Do<T>(this IEnumerable<T> enumerable, Action<T> onItem)
        {
            foreach (var item in enumerable)
                onItem(item);
        }
    }
}
