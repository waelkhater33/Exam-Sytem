namespace CSlProjrct_Version1
{
    partial class Deleting
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeleteByidQ = new System.Windows.Forms.TextBox();
            this.btnDeleteQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtDeleteByidQ
            // 
            this.txtDeleteByidQ.Location = new System.Drawing.Point(546, 245);
            this.txtDeleteByidQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeleteByidQ.Multiline = true;
            this.txtDeleteByidQ.Name = "txtDeleteByidQ";
            this.txtDeleteByidQ.Size = new System.Drawing.Size(127, 52);
            this.txtDeleteByidQ.TabIndex = 1;
            // 
            // btnDeleteQ
            // 
            this.btnDeleteQ.BackColor = System.Drawing.Color.Red;
            this.btnDeleteQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteQ.Location = new System.Drawing.Point(81, 572);
            this.btnDeleteQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteQ.Name = "btnDeleteQ";
            this.btnDeleteQ.Size = new System.Drawing.Size(178, 58);
            this.btnDeleteQ.TabIndex = 2;
            this.btnDeleteQ.Text = "Delete";
            this.btnDeleteQ.UseVisualStyleBackColor = false;
            this.btnDeleteQ.Click += new System.EventHandler(this.btnDeleteQ_Click);
            // 
            // Deleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 673);
            this.Controls.Add(this.btnDeleteQ);
            this.Controls.Add(this.txtDeleteByidQ);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Deleting";
            this.Text = "Deleting";
            this.Load += new System.EventHandler(this.Deleting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeleteByidQ;
        private System.Windows.Forms.Button btnDeleteQ;
    }
}