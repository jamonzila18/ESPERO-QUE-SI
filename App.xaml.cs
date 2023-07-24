namespace ESPERO_QUE_SI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage (new MainPage());
    }
    protected override void OnStart()
    {
        base.OnStart();
    }




}
