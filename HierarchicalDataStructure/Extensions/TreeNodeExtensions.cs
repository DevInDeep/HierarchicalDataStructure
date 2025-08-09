using System.Windows.Controls;
using HierarchicalDataStructure.Collections;

namespace HierarchicalDataStructure.Extensions
{
    internal static class TreeNodeExtensions
    {
        internal static IEnumerable<TreeViewItem> Convert<T>(this TreeNode<T> treeNode)
        {
            TreeViewItem rootTreeViewItem = new TreeViewItem() { Header = treeNode.Data };
            foreach (TreeNode<T> childTreeNode in treeNode.Children)
            {
                TreeViewItem childTreeViewItem = new TreeViewItem() { Header = childTreeNode.Data };
                rootTreeViewItem.Items.Add(childTreeViewItem);
                addChildren(childTreeViewItem, childTreeNode);
            }
            return [rootTreeViewItem];
        }

        private static void addChildren<T>(TreeViewItem treeViewItem, TreeNode<T> treeNode)
        {
            foreach (TreeNode<T> childTreeNode in treeNode.Children)
            {
                TreeViewItem childTreeViewItem = new TreeViewItem() { Header = childTreeNode.Data };
                treeViewItem.Items.Add(childTreeViewItem);
                addChildren(childTreeViewItem, childTreeNode);
            }
        }
    }
}
