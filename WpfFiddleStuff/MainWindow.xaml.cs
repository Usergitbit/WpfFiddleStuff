using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFiddleStuff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ModelFile> ModelFiles { get; set; } = new ObservableCollection<ModelFile>();
        public MainWindow()
        {
            InitializeComponent();
            ModelFiles.Add(
                new ModelFile
                {
                    Lods = new ObservableCollection<LodHeader>
                    {
                        new LodHeader
                        {
                            Info0 = "Info0",
                            Info1 = "Info1",
                            Info2 = "Info2",
                            Models = new ObservableCollection<Model>
                            {
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                }
                            }
                        },
                        new LodHeader
                        {
                            Info0 = "Info0",
                            Info1 = "Info1",
                            Info2 = "Info2",
                            Models = new ObservableCollection<Model>
                            {
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                }

                            }
                        },
                        new LodHeader
                        {
                            Info0 = "Info0",
                            Info1 = "Info1",
                            Info2 = "Info2",
                            Models = new ObservableCollection<Model>
                            {
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                },
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                }
                            }
                        },
                        new LodHeader
                        {
                            Info0 = "Info0",
                            Info1 = "Info1",
                            Info2 = "Info2",
                            Models = new ObservableCollection<Model>
                            {
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                },
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                },
                                new Model
                                {
                                    Info0 = "Info0",
                                    Transforms = "Transforms",
                                    Vertex = "Vertex"
                                }
                            }
                        },
                    }
                });

            DataContext = ModelFiles;
        }

        private void ExpandedChanged(object sender, RoutedEventArgs e)
        {
            var expander = (sender as Expander);
            var treeItem = expander.GetParentOfType<TreeViewItem>();
            treeItem.IsExpanded = expander.IsExpanded;
        }


    }
}
