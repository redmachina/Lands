using System;
using System.Collections.Generic;
using System.Text;


namespace lands.ViewModels
{

    using System.Windows.Input;
    class LoginViewModel
    {
        #region Propierties
        public String Email {
            get; 
            set;
        
        }

        public String Password {
            get; 
            set; 
        }

        public bool IsRunning
        {
            get; 
            set; 
        }


        public bool IsRemmember
        { 
            get; 
            set; 
        }
        #endregion

        #region Contructors
        public LoginViewModel()
        {
            this.IsRemmember = true;
        }
        
        #endregion


        #region Commands
        public ICommand LoginCommand
        { 
            get; 
            set; 
        }

        #endregion


    }
}
