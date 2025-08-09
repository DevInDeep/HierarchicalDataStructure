using HierarchicalDataStructure.Collections;
using System.Windows.Controls;

namespace HierarchicalDataStructure.Extensions
{
    internal static class TreeNodeExtensions
    {
        internal static IEnumerable<TreeViewItem> Convert<T>(this TreeNode<T> treeNode)
        {
            TreeViewItem rootItem = new TreeViewItem() { Header = treeNode.Data };

            return new[] { rootItem };
        }
    }
}
