namespace Full_Name_Message_Box
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
            this.enterbutton = new System.Windows.Forms.Button();
            this.fullname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterbutton
            // 
            this.enterbutton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterbutton.Location = new System.Drawing.Point(220, 115);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(122, 34);
            this.enterbutton.TabIndex = 0;
            this.enterbutton.Text = "Enter";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullname
            // 
            this.fullname.AutoSize = true;
            this.fullname.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(181, 47);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(203, 34);
            this.fullname.TabIndex = 1;
            this.fullname.Text = "Who are you?";
            this.fullname.Click += new System.EventHandler(this.fullname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 206);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.enterbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Label fullname;
    }
}

