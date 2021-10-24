using System.ComponentModel;


namespace PictureBoxAndComboBox
{
    partial class Task4
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
            this.backBtn         = new System.Windows.Forms.Button();
            this.trafficLightCmb = new System.Windows.Forms.ComboBox();
            this.trafficLightLbl = new System.Windows.Forms.Label();
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
            // trafficLightCmb
            // 
            this.trafficLightCmb.FormattingEnabled = true;
            this.trafficLightCmb.Items.AddRange(new object[] { "Красный", "Жёлтый", "Зелёный" });
            this.trafficLightCmb.Location             =  new System.Drawing.Point(12, 61);
            this.trafficLightCmb.Name                 =  "trafficLightCmb";
            this.trafficLightCmb.Size                 =  new System.Drawing.Size(121, 21);
            this.trafficLightCmb.TabIndex             =  1;
            this.trafficLightCmb.SelectedIndexChanged += new System.EventHandler(this.trafficLightCmb_SelectedIndexChanged);
            // 
            // trafficLightLbl
            // 
            this.trafficLightLbl.Anchor    = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.trafficLightLbl.Font      = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trafficLightLbl.Location  = new System.Drawing.Point(200, 64);
            this.trafficLightLbl.Name      = "trafficLightLbl";
            this.trafficLightLbl.Size      = new System.Drawing.Size(111, 28);
            this.trafficLightLbl.TabIndex  = 2;
            this.trafficLightLbl.Text      = "Светофор";
            this.trafficLightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(348, 139);
            this.Controls.Add(this.trafficLightLbl);
            this.Controls.Add(this.trafficLightCmb);
            this.Controls.Add(this.backBtn);
            this.Name = "Task4";
            this.Text = "Task4";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label trafficLightLbl;

        private System.Windows.Forms.ComboBox trafficLightCmb;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}