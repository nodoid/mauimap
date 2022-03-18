namespace mauimap;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		Task.Run(async () => await LaunchMap());
	}

	async Task LaunchMap()
    {
		var location = new Location(28.3772, 81.5707);
		var options = new MapLaunchOptions { Name = "Disney World" };
		//Launching Maps
		await Map.OpenAsync(location, options);
	}
}

