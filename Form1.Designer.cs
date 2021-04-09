
namespace car
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user_img = new System.Windows.Forms.PictureBox();
            this.admin_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_img)).BeginInit();
            this.SuspendLayout();
            // 
            // user_img
            // 
            this.user_img.BackColor = System.Drawing.SystemColors.Control;
            this.user_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_img.Image = ((System.Drawing.Image)(resources.GetObject("user_img.Image")));
            this.user_img.Location = new System.Drawing.Point(99, 178);
            this.user_img.Name = "user_img";
            this.user_img.Size = new System.Drawing.Size(150, 150);
            this.user_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_img.TabIndex = 0;
            this.user_img.TabStop = false;
            this.user_img.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user_img_MouseClick);
            // 
            // admin_img
            // 
            this.admin_img.BackColor = System.Drawing.SystemColors.Control;
            this.admin_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_img.Image = ((System.Drawing.Image)(resources.GetObject("admin_img.Image")));
            this.admin_img.Location = new System.Drawing.Point(546, 178);
            this.admin_img.Name = "admin_img";
            this.admin_img.Size = new System.Drawing.Size(150, 150);
            this.admin_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_img.TabIndex = 1;
            this.admin_img.TabStop = false;
            this.admin_img.MouseClick += new System.Windows.Forms.MouseEventHandler(this.admin_img_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.admin_img);
            this.Controls.Add(this.user_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            ((System.ComponentModel.ISupportInitialize)(this.user_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox user_img;
        private System.Windows.Forms.PictureBox admin_img;
    }
}

