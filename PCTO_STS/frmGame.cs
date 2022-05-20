using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTO_STS
{
    public partial class frmGame : Form
    {
        private string nickname;
        public frmGame()
        {
            InitializeComponent();
        }

        public string Nickname { get => nickname; set => nickname = value; }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            label3.Text = "Giocatori: " + "\n" + Nickname;
        }
    }
}
