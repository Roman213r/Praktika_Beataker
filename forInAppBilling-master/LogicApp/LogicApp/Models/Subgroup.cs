using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LogicApp.Models
{
    public class Subgroup : INotifyPropertyChanged
    {
        private TimeSpan _timeSpent;
        private int _wordsAccomplished;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public int SubgroupNumber { get; set; }
        public string ImageUrl { get; set; }
        public string WordNumbers { get; set; }

        public Color SubgroupColor { get; set; }
        public Color SubgroupMainColor { get; set; }
        public int WordsAccomplished
        {
            get { return _wordsAccomplished; } // TODO: get directly from property (group number needed then)
            set
            {
                _wordsAccomplished = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("WordsAccomplished");
            }
        }
        public int NumberOfWords { get; set; }       
        public TimeSpan TimeSpent
        {
            get { return _timeSpent; } // TODO: get directly from property (group number needed then)
            set
            {
                _timeSpent = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("TimeSpentString");
            }
        }

        public String TimeSpentString
        {
            get { return _timeSpent.ToString(@"hh\:mm\:ss"); }
            set { }            
        }

        public override string ToString()
        {
            return Name;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
