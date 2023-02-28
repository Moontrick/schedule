using Microsoft.Maui;
using Microsoft.Maui.Controls.Shapes;

namespace Schedule_app_3;

public partial class FactPage : ContentPage
{
	public FactPage()
	{
        //23
		InitializeComponent();
        TapGestureRecognizer das = new TapGestureRecognizer()
        {

        };
        Label btkniit = new Label()
		{ GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
			Text = "Факультет КНиИТ",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
        
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btbiolog = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Биологический факультет",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btgeogr = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Географический факультет",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btgeolog = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Геологический факультет",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btdopobr = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт дополнительного \n профессионального образования",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btisc = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт искусств",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label bthistory = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт истории и международных отношений",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btfiozik = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт физики",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btfizra = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт физической культуры и спорта",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
           
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btfilolog = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт филологии и журналистики",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label bthimiki = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Институт химии",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btsoc = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Социологический факультет",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btino = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Факультет иностранных языков и лингводидактики.",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btpsihi = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Факультет психологии",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btpsihi2 = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Факультет психолого-педагогического и специального образования",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btmediki = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Факультет фундаментальной медицины и медицинских технологий",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 75,
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btfilosof = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Философский факультет",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
            
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label bturid = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 10),
            Text = "Юридический факультет",
            
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btmah = new Label()
        { GestureRecognizers = { das },
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Факультет МехМат",
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
         
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label bteco = new Label()
        { GestureRecognizers = { das },
            Margin = new Thickness(0, 10, 0, 0),
            Text = "Экономический факультет",
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            //Background = Color.FromHex("D9D9D9"),
            Background = Color.FromHex("D9D9D9"),
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start,
           
        };
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
<<<<<<< HEAD
        string str1 = "Найти преподавателя";
=======
        string str1 = "Для преподавателя";
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
        
        
        Button el = new Button
        {
            TextColor = Color.FromRgb(255, 255, 255),
            FontFamily = "Comic Sans MS",
            Text = str1,
            Shadow = sh,
            Background = myHorizontalGradient,
<<<<<<< HEAD
            FontSize = 15,
=======
            FontSize = 14,
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            CornerRadius = 100,
            HorizontalOptions = LayoutOptions.End,
            WidthRequest = 300,
            HeightRequest = 200,
            
<<<<<<< HEAD
            Padding = new Thickness(0, 50, 120, 0),
=======
            Padding = new Thickness(0, 50, 130, 0),
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            
        };

        el.Clicked += async (s, e) =>
        {
            await Navigation.PushAsync(new TheacherFinder());
        };
        //Border br = new Border()
        //{
            
        //    Background = Color.FromHex("D9D9D9"),
        //    StrokeShape = new RoundRectangle
        //    {
        //        CornerRadius = new CornerRadius(Math.Abs(bteco.Height))
        //    },
        //    Content = bteco
        //};

        Grid flexLayout = new Grid()
        {
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.Start,
            HeightRequest = 200,
            Margin = new Thickness(100, -99, -150, 99),

            Children =
            {
                el,
            }
        };
        Grid gr2 = new Grid()
        {
            Margin = new Thickness(10, 0, 0, 0),
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
            Padding = new Thickness(0, 0, 0, 0),
            Content = gr3,
        };

        
        Background = Color.FromHex("#512cd4");
        StackLayout stackmain = new StackLayout()
        {
            Margin = new Thickness(0, -50, 0, 0),
            Background = myHorizontalGradient12,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start,
            Children =
            {
                btmah,btkniit,bteco,btbiolog,btgeogr,btgeolog,btisc,bthistory,btfiozik,btfizra,btfilolog,
                bthimiki,btsoc,btino,btpsihi,btpsihi2,btmediki,btfilosof,
                bturid
            }
        };
        StackLayout stackLayout = new StackLayout()
        {
            
            Background = myHorizontalGradient12,
            Children = { frame, stackmain }
        };
        ScrollView scroll = new ScrollView()
        {
            Background = myHorizontalGradient1,
            HorizontalOptions = LayoutOptions.Start,
            //WidthRequest = 500,
            Content = stackLayout,
        };
        das.Tapped += async (s, e) =>
        {
            Label batick = (Label)s;
            switch (batick.Text)
            {
                case "Факультет МехМат": 
                    await Navigation.PushAsync(new GroupPage("mm"));
                    break;
                case "Факультет КНиИТ":
                    await Navigation.PushAsync(new GroupPage("knt"));
                    break;
                case "Биологический факультет":
                    await Navigation.PushAsync(new GroupPage("bf"));
                    break;
                case "Географический факультет":
                    await Navigation.PushAsync(new GroupPage("gf"));
                    break;
                case "Геологический факультет":
                    await Navigation.PushAsync(new GroupPage("gl"));
                    break;
                case "Институт истории и международных отношений":
                    await Navigation.PushAsync(new GroupPage("imo"));
                    break;
                case "Институт искусств":
                    await Navigation.PushAsync(new GroupPage("ii"));
                    break;
                case "Институт физики":
                    await Navigation.PushAsync(new GroupPage("ff"));
                    break;
                case "Институт физической культуры и спорта":
                    await Navigation.PushAsync(new GroupPage("ifk"));
                    break;
                case "Институт филологии и журналистики":
                    await Navigation.PushAsync(new GroupPage("ifg"));
                    break;
                case "Институт химии":
                    await Navigation.PushAsync(new GroupPage("ih"));
                    break;
                case "Социологический факультет":
                    await Navigation.PushAsync(new GroupPage("sf"));
                    break;
                case "Факультет иностранных языков и лингводидактики":
                    await Navigation.PushAsync(new GroupPage("fi"));
                    break;
                case "Факультет психологии":
                    await Navigation.PushAsync(new GroupPage("fps"));
                    break;
                case "Факультет психолого-педагогического и специального образования":
                    await Navigation.PushAsync(new GroupPage("fppso"));
                    break;
                case "Факультет фундаментальной медицины и медицинских технологий":
                    await Navigation.PushAsync(new GroupPage("fmimt"));
                    break;
                case "Философский факультет":
                    await Navigation.PushAsync(new GroupPage("fp"));
                    break;
                case "Экономический факультет":
                    await Navigation.PushAsync(new GroupPage("ef"));
                    break;
                case "Юридический факультет":
                    await Navigation.PushAsync(new GroupPage("uf"));
                    break;
                default: break;
            }
            
        };
        //btkniit.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("knt"));
        //    //await Navigation.PushModalAsync(new FactPage());
        //};
        //bturid.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("uf"));
        //};
        //btfilosof.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("fp"));
        //};
        //btmediki.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("fmimt"));
        //};
        //btpsihi2.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("fppso"));
        //};
        //btpsihi.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("fps"));
        //};
        //btino.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("fi"));
        //};
        //btsoc.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("sf"));
        //};
        //bthimiki.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("ih"));
        //};
        //btfilolog.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("ifg"));
        //};
        //btfizra.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("ifk"));
        //};
        //btfiozik.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("ff"));
        //};
        //bthistory.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("imo"));
        //};
        //btisc.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("ii"));
        //};
        //btbiolog.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("bf"));
        //};
        //btgeogr.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("gf"));
        //};
        //btgeolog.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("gl"));
        //};
        //btdopobr.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("idpo"));
        //};
        //btmah.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("mm"));
        //    //await Navigation.PushModalAsync(new FactPage());
        //};
        //bteco.Clicked += async (sender, args) =>
        //{
        //    await Navigation.PushAsync(new GroupPage("ef"));
        //    //await Navigation.PushModalAsync(new FactPage());
        //};
        Content = scroll;
    }
}