namespace CSlProjrct_Version1
{
    partial class UpatingTandFQ
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
            this.btnUpdateTfQ = new System.Windows.Forms.Button();
            this.txtUpdateByIDQ = new System.Windows.Forms.TextBox();
            this.txtUpdateDesQ = new System.Windows.Forms.TextBox();
            this.TxtUpdateAnswQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateTfQ
            // 
            this.btnUpdateTfQ.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateTfQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTfQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateTfQ.Location = new System.Drawing.Point(48, 554);
            this.btnUpdateTfQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateTfQ.Name = "btnUpdateTfQ";
            this.btnUpdateTfQ.Size = new System.Drawing.Size(168, 53);
            this.btnUpdateTfQ.TabIndex = 0;
            this.btnUpdateTfQ.Text = "Update";
            this.btnUpdateTfQ.UseVisualStyleBackColor = false;
            this.btnUpdateTfQ.Click += new System.EventHandler(this.btnUpdateTfQ_Click);
            // 
            // txtUpdateByIDQ
            // 
            this.txtUpdateByIDQ.Location = new System.Drawing.Point(537, 41);
            this.txtUpdateByIDQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateByIDQ.Multiline = true;
            this.txtUpdateByIDQ.Name = "txtUpdateByIDQ";
            this.txtUpdateByIDQ.Size = new System.Drawing.Size(178, 48);
            this.txtUpdateByIDQ.TabIndex = 1;
            // 
            // txtUpdateDesQ
            // 
            this.txtUpdateDesQ.Location = new System.Drawing.Point(537, 116);
            this.txtUpdateDesQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUpdateDesQ.Multiline = true;
            this.txtUpdateDesQ.Name = "txtUpdateDesQ";
            this.txtUpdateDesQ.Size = new System.Drawing.Size(504, 173);
            this.txtUpdateDesQ.TabIndex = 2;
            // 
            // TxtUpdateAnswQ
            // 
            this.TxtUpdateAnswQ.Location = new System.Drawing.Point(537, 354);
            this.TxtUpdateAnswQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtUpdateAnswQ.Multiline = true;
            this.TxtUpdateAnswQ.Name = "TxtUpdateAnswQ";
            this.TxtUpdateAnswQ.Size = new System.Drawing.Size(178, 51);
            this.TxtUpdateAnswQ.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Question Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer:";
            // 
            // UpatingTandFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUpdateAnswQ);
            this.Controls.Add(this.txtUpdateDesQ);
            this.Controls.Add(this.txtUpdateByIDQ);
            this.Controls.Add(this.btnUpdateTfQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UpatingTandFQ";
            this.Text = "UpatingTandFQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateTfQ;
        private System.Windows.Forms.TextBox txtUpdateByIDQ;
        private System.Windows.Forms.TextBox txtUpdateDesQ;
        private System.Windows.Forms.TextBox TxtUpdateAnswQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}