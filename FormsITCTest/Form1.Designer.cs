namespace FormsITCTest
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
            this.c_ButtonSwitchMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_ButtonSwitchMode
            // 
            this.c_ButtonSwitchMode.Location = new System.Drawing.Point(13, 13);
            this.c_ButtonSwitchMode.Name = "c_ButtonSwitchMode";
            this.c_ButtonSwitchMode.Size = new System.Drawing.Size(173, 31);
            this.c_ButtonSwitchMode.TabIndex = 0;
            this.c_ButtonSwitchMode.Text = "Switch";
            this.c_ButtonSwitchMode.UseVisualStyleBackColor = true;
            this.c_ButtonSwitchMode.Click += new System.EventHandler(this.Handle_ButtonSwitchMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.c_ButtonSwitchMode);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button c_ButtonSwitchMode;
    }
}

