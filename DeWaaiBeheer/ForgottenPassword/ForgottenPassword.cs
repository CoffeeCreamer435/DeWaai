using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace DeWaaiBeheer
{
    public partial class frmForgotten : Form
    {     
        private DatabaseMethods db = new DatabaseMethods();
        private EmailMethod em = new EmailMethod();

        public frmForgotten()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var generatedPassword = GeneratePassword(8);
            var users = db.getUsers().Where(x => x.Email == email);

            if(users != null)
            {
                foreach (Users us in users)
                {
                    em.SendEmail(txtEmail.Text, "ytbemre0@gmail.com", "Wachtwoord vergeten", "Uw nieuwe wachtwoord is: " + generatedPassword + "\nU kunt uw wachtwoord veranderen nadat u bent ingelogd!");

                    us.Password = generatedPassword;
                    db.SaveChanges();

                    this.Close();
                    frmLogin form = new frmLogin();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Uw emailadres bestaat niet!");
            }
            
        }

        
        public static string GeneratePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
