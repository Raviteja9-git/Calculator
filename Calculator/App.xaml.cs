namespace Calculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Application.Current.UserAppTheme = AppTheme.Dark;
        MainPage = new AppShell();
        About = new AppShell();
	}

	

	public AppShell About { get; }
}
