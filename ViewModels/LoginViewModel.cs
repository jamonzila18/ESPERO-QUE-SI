using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPERO_QUE_SI.ViewModels
{
    internal class LoginViewModel
    {
        public Command RegisterBtn { get; }
        public Command LoginBtn { get; }
        

         private INavigation _navigation;

        public LoginViewModel(INavigation navigation)

        {
            this._navigation = navigation;
            RegisterBtn = new Command(RegisterBtnTappedAsync);
            LoginBtn = new Command(LoginBtnTappedAsync);
            
        }

      

        private async void LoginBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new Dashboardxaml());
        }
       

       

        private async void RegisterBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new RegisterPage());
        }
       

    }
}
