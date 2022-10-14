using Microsoft.Maui.Controls;
using SheduleFile;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace Schedule_app_3;

public partial class MainPage : ContentPage
{
	int count = 0;
    public MainPage()
    {
       
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

        static void WriteFromParser()
        {
            Dictionary<int, List<Dictionary<int, int>>> IDCommonPair = new Dictionary<int, List<Dictionary<int, int>>>();
            List<string> _PairType = new List<string>();
            List<string> _PairName = new List<string>();
            List<string> _TeacherName = new List<string>();
            List<string> _Location = new List<string>();

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
        StackLayout stackMain = new StackLayout();
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
        //__________________________________________________________________________________________
        //________________________________________Функции кнопок дней недели__________________________________________________
        btpn.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#5cb0ff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
        };
        btvt.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#5cb0ff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
        };
        btsr.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#5cb0ff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
        };
        btch.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#5cb0ff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#ffffff");
        };
        btpt.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#5cb0ff");
            btsb.Background = Color.FromHex("#ffffff");
        };
        btsb.Clicked += async (sender, args) =>
        {
            btvs.Background = Color.FromHex("#ffffff");
            btpn.Background = Color.FromHex("#ffffff");
            btvt.Background = Color.FromHex("#ffffff");
            btsr.Background = Color.FromHex("#ffffff");
            btch.Background = Color.FromHex("#ffffff");
            btpt.Background = Color.FromHex("#ffffff");
            btsb.Background = Color.FromHex("#5cb0ff");
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
        };


        //__________________________________________________________________________________________
        Label weekLabel = new Label
        {
            Text = "День недели",
            Margin = new Thickness(0,10,0,10),
            FontSize = 22,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center
        };
        StackLayout steckprom = new StackLayout
        {
            Children = {
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
        StackLayout frameend = new StackLayout
        {
            Children =
            {
                steckprom,
                stackMain,
            }

        };
        ScrollView scrol = new ScrollView
        {
            Content = frameend
        };
        
     

        Content = scrol;


    }

	//private void OnCounterClicked(object sender, EventArgs e)
	//{
	//	count++;

	//	if (count == 1)
	//		CounterBtn.Text = $"Clicked {count} time";
	//	else
	//		CounterBtn.Text = $"Clicked {count} times";

	//	SemanticScreenReader.Announce(CounterBtn.Text);
	//}



}

