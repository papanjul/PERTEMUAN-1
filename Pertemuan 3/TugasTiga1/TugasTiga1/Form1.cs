using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lblTampilNim.Text = "22.11.4832";
            lblTampilNama.Text = "Among Bagas Punarbawa Purnama";
            lblTampilKelas.Text = "IF05";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblTampilNim.Text = " ";
            lblTampilNama.Text = " ";
            lblTampilKelas.Text = " ";
        }
    }
}
