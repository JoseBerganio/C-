using System.Windows.Forms;
using System.Drawing.Text;

namespace MyDesktopApp.Modules.Registration{

    public partial class RegistrationForm : Form
    {
        public RegistrationForm(){
            InitializeComponent();
        }

        public void startRegistration(object? sender, EventArgs args){
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool areAllFilled = firstName == null && lastName == null && email==null && password==null;
            bool isChkBoxFilled = chkAcceptTerms.Checked;

            if (areAllFilled && isChkBoxFilled){
                MessageBox.Show("All fields must be filled.");
            }
            else{
                MessageBox.Show("Hi, "+ firstName +". Thank you for the registration.");
            }
        }


        public void clearInputs(object? sender, EventArgs args){
            txtFirstName = null;
            txtLastName = null;
            txtEmail = null;
            txtPassword = null;
        }
        
    }
}

