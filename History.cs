using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class History : Form
    {   
        public History()
        {
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
        private void History_Load(object sender, EventArgs e)
        {
            lista.Items.AddRange(MainMenu.Historial);
            Controls.Add(lista);
        }
    }
}
