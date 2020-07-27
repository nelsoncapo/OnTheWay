using OnTheWay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnTheWay.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loginpage : ContentPage
    {
        public Loginpage()
        {
            InitializeComponent();
        }

         void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Email.Text, Entry_Password.Text);

        }
    }

}