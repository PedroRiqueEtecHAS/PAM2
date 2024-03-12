namespace Nodes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private void LearnMore_Clicked(object sender, EventArgs e) 
	{
		Launcher.Default.OpenAsync("https://www.google.com.br");
	}

}