namespace homework10
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
            label1 = new Label();
            txtMyInput = new TextBox();
            btn0 = new Button();
            txtFileContent = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть шлях до файлу: ";
            // 
            // txtMyInput
            // 
            txtMyInput.Location = new Point(25, 77);
            txtMyInput.Name = "txtMyInput";
            txtMyInput.Size = new Size(709, 23);
            txtMyInput.TabIndex = 1;
            // 
            // btn0
            // 
            btn0.Location = new Point(25, 133);
            btn0.Name = "btn0";
            btn0.Size = new Size(709, 148);
            btn0.TabIndex = 2;
            btn0.Text = "Відкрити";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(25, 308);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ScrollBars = ScrollBars.Vertical;
            txtFileContent.Size = new Size(709, 67);
            txtFileContent.TabIndex = 3;
            txtFileContent.TextChanged += txtFileContent_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFileContent);
            Controls.Add(btn0);
            Controls.Add(txtMyInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMyInput;
        private Button btn0;
        private TextBox txtFileContent;
    }
}
