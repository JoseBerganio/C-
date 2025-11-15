using System.Windows.Forms;

namespace MyDesktopApp.Modules.Registration{

    partial class RegistrationForm : Register
    {
        public RegistrationForm(){
            InitializeComponent();
        }

        public void startRegistration(object? sender, EventArgs args){
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

        }
    }
}