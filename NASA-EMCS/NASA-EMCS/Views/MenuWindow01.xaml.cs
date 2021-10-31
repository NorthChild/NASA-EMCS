using NASA_EMCS_Logic.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NASA_EMCS.Views
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        private ButtonOBJ _Button;
        public MenuWindow()
        {
            InitializeComponent();
            _Button = new ButtonOBJ();
        }

        private void EngageBTN(object sender, RoutedEventArgs e)
        {
            GameWindow GameWindow02 = new GameWindow();
            GameWindow02.Show();
            this.Close();

        }

        private void AbortBTN(object sender, RoutedEventArgs e)
        {      
            this.Close();
        }
    }
}
