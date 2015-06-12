using HospitalAutomation.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HastaneArsiv
{
    public partial class LoginForm : Form
    {
        ErrorTracker eTracker;

        public LoginForm()
        {
            InitializeComponent();

            eTracker = new ErrorTracker(errorProviderLoginForm);
            errorProviderLoginForm.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProviderLoginForm.Clear();

            bool isUsernameFieldEmpty = string.IsNullOrWhiteSpace(txtUserName.Text);
            bool isPasswordFieldEmpty = string.IsNullOrWhiteSpace(txtPassword.Text);

            if (isUsernameFieldEmpty)
            {
                eTracker.SetError(txtUserName, "Boş Alan Bırakmayınız !");
            }

            if (isPasswordFieldEmpty)
            {
                eTracker.SetError(txtPassword, "Boş Alan Bırakmayınız !");
            }

            if (!isUsernameFieldEmpty && !isPasswordFieldEmpty)
            {
                HastaneArsivEntities db = new HastaneArsivEntities();


                var result = db.OTURUMs.Count(x => x.KullaniciAdi == txtUserName.Text && x.Sifre == txtPassword.Text);

                if (result <= 0)
                {
                    eTracker.SetError(txtUserName, "Kullanıcı Adı yada Şifre Hatalı !");
                    eTracker.SetError(txtPassword, "Kullanıcı Adı yada Şifre Hatalı !");
                }

                else
                {
                    this.Hide();

                    Form1 nextForm = new Form1();
                    nextForm.Show();
                }
            }
        }

    }
}
