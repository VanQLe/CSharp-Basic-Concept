﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Example.Models
{
    using System;
    using System.ComponentModel;
    public class Customer : INotifyPropertyChanged
    {

        private string _Name;

        /// <summary>
        /// Initializes a new instance of a Customer class
        /// </summary>
        /// <param name="customerName"></param>
        public Customer(String customerName)
        {
            Name = customerName;
        }

        /// <summary>
        /// Gets or sets the Customer's name.
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

        #region INotifyPropertyChanged   Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged( string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
             
            }
        }
        #endregion
    }

}
