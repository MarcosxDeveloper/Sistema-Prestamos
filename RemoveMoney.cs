using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RemoveMoney : Form
    {
        public RemoveMoney()
        {
            InitializeComponent();
        }
        public void Regresar()
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
        public void RestarBalance(double Num)
        {
            if (Num > MainMenu.Balance)
            {
                MessageBox.Show("Saldo Insuficiente");
            }
            else
            {
                MainMenu.Balance -= Num;
                MainMenu.Historial[MainMenu.Contador] = "Has Retirado " + Num.ToString() + "RD";
                MessageBox.Show(MainMenu.Historial[MainMenu.Contador]);
                MainMenu.Contador++;
                Regresar();
            }
            Regresar();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestarBalance(10);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RestarBalance(25);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RestarBalance(50);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            RestarBalance(100);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            RestarBalance(200);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            RestarBalance(500);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            RestarBalance(1000);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            RestarBalance(2000);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Regresar();
        }
    }
}
