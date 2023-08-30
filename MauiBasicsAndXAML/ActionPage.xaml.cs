namespace MauiBasicsAndXAML;

public partial class ActionPage : ContentPage
{
	public ActionPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
		DisplayAlert("This is an alert!", "Things are good", "Okay");
    }

    private void OnImageButtonClicked(object sender, EventArgs e)
    {
        DisplayAlert("You have clicked the image button", "", "okay");
    }

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("You Did A Thing!", $"You searched for {SearchBar.Text}", "Okay");
    }

    private void RightThing_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("You Did A Swipe!", "Right Thing", "Okay");
    }

    private void LeftThing_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("You Did A Swipe!", "Left Thing", "Okay");
    }
}