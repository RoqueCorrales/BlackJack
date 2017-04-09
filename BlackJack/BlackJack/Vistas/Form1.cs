using BlackJack.Vistas;
using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private const string AppId = "1836405080016245";
        private const string ExtendedPermissions = "public_profile,email";
        private string _accessToken;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            MDIPrincipal f = new MDIPrincipal();
            f.Show();


            //var fbLoginDialog = new FrmLogin(AppId, ExtendedPermissions);
            //fbLoginDialog.ShowDialog();

            //DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);

            // FrmLogin f = new FrmLogin();
            // f.Show();
        }
        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    dynamic result = fb.Get("/me");
                    var name = result.name;

                    // for .net 3.5
                    //var result = (IDictionary<string, object>)fb.Get("/me");
                    //var name = (string)result["name"];

                    MessageBox.Show("Hi " + name);

                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }
    }
}
