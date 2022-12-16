using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Graphics.Text;
using SheduleFile;
using static System.Net.Mime.MediaTypeNames;

namespace Schedule_app_3;

public partial class IndexPage : ContentPage
{
    int count = 0;
    int[] weekDate = new int[7];
    Dictionary<int, List<Dictionary<int, int>>> IDCommonPair = new Dictionary<int, List<Dictionary<int, int>>>();
    List<string> _PairType = new List<string>();
    List<string> _PairName = new List<string>();
    List<string> _TeacherName = new List<string>();
    List<string> _Location = new List<string>();
    List<string> _TimePair = new List<string>();
    List<string> _Podgroup = new List<string>();
    int curDate = 0;
    protected override bool OnBackButtonPressed()
    {
        return true;
    }
    public IndexPage(string str1, string str2)
    {



        _TimePair.Add("8:20 - 9:50");
        _TimePair.Add("10:00 - 11:35");
        _TimePair.Add("12:05 - 13:40");
        _TimePair.Add("13:50 - 15:25");
        _TimePair.Add("15:35 - 17:10");
        _TimePair.Add("17:20 - 18:40");
        _TimePair.Add("18:45 - 20:05");
        _TimePair.Add("20:10 - 21:30");
        InitializeComponent();
        GetAllDates();

        #region Storage
        var path = FileSystem.Current.AppDataDirectory;
        var fullPath = Path.Combine(path, "Shedule.txt");
        //FileSystem.OpenAppPackageFileAsync(fullPath);

        //using (var reader = FileSystem.OpenAppPackageFileAsync("Shedule.txt").Result)
        //{
        //    using (StreamReader streamReader = new StreamReader(reader))
        //    {

        //        while (!streamReader.EndOfStream)
        //        {
                    

        //        }

        //    }
        //}

        var fi = new FileInfo(fullPath);
           

        

        ReadFile readFile = new ReadFile(fullPath);
        IDCommonPair = readFile._IDCommonPair;
        _PairType = readFile.PairType;
        _PairName = readFile.PairName;
        _TeacherName = readFile.TeacherName;
        _Location = readFile.Location;
        _Podgroup = readFile.Podgroup;
        void GetAllDates()
        {
            for (int i = 0; i < weekDate.Length; i++) { weekDate[i] = 0; }
            DateTime currentDay = DateTime.Now;
            DayOfWeek dayOfWeek = currentDay.DayOfWeek;

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday: curDate = 0; break;
                case DayOfWeek.Tuesday: curDate = 1; break;
                case DayOfWeek.Wednesday: curDate = 2; break;
                case DayOfWeek.Thursday: curDate = 3; break;
                case DayOfWeek.Friday: curDate = 4; break;
                case DayOfWeek.Saturday: curDate = 5; break;
                case DayOfWeek.Sunday: curDate = 6; break;
                default: break;
            }

            for (int i = 0; i < weekDate.Length; i++)
            {

                weekDate[i] = (currentDay.Add(new TimeSpan(i - curDate, 0, 0, 0))).Day;
            }


        }
        #endregion

        //void WriteFromParser()
        //{
        //    int h = 1;

        //    for (int i = 0; i < 6; i++)
        //    {
        //        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        //        string faculty = "knt";

        //        string group = "311";
        //        Parser ob = new Parser(h, str1, str2);

        //        _PairType.AddRange(ob.PairType);
        //        _PairName.AddRange(ob.PairName);
        //        _TeacherName.AddRange(ob.TeacherName);
        //        _Location.AddRange(ob.Location);
        //        _Podgroup.AddRange(ob.Podgroup);
        //        var tmp = new List<Dictionary<int, int>>();
        //        tmp.Add(ob._IDCommonPair);
        //        IDCommonPair.Add(h, tmp);

        //        h++;

