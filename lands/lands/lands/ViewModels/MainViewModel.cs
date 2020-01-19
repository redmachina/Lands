using System;
using System.Collections.Generic;
using System.Text;

namespace lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModel
        public LoginViewModel Login { 
            get; 
            set; 
        }
        #endregion

        #region
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }


        #endregion

    }
}
