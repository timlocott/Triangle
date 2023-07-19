namespace Triangle;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var windows = base.CreateWindow(activationState);

        windows.MinimumHeight = 500;
        windows.MinimumWidth = 500;

        return windows;
    }
}

