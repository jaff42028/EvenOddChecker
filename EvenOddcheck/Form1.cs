using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOddcheck
{
    public partial class Form1 : Form
    {
        bool iseven;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkeven();
            int n = Convert.ToInt32(textBox1.Text);
            if (n < 0)
            {
                n = n * (-1);
                label1.Text = "Even is : " + isEven(n).ToString();
            }
            else
            {
                isEven(n);
                label1.Text = "Even is :" + isEven(n).ToString();
            }
        }
        //bool checkeven()
        //{
            
        //    int n = Convert.ToInt32(textBox1.Text);
        //    if (n < 0)
        //    {
        //        n = n *(-1);
        //    }
        //    for (int i = 1; i <= n; i++)
        //    {
        //        iseven = !iseven;
        //    }
        //    return iseven;
        //}

        //bool isEven(int n)
        //{
        //    bool isEven = true;
        //    for (int i = 0; i <= n; i++)
        //        isEven = !isEven;
        //    return isEven;
        //}

        bool isEven(int n)
        {
            bool isEven = true;
            for (int i = 1; i <= n; i++)
                isEven = !isEven;
            return isEven;
        }
    }
}
