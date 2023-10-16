namespace belge_durum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.txtZayif = new System.Windows.Forms.TextBox();
            this.txtDevamsızlık = new System.Windows.Forms.TextBox();
            this.btnDurumGoster = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "not ortalaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "zayıf sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "devamsızlık sayısı";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(291, 66);
            this.txtOrtalama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(190, 26);
            this.txtOrtalama.TabIndex = 3;
            // 
            // txtZayif
            // 
            this.txtZayif.Location = new System.Drawing.Point(242, 129);
            this.txtZayif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZayif.Name = "txtZayif";
            this.txtZayif.Size = new System.Drawing.Size(198, 26);
            this.txtZayif.TabIndex = 4;
            // 
            // txtDevamsızlık
            // 
            this.txtDevamsızlık.Location = new System.Drawing.Point(292, 195);
            this.txtDevamsızlık.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDevamsızlık.Name = "txtDevamsızlık";
            this.txtDevamsızlık.Size = new System.Drawing.Size(163, 26);
            this.txtDevamsızlık.TabIndex = 5;
            // 
            // btnDurumGoster
            // 
            this.btnDurumGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGoster.Location = new System.Drawing.Point(152, 263);
            this.btnDurumGoster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDurumGoster.Name = "btnDurumGoster";
            this.btnDurumGoster.Size = new System.Drawing.Size(231, 82);
            this.btnDurumGoster.TabIndex = 6;
            this.btnDurumGoster.Text = "belge durum göster";
            this.btnDurumGoster.UseVisualStyleBackColor = true;
            this.btnDurumGoster.Click += new System.EventHandler(this.btnDurumGoster_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(87, 372);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(59, 20);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "durum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 445);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnDurumGoster);
            this.Controls.Add(this.txtDevamsızlık);
            this.Controls.Add(this.txtZayif);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.TextBox txtZayif;
        private System.Windows.Forms.TextBox txtDevamsızlık;
        private System.Windows.Forms.Button btnDurumGoster;
        private System.Windows.Forms.Label lblDurum;
    }
}

