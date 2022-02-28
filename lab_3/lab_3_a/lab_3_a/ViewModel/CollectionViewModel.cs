using lab_3_a.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_a.ViewModel
{
    public class CollectionViewModel
    {
        //public List<User> Users { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator", Email = "admin@email.com", Gender=Gender.male });
            Users.Add(new User() { Name = "root", Email = "root@email.com", Gender = Gender.female });
            Users.Add(new User() { Name = "Blackhawk", Email = "Blackhawk@email.com", Gender = Gender.male });
            Users.Add(new User() { Name = "User001", Email = "User001@email.com", Gender = Gender.female });
            Users.Add(new User() { Name = "Cortana", Email = "Cortana@email.com", Gender = Gender.male });
        }
    }

}
