using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public static int Contador;
        public static double Balance = 9000;
        public static string[] Historial = new string[50];

        public MainMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertMoney depositar = new InsertMoney();
            depositar.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveMoney retirar = new RemoveMoney();
            retirar.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            History historial = new History();
            historial.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            balance.Text = Balance.ToString();
        }
    }
}
