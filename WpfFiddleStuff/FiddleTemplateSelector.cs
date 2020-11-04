using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfFiddleStuff
{
    public class FiddleTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null)
                return null;

            var frameworkElement = (FrameworkElement)container;

            return (DataTemplate)frameworkElement.FindResource("");
        }

    }
}
