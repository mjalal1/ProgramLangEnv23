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
            btnSyntax = new Button();
            ((System.ComponentModel.ISupportInitialize)outputWindow).BeginInit();
            SuspendLayout();
            // 
            // programWindow
            // 
            programWindow.BackColor = Color.Silver;
            programWindow.Location = new Point(35, 32);
            programWindow.Margin = new Padding(3, 2, 3, 2);
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
            commandLine.Margin = new Padding(3, 2, 3, 2);
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
            outputWindow.Margin = new Padding(3, 2, 3, 2);
            outputWindow.Name = "outputWindow";
            outputWindow.Size = new Size(400, 400);
            outputWindow.TabIndex = 2;
            outputWindow.TabStop = false;
            outputWindow.Paint += outputWindow_Paint;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Location = new Point(36, 415);
            exitBtn.Margin = new Padding(3, 2, 3, 2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(78, 29);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Close";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // labelDrawCountVal
            // 
            labelDrawCountVal.AutoSize = true;
            labelDrawCountVal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelDrawCountVal.Location = new Point(335, 292);
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
            labelDrawingCount.Location = new Point(173, 292);
            labelDrawingCount.Name = "labelDrawingCount";
            labelDrawingCount.Size = new Size(156, 17);
            labelDrawingCount.TabIndex = 5;
            labelDrawingCount.Text = "# of drawings on Canvas:";
            // 
            // btnSyntax
            // 
            btnSyntax.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSyntax.Location = new Point(36, 288);
            btnSyntax.Margin = new Padding(3, 2, 3, 2);
            btnSyntax.Name = "btnSyntax";
            btnSyntax.Size = new Size(122, 26);
            btnSyntax.TabIndex = 6;
            btnSyntax.Text = "Syntax Check";
            btnSyntax.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSyntax);
            Controls.Add(labelDrawingCount);
            Controls.Add(labelDrawCountVal);
            Controls.Add(exitBtn);
            Controls.Add(outputWindow);
            Controls.Add(commandLine);
            Controls.Add(programWindow);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphical Programming Language";
            Load += Form1_Load;
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
        private Button btnSyntax;
    }
}