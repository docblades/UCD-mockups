using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace WpfApplication2
{
    internal class InventoryModel
    {
        public ObservableCollection<InventoryData> Inventory { get; set; }
    }
}
