using System.Windows;
using System.Windows.Controls;
using HierarchicalDataStructure.Extensions;

namespace HierarchicalDataStructure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void MainWindow_Loaded(object sender, RoutedEventArgs e) => treeView.ItemsSource = TestData.FetchTestData().Convert();
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e) => treeView.Items.FilterBy(predicate);
        private bool predicate(TreeViewItem item) => item.GetHeaderOrEmpty().StartsWith(txtSearch.Text, StringComparison.OrdinalIgnoreCase);
    }
}