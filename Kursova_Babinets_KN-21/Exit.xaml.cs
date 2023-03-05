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
using System.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursova_Babinets_KN_21
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();

            Application.Current.Shutdown();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            this.Close();
        }
    }
}
