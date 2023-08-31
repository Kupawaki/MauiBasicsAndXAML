namespace MauiBasicsAndXAML;

public partial class InputPage : ContentPage
{
	public InputPage()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		SliderLabel.Text = ((int)e.NewValue).ToString();
    }
}