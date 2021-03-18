
namespace SchoolManagement
{
    partial class UserHome
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
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblMalayalam = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(423, 40);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(58, 20);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Theme";
            this.lblTheme.Click += new System.EventHandler(this.lblTheme_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(63, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 24);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "label2";
            // 
            // lblMalayalam
            // 
            this.lblMalayalam.AutoSize = true;
            this.lblMalayalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMalayalam.Location = new System.Drawing.Point(143, 106);
            this.lblMalayalam.Name = "lblMalayalam";
            this.lblMalayalam.Size = new System.Drawing.Size(60, 24);
            this.lblMalayalam.TabIndex = 2;
            this.lblMalayalam.Text = "label2";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(143, 130);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(60, 24);
            this.lblEnglish.TabIndex = 3;
            this.lblEnglish.Text = "label2";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaths.Location = new System.Drawing.Point(143, 154);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(60, 24);
            this.lblMaths.TabIndex = 4;
            this.lblMaths.Text = "label3";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaths);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblMalayalam);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTheme);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserHome_FormClosing);
            this.Load += new System.EventHandler(this.UserHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblMalayalam;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMaths;
    }
}