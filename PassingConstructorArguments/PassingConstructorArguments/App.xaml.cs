using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassingConstructorArguments
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.PassingConstructorArgumentsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
