namespace thuchanhtrenlop
{
    partial class bai1
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.lbketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(100, 57);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 1;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(100, 116);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(75, 23);
            this.btnhienthi.TabIndex = 2;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbketqua.Location = new System.Drawing.Point(283, 60);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(69, 20);
            this.lbketqua.TabIndex = 3;
            this.lbketqua.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 228);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Label lbketqua;
    }
}

