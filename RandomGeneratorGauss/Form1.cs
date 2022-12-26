using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGeneratorGauss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = 10.ToString();
            textBox2.Text = 10.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> current=new List<int>();
            List<int> answer = new List<int>();
            int max = Convert.ToInt16(textBox2.Text);
            int dimension = Convert.ToInt16(textBox1.Text);
            current = Gauss(dimension, max);
            answer=Distribution(current, max);
            chart1.Series["Numbers"].Points.Clear();
            for (int i = 0; i < answer.Count; i++)
            {
                chart1.Series["Numbers"].Points.AddXY(i, answer[i]);
            }
        }
        public List<int> Distribution(List<int> Gauss,int max)
        {
            List<int> answer = new List<int>();
            for (int i = 0; i < max+1; i++)
            {
                answer.Add(0);
            }
            foreach (int i in Gauss)
            { 
                answer[i]+=1;
            }
            return answer;
        }
        public List<int> Gauss(int n,int max)
        {
            List<int> list = new List<int>(); 
            Random random = new Random();
            for (int i=0;i<n; i++)
            {
                list.Add(random.Next(0,max));
            }
           return list;
        }
    }
}
