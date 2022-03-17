using System.Reflection;
using Xamarin.Forms;

namespace Mobile_Programming_Week_3_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Vertical;

            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.GetProperty
                | BindingFlags.Static;
            foreach (var field in typeof(Color).GetFields(bindingFlags))
            {
                var frame = new Frame
                {
                    BackgroundColor = (Color)field.GetValue(null),
                    Content = new Label
                    {
                        Text = field.ToString()
                    }
                };
                stackLayout.Children.Add(frame);
            }


            Content = stackLayout;
            InitializeComponent();
        }

    }
}