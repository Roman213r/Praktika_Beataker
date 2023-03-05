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
using Microsoft.Win32;
using System.IO;

namespace Kursova_Babinets_KN_21
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
          //  if (Russian.IsChecked == true) {  }
        }

        private void Do_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Do_Copy1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
         
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         

        }
    }
}
