using Project.MenuPrincipal;

namespace Project;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void BtnLogin_Clicked(object sender, EventArgs e)
	{
		if(txtusername.Text != null && txtpassword.Text != null)
		{
            Navigation.PushAsync(new MainSystem());
        }

		else
		{
			DisplayAlert("ew!", "Nome de usuario ou senha estão incorretos", "ok");
		}
	}

     int i = 0;
    Easing[] Easings = new Easing[]
    {
        Easing.Linear,
        Easing.SinOut,
        Easing.SinIn,
        Easing.SinInOut,
        Easing.CubicIn,
        Easing.CubicOut,
        Easing.CubicInOut,
        Easing.BounceOut,
        Easing.BounceIn,
        Easing.SpringIn,
        Easing.SpringOut,
    };

     private async void BtnLogout_Clicked(object sender, EventArgs e)
    {
        await loading.ScaleTo(2, 2000, Easings[i]);
        loading.Scale = 1;
        i++;
        if (i >= Easings.Length)
            i = 0;

        await loading.RotateTo(360, 2000, Easing.SinInOut);
 

       ResetProperties();
    }

    private async void ResetProperties()
    {
        await Task.Delay(1000);
        loading.Rotation = 0;
        loading.Scale = 1;
        loading.TranslationX = 0;
        loading.TranslationY = 0;
    }
}

