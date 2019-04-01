using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SQLiteXF.Pages.Home
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Home";
            Content = new StackLayout
            {
                Children =
                {
                    {
                        new Label
                        {
                            Text = "HelloWorld",
                            VerticalOptions =  LayoutOptions.Start,
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        }
                    }
                }
            };
        }
    }
}
