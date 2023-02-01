using CSlProjrct_Version1.Instructor_create_ExamForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CSlProjrct_Version1
{

    public partial class instractorform : Form
    {
        public int Instructor_id { get; set; }
        public int Course_id { get; set; }

        Context db = new Context();
        int index = 1;
        int flage = 1;
        int numq = 1;
        int numtf = 1;
        Exam Exam = new Exam();
        List<ExamQuestionsChoice> Choices = new List<ExamQuestionsChoice>();
        List<ExamQuestionsTF> questionsTFs = new List<ExamQuestionsTF>();
       

        public instractorform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Instructor_dashBooard frm = new Instructor_dashBooard();
            this.Hide();
            frm.Instructor_id= Instructor_id;
            frm.Show();

        }

        private void instractorform_Load(object sender, EventArgs e)
        {

            Course_id= (from i in db.Courses
                        where i.instructor_id == Instructor_id
                        select i.course_id).FirstOrDefault();
            var name = (from p in db.Instructors
                        where p.instructor_id == Instructor_id   // how to take it from user
                        select p.instructor_f_n).FirstOrDefault();
            text_id.Text = "Welcom" + "  " + name;


            var c = (from i in db.Courses
                     where i.instructor_id == Instructor_id
                     select i.course_name).FirstOrDefault();
            showcource.Text = c;

            idins.Text = Course_id.ToString();
        }// when instructor form loaded

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void showcource_Click(object sender, EventArgs e)
        {

        }
        private void q_content_Click(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void option1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e) // click next 
        {
           
            if (flage==2) // if it MCQ question
            {
                var count = (from c in db.QuestionstChoices
                             where c.course_id == Course_id
                             select c).Count();

                if (count > index)
                {
                    index=2;
                    index++;
                    var question = (from c in db.QuestionstChoices
                                    where c.course_id == Course_id && c.question_id == index
                                    select c).FirstOrDefault(); ;

                    q_content.Text = question.question_des;
                    id.Text = (question.question_id).ToString();
                    option1.Visible = true;
                    option1.Text = question.option1;
                   
                    button2.Text = question.option2;
                    answer.Text = question.answer;
                    
                    option3.Text = question.option3;
                    option4.Visible = true;
                    option4.Text = question.option4;
                }
                else
                {
                    MessageBox.Show("Qestion Ended --)");
                }

            }

             if (flage==3) // if    question is     TF
            {
                
                var count = (from c in db.QuestionstTFs
                             where c.course_id == Course_id
                             select c).Count();
      
                if (count > index)
                {

                    index++;
                    var question = (from c in db.QuestionstTFs
                                    where c.course_id == Course_id && c.question_id == index
                                    select c).FirstOrDefault(); ;

                    q_content.Text = question.question_des;
                    id.Text = (question.question_id).ToString();
                    option1.Visible = false;
                    option4.Visible = false;
                    answer.Text = question.answer.ToString();
                    option3.Text = "True";
                    button2.Text = "False";
                     

                }
                else
                {
                    MessageBox.Show("Qestion Ended --)");
                }




            }

             if(flage==4)
            {
                var count = (from c in db.QuestionstTexts
                             where c.course_id == Course_id
                             select c).Count();
                if (count > index)
                {
                    index++;
                    var question = (from c in db.QuestionstTexts
                                    where c.course_id == Course_id && c.question_id == index
                                    select c).FirstOrDefault();
                    q_content.Text = question.question_des;
                    id.Text = (question.question_id).ToString();
                    option1.Visible = false;
                    option4.Visible = false;
                    answer.Text = question.answer.ToString();
                    option3.Visible= false;
                    button2.Visible = false;




                }
                else
                {
                    MessageBox.Show("Qestion Ended --)");
                }



            }



        }

        private void Back_Click(object sender, EventArgs e)
        {
           
            if (flage == 2)  // back in Question MCQ
            {
                var count = (from c in db.QuestionstChoices
                             where c.course_id == Course_id
                             select c).Count();
                if (index != 1)
                {
                    index--;
                    var question = (from c in db.QuestionstChoices
                                    where c.course_id == Course_id && c.question_id == index
                                    select c).FirstOrDefault(); ;

                    q_content.Text = question.question_des;
                    id.Text = (question.question_id).ToString();
                    option1.Text = question.option1;
                    button2.Text = question.option2;
                    option3.Text = question.option3;
                    option4.Text = question.option4;
                    answer.Text = question.answer.ToString();
                }
                else
                {
                    MessageBox.Show("Qestion Ended --)");
                }
            }
            if (flage == 3) // back in Question MCQ
            {

                var count = (from c in db.QuestionstTFs
                             where c.course_id == Course_id
                             select c).Count();

                if (index!=1)
                {

                    index--;
                    var question = (from c in db.QuestionstTFs
                                    where c.course_id == Course_id && c.question_id == index
                                    select c).FirstOrDefault(); ;

                    q_content.Text = question.question_des;
                    id.Text = (question.question_id).ToString();
                    option1.Visible = false;
                    option4.Visible = false;
                    option3.Text = "True";
                    button2.Text = "False";
                    answer.Text = question.answer.ToString();


                }
                else

                    MessageBox.Show("Qestion Ended --)");
            }
            if(flage==4)
            {
                var count = (from c in db.QuestionstTexts
                             where c.course_id == Course_id
                             select c).Count();
                if (index!=1)
                {
                    index--;
                    var question = (from c in db.QuestionstTexts
                                    where c.course_id == Course_id && c.question_id == index
                                    select c).FirstOrDefault();
                    q_content.Text = question.question_des;
                    id.Text = (question.question_id).ToString();
                    option1.Visible = false;
                    option4.Visible = false;
                    answer.Text = question.answer.ToString();
                    option3.Visible = false;
                    button2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Qestion Ended --)");
                }



            }
        } // click back
        private void Mcq_Click(object sender, EventArgs e) // When Mcq Click
        {
            var question = (from c in db.QuestionstChoices
                            where c.course_id == Course_id
                            select c).FirstOrDefault();
            q_content.Text = question.question_des;
            id.Text = (question.question_id).ToString();
            option1.Text = question.option1; option1.Visible = true;
            button2.Text = question.option2;
            option3.Text = question.option3;
            answer.Text=question.answer;
            option4.Text = question.option4; option4.Visible = true;
            flage = 2;
            index = 1;
        }

        private void true_false_ques_Click(object sender, EventArgs e) // when true false click
        {
           

            var question = (from c in db.QuestionstTFs
                                where c.course_id == Course_id
                            select c).FirstOrDefault(); ;

                q_content.Text = question.question_des;
                id.Text = (question.question_id).ToString();
                option1.Visible = false;
                option4.Visible = false;
                option3.Text= "True";
                button2.Text = "False";
            answer.Text =(question.answer).ToString();

            flage = 3;
            index = 1;

        }

        private void add_Click(object sender, EventArgs e) // add  Question to Exam
        {
            if (flage == 2)
            {


                try
                {


                    db.ExamQuestionsChoices.Add(new ExamQuestionsChoice()
                    {
                        exam_id = int.Parse(texexamid.Text),
                        question_des = q_content.Text,
                        option1 = option1.Text,
                        option2 = button2.Text,
                        option3 = option3.Text,
                        option4 = option4.Text,
                        answerChoice = answer.Text,
                        question_id = numq,


                        degree = 10,
                    }
                    );



                    db.SaveChanges();
                    numq++;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            if (flage == 3)
                try
                {


                    {
                        db.ExamQuestionsTFs.Add(new ExamQuestionsTF()
                        {
                            exam_id = int.Parse(texexamid.Text),
                            question_id = numq,
                            question_des = q_content.Text,
                            answerTF = bool.Parse(answer.Text),
                            degree = 5,
                        }
                        );

                        db.SaveChanges();
                        numq++;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            if(flage==4)
            {
                try
                {
                    db.ExamQuestionsTexts.Add(

                        new ExamQuestionsText()
                        {
                            question_des=q_content.Text,
                            question_id=numq,
                            answerText=answer.Text,
                            degree=15,
                            exam_id = int.Parse(texexamid.Text),
                        }
                        );
                    db.SaveChanges();
                    numq++;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

        }  
        // end the add
        private void save_Click(object sender, EventArgs e)
        {
                int examid = int.Parse(textexamid.Text);
                int intakeid = int.Parse(intkid.Text);
                int brancid = int.Parse(branchid.Text);
                int tracidd = int.Parse(tracid.Text);
                int courceid = int.Parse(idins.Text);
                int instracid = Instructor_id;
                int time = int.Parse(totaltime.Text);

                Exam ex = new Exam()
                {
                    exam_id = examid,
                    exam_type = extype.Text,
                    endTime = dateTimePicker1.Value,
                    startTime = dateTimePicker2.Value,
                    intake_id = intakeid,
                    instructor_id = instracid,
                    branch_id = brancid,
                    course_id = courceid,
                    track_id = tracidd,
                    totalTime = new TimeSpan(0, time, 0),




                };

                db.Exams.Add(ex);

                db.SaveChanges();
            
           








            }


       
        private void Delete_Click_1(object sender, EventArgs e)
        {
            //if (flage == 2)
            //{
            //    Choices.Remove(new ExamQuestionsChoice()
            //    {

            //        question_des = q_content.Text,
            //        option1 = option1.Text,
            //        option2 = button2.Text,
            //        option3 = option3.Text,
            //        option4 = option4.Text,


            //    });









            //}
            //if (flage == 3)
            //{
            //    questionsTFs.Remove(
            //        new ExamQuestionsTF()
            //        {
            //            question_des = q_content.Text,


            //        }


            //        );





            //}

        }

        

     

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            //if(istid.Text==null)
            //{
            //    MessageBox.Show("invalid id");
            //}
          
            //    int instid = int.Parse(istid.Text);
            
            
          

           
            
            //Context db = new Context();
            //var name = (from p in db.Instructors
            //            where p.instructor_id == instid  // how to take it from user
            //            select p.instructor_f_n).FirstOrDefault();
            //text_id.Text = "Welcom" + "  " + name;


            //var c = (from i in db.Courses
            //         where i.instructor_id == 1
            //         select i.course_name).FirstOrDefault();
            //showcource.Text = c;


        }

        private void details_Click(object sender, EventArgs e)
        {
            //List<AllowanceOption> allopyin = new List<AllowanceOption>();
            //AllowanceOption p1 = new AllowanceOption
            //{
            //    allowanceOption_id = 1,
            //    exam_id = 1,
            //    allowanceOption_name = "true$falde",
            //    option1 = true,
            //    option2 = false
            //};
            //AllowanceOption p2 = new AllowanceOption
            //{
            //    allowanceOption_id = 2,
            //    exam_id = 1,
            //    allowanceOption_name = "true$falde",
            //    option1 = true,
            //    option2 = false
            //};
            //allopyin.Add(p1);
            //allopyin.Add(p2);
            //db.AllowanceOptions.Add(p1);
            //db.AllowanceOptions.Add(p2);




            //List<Exam> exam1 = new List<Exam>();
            


            //DateTime start_date = Convert.ToDateTime("2-2-2022 00:00:00.000");
            //DateTime end_date = Convert.ToDateTime("12-2-2022 00:00:00.000");
            //try
            //{
            //    Exam ex = new Exam()
            //    {
            //        exam_id= int.Parse(texexamid.Text),
            //        exam_type = extype.Text,
            //        endTime = Convert.ToDateTime("exstime.Text"),
            //    startTime =  Convert.ToDateTime("endtime.Text"),
            //        intake_id =int.Parse( intkid.Text),
            //        instructor_id = 1,
            //        branch_id = int.Parse(branchid.Text),
            //        course_id = 1,
            //        track_id = int.Parse(tracid.Text),
            //        totalTime = new TimeSpan(0, 30, 0),
            //        AllowanceOptions=allopyin



            //    };
                
            //    db.Exams.Add(ex);
                
            //    db.SaveChanges();
             
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Error number: " + ex.Number + " - " + ex.Message);
            //}



           






        }



   

   



        private void ok_Click(object sender, EventArgs e)
        {
            int instid = int.Parse(istid.Text);

            Context db = new Context();
            var name = (from p in db.Instructors
                        where p.instructor_id == instid  // how to take it from user
                        select p.instructor_f_n).FirstOrDefault();
            text_id.Text = "Welcom" + "  " + name;


            var c = (from i in db.Courses
                     where i.instructor_id == instid
                     select i.course_name).FirstOrDefault();
            showcource.Text = c;

            var b = (from i in db.Courses
                     where i.instructor_id == instid
                     select i.course_id).FirstOrDefault();
            idins.Text = b.ToString();



        }

    

        private void textquest_Click(object sender, EventArgs e)
        {
            



            var question = (from c in db.QuestionstTexts
                            where c.course_id == Course_id
                            select c).FirstOrDefault();

            q_content.Text = question.question_des;
            id.Text = (question.question_id).ToString();
            option1.Visible = false;
            button2.Visible = false;
            option3.Visible = false;
            answer.Text = question.answer;
            option4.Visible = false;
            flage = 4;
            index = 1;
        }
    }
}
