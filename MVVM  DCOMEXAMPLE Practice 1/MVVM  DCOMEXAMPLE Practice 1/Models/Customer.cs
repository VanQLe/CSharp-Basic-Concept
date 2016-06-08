using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM__DCOMEXAMPLE_Practice_1.Models
{
    using System.ComponentModel;
    class Customer : INotifyPropertyChanged
    {
        
        private string _Name;

        /// <summary>
        /// Initialize a Customer class object
        /// </summary>
        /// <param name="customerName"></param>
        public Customer(string customerName)
        {
            Name = customerName;
        }//end constructor

        /// <summary>
        /// Gets or set the Customer's name
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
