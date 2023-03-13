namespace Schedule_app_3;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
        Label tit = new Label()
        {
            FontFamily = "Inter",
            FontSize = 30,
            Text = "Настройки",
            TextColor = Color.FromRgb(0,0,0),
            Margin = new Thickness(0,0,0,20),
            HorizontalOptions = LayoutOptions.Center,
        };
		Button btfirst = new Button()
		{
            FontFamily = "Inter",
            Background = Color.FromHex("#D9D9D9"),
			Text = "Поиск преподавателя",
			WidthRequest = 325,
			HeightRequest = 50,
			CornerRadius = 22,
            FontSize = 20,
            Margin = new Thickness(0,0,0,20),
            TextColor = Color.FromRgb(0,0,0),
        };
        btfirst.Clicked += async (s, e) =>
        {
            await Navigation.PushAsync(new TheacherFinder());
        };
        Button btsecond = new Button()
        {
            FontFamily = "Inter",
            Background = Color.FromHex("#D9D9D9"),
            Text = "Поиск группы",
            WidthRequest = 325,
            HeightRequest = 50,
            CornerRadius = 22,
            FontSize = 20,
            Margin = new Thickness(0, 0, 0, 20),
            TextColor = Color.FromRgb(0, 0, 0),
        };
       
        btsecond.Clicked += async (s, e) =>
        {
            await Navigation.PushAsync(new FactPage());
        };
        Button btthird = new Button()
        {
            FontFamily = "Inter",
            Background = Color.FromHex("#D9D9D9"),
            Text = "Изменить текущую группу",
            WidthRequest = 325,
            HeightRequest = 50,
            CornerRadius = 22,
            FontSize = 20,
            Margin = new Thickness(0, 0, 0, 20),
            TextColor = Color.FromRgb(0, 0, 0),
        };
        btthird.Clicked += async (s, e) =>
        {
            await Navigation.PushAsync(new FactPage());
        };
        StackLayout stackmain = new StackLayout()
        {
            Margin = new Thickness(0,20,0,0),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start,
            Children =
            {
                tit, btfirst,btsecond,btthird
            }
        }; 
        LinearGradientBrush myHorizontalGradient12 = new LinearGradientBrush();
        myHorizontalGradient12.StartPoint = new Point(0.3, 0);
        myHorizontalGradient12.EndPoint = new Point(0.3, 1);
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#5F33DA"), 0.4f));
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#C38BF9"), 1.0f));
        ImageButton alertButton = new ImageButton
        {
            Source = "vopros.png",
            WidthRequest = 30,
            HeightRequest = 30,
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.End,
            BackgroundColor = Color.FromRgba(0, 0, 0, 1),
            IsOpaque = false,
            Aspect = Aspect.Fill,
            Margin = new Thickness(0, 0, 20, 20),
        };
        alertButton.Clicked += AlertButton_Clicked;

        async void AlertButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Спасибо за скачивание нашего приложения)", "Данное приложение было сделано студентами 3 курса ф-т КНиИТ", "ОK");
        }
        Label prod = new Label()
        {
            FontFamily = "Inter",
            Text = "C.P. @ CSIT Production",
            FontSize = 15,
            TextColor = Color.FromRgb(0, 0, 0),
            Margin = new Thickness(0, 0, 0, 20),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.End,
        };
        Grid gridend = new Grid()
        {
            //Background = myHorizontalGradient12,
            
            Children =
            {
                stackmain, prod,alertButton
            }
        };
        //Background = Color.FromHex("#512cd4");
        Content = gridend;
    }
}