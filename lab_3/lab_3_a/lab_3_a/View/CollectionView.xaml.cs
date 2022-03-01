using lab_3_a.Model;
using lab_3_a.ViewModel;
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

namespace lab_3_a.View
{
    public partial class CollectionView : UserControl
    {
        public CollectionViewModel viewModel = new CollectionViewModel();
        public CollectionView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Users.Add(new Model.User() { Name = txtUserName.Text });
            txtUserName.Text = string.Empty;
        }
        private void selectUser_Click(object sender, RoutedEventArgs e)
        {
            var User = ((sender as ListView).SelectedItem) as User;
            if (User != null)
            {
                Window parentWindow = Window.GetWindow(this);
                TextBox textChangeName = parentWindow.FindName("txtNewName") as TextBox;
                TextBlock textName = parentWindow.FindName("txtName") as TextBlock;

                textChangeName.Text = User.Name;
                textName.Text = User.Name;

                viewModel.SelectedUser = User.Id;
            }
        }
        public virtual void ChangeUserName(string userName)
        {
            viewModel.ChangeUserName(userName);
            listView.ItemsSource = null;
            listView.ItemsSource = viewModel.Users;
        }
    }
}
