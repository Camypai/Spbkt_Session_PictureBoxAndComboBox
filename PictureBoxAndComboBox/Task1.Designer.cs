using System.ComponentModel;


namespace PictureBoxAndComboBox
{
    partial class Task1
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
            this.openBtn  = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.backBtn  = new System.Windows.Forms.Button();
            this.imagePb  = new System.Windows.Forms.PictureBox();
            this.ofd      = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).BeginInit();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location                =  new System.Drawing.Point(12, 354);
            this.openBtn.Name                    =  "openBtn";
            this.openBtn.Size                    =  new System.Drawing.Size(92, 84);
            this.openBtn.TabIndex                =  7;
            this.openBtn.Text                    =  "Открыть";
            this.openBtn.UseVisualStyleBackColor =  true;
            this.openBtn.Click                   += new System.EventHandler(this.openBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location                =  new System.Drawing.Point(696, 354);
            this.clearBtn.Name                    =  "clearBtn";
            this.clearBtn.Size                    =  new System.Drawing.Size(92, 84);
            this.clearBtn.TabIndex                =  6;
            this.clearBtn.Text                    =  "Очистить";
            this.clearBtn.UseVisualStyleBackColor =  true;
            this.clearBtn.Click                   += new System.EventHandler(this.clearBtn_Click);
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
            // imagePb
            // 
            this.imagePb.Location = new System.Drawing.Point(12, 100);
            this.imagePb.Name     = "imagePb";
            this.imagePb.Size     = new System.Drawing.Size(776, 248);
            this.imagePb.TabIndex = 4;
            this.imagePb.TabStop  = false;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.imagePb);
            this.Name = "Task1";
            this.Text = "Task1";
            ((System.ComponentModel.ISupportInitialize)(this.imagePb)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button clearBtn;

        private System.Windows.Forms.Button openBtn;

        private System.Windows.Forms.Button         button3;
        private System.Windows.Forms.Button         button2;
        private System.Windows.Forms.Button         backBtn;
        private System.Windows.Forms.PictureBox     imagePb;
        private System.Windows.Forms.OpenFileDialog ofd;

        #endregion
    }
}