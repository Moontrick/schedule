<<<<<<< HEAD
ï»¿


=======
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
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
<<<<<<< HEAD
	{
=======
    {
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
        Shadow sh = new Shadow()
        {
            Brush = Color.FromRgb(0, 0, 0),
            Radius = 20,
            Opacity = 0.5f,
            Offset = new Point(0, 5),
        };
<<<<<<< HEAD
        
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
        InitializeComponent();
        ParserGroup _parserGroup = new ParserGroup(faculty);
        foreach (var num in _parserGroup.GroupList)
        {
            AllGroup.Add(num);
        }
<<<<<<< HEAD
        Entry entry = new Entry { Placeholder = "Ð’Ð²ÐµÐ´Ð¸Ñ‚Ðµ Ð½Ð¾Ð¼ÐµÑ€ Ð³Ñ€ÑƒÐ¿Ð¿Ñ‹...",
=======
        Entry entry = new Entry
        {
            Placeholder = "Ââåäèòå íîìåð ãðóïïû...",
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            FontFamily = "Comic Sans MS",
            WidthRequest = 200,
            HeightRequest = 40,
            Background = Color.FromHex("#9B92D6"),
            FontSize = 15,
<<<<<<< HEAD
           
            
=======


>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            TextColor = Color.FromRgb(0, 0, 0),
        };
        Border br = new Border()
        {
            StrokeThickness = 1,
            Shadow = sh,
<<<<<<< HEAD
            Padding = new Thickness(3,0,0,0),
=======
            Padding = new Thickness(3, 0, 0, 0),
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            Background = Color.FromHex("#9B92D6"),
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(40)
            },
            Margin = new Thickness(0, 0, 0, 50),
            Content = entry
        };
        //entry.Completed += OnEntryCompleted;
        StackLayout stackmain = new StackLayout()
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
<<<<<<< HEAD
            
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            Children =
            {
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
<<<<<<< HEAD
             bt = new Button()
=======
            bt = new Button()
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            {
                Shadow = sh,
                TextColor = Color.FromRgb(0, 0, 0),
                Background = Color.FromHex("D9D9D9"),
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
        Background = Color.FromHex("#512cd4");
        stackend.Children.Add(stackbut1);
        stacklast.Children.Add(stackmain);
<<<<<<< HEAD
         stacklast.Children.Add(stackend);
=======
        stacklast.Children.Add(stackend);
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
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
            BorderColor = Color.FromHex("#512cd4"),
            Background = myHorizontalGradient12,
            Content = stacklast,
<<<<<<< HEAD
            
        };
        ScrollView scrol = new ScrollView()
        {
            
            //Background = myHorizontalGradient,
            Content = frame,
        };
      
        
=======

        };
        ScrollView scrol = new ScrollView()
        {

            //Background = myHorizontalGradient,
            Content = frame,
        };


>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
        entry.TextChanged += async (sender, args) =>
        {
            string oldText = args.OldTextValue;
            string newText = args.NewTextValue;
            string myText = entry.Text;
            stackend.Clear();
<<<<<<< HEAD
           
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
            StackLayout stackbut = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
<<<<<<< HEAD
                
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
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
                                Background = Color.FromHex("D9D9D9"),

                            };
                            bt.Clicked += onclik;
                            stackbut.Add(bt);
                        }
                    }
                }
            }
<<<<<<< HEAD
    
            stackend.Children.Add(stackbut);
           
        };
         
=======

            stackend.Children.Add(stackbut);

        };

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4

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
<<<<<<< HEAD
            
=======

>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
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