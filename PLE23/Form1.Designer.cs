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
            exitBtn = new Button();
            labelDrawCountVal = new Label();
            labelDrawingCount = new Label();
            ((System.ComponentModel.ISupportInitialize)outputWindow).BeginInit();
            SuspendLayout();
            // 
            // programWindow
            // 
            programWindow.BackColor = Color.Silver;
            programWindow.Location = new Point(35, 32);
            programWindow.Multiline = true;
            programWindow.Name = "programWindow";
            programWindow.Size = new Size(307, 174);
            programWindow.TabIndex = 0;
            // 
            // commandLine
            // 
            commandLine.BackColor = Color.Silver;
            commandLine.BorderStyle = BorderStyle.FixedSingle;
            commandLine.Location = new Point(35, 236);
            commandLine.Name = "commandLine";
            commandLine.Size = new Size(315, 35);
            commandLine.TabIndex = 1;
            commandLine.KeyDown += commandLine_KeyDown;
            // 
            // outputWindow
            // 
            outputWindow.BackColor = Color.Silver;
            outputWindow.BorderStyle = BorderStyle.Fixed3D;
            outputWindow.Location = new Point(388, 32);
            outputWindow.Name = "outputWindow";
            outputWindow.Size = new Size(400, 400);
            outputWindow.TabIndex = 2;
            outputWindow.TabStop = false;
            outputWindow.Paint += outputWindow_Paint;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Location = new Point(18, 419);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(78, 23);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Close";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // labelDrawCountVal
            // 
            labelDrawCountVal.AutoSize = true;
            labelDrawCountVal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDrawCountVal.Location = new Point(335, 305);
            labelDrawCountVal.Name = "labelDrawCountVal";
            labelDrawCountVal.Size = new Size(15, 17);
            labelDrawCountVal.TabIndex = 4;
            labelDrawCountVal.Text = "0";
            // 
            // labelDrawingCount
            // 
            labelDrawingCount.AutoSize = true;
            labelDrawingCount.BackColor = Color.Transparent;
            labelDrawingCount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDrawingCount.ForeColor = Color.Black;
            labelDrawingCount.Location = new Point(173, 305);
            labelDrawingCount.Name = "labelDrawingCount";
            labelDrawingCount.Size = new Size(156, 17);
            labelDrawingCount.TabIndex = 5;
            labelDrawingCount.Text = "# of drawings on Canvas:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDrawingCount);
            Controls.Add(labelDrawCountVal);
            Controls.Add(exitBtn);
            Controls.Add(outputWindow);
            Controls.Add(commandLine);
            Controls.Add(programWindow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)outputWindow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox programWindow;
        public TextBox commandLine;
        public PictureBox outputWindow;
        private Button exitBtn;
        public Label labelDrawCountVal;
        private Label labelDrawingCount;
    }
}