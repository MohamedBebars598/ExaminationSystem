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
    public partial class StudentForm : Form
    {
        examEntities ent = new examEntities();
        public int studentID { get; set; }
        public StudentForm(int s)
        {
            InitializeComponent();
            studentID = s;
        }

        private void button1_Click(object sender, EventArgs e)// take exam
        {
            ChooseCourseExamForm ccef = new ChooseCourseExamForm(studentID);

        }
    }
}
