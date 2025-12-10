using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace jogoRPG
{
    public partial class Engine : Form
    {
        private Player _player;
        public Engine()
        {
            InitializeComponent();

            _player = new Player();

            _player.HPatual = 10;
            _player.HPmax = 50;
            _player.Ouro = 20;
            _player.EXPatual = 0;
            _player.Level = 1;

            lblPontosDeVida.Text = _player.HPatual.ToString();
            lblOuro.Text = _player.Ouro.ToString();
            lblExp.Text = _player.EXPatual.ToString();
            lblNivel.Text = _player.Level.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
