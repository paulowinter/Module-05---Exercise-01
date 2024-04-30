using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module05Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            DateTime birthdate = birthDatePicker.Date;

            DateTime today = DateTime.Today;

            int age = today.Year - birthdate.Year;

            result.Text = age.ToString();
        }
    }
}