namespace openGL
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            openglControl1 = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)openglControl1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 24);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 0;
            button1.Text = "Ось Х(+)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 69);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 1;
            button2.Text = "Ось Х(-)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(163, 24);
            button3.Name = "button3";
            button3.Size = new Size(112, 29);
            button3.TabIndex = 2;
            button3.Text = "Ось У(+)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(163, 69);
            button4.Name = "button4";
            button4.Size = new Size(112, 29);
            button4.TabIndex = 3;
            button4.Text = "Ось У(-)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(291, 24);
            button5.Name = "button5";
            button5.Size = new Size(112, 29);
            button5.TabIndex = 4;
            button5.Text = "Ось Z(+)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(291, 69);
            button6.Name = "button6";
            button6.Size = new Size(112, 29);
            button6.TabIndex = 5;
            button6.Text = "Ось Z(-)";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(474, 24);
            button7.Name = "button7";
            button7.Size = new Size(112, 29);
            button7.TabIndex = 6;
            button7.Text = "Масштаб (+)";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(474, 69);
            button8.Name = "button8";
            button8.Size = new Size(112, 29);
            button8.TabIndex = 7;
            button8.Text = "Масштаб (-)";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // openglControl1
            // 
            openglControl1.DrawFPS = false;
            openglControl1.Location = new Point(29, 126);
            openglControl1.Margin = new Padding(4, 5, 4, 5);
            openglControl1.Name = "openglControl1";
            openglControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            openglControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            openglControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            openglControl1.Size = new Size(557, 442);
            openglControl1.TabIndex = 8;
            openglControl1.OpenGLDraw += openGlDraw;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 625);
            Controls.Add(openglControl1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)openglControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private SharpGL.OpenGLControl openglControl1;
    }
}