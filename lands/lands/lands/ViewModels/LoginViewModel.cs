using System;
using System.Collections.Generic;
using System.Text;


namespace lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;


    class LoginViewModel : BaseViewModel
    {

        

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        private bool isRemmembered;
        #endregion

        #region Propierties
        public String Email {
            get { return this.email; }
            set { SetValue(ref this.email, value); }

        }

        public String Password {
            get { return password; }
            set { SetValue(ref password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }


        public bool IsRemmembered
        {
            get { return this.isRemmembered; }
            set { SetValue(ref this.isRemmembered, value); }
        }


        public bool IsEnabled 
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion






        #region Contructors
        public LoginViewModel()
        {
            this.isRemmembered = true;
            this.isEnabled = true;
        }
        
        #endregion


        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
            
        }

        

        private async void Login()
        {


            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Password",
                    "Accept");
            }
            
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Email ",
                    "Accept");
            }

            this.IsRunning = true;
            this.IsEnabled = false;


            if (this.Email != "mi_servicio@hotmail.com"||this.Password != "1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;

                await Application.Current.MainPage.DisplayAlert(

                    "Error",
                    "Email or password incorret.",
                    "Accept"


                    );


                    this.Password = string.Empty;
                

               
                return;
            }

            this.IsRunning = true;
            this.IsEnabled = false;

            this.Email = string.Empty;
            this.Password = string.Empty;


            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new Lands1Page());


        }

        #endregion


    }
}
