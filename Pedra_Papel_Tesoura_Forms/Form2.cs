using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pedra_Papel_Tesoura_Forms
{
    public partial class Form2 : Form
    {
        
        int player1 = 0;
        int player2 = 0;
        int pontosPlayer1 = 0;
        int pontosPlayer2 = 0;
        public Form2()
        {    
            InitializeComponent(); 
        }

        readonly Random random = new Random();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            player1 = 1;

            EscolhaPlayer2();
            TestarEscolhas();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            player1 = 2;

            EscolhaPlayer2();
            TestarEscolhas();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            player1 = 3;

            EscolhaPlayer2();
            TestarEscolhas();
        }
        
        public void TestarEscolhas()
        {

            if(player1 == 1 && player2 == 2 || player1 == 2 && player2 == 3 || player1 == 3 && player2 == 1)
            {
                pontosPlayer2++;
                txtPlayer2.Text = pontosPlayer2.ToString();
            }
            else if(player1 == 1 && player2 == 3 || player1 == 2 && player2 == 1 || player1 == 3 && player2 == 2)
            {
                pontosPlayer1++;
                txtPlayer1.Text = pontosPlayer1.ToString();
            }
            else
            {
                
            }
            
        }

        public void EscolhaPlayer2()
        {
            player2 = random.Next(1, 4);

            if(player2 == 1)
            {
                btnPlayer2.BackColor = System.Drawing.Color.Coral;
                btnPlayer2.Image = Image.FromFile(@"C:\Users\Márcio\Downloads\pedra.png");
            }
            else if(player2 == 2)
            {
                btnPlayer2.BackColor = System.Drawing.Color.Teal;
                btnPlayer2.Image = Image.FromFile(@"C:\Users\Márcio\Downloads\papel.png");
                
            }
            else
            {
                btnPlayer2.BackColor = System.Drawing.Color.Yellow;
                btnPlayer2.Image = Image.FromFile(@"C:\Users\Márcio\Downloads\tesoura.png");
            }

        }

    }
}
