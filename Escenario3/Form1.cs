namespace Escenario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigApp.Cargar();

            Text = ConfigApp.TituloApp;
            lblInfo.Text = $"La contraseña debe tener al menos {ConfigApp.LongitudMinimaPassword} caracteres";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un usuario");
                esValido = false;
            }
            else
                errorProvider1.SetError(txtUsuario, "");

            if (!Utilidades.ValidarCorreo(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresa un correo valido de la forma: nombreCorreo@servicioCorreo.extensionCorreo");
                esValido = false;
            }
            else
                errorProvider1.SetError(txtCorreo, "");

            if (!Utilidades.PasswordCorrecta(txtPassword.Text, ConfigApp.LongitudMinimaPassword))
            {
                errorProvider1.SetError(txtPassword, $"La contraseña debe tener al menos {ConfigApp.LongitudMinimaPassword} caracteres");
                esValido = false;
            }
            else
                errorProvider1.SetError(txtPassword, "");

            if (!esValido)
            {
                MessageBox.Show("Corrija los errores marcados para registrarse. Pase el mouse sobre los iconos para mayor informacion");
                return;
            }

            MessageBox.Show("Usuario registrado!");
        }
    }
}
