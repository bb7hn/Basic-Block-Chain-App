using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlockChain;
namespace BlockChain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Blockchain blok = new Blockchain();
        private int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            foreach (String item in listBox1.Items)
            {
                blok.createBlog(item);
                listBox2.Items.Add("---");
                listBox2.Items.Add("Blok" + (sayac + 1));
                listBox2.Items.Add(item);
                listBox2.Items.Add(blok.getHash().ToString());
                listBox2.Items.Add("---");
                sayac++;
            }
            
            
        }
    }
}
