using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TomaszFirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool isX = true;
        string[,] states = new string[3,3];
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string player;
            if(isX)
            {
                player = "X";
                isX = false;
            }
            else
            {
                player = "O";
                isX = true;
            }
            button.Content = "X";
            button.IsEnabled = false;

            switch(button.Name)
            {
                case "button_0_0":
                    states[0,0] = ;
                    break;


            }


            checkIsOver();
        }

        private void checkIsOver()
        {


        }

    }
}
