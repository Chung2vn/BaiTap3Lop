using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_moiDataSet.InfinityStones' table. You can move, or remove it, as needed.
            this.infinityStonesTableAdapter.Fill(this.database_moiDataSet.InfinityStones);
            try
            {
                StoneBUS stoneBUS = new StoneBUS();
                this.dataGridView1.DataSource = stoneBUS.GetStone();
            }
            catch
            {
                MessageBox.Show("Xay Ra Loi");;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StoneBUS stoneBUS = new StoneBUS();
                this.dataGridView1.DataSource = stoneBUS.GetStone(Convert.ToInt16(this.textBox1.Text));
            }
            catch
            {
                MessageBox.Show("Xay ra loi ");
            }
        }
    }
}
