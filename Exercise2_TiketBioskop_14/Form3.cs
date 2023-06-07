using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_TiketBioskop_14
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            
            this.Close();      
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiketBioskopDataSet1.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.tiketBioskopDataSet1.Pembeli);

        }
    }
}
