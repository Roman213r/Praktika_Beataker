using System;
using System.Collections.Generic;
using System.Text;

namespace LogicApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionTitle { get; set; }
        public string Description { get; set; }
        public Xamarin.Forms.Color GroupColor { get; set; }
        public int Letters { get; set; }

        public string Image
        {
            set { }

            get { return "Connections"; }
        }
    }
}
