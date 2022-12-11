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
			Text = "–§–∞–∫—É–ª—å—Ç–µ—Ç –ö–ù–∏–ò–¢",
             
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
            Text = "–ë–∏–æ–ª–æ–≥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
             
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
            Text = "–ì–µ–æ–≥—Ä–∞—Ñ–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
             
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
            Text = "–ì–µ–æ–ª–æ–≥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
             
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
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç –¥–æ–ø–æ–ª–Ω–∏—Ç–µ–ª—å–Ω–æ–≥–æ \n –ø—Ä–æ—Ñ–µ—Å—Å–∏–æ–Ω–∞–ª—å–Ω–æ–≥–æ –æ–±—Ä–∞–∑–æ–≤–∞–Ω–∏—è",
             
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
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç –∏—Å–∫—É—Å—Å—Ç–≤",
             
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
<<<<<<< HEAD
            Text = "»ÌÒÚËÚÛÚ ËÒÚÓËË Ë ÏÂÊ‰ÛÌ‡Ó‰Ì˚ı ÓÚÌÓ¯ÂÌËÈ",
=======
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç –∏—Å—Ç–æ—Ä–∏–∏ –∏ –º–µ–∂–¥—É–Ω–∞—Ä–æ–¥–Ω—ã—Ö –æ—Ç–Ω–æ—à–µ–Ω–∏–π",
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
             
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
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ñ–∏–∑–∏–∫–∏",
             
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
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ñ–∏–∑–∏—á–µ—Å–∫–æ–π –∫—É–ª—å—Ç—É—Ä—ã –∏ —Å–ø–æ—Ä—Ç–∞",
             
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
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ñ–∏–ª–æ–ª–æ–≥–∏–∏ –∏ –∂—É—Ä–Ω–∞–ª–∏—Å—Ç–∏–∫–∏",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
           
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label btfilolog = new Label()
=======
        Label bthimiki = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ö–∏–º–∏–∏",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label bthimiki = new Label()
=======
        Label btsoc = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–°–æ—Ü–∏–æ–ª–æ–≥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label btsoc = new Label()
=======
        Label btino = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–§–∞–∫—É–ª—å—Ç–µ—Ç –∏–Ω–æ—Å—Ç—Ä–∞–Ω–Ω—ã—Ö —è–∑—ã–∫–æ–≤ –∏ –ª–∏–Ω–≥–≤–æ–¥–∏–¥–∞–∫—Ç–∏–∫–∏.",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label btino = new Label()
=======
        Label btpsihi = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
<<<<<<< HEAD
            Text = "‘‡ÍÛÎ¸ÚÂÚ ËÌÓÒÚ‡ÌÌ˚ı ˇÁ˚ÍÓ‚ Ë ÎËÌ„‚Ó‰Ë‰‡ÍÚËÍË.",
=======
            Text = "–§–∞–∫—É–ª—å—Ç–µ—Ç –ø—Å–∏—Ö–æ–ª–æ–≥–∏–∏",
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label btpsihi = new Label()
=======
        Label btpsihi2 = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–§–∞–∫—É–ª—å—Ç–µ—Ç –ø—Å–∏—Ö–æ–ª–æ–≥–æ-–ø–µ–¥–∞–≥–æ–≥–∏—á–µ—Å–∫–æ–≥–æ –∏ —Å–ø–µ—Ü–∏–∞–ª—å–Ω–æ–≥–æ –æ–±—Ä–∞–∑–æ–≤–∞–Ω–∏—è",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label btpsihi2 = new Label()
=======
        Label btmediki = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–§–∞–∫—É–ª—å—Ç–µ—Ç —Ñ—É–Ω–¥–∞–º–µ–Ω—Ç–∞–ª—å–Ω–æ–π –º–µ–¥–∏—Ü–∏–Ω—ã –∏ –º–µ–¥–∏—Ü–∏–Ω—Å–∫–∏—Ö —Ç–µ—Ö–Ω–æ–ª–æ–≥–∏–π",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),

<<<<<<< HEAD
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btmediki = new Label()
=======
            //HeightRequest = 75,
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btfilosof = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–§–∏–ª–æ—Å–æ—Ñ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
             
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
<<<<<<< HEAD

            //HeightRequest = 75,
            WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label btfilosof = new Label()
=======
            
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
        Label bturid = new Label()
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 10),
            Text = "–Æ—Ä–∏–¥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
            
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("D9D9D9"),
            
            //HeightRequest = 50,
           WidthRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };
