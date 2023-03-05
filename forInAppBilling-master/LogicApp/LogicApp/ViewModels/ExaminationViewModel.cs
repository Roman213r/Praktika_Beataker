using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using ClosedXML.Excel;
using LogicApp.Views;
using Xamarin.Forms;

namespace LogicApp.ViewModels
{
    public class ExaminationViewModel : BaseViewModel
    {
        private Random random;
        private XLWorkbook wk;
        public string correctLetter;
        private ObservableCollection<string> _options;
        private string _letter;
        private int _timer = 50;

        public ObservableCollection<string> Options
        {
            get { return _options; }
            set { SetProperty(ref _options, value); }
        }

        public string Letter
        {
            get { return _letter; }
            set { SetProperty(ref _letter, value); }
        }

        public int Timer
        {
            get { return _timer; }
            set { SetProperty(ref _timer, value); }
        }

        public Command SelectOptionCommand => new Command((param) =>
        {
            if (param.ToString() == correctLetter)
            {
                ReadExcelasJSON();
            }
        });

        public int Group { get; set; }

        public ExaminationViewModel(int group)
        {
            Group = group;
            Options = new ObservableCollection<string>();
            random = new Random();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            wk = new XLWorkbook(assembly.GetManifestResourceStream("LogicApp.ExaminationResources.en_letters.xlsx"));

            ReadExcelasJSON();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                if (Timer == 0)
                {
                    Application.Current.MainPage.Navigation.PopModalAsync();
                    return false;
                }
                Timer--;
                return true;
            });
        }

        public void ReadExcelasJSON()
        {
            int index = 0;
            IXLWorksheet ws = wk.Worksheet(1);
            List<string> options = new List<string>();

            switch (Group)
            {
                case 0:
                    index = random.Next(1, 773);
                    correctLetter = ws.Cell(index, 1).Value.ToString();
                    Letter = ws.Cell(index, 2).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 773), 1).Value.ToString(), ws.Cell(random.Next(1, 773), 1).Value.ToString(), ws.Cell(random.Next(1, 773), 1).Value.ToString() };
                    break;
                case 1:
                    index = random.Next(1, 666);
                    correctLetter = ws.Cell(index, 3).Value.ToString();
                    Letter = ws.Cell(index, 4).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 666), 3).Value.ToString(), ws.Cell(random.Next(1, 666), 3).Value.ToString(), ws.Cell(random.Next(1, 666), 3).Value.ToString() };
                    break;
                case 2:
                    index = random.Next(1, 321);
                    correctLetter = ws.Cell(index, 5).Value.ToString();
                    Letter = ws.Cell(index, 6).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 321), 5).Value.ToString(), ws.Cell(random.Next(1, 321), 5).Value.ToString(), ws.Cell(random.Next(1, 321), 5).Value.ToString() };
                    break;
                case 3:
                    index = random.Next(1, 177);
                    correctLetter = ws.Cell(index, 7).Value.ToString();
                    Letter = ws.Cell(index, 8).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 177), 7).Value.ToString(), ws.Cell(random.Next(1, 177), 7).Value.ToString(), ws.Cell(random.Next(1, 177), 7).Value.ToString() };
                    break;
                case 4:
                    index = random.Next(1, 128);
                    correctLetter = ws.Cell(index, 9).Value.ToString();
                    Letter = ws.Cell(index, 10).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 128), 9).Value.ToString(), ws.Cell(random.Next(1, 128), 9).Value.ToString(), ws.Cell(random.Next(1, 128), 9).Value.ToString() };
                    break;
                case 5:
                    index = random.Next(1, 205);
                    correctLetter = ws.Cell(index, 11).Value.ToString();
                    Letter = ws.Cell(index, 12).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 205), 11).Value.ToString(), ws.Cell(random.Next(1, 205), 11).Value.ToString(), ws.Cell(random.Next(1, 205), 11).Value.ToString() };
                    break;
                case 6:
                    index = random.Next(1, 203);
                    correctLetter = ws.Cell(index, 13).Value.ToString();
                    Letter = ws.Cell(index, 14).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 203), 13).Value.ToString(), ws.Cell(random.Next(1, 203), 13).Value.ToString(), ws.Cell(random.Next(1, 203), 13).Value.ToString() };
                    break;
                case 7:
                    index = random.Next(1, 150);
                    correctLetter = ws.Cell(index, 15).Value.ToString();
                    Letter = ws.Cell(index, 16).Value.ToString();
                    options = new List<string> { correctLetter, ws.Cell(random.Next(1, 150), 15).Value.ToString(), ws.Cell(random.Next(1, 150), 15).Value.ToString(), ws.Cell(random.Next(1, 150), 15).Value.ToString() };
                    break;
                default:
                    break;
            }
            options = options.OrderBy(x => random.Next()).ToList();
            Options = new ObservableCollection<string>(options);
        }


    }
}
