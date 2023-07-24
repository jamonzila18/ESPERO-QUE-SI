

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPERO_QUE_SI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboardxaml : ContentPage
    {
        public Dashboardxaml()
        {

            InitializeComponent();
           
        }
        private void btniniciar_Clicked(object sender, EventArgs e)
        { Navigation.PushAsync(new Productos());
        }
            
            }
}