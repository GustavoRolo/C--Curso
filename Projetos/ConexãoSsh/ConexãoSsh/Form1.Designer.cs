namespace ConexãoSsh
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
            this.textIP = new System.Windows.Forms.TextBox();
            this.texDeviceIP = new System.Windows.Forms.TextBox();
            this.nameArq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(158, 48);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(134, 27);
            this.textIP.TabIndex = 0;
            this.textIP.TextChanged += new System.EventHandler(this.textIP_TextChanged);
            // 
            // texDeviceIP
            // 
            this.texDeviceIP.Location = new System.Drawing.Point(475, 48);
            this.texDeviceIP.Name = "texDeviceIP";
            this.texDeviceIP.Size = new System.Drawing.Size(134, 27);
            this.texDeviceIP.TabIndex = 1;
            this.texDeviceIP.TextChanged += new System.EventHandler(this.texDeviceIP_TextChanged);
            // 
            // nameArq
            // 
            this.nameArq.Location = new System.Drawing.Point(123, 130);
            this.nameArq.Name = "nameArq";
            this.nameArq.Size = new System.Drawing.Size(535, 27);
            this.nameArq.TabIndex = 2;
            this.nameArq.TextChanged += new System.EventHandler(this.nameArq_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameArq);
            this.Controls.Add(this.texDeviceIP);
            this.Controls.Add(this.textIP);
            this.Name = "Form1";
            this.Text = "texDeviceIP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox texDeviceIP;
        private System.Windows.Forms.TextBox nameArq;
        private System.Windows.Forms.Button button1;
    }
}
