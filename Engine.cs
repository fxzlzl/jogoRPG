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

            _player = new Player(10,10,20,0,1);

            local Local = new local(1, "Casa", "Essa é SUA casa! 🏠");

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNorte_Click( object sender, EventArgs e )
        {

        }

        private void btnOeste_Click( object sender, EventArgs e )
        {

        }

        private void btnSul_Click( object sender, EventArgs e )
        {

        }

        private void btnLeste_Click( object sender, EventArgs e )
        {

        }

        private void btnUsarArma_Click( object sender, EventArgs e )
        {

        }

        private void btnUsarPoção_Click( object sender, EventArgs e )
        {

        }
    }
}
