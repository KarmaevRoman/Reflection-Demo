using System.Windows;
using System.Windows.Controls;
using Reflection_Demo.ViewModel;
using Reflection_Demo.ViewModel.ClassForReflection;

namespace Reflection_Demo.View
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Presenter != null)
            {
                switch (((MainViewModel)DataContext).SelectedItem)
                {
                    case Car car:
                        Presenter.Content = car;
                        break;
                    case Human human:
                        Presenter.Content = human;
                        break;
                    case Table table:
                        Presenter.Content = table;
                        break;
                }
            }
        }
    }
}