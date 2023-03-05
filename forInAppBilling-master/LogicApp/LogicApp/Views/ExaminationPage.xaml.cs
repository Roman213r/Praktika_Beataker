using LogicApp.ViewModels;
using Xamarin.Forms;

namespace LogicApp.Views
{
    public partial class ExaminationPage : ContentPage
    {
        ExaminationViewModel _viewModel;

        public ExaminationPage(int group, string type)
        {
            InitializeComponent();
            BindingContext = _viewModel = new ExaminationViewModel(group);
            if (type == "select")
            {
                SelectType.IsVisible = true;
            }
            else if (type == "letter")
            {
                LetterType.IsVisible = true;
            }
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Letter.Text = "";
        }
    }
}
