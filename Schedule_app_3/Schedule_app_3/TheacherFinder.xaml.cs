using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using System.Runtime.CompilerServices;

namespace Schedule_app_3;

public partial class TheacherFinder : ContentPage
{
    List<string> _Name = new List<string>();
    List<string> _SurName = new List<string>();
    List<string> _Otchestvo = new List<string>();
    List<string> _Id = new List<string>();


    public TheacherFinder()
    {
        InitializeComponent();
        Shadow sh = new Shadow()
        {
            Brush = Color.FromRgb(0, 0, 0),
            Radius = 20,
            Opacity = 0.5f,
            Offset = new Point(0, 5),
        };
        //ParserGroup TeacherList = new ParserGroup(faculty);
        Dictionary<string, string> dic = new Dictionary<string, string>();
        //var path = FileSystem.Current.AppDataDirectory;
        //var fullPath = Path.Combine(path, "ScheduleTeachers.csv");
        string fullPath = "ScheduleTeachers.csv";

        //var stream = FileSystem.OpenAppPackageFileAsync(fullPath).Result;

        //var reader = new StreamReader(stream);

        //var contents = reader.ReadToEnd();

        //var fileName = "mybundledfile.txt";

        var CsvList = new Csv(fullPath);
        _Name = CsvList.Name;
        _SurName = CsvList.SurName;
        _Otchestvo = CsvList.Otchestvo;
        _Id = CsvList.Id;

        List<string> FullName = new List<string>();

        for (int i = 0; i < _Name.Count; i++)
        {
            FullName.Add(_SurName[i] + " " + _Name[i] + " " + _Otchestvo[i]);
            dic.Add(FullName[i], _Id[i]);
        }

        Entry entry = new Entry
        {
            Placeholder = "¬ведите фамиллию преподвател€...",
            FontFamily = "Comic Sans MS",
            WidthRequest = 300,
            HeightRequest = 40,
            Background = Color.FromHex("#9B92D6"),
            FontSize = 15,


            TextColor = Color.FromRgb(0, 0, 0),
        };

        Border br = new Border()
        {
            StrokeThickness = 1,
            Shadow = sh,
            Padding = new Thickness(3, 0, 0, 0),
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
            WidthRequest = 300,
            HeightRequest = 50,
        };
        for (int i = 0; i < _Name.Count(); i++)
        {
            bt = new Button()
            {
                Text = FullName[i],
                Shadow = sh,
                TextColor = Color.FromRgb(0, 0, 0),
                Background = Color.FromHex("D9D9D9"),
                FontSize = 13,
                WidthRequest = 300,
                HeightRequest = 50,
                Margin = new Thickness(0, 5, 0, 0),
            };
            bt.Clicked += onclik;
            stackbut1.Add(bt);
        }
        LinearGradientBrush myHorizontalGradient12 = new LinearGradientBrush();
        myHorizontalGradient12.StartPoint = new Point(0.3, 0);
        myHorizontalGradient12.EndPoint = new Point(0.3, 1);
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#512cd4"), 0.4f));
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#C38BF9"), 1.0f));
        StackLayout stacklast = new StackLayout()
        {
            //Background = myHorizontalGradient,
        }; ;
        StackLayout stackend = new StackLayout();
        Background = Color.FromHex("#512cd4");
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
            BorderColor = Color.FromHex("#512cd4"),
            Background = myHorizontalGradient12,
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
            for (int i = 0; i < _Name.Count(); i++)
            {
                string str = FullName[i];
                bool flag = true;
                if (myText.Length > str.Length)
                {

                }
                else
                {
                    for (int j = 0; j < myText.Length; j++)
                    {
                        
                        if ( (!str[j].ToString().Equals( myText[j].ToString().ToLower()) 
                             && !str[j].ToString().Equals(myText[j].ToString().ToUpper()) ) )
                            
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
                            Text = FullName[i],
                            Shadow = sh,
                            TextColor = Color.FromRgb(0, 0, 0),
                            Background = Color.FromHex("D9D9D9"),
                            FontSize = 13,
                            WidthRequest = 300,
                            HeightRequest = 50,
                            Margin = new Thickness(0, 5, 0, 0),


                        };
                        bt.Clicked += onclik;
                        stackbut.Add(bt);
                    }
                }
            }

            stackend.Children.Add(stackbut);

        };


        void onclik(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            string str = btn.Text;
            Navigation.PushAsync(new IndexPage("teacher", dic[str]));
        };

        //void OnEntryCompleted(object sender, EventArgs e)
        //{
        //    string text = ((Entry)sender).Text;
        //}
        Content = scrol;


    }
}