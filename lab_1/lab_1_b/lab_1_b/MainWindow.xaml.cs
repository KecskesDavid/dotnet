using lab_1_b.Model;
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

namespace lab_1_b
{
    public partial class MainWindow : Window
    {
        public Drill kimo = new Drill(
            new List<string>
            {
                    "1xKIMO Cordless K13811 Drill Driver",
                    "1x2.0Ah 20V Lithium-Ion Battery",
                    "1xFast Charger"
            },
            "Screw-In",
            "2.84 pounds",
            "KIMO.",
            Material.Titanium,
            null,
            "Average Battery Life 1000 Hours",
            "13.7 x 10.6 x 3 inches",
            "K13811",
            "Battery Powered",
            "Medium",
            Speed.Medium,
            null,
            "350 Inch Pounds",
            new Usage(
                true,
                true,
                false,
                true,
                true,
                true
            )
        );
        public MainWindow()
        {
            InitializeComponent();
            LoadMaterialComboBox();
            LoadSpeedComboBox();
        }

        private void LoadSpeedComboBox()
        {
            speedComboBox.ItemsSource = (Speed[])Enum.GetValues(typeof(Speed));
            speedComboBox.SelectedIndex = 0;
        }

        private void LoadMaterialComboBox()
        {
            materialComboBox.ItemsSource = (Material[])Enum.GetValues(typeof(Material));
            materialComboBox.SelectedIndex = 0;
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = kimo;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
        }
    }

}
