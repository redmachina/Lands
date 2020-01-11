using lands.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lands
{
    public partial class App : Application
    {
        #region Contructors
        public App()
        {
            InitializeComponent();

            this.MainPage = new NavigationPage(new LoginPage());
        }

        #endregion
        #region Metodos
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
        #endregion
    }
}
