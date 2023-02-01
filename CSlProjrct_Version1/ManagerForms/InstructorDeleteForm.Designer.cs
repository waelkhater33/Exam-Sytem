namespace CSlProjrct_Version1
{
    partial class InstructorDeleteForm
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
            this.txt_del = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_del
            // 
            this.txt_del.Location = new System.Drawing.Point(236, 104);
            this.txt_del.Name = "txt_del";
            this.txt_del.Size = new System.Drawing.Size(100, 20);
            this.txt_del.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intructor ID :";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(226, 182);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(127, 40);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // InstructorDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_del);
            this.Name = "InstructorDeleteForm";
            this.Text = "InstructorDeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
    }
}