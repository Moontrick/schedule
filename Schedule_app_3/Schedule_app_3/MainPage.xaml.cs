using Microsoft.Maui.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Schedule_app_3;

public partial class MainPage : ContentPage
{
    //int count = 0;
    public MainPage()
    {
        InitializeComponent();
        Label labelt = new Label()
        {
            Text = "Выберите тип расписания",
            FontSize = 30,
        };
        Button firstbt = new Button()
        {
            Text = "Студент",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(0, 200, 255),
            Margin = new Thickness(0, 0, 0, 0),
            HeightRequest = 50,
            WidthRequest = 150,
        };
        Button secondbt = new Button()
        {
            Text = "Препод",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(0, 200, 255),
            Margin = new Thickness(0, 10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 150,
            
        };
        StackLayout newstack = new StackLayout()
		{
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Children =
            {   labelt,
                firstbt,
                secondbt
            }
        };
        firstbt.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new FactPage());
            //await Navigation.PushModalAsync(new FactPage());
        };
        Content = newstack;
        
    }

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}



}

