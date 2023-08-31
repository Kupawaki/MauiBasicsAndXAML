namespace MauiBasicsAndXAML;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void onActionButtonPressed(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ActionPage());
    }

    private void OnInputButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputPage());
    }
}

