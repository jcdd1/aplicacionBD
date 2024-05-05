using System;
using System.Windows.Forms;
namespace aplicacionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            clsUsuario usuario = new clsUsuario(txtUsuario.Text, txtContra.Text);
            int consulta = usuario.consultarUsuario(usuario.strUsuario, usuario.strcontra);

            if (consulta == 1)
            {
                MessageBox.Show("Usuario registrado");
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario invalido");
            }

        }
    }
}