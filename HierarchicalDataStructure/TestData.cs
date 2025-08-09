using HierarchicalDataStructure.Collections;

namespace HierarchicalDataStructure
{
    internal static class TestData
    {
        internal static TreeNode<string> FetchTestData()
        {
            TreeNode<string> person = new TreeNode<string>("Person");
            person.Children.Add(new TreeNode<string>("First Name"));
            person.Children.Add(new TreeNode<string>("Last Name"));
            TreeNode<string> address = new TreeNode<string>("Address");
            address.Children.Add(new TreeNode<string>("Street"));
            address.Children.Add(new TreeNode<string>("City"));
            address.Children.Add(new TreeNode<string>("Postal Code"));
            address.Children.Add(new TreeNode<string>("Country"));
            person.Children.Add(address);
            return person;
        }
    }
}
