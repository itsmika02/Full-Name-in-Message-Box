using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Name_mssgbox
{
    public partial class MichaelaEspiritu : Form
    {
        public MichaelaEspiritu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            FullNameTextBox.Text = "";
            FirstNameTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = FirstNameTextBox.Text + "" + LastNameTextBox.Text; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
         
        
       
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! I'm Michaela P. Espiritu from BSCOE 1-4");
        }
    }
}
