namespace IntroCsharpCollectSingleDoubleNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelShowPanel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOddNumber = new System.Windows.Forms.TextBox();
            this.labelWarningP2 = new System.Windows.Forms.Label();
            this.buttonShowSum = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDoubleNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelShowPanel);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxOddNumber);
            this.groupBox2.Controls.Add(this.labelWarningP2);
            this.groupBox2.Controls.Add(this.buttonShowSum);
            this.groupBox2.Controls.Add(this.textBoxNumber);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxDoubleNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 200);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tek ve Çift Sayıları Toplatma/Collecting Single and Double Numbers";
            // 
            // labelShowPanel
            // 
            this.labelShowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelShowPanel.Location = new System.Drawing.Point(343, 31);
            this.labelShowPanel.Name = "labelShowPanel";
            this.labelShowPanel.Size = new System.Drawing.Size(74, 85);
            this.labelShowPanel.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tek Sayıların Toplamı:/Sum of Odd Numbers:";
            // 
            // textBoxOddNumber
            // 
            this.textBoxOddNumber.Location = new System.Drawing.Point(171, 82);
            this.textBoxOddNumber.Name = "textBoxOddNumber";
            this.textBoxOddNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxOddNumber.TabIndex = 17;
            // 
            // labelWarningP2
            // 
            this.labelWarningP2.Location = new System.Drawing.Point(6, 174);
            this.labelWarningP2.Name = "labelWarningP2";
            this.labelWarningP2.Size = new System.Drawing.Size(427, 17);
            this.labelWarningP2.TabIndex = 16;
            this.labelWarningP2.Text = "Henüz Hesaplanmadı/Not yet calculated";
            this.labelWarningP2.Visible = false;
            // 
            // buttonShowSum
            // 
            this.buttonShowSum.Location = new System.Drawing.Point(171, 52);
            this.buttonShowSum.Name = "buttonShowSum";
            this.buttonShowSum.Size = new System.Drawing.Size(150, 24);
            this.buttonShowSum.TabIndex = 14;
            this.buttonShowSum.Text = "Göster-Topla/Show-Additon";
            this.buttonShowSum.UseVisualStyleBackColor = true;
            this.buttonShowSum.Click += new System.EventHandler(this.buttonShowSum_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(190, 26);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Çift Sayıların Toplamı:/Sum of Double Numbers:";
            // 
            // textBoxDoubleNumber
            // 
            this.textBoxDoubleNumber.Location = new System.Drawing.Point(171, 113);
            this.textBoxDoubleNumber.Name = "textBoxDoubleNumber";
            this.textBoxDoubleNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoubleNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(43, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sayı Giriniz / Enter number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 200);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tek ve Çift Sayıları Toplatma/Collecting Single and Double Numbers";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelShowPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOddNumber;
        private System.Windows.Forms.Label labelWarningP2;
        private System.Windows.Forms.Button buttonShowSum;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDoubleNumber;
        private System.Windows.Forms.Label label5;
    }
}

