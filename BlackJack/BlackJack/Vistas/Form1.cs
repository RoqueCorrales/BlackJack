using BlackJack.Vistas;
using Facebook;
using System;
using System.Collections.Generic;

using System.Windows.Forms;


namespace BlackJack
{
    public partial class Form1 : Form
    {
        private const string AppId = "188773471634257";
        private const string ExtendedPermissions = "user_about_me,public_profile";
        private string _accessToken;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string _accessToken)
        {
            InitializeComponent();
            this._accessToken = _accessToken;
        }



        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FrmLogin(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
            this.Hide();

        }

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                     var parameters = new Dictionary<string, object>();
                    parameters["fields"] = "id,name,first_name,last_name,gender";
                    var result = (IDictionary<string, object>)fb.Get("me", parameters);
                    var id = (string)result["id"];
                    var name = (string)result["first_name"];
                    var last_name = (string)result["last_name"];
                    var gender = (string)result["gender"];
                    string foto = string.Format("https://graph.facebook.com/{0}/picture?type={1}", id, "square");
                    Modelo.Jugador j = new Modelo.Jugador();
                    j.nombre = name;
                    j.apellido = last_name;
                    j.genero = gender;
                    j.foto = foto;

                    MDIPrincipal juego = new MDIPrincipal(j,_accessToken);
                    juego.Show();
                   
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
          
        }

    }
}