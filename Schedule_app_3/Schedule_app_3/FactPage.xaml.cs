namespace Schedule_app_3;

public partial class FactPage : ContentPage
{
	public FactPage()
	{
		InitializeComponent();
		Button btkniit = new Button()
		{
            Margin = new Thickness(0, 10, 0, 0),
			Text = "‘акультет  Ќи»т",
            FontSize = 20,
            TextColor = Color.FromRgb(0, 0, 0),
            BorderColor = Color.FromHex("#5cb0ff"),
        
            HeightRequest = 50,
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        Button btmah = new Button()
        {
            Margin = new Thickness(0, 10, 0, 0),
            Text = "‘акультет ћехћат",
            FontSize = 20,
            TextColor = Color.FromRgb(0, 0, 0),
            BorderColor = Color.FromHex("#5cb0ff"),
         
            HeightRequest = 50,
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        Button bteco = new Button()
        {
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Ёкономический факультет",
            FontSize = 20,
            TextColor = Color.FromRgb(0, 0, 0),
            BorderColor = Color.FromHex("#5cb0ff"),
  
            HeightRequest = 50,
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        StackLayout stackmain = new StackLayout()
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start,
            Children =
            {
                btmah,btkniit,bteco
            }
        };
        ScrollView scroll = new ScrollView()
        {
            WidthRequest = 500,
            Content = stackmain,
        };
        btkniit.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new GroupPage());
            //await Navigation.PushModalAsync(new FactPage());
        };
        btmah.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new GroupPage());
            //await Navigation.PushModalAsync(new FactPage());
        };
        bteco.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new GroupPage());
            //await Navigation.PushModalAsync(new FactPage());
        };
        Content = scroll;
    }
}