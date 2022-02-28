using lab_2_b.Model;
using System;
using System.Collections.Generic;
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

namespace lab_2_b
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddElements();
        }

        private void AddElements()
        {
          
            ProductListView.ItemsSource = MockData();
        }

        private List<DrinkProduct> MockData()
        {
            return new List<DrinkProduct> {
                new DrinkProduct(
                1000,
                MaterialType.Leaf,
                "1",
                "1",
                "Coffe powder",
                10
                ),new DrinkProduct(
                2,
                MaterialType.Leaf,
                "2",
                "2",
                "Tea",
                20
                ),new DrinkProduct(
                3,
                MaterialType.Leaf,
                "3",
                "3",
                "Beef Drink",
                30000
                )
            };
        }
    }
}
