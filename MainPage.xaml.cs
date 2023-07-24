using ESPERO_QUE_SI.ViewModels;

namespace ESPERO_QUE_SI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel(Navigation);
	}


	
	
}

