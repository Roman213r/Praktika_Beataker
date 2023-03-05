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
using System.Windows.Threading;


namespace Kursova_Babinets_KN_21
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            EllipseOne.Visibility = Visibility.Hidden;
            EllipseTwo.Visibility = Visibility.Hidden;
            EllipseFour.Visibility = Visibility.Hidden;
            EllipseSix.Visibility = Visibility.Hidden;
            EllipseSeven.Visibility = Visibility.Hidden;

        }

        DispatcherTimer timer = new DispatcherTimer();
        private void timer_Tick(object sender, EventArgs e)
        {

            int i = 0;
            i++;


         
            Canvas.SetLeft(TrafficLeft, Canvas.GetLeft(TrafficLeft) + i);
        
            Canvas.SetLeft(TrafficTop, Canvas.GetLeft(TrafficTop) + i);
            if (Canvas.GetLeft(TrafficLeft) + i > 268)
            {

                
                Canvas.SetLeft(TrafficLeft, -687);
                Canvas.SetLeft(TrafficTop, -707);
                SoundPlayer PlayerOne = new SoundPlayer(Properties.Resources.A22);
                PlayerOne.Play();
                timer.Stop();
             



            }


        }

        SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.MusicChange);


        private void Play_Click(object sender, RoutedEventArgs e)
        {
      
            SPlayser.Play();

            timer.Interval = TimeSpan.FromMilliseconds(2);
            timer.Tick += timer_Tick;
            timer.Start();





        }



        private void StopTraffic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            timer.Stop();



        }

        private void FasterTraffic_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerOne = new SoundPlayer(Properties.Resources.MusicChange2);
            PlayerOne.Play();

            timer.Interval = TimeSpan.FromMilliseconds(8);
            timer.Tick += timer_Tick;
            timer.Start();




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerTwo = new SoundPlayer(Properties.Resources.noty_do);
            PlayerTwo.Play();

        }


        private void NotaDo_Click(object sender, RoutedEventArgs e)
        {

            SoundPlayer PlayerThree = new SoundPlayer(Properties.Resources.re);
            PlayerThree.Play();
        }




        private void Folder_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = "c:\\";

            dlg.RestoreDirectory = true;



            if (dlg.ShowDialog() == true)

            {
                string selectedFileName = dlg.FileName;


                System.Diagnostics.Process.Start(selectedFileName);

            }
        }


        private void SaveToolbar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Save .wav Files";
            saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "wav";
            saveFileDialog1.Filter = "Mp3 & Wav files (*.wav)|*.wav|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == true)
            {
                // textBox1.Text = saveFileDialog1.FileName;
            }
        }

        private void HelpToolbars_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore.exe", "https://en.wikipedia.org/wiki/FL_Studio");
        }

       

 



        private void EditBit_Click(object sender, RoutedEventArgs e)
        {
            DifferentForm form = new DifferentForm();
            form.Show();
            
        
        }

        private void DownloadBit_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer SPlayser = new SoundPlayer(Properties.Resources.ButtonClick);
            SPlayser.Play();
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == true)
            {

                dlg.InitialDirectory = "c:\\";

                dlg.RestoreDirectory = true;
                dlg.DefaultExt = "wav";
                dlg.Filter = "Mp3 & Wav files (*.wav)|*.wav|All files (*.*)|*.*";



                string selectedFileName = dlg.FileName;


                System.Diagnostics.Process.Start(selectedFileName);
                timer.Interval = TimeSpan.FromMilliseconds(2);
                timer.Tick += timer_Tick;
                timer.Start();

            }
        }

        private void ChangeBit_Checked(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerThree = new SoundPlayer(Properties.Resources.MusicChang);
            PlayerThree.Play();
            EllipseOne.Width = 40;
            EllipseOne.Height = 20;
            EllipseTwo.Width = 40;
            EllipseTwo.Height = 20;
            EllipseFour.Width = 40;
            EllipseFour.Height = 20;
            EllipseSix.Width = 40;
            EllipseSix.Height = 20;
            EllipseSeven.Width = 40;
            EllipseSeven.Height = 20;
            CircleOne.Width = 40;
            CircleOne.Height = 20;
            CircleTwo.Width = 40;
            CircleTwo.Height = 20;
            CircleFour.Width = 40;
            CircleFour.Height = 20;
            CircleSix.Width = 40;
            CircleSix.Height = 20;
            CircleSeven.Width = 40;
            CircleSeven.Height = 20;
        
         
            timer.Interval = TimeSpan.FromMilliseconds(2);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void AddBit_Checked(object sender, RoutedEventArgs e)
        {
            EllipseOne.Visibility = Visibility.Visible;
            EllipseTwo.Visibility = Visibility.Visible;
            EllipseFour.Visibility = Visibility.Visible;
            EllipseSix.Visibility = Visibility.Visible;
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.MusicChange4);
            PlayerFour.Play();
            timer.Interval = TimeSpan.FromMilliseconds(2);
            timer.Tick += timer_Tick;
            timer.Start();
            

        }

        private void NotaFa_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.fa);
            PlayerFour.Play();

        }

        private void NotaRe_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.re);
            PlayerFour.Play();

        }

        private void NotaMi_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.mi);
            PlayerFour.Play();
        }

        private void NotaSol_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.sol);
            PlayerFour.Play();
        }

        private void NotaSi_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.si);
            PlayerFour.Play();
        }

        private void NotaLja_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.lja);
            PlayerFour.Play();
        }

        private void NotaSil_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.si);
            PlayerFour.Play();
        }

        private void NotaTone_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.si);
            PlayerFour.Play();
        }

        private void NotatoneLja_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.lja);
            PlayerFour.Play();
        }

        private void NotatoneSol_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.fa);
            PlayerFour.Play();

        }

        private void NotatoneRe_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.re);
            PlayerFour.Play();

        }

        private void NotatoneDo_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.noty_do);
            PlayerFour.Play();

        }

        private void NotatoneSi_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.si);
            PlayerFour.Play();

        }

        private void NotatoneLya_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.lja);
            PlayerFour.Play();

        }

        private void NotaRee_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer PlayerFour = new SoundPlayer(Properties.Resources.lja);
            PlayerFour.Play();
        }
    }
}