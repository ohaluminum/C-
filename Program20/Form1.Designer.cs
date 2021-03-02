
namespace Program20
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
            this.UserButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.GuestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserButton
            // 
            this.UserButton.Font = new System.Drawing.Font("DengXian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserButton.Location = new System.Drawing.Point(318, 57);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(148, 60);
            this.UserButton.TabIndex = 0;
            this.UserButton.Text = "User Button";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Visible = false;
            this.UserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Font = new System.Drawing.Font("DengXian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.Location = new System.Drawing.Point(318, 177);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(148, 60);
            this.AdminButton.TabIndex = 1;
            this.AdminButton.Text = "Administrator Menu";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Visible = false;
            // 
            // GuestButton
            // 
            this.GuestButton.Font = new System.Drawing.Font("DengXian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestButton.Location = new System.Drawing.Point(318, 301);
            this.GuestButton.Name = "GuestButton";
            this.GuestButton.Size = new System.Drawing.Size(148, 60);
            this.GuestButton.TabIndex = 2;
            this.GuestButton.Text = "Guest Button";
            this.GuestButton.UseVisualStyleBackColor = true;
            this.GuestButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuestButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.UserButton);
            this.Name = "Form1";
            this.Text = "Secure Button Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button GuestButton;
    }
}

