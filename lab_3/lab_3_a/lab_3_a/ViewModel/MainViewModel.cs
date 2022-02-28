using lab_3_a.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_a.ViewModel
{
    class MainViewModel
    {
        public User User { get; set; }
        public MainViewModel()
        {
            User = new User() { Name = "Cortana" };
        }
        public void ChangeName(string newName)
        {
            User.Name = newName;
        }
    }
}
