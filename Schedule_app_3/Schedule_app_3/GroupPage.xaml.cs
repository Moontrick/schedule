


using System.Windows.Input;

namespace Schedule_app_3;

public partial class GroupPage : ContentPage
{
    List<string> l = new List<string>();
    public GroupPage()
	{
		InitializeComponent();
        l.Add("311");
        l.Add("351");
        l.Add("341");
        l.Add("321");
        l.Add("211");
        l.Add("251");
        l.Add("241");
        l.Add("221");
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
        for (int i = 0; i < l.Count(); i++)
        {
             bt = new Button()
            {
                Text = l[i],
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
            for (int i = 0; i < l.Count(); i++)
            {
                string str = l[i];
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
                            Text = l[i],
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
            
             Navigation.PushModalAsync(new IndexPage());
        };

        //void OnEntryCompleted(object sender, EventArgs e)
        //{
        //    string text = ((Entry)sender).Text;
        //}
        Content = scrol;
    }
}