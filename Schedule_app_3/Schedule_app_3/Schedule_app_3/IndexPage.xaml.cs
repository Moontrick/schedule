using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Graphics.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Schedule_app_3;

public partial class IndexPage : ContentPage
{
	public IndexPage()
	{
        Dictionary<int, List<Dictionary<int, int>>> IDCommonPair = new Dictionary<int, List<Dictionary<int, int>>>();
        List<string> _PairType = new List<string>();
        List<string> _PairName = new List<string>();
        List<string> _TeacherName = new List<string>();
        List<string> _Location = new List<string>();

        InitializeComponent();

        #region Storage
        var path = FileSystem.Current.AppDataDirectory;
        var fullPath = Path.Combine(path, "Shedule.txt");

        if (!File.Exists(fullPath))
        {

            File.Create(fullPath);
            WriteFromParser();
        }
        else
        {
            var fi = new FileInfo(fullPath);
            if (fi.Length == 0)
                WriteFromParser();

        }

        //ReadFile readFile = new ReadFile(fullPath);

        #endregion

        void WriteFromParser()
        {
            int h = 1;

            for (int i = 0; i < 6; i++)
            {
                Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

                Parser ob = new Parser(h);

                _PairType.AddRange(ob.PairType);
                _PairName.AddRange(ob.PairName);
                _TeacherName.AddRange(ob.TeacherName);
                _Location.AddRange(ob.Location);
                var tmp = new List<Dictionary<int, int>>();
                tmp.Add(ob._IDCommonPair);
                IDCommonPair.Add(h, tmp);

                h++;

            }
        }
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
            Text = "ПН",
            BorderWidth = 1,
            TextColor = Color.FromRgb(0, 0, 0),
            BorderColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(5, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btvt = new Button()
        {
            Text = "ВТ",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(60, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btsr = new Button()
        {
            Text = "СР",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(115, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btch = new Button()
        {
            Text = "ЧТ",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(170, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btpt = new Button()
        {
            Text = "ПТ",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(225, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btsb = new Button()
        {
            Text = "СБ",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(280, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start
        };
        Button btvs = new Button()
        {
            Text = "ВС",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(255, 255, 255),
            Margin = new Thickness(335, -10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 50,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Start,
            VerticalOptions = LayoutOptions.Start,
        };
        //__________________________________________________________________________________________     

        //________________________________________Таблица дней недели__________________________________________________
        Grid gridButton = new Grid
        {

            VerticalOptions = LayoutOptions.Start,
            Margin = new Thickness(0, 0, 0, 0),
            Children =
            {
                new StackLayout {

                    Children ={
                        new Label
                            {

                                Text = "ПН",
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
                                TextColor = Color.FromRgb(0,0,0),
                                Background = Color.FromRgb(255,255,255),
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
        Frame framtitle = new Frame
        {
            Content = titleLabel,
            Padding = new Thickness(10, 10, 10, 10),
            Margin = new Thickness(0, 0, 0, 0),
            BackgroundColor = Color.FromHex("#0084ff"),
            CornerRadius = 0
        };
        StackLayout steckprom = new StackLayout
        {
            Children = {
                framtitle,
                gridButton,
                weekLabel
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
                        // new Label
                        //{
                        //    TextColor = Color.FromHex("#828181"),
                        //     FontSize = 16,
                        //    Text = "1под",
                        //    HorizontalOptions = LayoutOptions.End,
                        //     VerticalOptions = LayoutOptions.Center
                        //},
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
                            Text = "8:20 - 9:50",
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
                        BackgroundColor = Color.FromHex("#f9f9f9"),
                        CornerRadius = 5,
                    };
                    stackMain.Children.Add(fr);
                    number_of_pairs++;
                }
            }
            return stackMain;
        }
        frameend = new StackLayout
        {
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
        btpn.Clicked += async (sender, args) =>
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#5cb0ff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
            stackMain = make_curremt_day(1, 0);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);

        };
        btvt.Clicked += async (sender, args) =>
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#5cb0ff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
            int n = 0;
            for (int i = 0; i < 1; i++)
            {
                var current_days = IDCommonPair[i + 1];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            stackMain = make_curremt_day(2, n);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);
        };
        btsr.Clicked += async (sender, args) =>
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#5cb0ff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
            int n = 0;
            for (int i = 0; i < 2; i++)
            {
                var current_days = IDCommonPair[i + 1];
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
        btch.Clicked += async (sender, args) =>
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#5cb0ff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
            int n = 0;
            for (int i = 0; i < 3; i++)
            {
                var current_days = IDCommonPair[i + 1];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            stackMain = make_curremt_day(4, n);
        };
        btpt.Clicked += async (sender, args) =>
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#5cb0ff");
            btsb.Background = Color.FromHex("#ffffff");
            int n = 0;
            for (int i = 0; i < 4; i++)
            {
                var current_days = IDCommonPair[i + 1];
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
        btsb.Clicked += async (sender, args) =>
        {
            StackLayout stackMain = new StackLayout();
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#5cb0ff");
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                var current_days = IDCommonPair[i + 1];
                for (int j = 0; j < current_days[0].Count; j++)
                {
                    n = n + current_days[0][j];

                }
            }
            stackMain = make_curremt_day(6, n);
            frameend.Children.Clear();
            frameend.Children.Add(steckprom);
            frameend.Children.Add(stackMain);
        };
        btvs.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#5cb0ff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
            //await Navigation.PushAsync(new IndexPage());
        };

        Content = scrol;


    }
}