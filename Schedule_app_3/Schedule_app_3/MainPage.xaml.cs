using static Java.Util.Jar.Attributes;
using static System.Net.Mime.MediaTypeNames;

namespace Schedule_app_3;

public partial class MainPage : ContentPage
{
	int count = 0;
    
    public MainPage()
    {
        InitializeComponent();

        //Button button = new Button
        //{
        //    Text = "Navigate!",
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.Center
        //};

        //button.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new IndexPage());
        //};

        //Content = button;

        //Label l1 = new Label
        //{
        //    Text = "label1",
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.Center
        //};
        //Label l2 = new Label
        //{
        //    Text = "label2",
        //    HorizontalOptions = LayoutOptions.Center,
        //    VerticalOptions = LayoutOptions.End
        //};

        StackLayout stackMain = new StackLayout();
       
        //for(int i = 0; i < 10; i++)
        //{
        //    Label l = new Label
        //    {
        //        Text = "label" + i,
        //        Margin = new Thickness(10, 0, 0, 0),
        //        HorizontalOptions = LayoutOptions.Center,
        //        VerticalOptions = LayoutOptions.Center
        //    };
        //    st.Children.Add(l);
        //};
        for (int i = 0; i < 10; i++)
        {
            StackLayout st = new StackLayout();
            Grid fr1 = new Grid
            {
                Padding = new Thickness(0, 0, 0, 0),
                Children =
            {
                new Label
                {
                    TextColor = Color.FromHex("#828181"),
                    FontSize = 16,
                    Text = "1",
                     HorizontalOptions = LayoutOptions.Start,
                     VerticalOptions = LayoutOptions.Center
                },
                 new Label
                {
                    TextColor = Color.FromHex("#828181"),
                     FontSize = 16,
                    Text = "Лекция",
                    Padding = new Thickness (20,0,0,0),
                     HorizontalOptions = LayoutOptions.Start,
                     VerticalOptions = LayoutOptions.Center
                },
                 new Label
                {
                    TextColor = Color.FromHex("#828181"),
                     FontSize = 16,
                    Text = "1под",
                    HorizontalOptions = LayoutOptions.End,
                     VerticalOptions = LayoutOptions.Center
                },
           }

            };
            st.Children.Add(fr1);
            Label l1 = new Label
            {
                FontSize = 17,
                FontFamily = "Comic Sans MS",
                TextColor = Color.FromRgb(0, 0, 0),
                Padding = new Thickness(0, 10, 0, 0),
                Text = "Методы вычислений",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
            };
            st.Children.Add(l1);
            Label l2 = new Label
            {
                TextColor = Color.FromHex("#828181"),
                FontSize = 16,
                Padding = new Thickness(0, 5, 0, 0),
                Text = "Поплавский Д. В.",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
            };
            st.Children.Add(l2);

            Grid fr2 = new Grid
            {
                Padding = new Thickness(0, 8, 0, 0),
                Children =
            {
                new Label
                {
                               TextColor = Color.FromHex("#828181"),
                    FontSize = 16,
                    Text = "12корпус ауд. 420",
                     HorizontalOptions = LayoutOptions.Start,
                     VerticalOptions = LayoutOptions.Center
                },
                 new Label
                {
                                TextColor = Color.FromHex("#828181"),
                     FontSize = 16,
                    Text = "8:20 - 9:50",
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Center
                },
           }

            };
            st.Children.Add(fr2);


            Frame fr = new Frame
            {
                Content = st,
                Margin = new Thickness(5, 10, 5, 0),
                HeightRequest = 150,
                BackgroundColor = Color.FromHex("#f9f9f9"),
                CornerRadius = 5,
            };
            stackMain.Children.Add(fr);
        }
        Content = stackMain;
       

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}



}

