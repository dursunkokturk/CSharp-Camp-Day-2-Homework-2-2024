namespace Asynchronous_Programming
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
            btnProcess1 = new Button();
            btnProcess2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnProcess1
            // 
            btnProcess1.Font = new Font("Segoe UI", 12F);
            btnProcess1.Location = new Point(23, 318);
            btnProcess1.Name = "btnProcess1";
            btnProcess1.Size = new Size(113, 41);
            btnProcess1.TabIndex = 0;
            btnProcess1.Text = "Process1";
            btnProcess1.UseVisualStyleBackColor = true;
            btnProcess1.Click += btnProcess1_Click;
            // 
            // btnProcess2
            // 
            btnProcess2.Font = new Font("Segoe UI", 12F);
            btnProcess2.Location = new Point(273, 318);
            btnProcess2.Name = "btnProcess2";
            btnProcess2.Size = new Size(96, 41);
            btnProcess2.TabIndex = 1;
            btnProcess2.Text = "Process2";
            btnProcess2.UseVisualStyleBackColor = true;
            btnProcess2.Click += btnProcess2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 45);
            label1.TabIndex = 2;
            label1.Text = "Thread:\r\nİşlemlerin En Kısa Sürede Yapılması İçin\r\nOluşturulan Yol Denilebilir.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(298, 120);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 222);
            label3.Name = "label3";
            label3.Size = new Size(295, 75);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 9);
            label4.Name = "label4";
            label4.Size = new Size(202, 45);
            label4.TabIndex = 5;
            label4.Text = "Asynchronous Programming:\r\nHer Thread İçinde İki İşlemin \r\nAynı Anda Yapılabilmesi Durumudur.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 386);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProcess2);
            Controls.Add(btnProcess1);
            Name = "Form1";
            Text = " Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcess1;
        private Button btnProcess2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
