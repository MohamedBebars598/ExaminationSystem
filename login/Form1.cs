using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//login
        {
            examEntities ent = new examEntities();
            string userName = textBox1.Text;
            int password = int.Parse(textBox2.Text);


            var check = ent.checkUser(userName, password).FirstOrDefault();
            var test = check.FirstOrDefault();
            var test2 = test.ToString();

            MessageBox.Show(test2);

            //var check = from d in ent.checkUser(userName, password) select d;
            //if(check==0)
            //{
            //    MessageBox.Show("User not Registered");
            //}

            //var getUser = from u in ent. 
        }
    } 
}