<<<<<<< HEAD
        Label bturid = new Label()
        { GestureRecognizers = { das },
            FontSize = 20,
            FontFamily = "Comic Sans MS",
            Padding = new Thickness(5, 0, 5, 0),
            Margin = new Thickness(0, 10, 0, 10),
            Text = "ﬁË‰Ë˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ",
            
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
            Text = "‘‡ÍÛÎ¸ÚÂÚ ÃÂıÃ‡Ú",
=======
        Label btmah = new Label()
        { GestureRecognizers = { das },
            Margin = new Thickness(0, 10, 0, 0),
            Text = "–§–∞–∫—É–ª—å—Ç–µ—Ç –ú–µ—Ö–ú–∞—Ç",
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
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
            Text = "–≠–∫–æ–Ω–æ–º–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
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
            Text = "–í—ã–±–µ—Ä–∏—Ç–µ —Ñ–∞–∫—É–ª—å—Ç–µ—Ç",
            TextColor = Color.FromRgb(0, 0, 0),

            HorizontalOptions = LayoutOptions.Center,
            Padding = new Thickness(0, 0, 0, 3),
        };
        LinearGradientBrush myHorizontalGradient = new LinearGradientBrush();
        myHorizontalGradient.StartPoint = new Point(0, 0.5);
        myHorizontalGradient.EndPoint = new Point(0.5, 1);
        myHorizontalGradient.GradientStops.Add(new GradientStop(Color.FromHex("#673FD8"), 0.0f));
        myHorizontalGradient.GradientStops.Add(new GradientStop(Color.FromHex("#934ACD"), 1.0f));
        string str1 = "–ù–∞–π—Ç–∏ –ø—Ä–µ–ø–æ–¥–∞–≤–∞—Ç–µ–ª—è";
        
        
        Button el = new Button
        {
            TextColor = Color.FromRgb(255, 255, 255),
            FontFamily = "Comic Sans MS",
            Text = str1,
            Shadow = sh,
            Background = myHorizontalGradient,
            FontSize = 15,
            CornerRadius = 100,
            HorizontalOptions = LayoutOptions.End,
            WidthRequest = 300,
            HeightRequest = 200,
            
            Padding = new Thickness(0, 50, 120, 0),
            
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
<<<<<<< HEAD
                case "‘‡ÍÛÎ¸ÚÂÚ ÃÂıÃ‡Ú": 
                    await Navigation.PushAsync(new GroupPage("mm"));
                    break;
                case "‘‡ÍÛÎ¸ÚÂÚ  ÕË»“":
                    await Navigation.PushAsync(new GroupPage("knt"));
                    break;
                case "¡ËÓÎÓ„Ë˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
                    await Navigation.PushAsync(new GroupPage("bf"));
                    break;
                case "√ÂÓ„‡ÙË˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
                    await Navigation.PushAsync(new GroupPage("gf"));
                    break;
                case "√ÂÓÎÓ„Ë˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
                    await Navigation.PushAsync(new GroupPage("gl"));
                    break;
                case "»ÌÒÚËÚÛÚ ËÒÚÓËË Ë ÏÂÊ‰ÛÌ‡Ó‰Ì˚ı ÓÚÌÓ¯ÂÌËÈ":
                    await Navigation.PushAsync(new GroupPage("imo"));
                    break;
                case "»ÌÒÚËÚÛÚ ËÒÍÛÒÒÚ‚":
                    await Navigation.PushAsync(new GroupPage("ii"));
                    break;
                case "»ÌÒÚËÚÛÚ ÙËÁËÍË":
                    await Navigation.PushAsync(new GroupPage("ff"));
                    break;
                case "»ÌÒÚËÚÛÚ ÙËÁË˜ÂÒÍÓÈ ÍÛÎ¸ÚÛ˚ Ë ÒÔÓÚ‡":
                    await Navigation.PushAsync(new GroupPage("ifk"));
                    break;
                case "»ÌÒÚËÚÛÚ ÙËÎÓÎÓ„ËË Ë ÊÛÌ‡ÎËÒÚËÍË":
                    await Navigation.PushAsync(new GroupPage("ifg"));
                    break;
                case "»ÌÒÚËÚÛÚ ıËÏËË":
                    await Navigation.PushAsync(new GroupPage("ih"));
                    break;
                case "—ÓˆËÓÎÓ„Ë˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
                    await Navigation.PushAsync(new GroupPage("sf"));
                    break;
                case "‘‡ÍÛÎ¸ÚÂÚ ËÌÓÒÚ‡ÌÌ˚ı ˇÁ˚ÍÓ‚ Ë ÎËÌ„‚Ó‰Ë‰‡ÍÚËÍË":
                    await Navigation.PushAsync(new GroupPage("fi"));
                    break;
                case "‘‡ÍÛÎ¸ÚÂÚ ÔÒËıÓÎÓ„ËË":
                    await Navigation.PushAsync(new GroupPage("fps"));
                    break;
                case "‘‡ÍÛÎ¸ÚÂÚ ÔÒËıÓÎÓ„Ó-ÔÂ‰‡„Ó„Ë˜ÂÒÍÓ„Ó Ë ÒÔÂˆË‡Î¸ÌÓ„Ó Ó·‡ÁÓ‚‡ÌËˇ":
                    await Navigation.PushAsync(new GroupPage("fppso"));
                    break;
                case "‘‡ÍÛÎ¸ÚÂÚ ÙÛÌ‰‡ÏÂÌÚ‡Î¸ÌÓÈ ÏÂ‰ËˆËÌ˚ Ë ÏÂ‰ËˆËÌÒÍËı ÚÂıÌÓÎÓ„ËÈ":
                    await Navigation.PushAsync(new GroupPage("fmimt"));
                    break;
                case "‘ËÎÓÒÓÙÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
                    await Navigation.PushAsync(new GroupPage("fp"));
                    break;
                case "›ÍÓÌÓÏË˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
                    await Navigation.PushAsync(new GroupPage("ef"));
                    break;
                case "ﬁË‰Ë˜ÂÒÍËÈ Ù‡ÍÛÎ¸ÚÂÚ":
=======
                case "–§–∞–∫—É–ª—å—Ç–µ—Ç –ú–µ—Ö–ú–∞—Ç": 
                    await Navigation.PushAsync(new GroupPage("mm"));
                    break;
                case "–§–∞–∫—É–ª—å—Ç–µ—Ç –ö–ù–∏–ò–¢":
                    await Navigation.PushAsync(new GroupPage("knt"));
                    break;
                case "–ë–∏–æ–ª–æ–≥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
                    await Navigation.PushAsync(new GroupPage("bf"));
                    break;
                case "–ì–µ–æ–≥—Ä–∞—Ñ–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
                    await Navigation.PushAsync(new GroupPage("gf"));
                    break;
                case "–ì–µ–æ–ª–æ–≥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
                    await Navigation.PushAsync(new GroupPage("gl"));
                    break;
                case "–ò–Ω—Å—Ç–∏—Ç—É—Ç –∏—Å—Ç–æ—Ä–∏–∏ –∏ –º–µ–∂–¥—É–Ω–∞—Ä–æ–¥–Ω—ã—Ö –æ—Ç–Ω–æ—à–µ–Ω–∏–π":
                    await Navigation.PushAsync(new GroupPage("imo"));
                    break;
                case "–ò–Ω—Å—Ç–∏—Ç—É—Ç –∏—Å–∫—É—Å—Å—Ç–≤":
                    await Navigation.PushAsync(new GroupPage("ii"));
                    break;
                case "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ñ–∏–∑–∏–∫–∏":
                    await Navigation.PushAsync(new GroupPage("ff"));
                    break;
                case "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ñ–∏–∑–∏—á–µ—Å–∫–æ–π –∫—É–ª—å—Ç—É—Ä—ã –∏ —Å–ø–æ—Ä—Ç–∞":
                    await Navigation.PushAsync(new GroupPage("ifk"));
                    break;
                case "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ñ–∏–ª–æ–ª–æ–≥–∏–∏ –∏ –∂—É—Ä–Ω–∞–ª–∏—Å—Ç–∏–∫–∏":
                    await Navigation.PushAsync(new GroupPage("ifg"));
                    break;
                case "–ò–Ω—Å—Ç–∏—Ç—É—Ç —Ö–∏–º–∏–∏":
                    await Navigation.PushAsync(new GroupPage("ih"));
                    break;
                case "–°–æ—Ü–∏–æ–ª–æ–≥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
                    await Navigation.PushAsync(new GroupPage("sf"));
                    break;
                case "–§–∞–∫—É–ª—å—Ç–µ—Ç –∏–Ω–æ—Å—Ç—Ä–∞–Ω–Ω—ã—Ö —è–∑—ã–∫–æ–≤ –∏ –ª–∏–Ω–≥–≤–æ–¥–∏–¥–∞–∫—Ç–∏–∫–∏":
                    await Navigation.PushAsync(new GroupPage("fi"));
                    break;
                case "–§–∞–∫—É–ª—å—Ç–µ—Ç –ø—Å–∏—Ö–æ–ª–æ–≥–∏–∏":
                    await Navigation.PushAsync(new GroupPage("fps"));
                    break;
                case "–§–∞–∫—É–ª—å—Ç–µ—Ç –ø—Å–∏—Ö–æ–ª–æ–≥–æ-–ø–µ–¥–∞–≥–æ–≥–∏—á–µ—Å–∫–æ–≥–æ –∏ —Å–ø–µ—Ü–∏–∞–ª—å–Ω–æ–≥–æ –æ–±—Ä–∞–∑–æ–≤–∞–Ω–∏—è":
                    await Navigation.PushAsync(new GroupPage("fppso"));
                    break;
                case "–§–∞–∫—É–ª—å—Ç–µ—Ç —Ñ—É–Ω–¥–∞–º–µ–Ω—Ç–∞–ª—å–Ω–æ–π –º–µ–¥–∏—Ü–∏–Ω—ã –∏ –º–µ–¥–∏—Ü–∏–Ω—Å–∫–∏—Ö —Ç–µ—Ö–Ω–æ–ª–æ–≥–∏–π":
                    await Navigation.PushAsync(new GroupPage("fmimt"));
                    break;
                case "–§–∏–ª–æ—Å–æ—Ñ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
                    await Navigation.PushAsync(new GroupPage("fp"));
                    break;
                case "–≠–∫–æ–Ω–æ–º–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
                    await Navigation.PushAsync(new GroupPage("ef"));
                    break;
                case "–Æ—Ä–∏–¥–∏—á–µ—Å–∫–∏–π —Ñ–∞–∫—É–ª—å—Ç–µ—Ç":
>>>>>>> dadeb6ae7095765cb1fc448387689311b16b2441
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
