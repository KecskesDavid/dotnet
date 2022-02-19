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
            Manufactuerer.Text = kimo.Manufactuerer;
            PackageDimensions.Text = kimo.PackageDimensions;
            ItemWeight.Text = kimo.ItemWeight;
            PartNumber.Text = kimo.PartNumber;
            Size.Text = kimo.Size;
            PowerSource.Text = kimo.PowerSource;
            IncludeComponenets.Text = string.Join("\n", kimo.IncludeComponenets.ToArray());
            Torque.Text = kimo.Tourque;
            InstallationMethod.Text = kimo.InstallationMethod;
            Note.Text = kimo.Note;

            materialComboBox.SelectedItem = kimo.Material;
            speedComboBox.SelectedItem = kimo.Speed;

            ConcreteCheckbox.IsChecked = kimo.Usage.Concrete;
            WoodCheckbox.IsChecked = kimo.Usage.Wood;
            MetalCheckbox.IsChecked = kimo.Usage.Metal;
            HardBrickCheckbox.IsChecked = kimo.Usage.HardBrick;
            HardMaterialCheckbox.IsChecked = kimo.Usage.HardMaterial;
            ScrewDriverCheckbox.IsChecked = kimo.Usage.ScrewDriver;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Manufactuerer.Text = string.Empty;
            PackageDimensions.Text = string.Empty;
            ItemWeight.Text = string.Empty;
            PartNumber.Text = string.Empty;
            Size.Text = string.Empty;
            PowerSource.Text = string.Empty;
            IncludeComponenets.Text = string.Empty;
            Torque.Text = string.Empty;
            InstallationMethod.Text = string.Empty;
            Note.Text = string.Empty;

            materialComboBox.SelectedIndex = 0;
            speedComboBox.SelectedIndex = 0;

            ConcreteCheckbox.IsChecked = false;
            WoodCheckbox.IsChecked = false;
            MetalCheckbox.IsChecked = false;
            HardBrickCheckbox.IsChecked = false;
            HardMaterialCheckbox.IsChecked = false;
            ScrewDriverCheckbox.IsChecked = false;
        }
    }

}
