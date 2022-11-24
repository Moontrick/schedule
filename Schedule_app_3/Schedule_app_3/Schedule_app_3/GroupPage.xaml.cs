


using System.Windows.Input;

namespace Schedule_app_3;

public partial class GroupPage : ContentPage
{
    List<string> AllGroup = new List<string>();
    public GroupPage(string faculty)
	{
		InitializeComponent();
        ParserGroup _parserGroup = new ParserGroup(faculty);
        foreach (var num in _parserGroup.GroupList)
        {
            AllGroup.Add(num);
        }
        Entry entry = new Entry { Placeholder = "¬ведите номер группы" };

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
        for (int i = 0; i < AllGroup.Count(); i++)
        {
             bt = new Button()
            {
                Text = AllGroup[i],
                FontSize = 15,
                WidthRequest = 100,
                HeightRequest = 50,
                Margin = new Thickness(0, 5, 0, 0),
            };
            bt.Clicked += onclik;
            stackbut1.Add(bt);
        }

        StackLayout stackend = new StackLayout();
        StackLayout stacklast = new StackLayout();
       
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
            Content = stacklast,
            
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
            
            StackLayout stackbut = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start,
            };
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
            Button batick = (Button)sender;
             Navigation.PushModalAsync(new IndexPage(faculty, batick.Text));
        };

        //void OnEntryCompleted(object sender, EventArgs e)
        //{
        //    string text = ((Entry)sender).Text;
        //}
        Content = scrol;
    }
}