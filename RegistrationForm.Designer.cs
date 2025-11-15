namespace MyDesktopApp.Modules.Registration{
    partial class RegistrationForm
    {
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtEmail;
    
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPassword;
        private Label lblEmail;

        private Button btnSubmit;
        private Button btnClear;
        
        private CheckBox chkAcceptTerms;


        private void InitializeComponent()
        {
            // draw gui
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();

            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            chkAcceptTerms = new CheckBox();

            btnSubmit = new Button();
            btnClear = new Button();


            // label first name
            lblFirstName.Text = "First Name";
            lblFirstName.Location = new Point(20, 20);

            //txt first name
            txtFirstName.Location = new Point(20, 40);
            txtFirstName.Size = new Size(200, 20);

            // label last name
            lblLastName.Text = "Last Name";
            lblLastName.Location = new Point(20, 70);

            //txt Last Name
            txtLastName.Location = new Point(20, 90);
            txtLastName.Size = new Size(200, 20);

            // label Email
            lblEmail.Text = "Email";
            lblEmail.Location = new Point(20, 110);

            //txt Email
            txtEmail.Location = new Point(20, 140);
            txtEmail.Size = new Size(200, 20);

            // label Password
            lblPassword.Text = "Password";
            lblPassword.Location = new Point(20, 160);

            //txt password
            txtPassword.Location = new Point(20, 190);
            txtPassword.Size = new Size(200, 20);

            chkAcceptTerms.Text = "I accept terms and conditions"
            chkAcceptTerms.Location = new Point(30, 200);
            chkAcceptTerms.Size = new Size(80, 80);
           //chkShowPass.CheckedChanged += ShowPass;

            // button
            btnSubmit.Text = "Submit";
            btnSubmit.Location = new Point(40, 220);
            btnSubmit.Size = new Size(80, 80);
            //login event
            btnSubmit.Click += startRegistration;

            // button
            btnClear.Text = "Clear";
            btnClear.Location = new Point(90, 220);
            btnClear.Size = new Size(80, 80);
            //clear event
            btnClear.Click += clearInputs;

            this.ClientSize = new Size(300, 160);
            this.Text = "Registration Form";
            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(txtLastName);
            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(chkAcceptTerms);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(btnClear);
        }
    }
}
