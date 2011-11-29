using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetupDataModel();
        }

        private void SetupDataModel()
        {
            var model = new ObservableCollection<InventoryData>();
            model.Add(new InventoryData()
            {
                Name = "Hand Towel",
                Count = 3,
                Minimum = 3
            });
            model.Add(new InventoryData()
                {
                    Name = "Scented Soap",
                    Count = 100,
                    Minimum = 50
                });
            model.Add(new InventoryData()
                {
                    Name = "Wash Cloth",
                    Count = 1,
                    Minimum = 5
                });

            var data = new InventoryModel() { Inventory = model };
            DataContext = data;
        }
    }

}
