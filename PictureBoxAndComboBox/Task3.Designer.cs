using System.ComponentModel;


namespace PictureBoxAndComboBox
{
    partial class Task3
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
            this.backBtn   = new System.Windows.Forms.Button();
            this.seasonPb  = new System.Windows.Forms.PictureBox();
            this.seasonCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.seasonPb)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location                =  new System.Drawing.Point(12, 12);
            this.backBtn.Name                    =  "backBtn";
            this.backBtn.Size                    =  new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                =  0;
            this.backBtn.Text                    =  "Назад";
            this.backBtn.UseVisualStyleBackColor =  true;
            this.backBtn.Click                   += new System.EventHandler(this.backBtn_Click);
            // 
            // seasonPb
            // 
            this.seasonPb.Location = new System.Drawing.Point(139, 95);
            this.seasonPb.Name     = "seasonPb";
            this.seasonPb.Size     = new System.Drawing.Size(649, 343);
            this.seasonPb.TabIndex = 4;
            this.seasonPb.TabStop  = false;
            // 
            // seasonCmb
            // 
            this.seasonCmb.FormattingEnabled = true;
            this.seasonCmb.Items.AddRange(new object[] { "Зима", "Весна", "Лето", "Осень" });
            this.seasonCmb.Location             =  new System.Drawing.Point(12, 95);
            this.seasonCmb.Name                 =  "seasonCmb";
            this.seasonCmb.Size                 =  new System.Drawing.Size(121, 21);
            this.seasonCmb.TabIndex             =  3;
            this.seasonCmb.SelectedIndexChanged += new System.EventHandler(this.seasonCmb_SelectedIndexChanged);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seasonPb);
            this.Controls.Add(this.seasonCmb);
            this.Controls.Add(this.backBtn);
            this.Name = "Task3";
            this.Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)(this.seasonPb)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox seasonPb;
        private System.Windows.Forms.ComboBox   seasonCmb;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}