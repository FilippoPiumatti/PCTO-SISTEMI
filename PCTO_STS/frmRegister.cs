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
    public partial class frmRegister : Form
    {

        public frmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "" || txtC.Text == "" || txtNick.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("INSERISCI LE CREDENZIALI CORETTAMENTE..", "Attenzione:", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                frmGame fr = new frmGame();
                fr.Nickname = txtNick.Text;
                fr.Show();
            }
           
        }
    }
}
