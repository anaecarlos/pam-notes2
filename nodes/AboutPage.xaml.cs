namespace nodes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

	}
	private async void LearnMore_Cicked(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://www.google.com.br");
	}
}