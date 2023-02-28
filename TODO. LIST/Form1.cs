using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO.LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimeData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTarefa_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lblTarefa_Click(object sender, EventArgs e)
        {


        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            { 
                MessageBox.Show("Erro");
            }
            else
            {
                listBox1.Items.Add($"{dateTimeData.Value:d} - {txtTarefa.Text}");
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtTarefa.Text == "")
            {
                MessageBox.Show("Erro");
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
