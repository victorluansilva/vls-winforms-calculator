namespace Exemplo
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
            inputTextX = new TextBox();
            labelTitle = new Label();
            labelOutput = new Label();
            btnClick = new Button();
            inputTextY = new TextBox();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(16, 135);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(187, 31);
            inputTextX.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(12, 21);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Digite abaixo, os valores para X e Y:";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(373, 21);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.Visible = false;
            // 
            // btnClick
            // 
            btnClick.BackColor = Color.FromArgb(255, 127, 84);
            btnClick.Cursor = Cursors.Hand;
            btnClick.FlatAppearance.BorderColor = SystemColors.Window;
            btnClick.FlatAppearance.BorderSize = 3;
            btnClick.FlatStyle = FlatStyle.Flat;
            btnClick.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClick.ForeColor = SystemColors.ButtonFace;
            btnClick.Location = new Point(16, 274);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(187, 63);
            btnClick.TabIndex = 3;
            btnClick.Text = "Resultado";
            btnClick.UseVisualStyleBackColor = false;
            btnClick.Click += onButtonClick;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(16, 206);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(187, 31);
            inputTextY.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(inputTextY);
            Controls.Add(btnClick);
            Controls.Add(labelOutput);
            Controls.Add(labelTitle);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextX;
        private Label labelTitle;
        private Label labelOutput;
        private Button btnClick;
        private TextBox inputTextY;
    }
}
