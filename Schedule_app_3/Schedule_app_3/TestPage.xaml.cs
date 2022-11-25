using Microsoft.Maui.Controls.Shapes;

namespace Schedule_app_3;

public partial class TestPage : ContentPage
{
	public TestPage()
	{

        InitializeComponent();
        Shadow sh = new Shadow()
        {
            Brush = Color.FromRgb(0, 0, 0),
            Radius = 20,
            Opacity = 0.5f,
            Offset = new Point(0, 5),
        };
        Button entry = new Button()
        {
            Shadow = sh,
            FontFamily = "Comic Sans MS",
            WidthRequest = 200,
            HeightRequest = 40,
            Background = Color.FromHex("#9B92D6"),
            FontSize = 15,
            CornerRadius = 17,
            Text = "Выберите факультет",
            TextColor = Color.FromRgb(0, 0, 0),

            HorizontalOptions = LayoutOptions.Center,
            Padding = new Thickness(0, 0, 0, 3),
        };
        LinearGradientBrush myHorizontalGradient = new LinearGradientBrush();
        myHorizontalGradient.StartPoint = new Point(0, 0.5);
        myHorizontalGradient.EndPoint = new Point(0.5, 1);
        myHorizontalGradient.GradientStops.Add(new GradientStop(Color.FromHex("#673FD8"), 0.0f));
        myHorizontalGradient.GradientStops.Add(new GradientStop(Color.FromHex("#934ACD"), 1.0f));

        // Use the brush to paint the rectangle.
        Button el = new Button()
        {
            TextColor = Color.FromRgb(255, 255, 255),
            FontFamily = "Comic Sans MS",
            Text = "Поиск по\nпреподавателям",
            Shadow = sh,
            Background = myHorizontalGradient,
            CornerRadius = 150,
            HorizontalOptions = LayoutOptions.End,
            WidthRequest = 300,
            HeightRequest = 200,
            Padding = new Thickness(0, 50, 120, 0),
            ZIndex = 1,
        };

        Grid flexLayout = new Grid()
        {
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 200,
            Margin = new Thickness(100, -99, -150, 100),

            Children =
            {
                el,
            }
        };
        Grid gr2 = new Grid()
        {
            Margin = new Thickness(-75, 0, 0, 0),
            Padding = new Thickness(0, 80, 0, 0),
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,

            Children =
            {
                entry,
            }
        }; Grid gr3 = new Grid()
        {
            Children =
            {
                flexLayout,gr2
            }
        };
        LinearGradientBrush myHorizontalGradient1 = new LinearGradientBrush();
        myHorizontalGradient1.StartPoint = new Point(0.5, 0);
        myHorizontalGradient1.EndPoint = new Point(0.5, 1);
        myHorizontalGradient1.GradientStops.Add(new GradientStop(Color.FromHex("#512cd4"), 0.0f));
        myHorizontalGradient1.GradientStops.Add(new GradientStop(Color.FromHex("#5F33DA"), 1.0f));

        LinearGradientBrush myHorizontalGradient12 = new LinearGradientBrush();
        myHorizontalGradient12.StartPoint = new Point(0.3, 0);
        myHorizontalGradient12.EndPoint = new Point(0.3, 1);
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#5F33DA"), 0.4f));
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#C38BF9"), 1.0f));
        Frame frame = new Frame()
        {
            BorderColor = Color.FromHex("#512cd4"),
            Background = myHorizontalGradient1,
            Padding = new Thickness(100, 0, 0, 0),
            Content = gr3,
        };

        StackLayout stackLayout = new StackLayout()
        {

            Background = myHorizontalGradient12,
            Children = { frame }
        };
        Background = Color.FromHex("#512cd4");



        Content = stackLayout;
    }
}