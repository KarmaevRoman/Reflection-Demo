using System.Windows;
using System.Windows.Controls;
using Reflection_Demo.ViewModel.ClassForReflection;

namespace Reflection_Demo.View.LocalTemplateSelector
{
    internal class MainTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (container is FrameworkElement element && item != null)
                switch (item)
                {
                    case Car car:
                        return element.FindResource("CarTemplate") as DataTemplate;
                    case Human human:
                        return element.FindResource("HumanTemplate") as DataTemplate;
                    case Table table:
                        return element.FindResource("TableTemplate") as DataTemplate;
                    default:
                        return null;
                }

            return null;
        }
    }
}