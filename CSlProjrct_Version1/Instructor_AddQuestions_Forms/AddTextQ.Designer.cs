namespace CSlProjrct_Version1
{
    partial class AddTextQ
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
            this.txtDesAddQ = new System.Windows.Forms.TextBox();
            this.txtAnswAddQ = new System.Windows.Forms.TextBox();
            this.txtCsrIDAddQ = new System.Windows.Forms.TextBox();
            this.btnAddTextQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDesAddQ
            // 
            this.txtDesAddQ.Location = new System.Drawing.Point(545, 39);
            this.txtDesAddQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDesAddQ.Multiline = true;
            this.txtDesAddQ.Name = "txtDesAddQ";
            this.txtDesAddQ.Size = new System.Drawing.Size(708, 169);
            this.txtDesAddQ.TabIndex = 1;
            // 
            // txtAnswAddQ
            // 
            this.txtAnswAddQ.Location = new System.Drawing.Point(545, 251);
            this.txtAnswAddQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnswAddQ.Multiline = true;
            this.txtAnswAddQ.Name = "txtAnswAddQ";
            this.txtAnswAddQ.Size = new System.Drawing.Size(708, 192);
            this.txtAnswAddQ.TabIndex = 2;
            // 
            // txtCsrIDAddQ
            // 
            this.txtCsrIDAddQ.Location = new System.Drawing.Point(545, 476);
            this.txtCsrIDAddQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCsrIDAddQ.Multiline = true;
            this.txtCsrIDAddQ.Name = "txtCsrIDAddQ";
            this.txtCsrIDAddQ.Size = new System.Drawing.Size(150, 67);
            this.txtCsrIDAddQ.TabIndex = 3;
            // 
            // btnAddTextQ
            // 
            this.btnAddTextQ.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddTextQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTextQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTextQ.Location = new System.Drawing.Point(43, 607);
            this.btnAddTextQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTextQ.Name = "btnAddTextQ";
            this.btnAddTextQ.Size = new System.Drawing.Size(184, 47);
            this.btnAddTextQ.TabIndex = 4;
            this.btnAddTextQ.Text = "Add";
            this.btnAddTextQ.UseVisualStyleBackColor = false;
            this.btnAddTextQ.Click += new System.EventHandler(this.btnAddTextQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Question Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 525);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course ID:";
            // 
            // AddTextQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddTextQ);
            this.Controls.Add(this.txtCsrIDAddQ);
            this.Controls.Add(this.txtAnswAddQ);
            this.Controls.Add(this.txtDesAddQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddTextQ";
            this.Text = "Add Text Question";
            this.Load += new System.EventHandler(this.AddTextQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDesAddQ;
        private System.Windows.Forms.TextBox txtAnswAddQ;
        private System.Windows.Forms.TextBox txtCsrIDAddQ;
        private System.Windows.Forms.Button btnAddTextQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}