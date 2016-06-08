
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVM_Example.ViewModels
{
    using Commands;
    using MVVM_Example.Models;
    using System;
    using System.Diagnostics;
    using System.Windows.Input;
    class CustomerViewModel
    {   
        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// </summary>
        public CustomerViewModel()
        {
            _Customer = new Customer("Van");
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        /// <summary>
        /// Gets or sets a SystemBoolean value indicating whether the Customer can be updated.
        /// </summary>
        public bool CanUpdate
        {
            get
            {
                if(Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.Name);
            }
          
        }

        private Customer _Customer;

        /// <summary>
        /// Gets the Customer instance.
        /// </summary>
        public Customer Customer
        {
            get
            {
                return _Customer;
            }
    
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }
      

        public void SaveChanged()
        {
            Debug.Assert(false, String.Format("{0} was  updated TESTHELLOWORLD", Customer.Name));
        }


    }
}
