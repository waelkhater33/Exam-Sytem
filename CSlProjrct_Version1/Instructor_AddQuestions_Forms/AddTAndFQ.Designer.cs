namespace CSlProjrct_Version1
{
    partial class AddTAndFQ
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
            this.txtDesTfQ = new System.Windows.Forms.TextBox();
            this.txtAnswTfQ = new System.Windows.Forms.TextBox();
            this.txtCrsIdTfQ = new System.Windows.Forms.TextBox();
            this.btnAddTfQ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDesTfQ
            // 
            this.txtDesTfQ.Location = new System.Drawing.Point(642, 95);
            this.txtDesTfQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDesTfQ.Multiline = true;
            this.txtDesTfQ.Name = "txtDesTfQ";
            this.txtDesTfQ.Size = new System.Drawing.Size(508, 157);
            this.txtDesTfQ.TabIndex = 1;
            // 
            // txtAnswTfQ
            // 
            this.txtAnswTfQ.Location = new System.Drawing.Point(642, 361);
            this.txtAnswTfQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAnswTfQ.Multiline = true;
            this.txtAnswTfQ.Name = "txtAnswTfQ";
            this.txtAnswTfQ.Size = new System.Drawing.Size(184, 74);
            this.txtAnswTfQ.TabIndex = 2;
            // 
            // txtCrsIdTfQ
            // 
            this.txtCrsIdTfQ.Location = new System.Drawing.Point(642, 537);
            this.txtCrsIdTfQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCrsIdTfQ.Multiline = true;
            this.txtCrsIdTfQ.Name = "txtCrsIdTfQ";
            this.txtCrsIdTfQ.Size = new System.Drawing.Size(184, 68);
            this.txtCrsIdTfQ.TabIndex = 3;
            // 
            // btnAddTfQ
            // 
            this.btnAddTfQ.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddTfQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTfQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTfQ.Location = new System.Drawing.Point(49, 644);
            this.btnAddTfQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTfQ.Name = "btnAddTfQ";
            this.btnAddTfQ.Size = new System.Drawing.Size(222, 53);
            this.btnAddTfQ.TabIndex = 4;
            this.btnAddTfQ.Text = "Add";
            this.btnAddTfQ.UseVisualStyleBackColor = false;
            this.btnAddTfQ.Click += new System.EventHandler(this.btnAddTfQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 587);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Course ID:";
            // 
            // AddTAndFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 736);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTfQ);
            this.Controls.Add(this.txtCrsIdTfQ);
            this.Controls.Add(this.txtAnswTfQ);
            this.Controls.Add(this.txtDesTfQ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddTAndFQ";
            this.Text = "Add TF Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDesTfQ;
        private System.Windows.Forms.TextBox txtAnswTfQ;
        private System.Windows.Forms.TextBox txtCrsIdTfQ;
        private System.Windows.Forms.Button btnAddTfQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}