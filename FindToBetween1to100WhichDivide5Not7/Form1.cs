using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindToBetween1to100WhichDivide5Not7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sum = 0;
            int  count = 1;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%5==0 && i%7!=0)
                {
                    sum += i;
                    count++;
                }
            }
            MessageBox.Show("Total sum:" + sum.ToString() + "\nCount : " + count.ToString());
        }
    }
}
