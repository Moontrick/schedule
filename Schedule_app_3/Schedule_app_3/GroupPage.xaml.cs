using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;

namespace Schedule_app_3;

public partial class GroupPage : ContentPage
{
    List<string> AllGroup = new List<string>();
    Dictionary<int, List<Dictionary<int, int>>> IDCommonPair = new Dictionary<int, List<Dictionary<int, int>>>();
    List<string> _PairType = new List<string>();
    List<string> _PairName = new List<string>();
    List<string> _TeacherName = new List<string>();
    List<string> _Location = new List<string>();
    List<string> _TimePair = new List<string>();
    List<string> _Podgroup = new List<string>();
    public GroupPage(string faculty)
    {
        Shadow sh = new Shadow()
        {
            Brush = Color.FromRgb(0, 0, 0),
            Radius = 20,
            Opacity = 0.5f,
            Offset = new Point(0, 5),
        };

        InitializeComponent();
        ParserGroup _parserGroup = new ParserGroup(faculty);
        foreach (var num in _parserGroup.GroupList)
        {
            AllGroup.Add(num);
        }

        LinearGradientBrush myHorizontalGradient = new LinearGradientBrush();
        myHorizontalGradient.StartPoint = new Point(0, 0.8);
        myHorizontalGradient.EndPoint = new Point(0.8, 1);
        myHorizontalGradient.GradientStops.Add(new GradientStop(Color.FromHex("#00A3FF"), 0.0f));
        myHorizontalGradient.GradientStops.Add(new GradientStop(Color.FromHex("#EFEFEF"), 1.0f));
        Label lbtitle = new Label()
        {
            FontFamily = "Comic Sans MS",
            Text = "Поиск группы",
            FontSize= 20,
            TextColor = Color.FromRgb(0, 0, 0),
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            Margin = new Thickness(0,0,0,20),
        };
        Entry entry = new Entry
        {
            Placeholder = "Введите номер группы...",
            FontFamily = "Comic Sans MS",
            WidthRequest = 250,
            HeightRequest = 40,
            PlaceholderColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#EFEFEF"),
            FontSize = 15,


            TextColor = Color.FromRgb(0, 0, 0),
        };
        Border br = new Border()
        {
            StrokeThickness = 1,
            Shadow = sh,
            Padding = new Thickness(0, 0, 0, 0),
            //Background = Color.FromHex("#9B92D6"),
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(10)
            },
            Margin = new Thickness(0, 0, 0, 50),
            Content = entry
        };
        //entry.Completed += OnEntryCompleted;
        StackLayout stackmain = new StackLayout()
        {
            
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            
            Children =
            {  lbtitle,
                br
            }
        };

        StackLayout stackbut1 = new StackLayout()
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
        };
        Button bt = new Button()
        {
            Text = "",
            FontSize = 15,
            Margin = new Thickness(0, 3, 0, 0),
            WidthRequest = 100,
            HeightRequest = 50,
        };
        for (int i = 0; i < AllGroup.Count(); i++)
        {
            bt = new Button()
            {
                Shadow = sh,
                TextColor = Color.FromRgb(0, 0, 0),
                Background = Color.FromHex("EFEFEF"),
                Text = AllGroup[i],
                FontSize = 15,
                WidthRequest = 150,
                HeightRequest = 50,
                Margin = new Thickness(0, 5, 0, 0),
            };
            bt.Clicked += onclik;
            //stackbut1.Add(bt);
        }
        LinearGradientBrush myHorizontalGradient12 = new LinearGradientBrush();
        myHorizontalGradient12.StartPoint = new Point(0.3, 0);
        myHorizontalGradient12.EndPoint = new Point(0.3, 1);
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#512cd4"), 0.4f));
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#C38BF9"), 1.0f));
        StackLayout stackend = new StackLayout()
        {
            //Background = myHorizontalGradient,
        };
        StackLayout stacklast = new StackLayout()
        {
            //Background = myHorizontalGradient,
        }; ;
        //Background = Color.FromHex("#512cd4");
        stackend.Children.Add(stackbut1);
        stacklast.Children.Add(stackmain);
        stacklast.Children.Add(stackend);
        //-----------------------------
        //Button dsa = new Button()
        //{
        //    Text = "dsa",
        //    FontSize = 15,
        //    WidthRequest = 100,
        //    HeightRequest = 50,
        //    Margin = new Thickness(0, 5, 0, 0),
        //};
        //dsa.Clicked += async (sender, args) =>
        //{

        //    await Navigation.PushModalAsync(new IndexPage());
        //};
        //stackend.Children.Add(dsa);
        //-----------------------------
        Frame frame = new Frame()
        {
           
            //BorderColor = Color.FromHex("#512cd4"),
            //Background = myHorizontalGradient12,
            Content = stacklast,

        };
        ScrollView scrol = new ScrollView()
        {

            //Background = myHorizontalGradient,
            Content = frame,
        };


        entry.TextChanged += async (sender, args) =>
        {
            string oldText = args.OldTextValue;
            string newText = args.NewTextValue;
            string myText = entry.Text;
            stackend.Clear();

            StackLayout stackbut = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,

            };
            if (myText.Length != 0)
            {
                for (int i = 0; i < AllGroup.Count(); i++)
                {
                    string str = AllGroup[i];
                    bool flag = true;
                    if (myText.Length > str.Length)
                    {

                    }
                    else
                    {
                        for (int j = 0; j < myText.Length; j++)
                        {
                            if (str[j] != myText[j])
                            {
                                flag = false;
                            }
                        }
                        if (flag)
                        {
                            // ICommand ic;
                            bt = new Button()
                            {

                                // Command = ic.Execute(NavTogle),
                                Text = AllGroup[i],
                                FontSize = 15,
                                Margin = new Thickness(0, 3, 0, 0),
                                WidthRequest = 100,
                                HeightRequest = 50,
                                Shadow = sh,
                                TextColor = Color.FromRgb(0, 0, 0),
                                Background = Color.FromHex("EFEFEF"),

                            };
                            bt.Clicked += onclik;
                            stackbut.Add(bt);
                        }
                    }
                }
            }

            stackend.Children.Add(stackbut);

        };


        void onclik(object sender, EventArgs args)
        {
            Button batick = (Button)sender;

            int h = 1;
            //WriteFromParser
            for (int i = 0; i < 6; i++)
            {
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
                //string faculty = "knt";

                //string group = "311";
                Parser ob = new Parser(h, faculty, batick.Text);

                _PairType.AddRange(ob.PairType);
                _PairName.AddRange(ob.PairName);
                _TeacherName.AddRange(ob.TeacherName);
                _Location.AddRange(ob.Location);
                _Podgroup.AddRange(ob.Podgroup);
                var tmp = new List<Dictionary<int, int>>();
                tmp.Add(ob._IDCommonPair);
                IDCommonPair.Add(h, tmp);

                h++;

            }

            //
            WriteFile WF = new WriteFile(IDCommonPair, _PairType, _PairName, _TeacherName, _Location, _Podgroup);




            Navigation.PushAsync(new IndexPage(faculty, batick.Text));
            //Navigation.PushModalAsync(new IndexPage(faculty, batick.Text));
        };

        //void OnEntryCompleted(object sender, EventArgs e)
        //{
        //    string text = ((Entry)sender).Text;
        //}
        Content = scrol;
    }
}