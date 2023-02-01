namespace CSlProjrct_Version1
{
    partial class EditAllQuetions
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
            this.comBoxAddSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedItem = new System.Windows.Forms.Label();
            this.ConnnetToAdd = new System.Windows.Forms.Button();
            this.btnUpdateQ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_backtoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comBoxAddSelect
            // 
            this.comBoxAddSelect.FormattingEnabled = true;
            this.comBoxAddSelect.Items.AddRange(new object[] {
            "Choices",
            "True And False",
            "Text"});
            this.comBoxAddSelect.Location = new System.Drawing.Point(378, 70);
            this.comBoxAddSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comBoxAddSelect.Name = "comBoxAddSelect";
            this.comBoxAddSelect.Size = new System.Drawing.Size(306, 23);
            this.comBoxAddSelect.TabIndex = 0;
            this.comBoxAddSelect.SelectedIndexChanged += new System.EventHandler(this.comBoxAddSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Questoin Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectedItem
            // 
            this.SelectedItem.AutoSize = true;
            this.SelectedItem.Location = new System.Drawing.Point(562, 183);
            this.SelectedItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(15, 15);
            this.SelectedItem.TabIndex = 3;
            this.SelectedItem.Text = "?";
            // 
            // ConnnetToAdd
            // 
            this.ConnnetToAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.ConnnetToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnnetToAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnnetToAdd.Location = new System.Drawing.Point(24, 594);
            this.ConnnetToAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConnnetToAdd.Name = "ConnnetToAdd";
            this.ConnnetToAdd.Size = new System.Drawing.Size(410, 67);
            this.ConnnetToAdd.TabIndex = 4;
            this.ConnnetToAdd.Text = "Add";
            this.ConnnetToAdd.UseVisualStyleBackColor = false;
            this.ConnnetToAdd.Click += new System.EventHandler(this.ConnnetToAdd_Click);
            // 
            // btnUpdateQ
            // 
            this.btnUpdateQ.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateQ.Location = new System.Drawing.Point(464, 594);
            this.btnUpdateQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateQ.Name = "btnUpdateQ";
            this.btnUpdateQ.Size = new System.Drawing.Size(411, 67);
            this.btnUpdateQ.TabIndex = 5;
            this.btnUpdateQ.Text = "updating";
            this.btnUpdateQ.UseVisualStyleBackColor = false;
            this.btnUpdateQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(911, 594);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(364, 67);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_backtoHome
            // 
            this.btn_backtoHome.Location = new System.Drawing.Point(1011, 44);
            this.btn_backtoHome.Name = "btn_backtoHome";
            this.btn_backtoHome.Size = new System.Drawing.Size(208, 37);
            this.btn_backtoHome.TabIndex = 7;
            this.btn_backtoHome.Text = " Home Page";
            this.btn_backtoHome.UseVisualStyleBackColor = true;
            this.btn_backtoHome.Click += new System.EventHandler(this.btn_backtoHome_Click);
            // 
            // EditAllQuetions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.btn_backtoHome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdateQ);
            this.Controls.Add(this.ConnnetToAdd);
            this.Controls.Add(this.SelectedItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxAddSelect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditAllQuetions";
            this.Text = "Edit All Quetions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditAllQuetions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxAddSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedItem;
        private System.Windows.Forms.Button ConnnetToAdd;
        private System.Windows.Forms.Button btnUpdateQ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_backtoHome;
    }
}