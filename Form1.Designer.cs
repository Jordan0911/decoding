namespace decoding
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
            to_be_deciphered = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            result = new ListBox();
            SuspendLayout();
            // 
            // to_be_deciphered
            // 
            to_be_deciphered.FormattingEnabled = true;
            to_be_deciphered.ItemHeight = 15;
            to_be_deciphered.Location = new Point(3, 68);
            to_be_deciphered.Name = "to_be_deciphered";
            to_be_deciphered.Size = new Size(190, 274);
            to_be_deciphered.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(286, 352);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "decipher";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 348);
            button2.Name = "button2";
            button2.Size = new Size(112, 27);
            button2.TabIndex = 3;
            button2.Text = "insert words";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // result
            // 
            result.FormattingEnabled = true;
            result.ItemHeight = 15;
            result.Location = new Point(230, 68);
            result.Name = "result";
            result.Size = new Size(190, 274);
            result.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(to_be_deciphered);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox to_be_deciphered;
        private Label label1;
        private Button button1;
        private Button button2;
        private ListBox result;
    }
}
