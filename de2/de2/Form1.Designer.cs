namespace de2
{
    partial class Form1
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
            this.lbht = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtchieucao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbht
            // 
            this.lbht.AutoSize = true;
            this.lbht.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbht.Location = new System.Drawing.Point(318, 65);
            this.lbht.Name = "lbht";
            this.lbht.Size = new System.Drawing.Size(49, 14);
            this.lbht.TabIndex = 0;
            this.lbht.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtchieucao
            // 
            this.txtchieucao.Location = new System.Drawing.Point(144, 46);
            this.txtchieucao.Name = "txtchieucao";
            this.txtchieucao.Size = new System.Drawing.Size(100, 20);
            this.txtchieucao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chiều cao:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtchieucao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbht;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtchieucao;
        private System.Windows.Forms.Label label2;
    }
}

