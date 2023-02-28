<<<<<<< HEAD
﻿

=======



using CsvHelper.Configuration.Attributes;
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
using Microsoft.Maui.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Schedule_app_3;

public partial class MainPage : ContentPage
{
    //int count = 0;
<<<<<<< HEAD
=======
    //void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    //{
    //    StackLayout st = (StackLayout)sender;
    //    double x = Content.TranslationX;
    //        switch (e.StatusType)
    //        {
    //            case GestureStatus.Running:
    //                // Translate and ensure we don't pan beyond the wrapped user interface element bounds.
    //                Content.TranslationX = Math.Max(Math.Min(0, x + e.TotalX), -Math.Abs(Content.Width - DeviceDisplay.MainDisplayInfo.Width));
    //                //Content.TranslationY = Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs(Content.Height - DeviceDisplay.MainDisplayInfo.Height));
    //                break;

    //            case GestureStatus.Completed:
    //                // Store the translation applied during the pan
    //                x = Content.TranslationX;
    //                // y = Content.TranslationY;
    //                break;
    //        }
        
    //}
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
    public MainPage()
    {
        
        InitializeComponent();
        Label labelt = new Label()
        {
            Text = "Выберите тип расписания",
            FontSize = 30,
        };
        Button firstbt = new Button()
        {
           
            Text = "Студент",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(0, 200, 255),
            Margin = new Thickness(0, 0, 0, 0),
            HeightRequest = 50,
            WidthRequest = 150,
<<<<<<< HEAD
        };
        Button secondbt = new Button()
        {
            Text = "Препод",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(0, 200, 255),
            Margin = new Thickness(0, 10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 150,
            
        };
        Button tbbt = new Button()
        {
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgb(255,0,0),
        };
        Button tbbt2 = new Button()
        {
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgb(0, 255, 0),
        };
        Button tbbt3 = new Button()
        {
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgb(0, 0, 255),
        };
        FlyoutItem ft = new FlyoutItem
        {
            Title = "cats",
        };

        ImageButton bttitle = new ImageButton
        {
            Source = "settings.png",
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.End,
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgba(0, 0, 0, 1),
            IsOpaque = false,
            Aspect = Aspect.Fill
        };
        bttitle.Released += async (a, e) =>
        {
            bttitle.BackgroundColor = Color.FromRgba(0, 255, 255, 255);
        };
        
=======
        };
        
        Button secondbt = new Button()
        {
            //StyleClass = "test",
            Text = "Препод",
            BorderWidth = 1,
            BorderColor = Color.FromRgb(0, 0, 0),
            //TextColor = Color.FromRgb(0, 0, 0),
            Background = Color.FromRgb(0, 200, 255),
            Margin = new Thickness(0, 10, 0, 0),
            HeightRequest = 50,
            WidthRequest = 150,
            
        };
        Button tbbt = new Button()
        {
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgb(255,0,0),
        };
        Button tbbt2 = new Button()
        {
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgb(0, 255, 0),
        };
        Button tbbt3 = new Button()
        {
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgb(0, 0, 255),
        };
        FlyoutItem ft = new FlyoutItem
        {
            Title = "cats",
        };

        ImageButton bttitle = new ImageButton
        {

            Source = "settings.png",
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.End,
            WidthRequest = 50,
            HeightRequest = 50,
            BackgroundColor = Color.FromRgba(0, 0, 0, 1),
            IsOpaque = false,
            Aspect = Aspect.Fill
        };
        bttitle.Released += async (a, e) =>
        {
            bttitle.BackgroundColor = Color.FromRgba(0, 255, 255, 255);
        };

        
        PanGestureRecognizer panGesture = new PanGestureRecognizer();
      
        
        //ToolTipProperties.SetText(button, "Click to Save your data");
        
        //panGesture.PanUpdated += OnPanUpdated;
        
      
        StackLayout newstack = new StackLayout()
		{

            GestureRecognizers = { panGesture },
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Children =
            {   labelt,
                firstbt,
                secondbt,
                bttitle
            }
        };
        
        firstbt.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new FactPage());
            //await Navigation.PushModalAsync(new FactPage());
        }; 
        
        
            
        
        secondbt.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new TestPage());
            //await Navigation.PushModalAsync(new FactPage());
        };
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4

        //ToolTipProperties.SetText(button, "Click to Save your data");

<<<<<<< HEAD
        StackLayout newstack = new StackLayout()
		{
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Children =
            {   labelt,
                firstbt,
                secondbt,
                bttitle
            }
        };
        
        firstbt.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new FactPage());
            //await Navigation.PushModalAsync(new FactPage());
        }; 
        
        
            
        
        secondbt.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new TestPage());
            //await Navigation.PushModalAsync(new FactPage());
        };
        Content = newstack;
        
=======
        Label lref = new Label() { 
            Text = "Ошибка! Отсутствует интернет соединение!",
            FontSize = 30,
        };
        Button btref = new Button() {
            Text = "Обновить",
            WidthRequest = 300,
            CornerRadius = 50,
        };

        btref.Clicked += async (sender, args) =>
        {
            await Navigation.PushAsync(new FactPage());
            //await Navigation.PushModalAsync(new FactPage());
        };


        StackLayout stackrefresh = new StackLayout() {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Children = {lref, btref}

        };

        Content = stackrefresh;
        //WebView webView = new WebView();
        //webView.Source = "index.html";
        //Content = webView;
>>>>>>> 1ac3029d253b2fe0d2456bc698d36359048c87a4
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

