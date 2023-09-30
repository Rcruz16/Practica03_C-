namespace Practica03_C_
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
            tbx1 = new TextBox();
            tbx2 = new TextBox();
            btn_Ftc = new Button();
            btn_Ctf = new Button();
            btn_Clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbx1
            // 
            tbx1.Location = new Point(34, 179);
            tbx1.Name = "tbx1";
            tbx1.Size = new Size(125, 27);
            tbx1.TabIndex = 0;
            // 
            // tbx2
            // 
            tbx2.Location = new Point(333, 179);
            tbx2.Name = "tbx2";
            tbx2.Size = new Size(125, 27);
            tbx2.TabIndex = 1;
            // 
            // btn_Ftc
            // 
            btn_Ftc.Location = new Point(197, 127);
            btn_Ftc.Name = "btn_Ftc";
            btn_Ftc.Size = new Size(94, 29);
            btn_Ftc.TabIndex = 2;
            btn_Ftc.Text = "F To C";
            btn_Ftc.UseVisualStyleBackColor = true;
            btn_Ftc.Click += btn_Ftc_Click;
            // 
            // btn_Ctf
            // 
            btn_Ctf.Location = new Point(197, 179);
            btn_Ctf.Name = "btn_Ctf";
            btn_Ctf.Size = new Size(94, 29);
            btn_Ctf.TabIndex = 3;
            btn_Ctf.Text = "C to F";
            btn_Ctf.UseVisualStyleBackColor = true;
            btn_Ctf.Click += btn_Ctf_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(197, 240);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(94, 29);
            btn_Clear.TabIndex = 4;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(143, 56);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 5;
            label1.Text = "CONVERSOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(520, 406);
            Controls.Add(label1);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Ctf);
            Controls.Add(btn_Ftc);
            Controls.Add(tbx2);
            Controls.Add(tbx1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx1;
        private TextBox tbx2;
        private Button btn_Ftc;
        private Button btn_Ctf;
        private Button btn_Clear;
        private Label label1;
    }
}