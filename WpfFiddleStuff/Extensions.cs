using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfFiddleStuff
{
    public static class Extensions
    {
        public static T GetParentOfType<T>(this Expander child) where T : DependencyObject
        {
            DependencyObject parentDependencyObject = child;
            do
            {
                parentDependencyObject = VisualTreeHelper.GetParent(parentDependencyObject);
                if (parentDependencyObject is T parent)
                    return parent;
            }
            while (parentDependencyObject != null);
            return null;
        }
    }
}
