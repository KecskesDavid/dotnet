using lab_3_a.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_a.ViewModel
{
    public class CollectionViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> Users { get; set; }
        public long SelectedUser = 0L;

        public event PropertyChangedEventHandler PropertyChanged;

        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Id = 0L, Name = "Administrator", Email = "admin@email.com", Gender=Gender.male });
            Users.Add(new User() { Id = 1L, Name = "root", Email = "root@email.com", Gender = Gender.female });
            Users.Add(new User() { Id = 2L, Name = "Blackhawk", Email = "Blackhawk@email.com", Gender = Gender.male });
            Users.Add(new User() { Id = 3L, Name = "User001", Email = "User001@email.com", Gender = Gender.female });
            Users.Add(new User() { Id = 4L, Name = "Cortana", Email = "Cortana@email.com", Gender = Gender.male });
        }

        internal void ChangeUserName(string userName)
        {
            Users.ToList().Find(User => User.Id == SelectedUser).Name = userName;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Users"));
        }
    }

}
