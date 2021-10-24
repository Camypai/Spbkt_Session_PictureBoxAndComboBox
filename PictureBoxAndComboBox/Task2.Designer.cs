using System.ComponentModel;


namespace PictureBoxAndComboBox
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1    = new System.Windows.Forms.Label();
            this.numberTb  = new System.Windows.Forms.TextBox();
            this.calcBtn   = new System.Windows.Forms.Button();
            this.label2    = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.backBtn   = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text     = "Введите целое число";
            // 
            // numberTb
            // 
            this.numberTb.Location = new System.Drawing.Point(142, 52);
            this.numberTb.Name     = "numberTb";
            this.numberTb.Size     = new System.Drawing.Size(100, 20);
            this.numberTb.TabIndex = 1;
            // 
            // calcBtn
            // 
            this.calcBtn.Location                =  new System.Drawing.Point(248, 52);
            this.calcBtn.Name                    =  "calcBtn";
            this.calcBtn.Size                    =  new System.Drawing.Size(115, 46);
            this.calcBtn.TabIndex                =  2;
            this.calcBtn.Text                    =  "Вычислить";
            this.calcBtn.UseVisualStyleBackColor =  true;
            this.calcBtn.Click                   += new System.EventHandler(this.calcBtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name     = "label2";
            this.label2.Size     = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 3;
            this.label2.Text     = "Результат";
            // 
            // resultLbl
            // 
            this.resultLbl.Location = new System.Drawing.Point(142, 75);
            this.resultLbl.Name     = "resultLbl";
            this.resultLbl.Size     = new System.Drawing.Size(100, 23);
            this.resultLbl.TabIndex = 4;
            this.resultLbl.Text     = "?";
            // 
            // backBtn
            // 
            this.backBtn.Location                =  new System.Drawing.Point(12, 12);
            this.backBtn.Name                    =  "backBtn";
            this.backBtn.Size                    =  new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                =  5;
            this.backBtn.Text                    =  "Назад";
            this.backBtn.UseVisualStyleBackColor =  true;
            this.backBtn.Click                   += new System.EventHandler(this.backBtn_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(376, 111);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.numberTb);
            this.Controls.Add(this.label1);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   label2;
        private System.Windows.Forms.Label   resultLbl;
        private System.Windows.Forms.Button  calcBtn;
        private System.Windows.Forms.TextBox numberTb;
        private System.Windows.Forms.Button  backBtn;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label   label1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}