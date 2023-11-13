namespace PLE23
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
            programWindow = new TextBox();
            commandLine = new TextBox();
            outputWindow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)outputWindow).BeginInit();
            SuspendLayout();
            // 
            // programWindow
            // 
            programWindow.Location = new Point(35, 32);
            programWindow.Multiline = true;
            programWindow.Name = "programWindow";
            programWindow.Size = new Size(307, 174);
            programWindow.TabIndex = 0;
            // 
            // commandLine
            // 
            commandLine.Location = new Point(35, 236);
            commandLine.Name = "commandLine";
            commandLine.Size = new Size(315, 35);
            commandLine.TabIndex = 1;
            // 
            // outputWindow
            // 
            outputWindow.Location = new Point(388, 32);
            outputWindow.Name = "outputWindow";
            outputWindow.Size = new Size(400, 400);
            outputWindow.TabIndex = 2;
            outputWindow.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputWindow);
            Controls.Add(commandLine);
            Controls.Add(programWindow);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)outputWindow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox programWindow;
        private TextBox commandLine;
        private PictureBox outputWindow;
    }
}