using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_a.Model
{
    public class User : INotifyPropertyChanged
    {
        private string _Name { 
            get { return _Name; }
            set
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            } 
        }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    public enum Gender
    {
        male, female
    }
}
