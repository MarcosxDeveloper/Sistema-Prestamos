using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InsertMoney : Form
    {
        public InsertMoney()
        {
            InitializeComponent();
        }
        public void Regresar()
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
        public void SumarBalance(double Num)
        {
            MainMenu.Balance += Num;
            MainMenu.Historial[MainMenu.Contador] = "Has Depositado " + Num.ToString() + "RD";
            MessageBox.Show(MainMenu.Historial[MainMenu.Contador]);
            MainMenu.Contador++;
            Regresar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SumarBalance(10);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SumarBalance(25);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SumarBalance(50);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SumarBalance(100);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SumarBalance(200);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SumarBalance(500);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SumarBalance(1000);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SumarBalance(2000);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Regresar();
        }
    }
}
