using System.Windows.Controls;

namespace HierarchicalDataStructure.Extensions
{
    internal static class ItemCollectionExtensions
    {
        internal static void Do<T>(this ItemCollection collection, Action<T> onItem) where T : TreeViewItem
        {
            foreach (var item in collection)
            {
                if (item is T castItem)
                {
                    onItem(castItem);
                    castItem.Items.Do(onItem);
                }
            }
        }

        internal static IEnumerable<T> Where<T>(this ItemCollection collection, Func<T, bool> predicate) where T : TreeViewItem
        {
            foreach (var item in collection)
            {
                if (item is T)
                {
                    T castItem = (T) item;
                    if (predicate(castItem))
                        yield return castItem;
                    foreach(var childItem in castItem.Items.Where(predicate))
                        yield return childItem;
                }
            }
        }

        internal static void FilterBy(this ItemCollection collection, Func<TreeViewItem, bool> filter)
        {
            collection.Do<TreeViewItem>(item => item.Collapse());
            collection.Where<TreeViewItem>(filter).ToList().Do(item => item.ExpandParentStructure());
        }
    }
}
