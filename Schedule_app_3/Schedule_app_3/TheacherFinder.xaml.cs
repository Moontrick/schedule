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

        //ParserGroup TeacherList = new ParserGroup(faculty);
        Dictionary<string, string> dic = new Dictionary<string, string>();
        //var path = FileSystem.Current.AppDataDirectory;
        //var fullPath = Path.Combine(path, "ScheduleTeachers.csv");
        string fullPath = @"D:\C#\Shedule\schedule\Schedule_app_3\Schedule_app_3\ScheduleTeachers.csv";
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

        Entry entry = new Entry { Placeholder = "Enter text" };

        //entry.Completed += OnEntryCompleted;
        StackLayout stackmain = new StackLayout()
        {
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
            Children =
            {
                entry
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
        for (int i = 0; i < _Name.Count(); i++)
        {
            bt = new Button()
            {
                Text = FullName[i],
                FontSize = 15,
                WidthRequest = 100,
                HeightRequest = 50,
                Margin = new Thickness(0, 5, 0, 0),
            };
            bt.Clicked += onclik;
            stackbut1.Add(bt);
        }

        StackLayout stackend = new StackLayout();

        stackend.Children.Add(stackmain);
        stackend.Children.Add(stackbut1);
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
            Content = stackend,

        };
        ScrollView scrol = new ScrollView()
        {
            Content = frame,
        };


        entry.TextChanged += async (sender, args) =>
        {
            string oldText = args.OldTextValue;
            string newText = args.NewTextValue;
            string myText = entry.Text;
            stackend.Clear();
            stackend.Children.Add(stackmain);
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
                            Text = FullName[i],
                            FontSize = 15,
                            Margin = new Thickness(0, 3, 0, 0),
                            WidthRequest = 100,
                            HeightRequest = 50,


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
            Navigation.PushModalAsync(new IndexPage("teacher", dic[str]));
        };

        //void OnEntryCompleted(object sender, EventArgs e)
        //{
        //    string text = ((Entry)sender).Text;
        //}
        Content = scrol;


    }
}