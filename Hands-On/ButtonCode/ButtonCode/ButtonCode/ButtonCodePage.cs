using System;
using Xamarin.Forms;

namespace ButtonCode
{
    class ButtonCodePage : ContentPage
    {
        int count = 0;

        public ButtonCodePage()
        {
            Button button = new Button
            {
                
            };
            button.Clicked += (sender, args) =>
            {
               
            };

            this.Content = button;
        }
    }
}
