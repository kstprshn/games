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
    public partial class kazino : Form
    {
        private int pointcount = 0;
        private int[] slots = new int[3];

        public kazino()
        {
            InitializeComponent();
        }
        
        private void dv1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int dig = r.Next(8);
            slots[0] = dig;
            updslots();
        }
        private void dv2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int dig = r.Next(8);
            slots[1] = dig;
            updslots();
        }

        private void dv3_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int dig = r.Next(8);
            slots[2] = dig;
            updslots();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = System.Convert.ToString(pointcount);            

            dv1.Enabled = true;
            dv2.Enabled = true;
            dv3.Enabled = true;

            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
        }

        private void stop1_Tick(object sender, EventArgs e)
        {
            dv1.Enabled = false;
            stop1.Enabled = false;

        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            dv2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            dv3.Enabled = false;
            stop3.Enabled = false;

            updslots();
            prize();
        }

        private void prize()
        {
            var query =  slots.GroupBy(x => x)
              .Where(g => g.Count() > 1 & g.Key > 0 & g.Key < 8)
              .Select(y => new { value = y.Key, count = y.Count() })
              .ToList();

            if (query.Count > 0) {
                int tmp;
                if (query[0].count == 2)
                {
                    tmp = query[0].value * 100;
                }
                else {
                    tmp = query[0].value * 200;
                }

                MessageBox.Show("Ваш выйгрыш: " + tmp.ToString());
                pointcount += tmp;
            }

            label5.Text = System.Convert.ToString(pointcount);
        }
        private void updslots() {
            label1.Text = slots[0].ToString();
            label2.Text = slots[1].ToString();
            label3.Text = slots[2].ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
