namespace CSlProjrct_Version1
{
    partial class UpdatingTextQ
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
            this.txtUpdateByIdQ = new System.Windows.Forms.TextBox();
            this.txtUpdateDesQ = new System.Windows.Forms.TextBox();
            this.txtUpdateAnswQ = new System.Windows.Forms.TextBox();
            this.btnUpdateTextQ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUpdateByIdQ
            // 
            this.txtUpdateByIdQ.Location = new System.Drawing.Point(619, 37);
            this.txtUpdateByIdQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateByIdQ.Multiline = true;
            this.txtUpdateByIdQ.Name = "txtUpdateByIdQ";
            this.txtUpdateByIdQ.Size = new System.Drawing.Size(144, 49);
            this.txtUpdateByIdQ.TabIndex = 0;
            // 
            // txtUpdateDesQ
            // 
            this.txtUpdateDesQ.Location = new System.Drawing.Point(619, 151);
            this.txtUpdateDesQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateDesQ.Multiline = true;
            this.txtUpdateDesQ.Name = "txtUpdateDesQ";
            this.txtUpdateDesQ.Size = new System.Drawing.Size(493, 134);
            this.txtUpdateDesQ.TabIndex = 1;
            // 
            // txtUpdateAnswQ
            // 
            this.txtUpdateAnswQ.Location = new System.Drawing.Point(619, 353);
            this.txtUpdateAnswQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateAnswQ.Multiline = true;
            this.txtUpdateAnswQ.Name = "txtUpdateAnswQ";
            this.txtUpdateAnswQ.Size = new System.Drawing.Size(493, 128);
            this.txtUpdateAnswQ.TabIndex = 2;
            // 
            // btnUpdateTextQ
            // 
            this.btnUpdateTextQ.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateTextQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTextQ.Location = new System.Drawing.Point(42, 574);
            this.btnUpdateTextQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateTextQ.Name = "btnUpdateTextQ";
            this.btnUpdateTextQ.Size = new System.Drawing.Size(202, 66);
            this.btnUpdateTextQ.TabIndex = 3;
            this.btnUpdateTextQ.Text = "Update";
            this.btnUpdateTextQ.UseVisualStyleBackColor = false;
            this.btnUpdateTextQ.Click += new System.EventHandler(this.btnUpdateTextQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer:";
            // 
            // UpdatingTextQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateTextQ);
            this.Controls.Add(this.txtUpdateAnswQ);
            this.Controls.Add(this.txtUpdateDesQ);
            this.Controls.Add(this.txtUpdateByIdQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpdatingTextQ";
            this.Text = "Updating Text Question";
            this.Load += new System.EventHandler(this.UpdatingTextQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdateByIdQ;
        private System.Windows.Forms.TextBox txtUpdateDesQ;
        private System.Windows.Forms.TextBox txtUpdateAnswQ;
        private System.Windows.Forms.Button btnUpdateTextQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}