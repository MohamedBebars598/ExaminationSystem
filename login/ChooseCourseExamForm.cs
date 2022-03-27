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
    public partial class ChooseCourseExamForm : Form
    {
        examEntities ent = new examEntities();
        public int studentID { get; set; }
        public ChooseCourseExamForm(int s)
        {
            InitializeComponent();
            studentID = s;
        }

        private void ChooseCourseExamForm_Load(object sender, EventArgs e)//on load
        {
            var courses = (from c in ent.Courses where c.Crs_ID == (from s in ent.Std_Course where s.Std_ID == studentID select s.Crs_ID).First() select c.Crs_Name); 
            foreach( var c in courses)
            {
                comboBox1.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)// start exam
        {
            int crs_id = (from c in ent.Courses where c.Crs_Name== comboBox1.SelectedItem select c.Crs_ID).First();
            int exam_id = (from ex in ent.Exams where ex.Crs_ID == crs_id select ex.Exam_ID).First();

        }
    }
}
