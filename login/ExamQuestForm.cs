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
    public partial class ExamQuestForm : Form
    {
        examEntities ent = new examEntities();
        public int studentID { get; set; }
        public int examID { get; set; }
        public int courseID { get; set; }
        public ExamQuestForm(int stdid, int eid, int cid)
        {
            InitializeComponent();
            studentID = stdid;
            examID = eid;
            courseID = cid;
        }
        public void copyGB ( int s, int e, int c  )
        {
            GroupBox[] g = new GroupBox[10];
            int y = groupBox1.Location.Y;
            var questsID = from q in ent.Std_Exam_Ques where q.Exam_ID == e & q.Std_ID == s select q.Ques_ID;
            var questContent = " ";
            var questType = " ";
            foreach(var q in questsID)
            {
                int se = questsID.Count();
                int ss = 0;
                questType = (from x in ent.Questions where x.Ques_ID == q select x.Ques_Type).First();
                questContent = (from x in ent.Questions where x.Ques_ID == q select x.Ques_Content).First();
                if(questType=="MCQ")
                {
                    if (ss <= se)
                    {
                     var choices = from ch in ent.Choices where ch.Ques_ID == q select ch.Cho_Content;
                    g[ss] = groupBox1;
                    //internal controls
                    ss++;
                    

                    }
                }

            }
        //    for(int j =0; j<10; j++)
        //    {
        //        g[i] = groupBox1;
        //        g[i].Location= new Point(groupBox1.Location.X, y + 30);
        //        y += 30;
        //    }
        //    groupBox1.Controls[
        //        return g;
        }

        private void ExamQuestForm_Load(object sender, EventArgs e)
        {

        }

    }
}
