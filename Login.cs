using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = User.Text;
            string Contraseña = Password.Text;
            if (Usuario=="admin" && Contraseña=="123456")
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto");
                User.Text = "";
                Password.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