        //    }
        //}
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
        //________________________________________Кнопки дней недели__________________________________________________
        Button btpn = new Button()
        {
            Text = Convert.ToString(weekDate[0]),
            BorderWidth = 1,
            TextColor = Color.FromRgb(0, 0, 0),
            BorderColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#512cd4"),
            Margin = new Thickness(5, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btvt = new Button()
        {
            Text = Convert.ToString(weekDate[1]),
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#512cd4"),
            Margin = new Thickness(60, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btsr = new Button()
        {
            Text = Convert.ToString(weekDate[2]),
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#D9D9D9"),
            Margin = new Thickness(115, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btch = new Button()
        {
            Text = Convert.ToString(weekDate[3]),
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#512cd4"),
            Margin = new Thickness(170, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btpt = new Button()
        {
            Text = Convert.ToString(weekDate[4]),
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#512cd4"),
            Margin = new Thickness(225, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btsb = new Button()
        {
            Text = Convert.ToString(weekDate[5]),
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#512cd4"),
            Margin = new Thickness(280, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btvs = new Button()
        {
            Text = Convert.ToString(weekDate[6]),
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromHex("#512cd4"),
            Margin = new Thickness(335, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
        };
        //__________________________________________________________________________________________     
        LinearGradientBrush myHorizontalGradient12 = new LinearGradientBrush();
        myHorizontalGradient12.StartPoint = new Point(0.3, 0);
        myHorizontalGradient12.EndPoint = new Point(0.3, 1);
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#512cd4"), 0.4f));
        myHorizontalGradient12.GradientStops.Add(new GradientStop(Color.FromHex("#C38BF9"), 1.0f));
        //________________________________________Таблица дней недели__________________________________________________

        Grid gridButton = new Grid
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start,
            Margin = new Thickness(0, 0, 0, 0),
            Children =
            {
                new StackLayout {

                    Children ={
                        new Label
                            {
                            Background = Color.FromHex("#512cd4"),
                                Text = "ПН",
                                TextColor = Color.FromRgb(255,255,255),

                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(17, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                       btpn
                    }
                },
                new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "ВТ",
                                TextColor = Color.FromRgb(255,255,255),
                                Background = Color.FromHex("#512cd4"),
                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(75, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                      btvt
                    }
                },
                     new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "СР",
                                TextColor = Color.FromRgb(255,255,255),
                               Background = Color.FromHex("#512cd4"),
                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(131, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                    btsr
                    }
                },
                new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "ЧТ",
                                TextColor = Color.FromRgb(255,255,255),
                                Background = Color.FromHex("#512cd4"),
                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(185, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                      btch
                    }
                },
                 new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "ПТ",
                                TextColor = Color.FromRgb(255,255,255),
                                Background = Color.FromHex("#512cd4"),
                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(240, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                      btpt
                    }
                },
                   new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "СБ",
                                TextColor = Color.FromRgb(255,255,255),
                                Background = Color.FromHex("#512cd4"),
                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(295, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                     btsb
                    }
                },
               new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "ВС",
                                TextColor = Color.FromRgb(255,255,255),
                               Background = Color.FromHex("#512cd4"),
                                Padding = new Thickness(0, 17, 0, 0),
                                Margin = new Thickness(352, 0, 0, 0),
                                HeightRequest = 50,
                                WidthRequest = 50,
                                HorizontalOptions = LayoutOptions.Start,
                                VerticalOptions = LayoutOptions.Start
                            },
                    btvs
                    }
                },
            }
        };
        StackLayout frameend = new StackLayout();
        Background = Color.FromHex("#512cd4");
        //__________________________________________________________________________________________
        //__________________________________________________________________________________________
        Label weekLabel = new Label
        {
            Text = "День недели",
            Margin = new Thickness(0, 10, 0, 10),
            FontSize = 22,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        Label titleLabel = new Label()
        {
            Text = "Расписание",
            FontSize = 30,
            TextColor = Color.FromRgb(0, 0, 0),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Start
        };

        ImageButton bttitle = new ImageButton
        {
            Source = "settings.png",
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.End,
            WidthRequest = 30,
            HeightRequest = 30,
            BackgroundColor = Color.FromRgba(0, 0, 0, 1),
            IsOpaque = false,
            Aspect = Aspect.Fill
        };
        bttitle.Clicked += async (a, e) =>
        {
            await Navigation.PushAsync(new SettingsPage());
        };

        Grid flexLayout = new Grid()
        {

            VerticalOptions = LayoutOptions.Start,

            Children =
            {
                titleLabel,
                bttitle
            }
        };
        Frame framtitle = new Frame
        {
            Content = flexLayout,
            Padding = new Thickness(10, 10, 10, 10),
            Margin = new Thickness(0, 0, 0, 0),
            BackgroundColor = Color.FromHex("#512cd4"),
            BorderColor = Color.FromHex("#512cd4"),
            CornerRadius = 0
        };
        StackLayout steckprom = new StackLayout
        {
            Children = {
                framtitle,
                gridButton,
                //weekLabel,
                
            }
        };

        //________________________________________Создание блока кнопок дней недели__________________________________________________
        Frame frameButton = new Frame
        {
            Content = steckprom,
            HeightRequest = 100,
        };





        //________________________________________Создание стэка расписания__________________________________________________
        StackLayout make_curremt_day(int cur_day, int n)
        {
            StackLayout stackMain = new StackLayout();
            var current_days = IDCommonPair[cur_day];
            int number_of_pairs = n;
            bool flagick = true;
            for (int i = 0; i < current_days[0].Count; i++)
            {

                for (int j = 0; j < current_days[0][i]; j++)
                {
                    Label number_p = new Label();
                    if (j == 0)
                    {
                        number_p = new Label
                        {
                            TextColor = Color.FromHex("#828181"),
                            FontSize = 16,
                            Text = System.Convert.ToString(i + 1),
                            HorizontalOptions = LayoutOptions.Start,
                            VerticalOptions = LayoutOptions.Center
                        };
                    }
                    else
                    {
                        number_p = new Label
                        {
                            TextColor = Color.FromHex("#828181"),
                            FontSize = 16,
                            Text = System.Convert.ToString(i + 1) + '.' + System.Convert.ToString(j),
                            HorizontalOptions = LayoutOptions.Start,
                            VerticalOptions = LayoutOptions.Center
                        };
                    }

                    StackLayout st = new StackLayout();
                    Grid fr1 = new Grid
                    {
                        Padding = new Thickness(0, 0, 0, 0),
                        Children =
                        {
                            number_p,
                             new Label
                            {
                                 Margin = new Thickness(10, 0, 0, 0),
                                TextColor = Color.FromHex("#828181"),
                                 FontSize = 16,
                                Text = _PairType[number_of_pairs],
                                Padding = new Thickness (20,0,0,0),
                                 HorizontalOptions = LayoutOptions.Start,
                                 VerticalOptions = LayoutOptions.Center
                            },
                             new Label
                            {
                                TextColor = Color.FromHex("#828181"),
                                 FontSize = 16,
                                Text = _Podgroup[number_of_pairs],
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
                        Padding = new Thickness(0, 5, 0, 0),
                        Text = _PairName[number_of_pairs],
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Center,
                    };
                    st.Children.Add(l1);
                    Label l2 = new Label
                    {
                        TextColor = Color.FromHex("#828181"),
                        FontSize = 16,
                        Padding = new Thickness(0, 5, 0, 0),
                        Text = _TeacherName[number_of_pairs],
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
                            Text = _Location[number_of_pairs],
                             HorizontalOptions = LayoutOptions.Start,
                             VerticalOptions = LayoutOptions.Center,

                        },
                         new Label
                        {
                            TextColor = Color.FromHex("#828181"),
                            FontSize = 16,
                            Text = _TimePair[i],
                            HorizontalOptions = LayoutOptions.End,
                            VerticalOptions = LayoutOptions.Center
                        },
                   }

                    };
                    st.Children.Add(fr2);

                    //___________________________________________________________________________________

                    Frame fr = new Frame
                    {
                        Content = st,
                        Margin = new Thickness(5, 10, 5, 5),
                        BackgroundColor = Color.FromHex("#D9D9D9"),
                        CornerRadius = 5,
                    };
                    stackMain.Children.Add(fr);
                    number_of_pairs++;
                    flagick = false;
                }
                //if ((current_days[0][i] == 0) && flagick)
                //{

                //        Label number_p = new Label();

                //        number_p = new Label
                //        {
                //            TextColor = Color.FromHex("#828181"),
                //            FontSize = 16,
                //            Text = System.Convert.ToString(i + 1),
                //            HorizontalOptions = LayoutOptions.Start,
                //            VerticalOptions = LayoutOptions.Center
                //        };


                //        StackLayout st = new StackLayout();
                //        st.Children.Add(number_p);

                //        Label l1 = new Label
                //        {
                //            FontSize = 17,
                //            FontFamily = "Comic Sans MS",
                //            TextColor = Color.FromRgb(0, 0, 0),
                //            Padding = new Thickness(0, 5, 0, 0),
                //            Text = "Поздравляю, вам сегодня не к первой паре!",
                //            HorizontalOptions = LayoutOptions.Center,
                //            VerticalOptions = LayoutOptions.Center,
                //        };
                //        st.Children.Add(l1);





                //        //___________________________________________________________________________________

                //        Frame fr = new Frame
                //        {
                //            Content = st,
                //            Margin = new Thickness(5, 10, 5, 5),
                //            BackgroundColor = Color.FromHex("#D9D9D9"),
                //            CornerRadius = 5,
                //        };
                //        stackMain.Children.Add(fr);
                //        number_of_pairs++;
                //    }
            }

            return stackMain;

        }

        //__________________________
        StackLayout make_vs_day()
        {



            Label lbvs = new Label()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 30,
                Text = "Выходной!",

            };
            StackLayout stst = new StackLayout()
            {
                Children = { lbvs }
            };

            //*[@id="2_3"]/div/div[5]
            //*[@id="2_3"]/div/div[5]/a[1]
            StackLayout stackMain = new StackLayout();

            Frame fr = new Frame
            {
                Content = stst,
                Margin = new Thickness(5, 10, 5, 5),
                BackgroundColor = Color.FromHex("#D9D9D9"),
                CornerRadius = 5,
            };
            stackMain.Children.Add(fr);



            return stackMain;
        }
        //__________________________
        frameend = new StackLayout
        {

            Background = myHorizontalGradient12,
            Children =
            {
                steckprom,

            }

        };
        ScrollView scrol = new ScrollView
        {
            Content = frameend
        };

        //________________________________________Функции кнопок дней недели__________________________________________________
        btpn.Clicked += Monday;
        btvt.Clicked += Tuesday;
        btsr.Clicked += Wednesday;
        btch.Clicked += Thursday;
        btpt.Clicked += Friday;
        btsb.Clicked += Saturday;
        btvs.Clicked += Sunday;
        void Monday(object sender, EventArgs args)
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#D9D9D9");
            btpn.Background = Color.FromHex("#C38BF9");
            btvt.Background = Color.FromHex("#D9D9D9");
            btsr.Background = Color.FromHex("#D9D9D9");
            btch.Background = Color.FromHex("#D9D9D9");
            btpt.Background = Color.FromHex("#D9D9D9");
            btsb.Background = Color.FromHex("#D9D9D9");
            stackMain = make_curremt_day(0, 0);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);

        };
        void Tuesday(object sender, EventArgs args)
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#D9D9D9");
            btpn.Background = Color.FromHex("#D9D9D9");
            btvt.Background = Color.FromHex("#C38BF9");
            btsr.Background = Color.FromHex("#D9D9D9");
            btch.Background = Color.FromHex("#D9D9D9");
            btpt.Background = Color.FromHex("#D9D9D9");
            btsb.Background = Color.FromHex("#D9D9D9");
            int n = 0;
            for (int i = 0; i < 1; i++)
            {
                var current_days = IDCommonPair[i];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            stackMain = make_curremt_day(1, n);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);
        };
        void Wednesday(object sender, EventArgs args)
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#D9D9D9");
            btpn.Background = Color.FromHex("#D9D9D9");
            btvt.Background = Color.FromHex("#D9D9D9");
            btsr.Background = Color.FromHex("#C38BF9");
            btch.Background = Color.FromHex("#D9D9D9");
            btpt.Background = Color.FromHex("#D9D9D9");
            btsb.Background = Color.FromHex("#D9D9D9");
            int n = 0;
            for (int i = 0; i < 2; i++)
            {
                var current_days = IDCommonPair[i];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            stackMain = make_curremt_day(2, n);

            frameend.Children.Add(stackMain);
        };
        void Thursday(object sender, EventArgs args)
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#D9D9D9");
            btpn.Background = Color.FromHex("#D9D9D9");
            btvt.Background = Color.FromHex("#D9D9D9");
            btsr.Background = Color.FromHex("#D9D9D9");
            btch.Background = Color.FromHex("#C38BF9");
            btpt.Background = Color.FromHex("#D9D9D9");
            btsb.Background = Color.FromHex("#D9D9D9");
            int n = 0;
            for (int i = 0; i < 3; i++)
            {
                var current_days = IDCommonPair[i];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            stackMain = make_curremt_day(3, n);

            frameend.Children.Add(stackMain);
        };
        void Friday(object sender, EventArgs args)
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#D9D9D9");
            btpn.Background = Color.FromHex("#D9D9D9");
            btvt.Background = Color.FromHex("#D9D9D9");
            btsr.Background = Color.FromHex("#D9D9D9");
            btch.Background = Color.FromHex("#D9D9D9");
            btpt.Background = Color.FromHex("#C38BF9");
            btsb.Background = Color.FromHex("#D9D9D9");
            int n = 0;
            for (int i = 0; i < 4; i++)
            {
                var current_days = IDCommonPair[i];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            stackMain = make_curremt_day(4, n);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);
        };
        void Saturday(object sender, EventArgs args)
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#D9D9D9");
            btpn.Background = Color.FromHex("#D9D9D9");
            btvt.Background = Color.FromHex("#D9D9D9");
            btsr.Background = Color.FromHex("#D9D9D9");
            btch.Background = Color.FromHex("#D9D9D9");
            btpt.Background = Color.FromHex("#D9D9D9");
            btsb.Background = Color.FromHex("#C38BF9");
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                var current_days = IDCommonPair[i];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            stackMain = make_curremt_day(5, n);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);
        };
        void Sunday(object sender, EventArgs args)
        {
            btvs.Background = Color.FromHex("#C38BF9");
            btpn.Background = Color.FromHex("#D9D9D9");
            btvt.Background = Color.FromHex("#D9D9D9");
            btsr.Background = Color.FromHex("#D9D9D9");
            btch.Background = Color.FromHex("#D9D9D9");
            btpt.Background = Color.FromHex("#D9D9D9");
            btsb.Background = Color.FromHex("#D9D9D9");
            StackLayout stackMain = new StackLayout();
            stackMain = make_vs_day();
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);

        };

        Content = scrol;
        EventArgs args321;
        switch (curDate)
        {
            case 0: Monday(btpn, EventArgs.Empty); break;
            case 1: Tuesday(btvt, EventArgs.Empty); break;
            case 2: Wednesday(btsr, EventArgs.Empty); break;
            case 3: Thursday(btch, EventArgs.Empty); break;
            case 4: Friday(btpt, EventArgs.Empty); break;
            case 5: Saturday(btsb, EventArgs.Empty); break;
            case 6: Sunday(btvs, EventArgs.Empty); break;
            default: break;
        }
    }
}
