using System.Windows.Forms;

namespace CSlProjrct_Version1
{
    partial class instractorform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instractorform));
            this.inst_name = new System.Windows.Forms.Panel();
            this.idins = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showcource = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.textquest = new System.Windows.Forms.Button();
            this.true_false_ques = new System.Windows.Forms.Button();
            this.Mcq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Degree = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textexamid = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.totaltime = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.branchid = new System.Windows.Forms.TextBox();
            this.ff = new System.Windows.Forms.Button();
            this.texexamid = new System.Windows.Forms.TextBox();
            this.tracid = new System.Windows.Forms.TextBox();
            this.trakid = new System.Windows.Forms.Button();
            this.intakid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.start_time = new System.Windows.Forms.Button();
            this.examtype = new System.Windows.Forms.Button();
            this.examid = new System.Windows.Forms.Button();
            this.extype = new System.Windows.Forms.TextBox();
            this.intkid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.ADDD = new System.Windows.Forms.Button();
            this.option4 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Button();
            this.q_content = new System.Windows.Forms.Button();
            this.idinst = new System.Windows.Forms.Label();
            this.istid = new System.Windows.Forms.TextBox();
            this.inst_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.Degree.SuspendLayout();
            this.SuspendLayout();
            // 
            // inst_name
            // 
            this.inst_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inst_name.BackgroundImage")));
            this.inst_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inst_name.Controls.Add(this.istid);
            this.inst_name.Controls.Add(this.idins);
            this.inst_name.Controls.Add(this.ok);
            this.inst_name.Controls.Add(this.label2);
            this.inst_name.Controls.Add(this.idinst);
            this.inst_name.Controls.Add(this.showcource);
            this.inst_name.Controls.Add(this.text_id);
            this.inst_name.Controls.Add(this.textquest);
            this.inst_name.Controls.Add(this.true_false_ques);
            this.inst_name.Controls.Add(this.Mcq);
            this.inst_name.Controls.Add(this.label1);
            this.inst_name.Controls.Add(this.logo);
            this.inst_name.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.inst_name.Location = new System.Drawing.Point(0, 0);
            this.inst_name.Name = "inst_name";
            this.inst_name.Size = new System.Drawing.Size(236, 666);
            this.inst_name.TabIndex = 0;
            // 
            // idins
            // 
            this.idins.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.idins.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.idins.ForeColor = System.Drawing.Color.Black;
            this.idins.Location = new System.Drawing.Point(168, 244);
            this.idins.Name = "idins";
            this.idins.Size = new System.Drawing.Size(65, 41);
            this.idins.TabIndex = 23;
            this.idins.Text = "id";
            this.idins.UseVisualStyleBackColor = false;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ok.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.ok.ForeColor = System.Drawing.Color.Black;
            this.ok.Location = new System.Drawing.Point(63, 290);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(65, 53);
            this.ok.TabIndex = 21;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(10, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter Couce Id";
            // 
            // showcource
            // 
            this.showcource.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showcource.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.showcource.ForeColor = System.Drawing.Color.Black;
            this.showcource.Location = new System.Drawing.Point(107, 348);
            this.showcource.Name = "showcource";
            this.showcource.Size = new System.Drawing.Size(105, 65);
            this.showcource.TabIndex = 16;
            this.showcource.Text = "V#";
            this.showcource.UseVisualStyleBackColor = false;
            this.showcource.Click += new System.EventHandler(this.showcource_Click);
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.text_id.Location = new System.Drawing.Point(13, 154);
            this.text_id.Multiline = true;
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(220, 40);
            this.text_id.TabIndex = 15;
            this.text_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textquest
            // 
            this.textquest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textquest.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.textquest.ForeColor = System.Drawing.Color.Black;
            this.textquest.Location = new System.Drawing.Point(34, 572);
            this.textquest.Name = "textquest";
            this.textquest.Size = new System.Drawing.Size(177, 65);
            this.textquest.TabIndex = 5;
            this.textquest.Text = "Text  Question";
            this.textquest.UseVisualStyleBackColor = false;
            this.textquest.Click += new System.EventHandler(this.textquest_Click);
            // 
            // true_false_ques
            // 
            this.true_false_ques.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.true_false_ques.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.true_false_ques.ForeColor = System.Drawing.Color.Black;
            this.true_false_ques.Location = new System.Drawing.Point(34, 502);
            this.true_false_ques.Name = "true_false_ques";
            this.true_false_ques.Size = new System.Drawing.Size(177, 65);
            this.true_false_ques.TabIndex = 4;
            this.true_false_ques.Text = "True&False";
            this.true_false_ques.UseVisualStyleBackColor = false;
            this.true_false_ques.Click += new System.EventHandler(this.true_false_ques_Click);
            // 
            // Mcq
            // 
            this.Mcq.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mcq.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.Mcq.ForeColor = System.Drawing.Color.Black;
            this.Mcq.Location = new System.Drawing.Point(34, 432);
            this.Mcq.Name = "Mcq";
            this.Mcq.Size = new System.Drawing.Size(177, 65);
            this.Mcq.TabIndex = 3;
            this.Mcq.Text = "MCQ";
            this.Mcq.UseVisualStyleBackColor = false;
            this.Mcq.Click += new System.EventHandler(this.Mcq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(34, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cource";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(34, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(157, 138);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Degree
            // 
            this.Degree.BackColor = System.Drawing.Color.Transparent;
            this.Degree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Degree.Controls.Add(this.label3);
            this.Degree.Controls.Add(this.textexamid);
            this.Degree.Controls.Add(this.button5);
            this.Degree.Controls.Add(this.answer);
            this.Degree.Controls.Add(this.dateTimePicker2);
            this.Degree.Controls.Add(this.dateTimePicker1);
            this.Degree.Controls.Add(this.totaltime);
            this.Degree.Controls.Add(this.button4);
            this.Degree.Controls.Add(this.branchid);
            this.Degree.Controls.Add(this.ff);
            this.Degree.Controls.Add(this.texexamid);
            this.Degree.Controls.Add(this.tracid);
            this.Degree.Controls.Add(this.trakid);
            this.Degree.Controls.Add(this.intakid);
            this.Degree.Controls.Add(this.button1);
            this.Degree.Controls.Add(this.start_time);
            this.Degree.Controls.Add(this.examtype);
            this.Degree.Controls.Add(this.examid);
            this.Degree.Controls.Add(this.extype);
            this.Degree.Controls.Add(this.intkid);
            this.Degree.Controls.Add(this.button3);
            this.Degree.Controls.Add(this.save);
            this.Degree.Controls.Add(this.Back);
            this.Degree.Controls.Add(this.next);
            this.Degree.Controls.Add(this.ADDD);
            this.Degree.Controls.Add(this.option4);
            this.Degree.Controls.Add(this.option3);
            this.Degree.Controls.Add(this.button2);
            this.Degree.Controls.Add(this.option1);
            this.Degree.Controls.Add(this.id);
            this.Degree.Controls.Add(this.q_content);
            this.Degree.Location = new System.Drawing.Point(309, 96);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(944, 570);
            this.Degree.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(355, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Question Answer";
            // 
            // textexamid
            // 
            this.textexamid.Location = new System.Drawing.Point(135, 14);
            this.textexamid.Name = "textexamid";
            this.textexamid.Size = new System.Drawing.Size(30, 20);
            this.textexamid.TabIndex = 38;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 34);
            this.button5.TabIndex = 37;
            this.button5.Text = "Exam ID";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.answer.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.answer.ForeColor = System.Drawing.Color.Black;
            this.answer.Location = new System.Drawing.Point(528, 327);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(144, 54);
            this.answer.TabIndex = 36;
            this.answer.Text = "answer";
            this.answer.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(355, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(355, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // totaltime
            // 
            this.totaltime.Location = new System.Drawing.Point(697, 11);
            this.totaltime.Name = "totaltime";
            this.totaltime.Size = new System.Drawing.Size(86, 20);
            this.totaltime.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(569, -3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 34);
            this.button4.TabIndex = 32;
            this.button4.Text = "Total-time";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // branchid
            // 
            this.branchid.Location = new System.Drawing.Point(387, 120);
            this.branchid.Name = "branchid";
            this.branchid.Size = new System.Drawing.Size(30, 20);
            this.branchid.TabIndex = 31;
            // 
            // ff
            // 
            this.ff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ff.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.ff.ForeColor = System.Drawing.Color.Black;
            this.ff.Location = new System.Drawing.Point(238, 109);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(111, 34);
            this.ff.TabIndex = 30;
            this.ff.Text = "branchid";
            this.ff.UseVisualStyleBackColor = false;
            // 
            // texexamid
            // 
            this.texexamid.Location = new System.Drawing.Point(118, 501);
            this.texexamid.Name = "texexamid";
            this.texexamid.Size = new System.Drawing.Size(30, 20);
            this.texexamid.TabIndex = 29;
            // 
            // tracid
            // 
            this.tracid.Location = new System.Drawing.Point(135, 137);
            this.tracid.Name = "tracid";
            this.tracid.Size = new System.Drawing.Size(30, 20);
            this.tracid.TabIndex = 28;
            this.tracid.Text = " ";
            // 
            // trakid
            // 
            this.trakid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trakid.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.trakid.ForeColor = System.Drawing.Color.Black;
            this.trakid.Location = new System.Drawing.Point(3, 129);
            this.trakid.Name = "trakid";
            this.trakid.Size = new System.Drawing.Size(111, 34);
            this.trakid.TabIndex = 27;
            this.trakid.Text = "trake_id";
            this.trakid.UseVisualStyleBackColor = false;
            // 
            // intakid
            // 
            this.intakid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.intakid.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.intakid.ForeColor = System.Drawing.Color.Black;
            this.intakid.Location = new System.Drawing.Point(0, 90);
            this.intakid.Name = "intakid";
            this.intakid.Size = new System.Drawing.Size(111, 34);
            this.intakid.TabIndex = 26;
            this.intakid.Text = "intake_id";
            this.intakid.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(238, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "End-time";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // start_time
            // 
            this.start_time.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_time.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.start_time.ForeColor = System.Drawing.Color.Black;
            this.start_time.Location = new System.Drawing.Point(238, -3);
            this.start_time.Name = "start_time";
            this.start_time.Size = new System.Drawing.Size(111, 34);
            this.start_time.TabIndex = 22;
            this.start_time.Text = "start-time";
            this.start_time.UseVisualStyleBackColor = false;
            // 
            // examtype
            // 
            this.examtype.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.examtype.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.examtype.ForeColor = System.Drawing.Color.Black;
            this.examtype.Location = new System.Drawing.Point(-9, 39);
            this.examtype.Name = "examtype";
            this.examtype.Size = new System.Drawing.Size(111, 34);
            this.examtype.TabIndex = 21;
            this.examtype.Text = "Exam Type";
            this.examtype.UseVisualStyleBackColor = false;
            // 
            // examid
            // 
            this.examid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.examid.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.examid.ForeColor = System.Drawing.Color.Black;
            this.examid.Location = new System.Drawing.Point(15, 490);
            this.examid.Name = "examid";
            this.examid.Size = new System.Drawing.Size(96, 34);
            this.examid.TabIndex = 20;
            this.examid.Text = "Exam id";
            this.examid.UseVisualStyleBackColor = false;
            // 
            // extype
            // 
            this.extype.Location = new System.Drawing.Point(118, 50);
            this.extype.Name = "extype";
            this.extype.Size = new System.Drawing.Size(86, 20);
            this.extype.TabIndex = 16;
            // 
            // intkid
            // 
            this.intkid.Location = new System.Drawing.Point(142, 104);
            this.intkid.Name = "intkid";
            this.intkid.Size = new System.Drawing.Size(30, 20);
            this.intkid.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(857, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 55);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.ForestGreen;
            this.save.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(577, 89);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(151, 68);
            this.save.TabIndex = 14;
            this.save.Text = "Save Exam";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back.BackgroundImage")));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(216, 400);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(89, 47);
            this.Back.TabIndex = 13;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.next.ForeColor = System.Drawing.Color.Black;
            this.next.Location = new System.Drawing.Point(367, 396);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(87, 50);
            this.next.TabIndex = 12;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // ADDD
            // 
            this.ADDD.BackColor = System.Drawing.Color.DodgerBlue;
            this.ADDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ADDD.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.ADDD.ForeColor = System.Drawing.Color.Black;
            this.ADDD.Location = new System.Drawing.Point(186, 466);
            this.ADDD.Name = "ADDD";
            this.ADDD.Size = new System.Drawing.Size(190, 80);
            this.ADDD.TabIndex = 11;
            this.ADDD.Text = "Add";
            this.ADDD.UseVisualStyleBackColor = false;
            this.ADDD.Click += new System.EventHandler(this.add_Click);
            // 
            // option4
            // 
            this.option4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.option4.Font = new System.Drawing.Font("Simplified Arabic", 15.75F, System.Drawing.FontStyle.Bold);
            this.option4.ForeColor = System.Drawing.Color.Black;
            this.option4.Location = new System.Drawing.Point(545, 268);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(90, 54);
            this.option4.TabIndex = 9;
            this.option4.Text = "option4";
            this.option4.UseVisualStyleBackColor = false;
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.option3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.option3.ForeColor = System.Drawing.Color.Black;
            this.option3.Location = new System.Drawing.Point(414, 268);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(100, 54);
            this.option3.TabIndex = 8;
            this.option3.Text = "option3";
            this.option3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(278, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "option2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.option1.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.option1.ForeColor = System.Drawing.Color.Black;
            this.option1.Location = new System.Drawing.Point(159, 268);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(95, 54);
            this.option1.TabIndex = 6;
            this.option1.Text = "option1";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.Location = new System.Drawing.Point(-9, 167);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(65, 53);
            this.id.TabIndex = 4;
            this.id.Text = "v";
            this.id.UseVisualStyleBackColor = false;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // q_content
            // 
            this.q_content.BackColor = System.Drawing.Color.Transparent;
            this.q_content.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold);
            this.q_content.ForeColor = System.Drawing.Color.Black;
            this.q_content.Location = new System.Drawing.Point(47, 167);
            this.q_content.Name = "q_content";
            this.q_content.Size = new System.Drawing.Size(769, 53);
            this.q_content.TabIndex = 4;
            this.q_content.Text = "content";
            this.q_content.UseVisualStyleBackColor = false;
            this.q_content.Click += new System.EventHandler(this.q_content_Click);
            // 
            // idinst
            // 
            this.idinst.AutoSize = true;
            this.idinst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.idinst.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.idinst.Location = new System.Drawing.Point(10, 211);
            this.idinst.Name = "idinst";
            this.idinst.Size = new System.Drawing.Size(131, 18);
            this.idinst.TabIndex = 18;
            this.idinst.Text = "Enter Your ID";
            // 
            // istid
            // 
            this.istid.Location = new System.Drawing.Point(168, 206);
            this.istid.Name = "istid";
            this.istid.Size = new System.Drawing.Size(64, 27);
            this.istid.TabIndex = 37;
            this.istid.Text = " ";
            // 
            // instractorform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.ControlBox = false;
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.inst_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "instractorform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instractorform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.instractorform_Load);
            this.inst_name.ResumeLayout(false);
            this.inst_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.Degree.ResumeLayout(false);
            this.Degree.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel inst_name;
        private Panel Degree;
        private PictureBox logo;
        private Button Mcq;
        private Label label1;
        private Button id;
        private Button q_content;
        private Button true_false_ques;
        private Button textquest;
        private Button option4;
        private Button option3;
        private Button button2;
        private Button option1;
        private Button save;
        private Button Back;
        private Button next;
        private Button ADDD;
        private Button button3;
        private TextBox text_id;
        private Button showcource;
        private TextBox extype;
        private TextBox intkid;
        private Button examtype;
        private Button examid;
        private Button start_time;
        private Button button1;
        private Button intakid;
        private TextBox branchid;
        private Button ff;
        private TextBox texexamid;
        private TextBox tracid;
        private Button trakid;
        private TextBox totaltime;
        private Button button4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button answer;
        private Label label2;
        private Button ok;
        private Button idins;
        private TextBox textexamid;
        private Button button5;
        private Label label3;
        private TextBox istid;
        private Label idinst;
    }
}