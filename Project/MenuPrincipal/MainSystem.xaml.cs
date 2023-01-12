namespace Project.MenuPrincipal;

public partial class MainSystem : ContentPage
{
	RestService restService;

	public MainSystem()
	{
		InitializeComponent();
		restService = new RestService();
	}
	
	async void OnGetWeatherButtonClicked(object sender, EventArgs e)
	{
        //RestService.cs
        //Caso o usuario não digite nada no campo 

        if (!string.IsNullOrWhiteSpace(Entry_cidade.Text))
		{
			WeatherData weatherData = await restService.GetWeatherData(GerarURL(Constants.OpenWeatherMapEndpoint));
			BindingContext = weatherData;
		}
	}

	string GerarURL(string endPoint)
	{
		string requerirUri = endPoint;
		requerirUri += $"?q={Entry_cidade.Text}";
		requerirUri += "&units=imperial";
		requerirUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
		return requerirUri;
	}
}