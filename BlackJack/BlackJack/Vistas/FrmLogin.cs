using BlackJack.Modelo;
using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.Vistas
{
    public partial class FrmLogin : Form
    {

        private const string AppId = "188773471634257";
        private readonly Uri _loginUrl;
        public FacebookOAuthResult _FacebookOAuthResult { get; private set; }
        private const string _ExtendedPermissions = "user_about_me,public_profile";




        public FrmLogin()
        {
            if (string.IsNullOrEmpty(AppId))
                throw new ArgumentNullException("appId");
            var _oauthClient = new FacebookOAuthClient { AppId = AppId };
            IDictionary<string, object> _loginParameters = new Dictionary<string, object>();
            _loginParameters["response_type"] = "token";
            _loginParameters["display"] = "popup";
            if (!string.IsNullOrEmpty(_ExtendedPermissions))
            {
                _loginParameters["scope"] = _ExtendedPermissions;
            }
            _loginUrl = _oauthClient.GetLoginUrl(_loginParameters);
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(_loginUrl.AbsoluteUri);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            FacebookOAuthResult _oauthResult;
            if (FacebookOAuthResult.TryParse(e.Url, out _oauthResult))
            {
                this._FacebookOAuthResult = _oauthResult;
                this.DialogResult = _FacebookOAuthResult.IsSuccess ? DialogResult.OK : DialogResult.No;
                try
                {
                    Jugador jugador = new Jugador();
                    var fb = new FacebookClient(_FacebookOAuthResult.AccessToken);
                    var parameters = new Dictionary<string, object>();
                    parameters["fields"] = "id,name,first_name,last_name,gender";
                    var result = (IDictionary<string, object>)fb.Get("me", parameters);
                    var id = (string)result["id"];
                    string profilePictureUrl = string.Format("https://graph.facebook.com/{0}/picture?type={1}", id, "square");
                    jugador.foto = profilePictureUrl;
                    try
                    {
                        Type tresult = result.GetType();
                        var objname = (string)result["name"];
                        var firstName = (string)result["first_name"];
                        var lastName = (string)result["last_name"];
                        var gender = (string)result["gender"];
                        jugador.nombre = objname;
                        jugador.apellido = lastName;
                        jugador.genero = gender;

                        MDIPrincipal principal = new MDIPrincipal(jugador);
                        principal.Show();
                        this.Close();

                    }
                    catch (FacebookApiException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this._FacebookOAuthResult = null;
            }
        }
}
}
