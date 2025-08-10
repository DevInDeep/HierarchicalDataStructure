using System.Windows.Controls;

namespace HierarchicalDataStructure.Extensions
{
    internal static class TreeViewItemExtensions
    {
        internal static void Collapse(this TreeViewItem treeViewItem) =>
            treeViewItem.Height = 0;
        internal static void Expand(this TreeViewItem treeViewItem)
        {
            treeViewItem.Height = Double.NaN;
            treeViewItem.IsExpanded = true;
        }
        internal static string GetHeaderOrEmpty(this TreeViewItem treeViewItem)
        {
            string? header = treeViewItem.Header as string;
            if (header == null) return string.Empty;
            return header;
        }
        internal static void ExpandParentStructure(this TreeViewItem treeViewItem) =>
            treeViewItem.HieararchyWalk().Do(item => item.Expand());
        
        internal static IEnumerable<TreeViewItem> HieararchyWalk(this TreeViewItem treeViewItem)
        {
            TreeViewItem tempItem = treeViewItem;
            yield return tempItem;
            while (tempItem.Parent != null)
            {
                yield return (TreeViewItem)tempItem.Parent;
                tempItem = (TreeViewItem)tempItem.Parent;
            }
        }
    }
}
