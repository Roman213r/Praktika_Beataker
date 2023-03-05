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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursova_Babinets_KN_21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            Window1 form2 = new Window1();
            form2.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            Window3 form2 = new Window3();
            form2.Show();



        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            Window2 form2 = new Window2();
            form2.Show();
        }
    }
}
