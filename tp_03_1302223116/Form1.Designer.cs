namespace tp_03_1302223116
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
            submitButton = new Button();
            label1 = new Label();
            userInput = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            submitButton.BackColor = SystemColors.ButtonFace;
            submitButton.FlatStyle = FlatStyle.System;
            submitButton.Location = new Point(482, 44);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(127, 29);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit/Kirim";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Your Name";
            label1.Click += label1_Click;
            // 
            // userInput
            // 
            userInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userInput.Location = new Point(23, 44);
            userInput.Name = "userInput";
            userInput.Size = new Size(438, 27);
            userInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 112);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Output";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 169);
            Controls.Add(label2);
            Controls.Add(userInput);
            Controls.Add(label1);
            Controls.Add(submitButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TP Mod 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private Label label1;
        private TextBox userInput;
        private Label label2;
    }
}
