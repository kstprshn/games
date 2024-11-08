using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game 
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            label2.Visible = true;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {          
                
                 if (comboBox1.SelectedItem == comboBox1.Items[1])
                 {
                    var game1 = new cars();
                    game1.Show();
                 }
                 else if (comboBox1.SelectedItem == comboBox1.Items[0])
                {
                    var game2 = new kazino();
                    game2.Show();
                }
                else if (comboBox1.SelectedItem == comboBox1.Items[2])
                {
                    var game3 = new chess();
                    game3.Show();
                }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                label2.Visible = true;
                button1.Enabled = false;
            }

            else if (comboBox1.SelectedItem != null)
            {
                label2.Visible = false;
                button1.Enabled = true;
            }
        }
    }
}
