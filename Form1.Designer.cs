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
            btnSoma = new Button();
            inputTextY = new TextBox();
            labelX = new Label();
            label1 = new Label();
            btnSub = new Button();
            btnMult = new Button();
            btnRaiz = new Button();
            btnDobro = new Button();
            btnDiv = new Button();
            button6 = new Button();
            button7 = new Button();
            btnPorcent = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Font = new Font("Segoe UI", 12F);
            inputTextX.Location = new Point(82, 78);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(187, 39);
            inputTextX.TabIndex = 1;
            inputTextX.Text = "...";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(2, -1);
            labelTitle.MaximumSize = new Size(300, 65);
            labelTitle.MinimumSize = new Size(300, 65);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Calculator";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.FromArgb(40, 42, 54);
            labelOutput.Font = new Font("Segoe UI", 12F);
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(373, 21);
            labelOutput.MaximumSize = new Size(400, 350);
            labelOutput.MinimumSize = new Size(400, 350);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(10, 20, 20, 10);
            labelOutput.Size = new Size(400, 350);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "...";
            labelOutput.TextAlign = ContentAlignment.TopRight;
            labelOutput.Visible = false;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(255, 127, 84);
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatAppearance.BorderColor = SystemColors.Window;
            btnSoma.FlatAppearance.BorderSize = 3;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSoma.ForeColor = SystemColors.ButtonFace;
            btnSoma.Location = new Point(16, 232);
            btnSoma.MaximumSize = new Size(100, 65);
            btnSoma.MinimumSize = new Size(100, 65);
            btnSoma.Name = "btnSoma";
            btnSoma.Padding = new Padding(5);
            btnSoma.Size = new Size(100, 65);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += onSomaClick;
            // 
            // inputTextY
            // 
            inputTextY.Font = new Font("Segoe UI", 12F);
            inputTextY.Location = new Point(82, 136);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(187, 39);
            inputTextY.TabIndex = 2;
            inputTextY.Text = "...";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.BackColor = Color.Transparent;
            labelX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelX.ForeColor = Color.Coral;
            labelX.Location = new Point(2, 59);
            labelX.MaximumSize = new Size(65, 65);
            labelX.MinimumSize = new Size(65, 65);
            labelX.Name = "labelX";
            labelX.Size = new Size(65, 65);
            labelX.TabIndex = 5;
            labelX.Text = "X";
            labelX.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(2, 117);
            label1.MaximumSize = new Size(65, 65);
            label1.MinimumSize = new Size(65, 65);
            label1.Name = "label1";
            label1.Size = new Size(65, 65);
            label1.TabIndex = 6;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(255, 127, 84);
            btnSub.Cursor = Cursors.Hand;
            btnSub.FlatAppearance.BorderColor = SystemColors.Window;
            btnSub.FlatAppearance.BorderSize = 3;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSub.ForeColor = SystemColors.ButtonFace;
            btnSub.Location = new Point(136, 232);
            btnSub.MaximumSize = new Size(100, 65);
            btnSub.MinimumSize = new Size(100, 65);
            btnSub.Name = "btnSub";
            btnSub.Padding = new Padding(5);
            btnSub.Size = new Size(100, 65);
            btnSub.TabIndex = 7;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.FromArgb(255, 127, 84);
            btnMult.Cursor = Cursors.Hand;
            btnMult.FlatAppearance.BorderColor = SystemColors.Window;
            btnMult.FlatAppearance.BorderSize = 3;
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnMult.ForeColor = SystemColors.ButtonFace;
            btnMult.Location = new Point(258, 232);
            btnMult.MaximumSize = new Size(100, 65);
            btnMult.MinimumSize = new Size(100, 65);
            btnMult.Name = "btnMult";
            btnMult.Padding = new Padding(5);
            btnMult.Size = new Size(100, 65);
            btnMult.TabIndex = 8;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.FromArgb(255, 127, 84);
            btnRaiz.Cursor = Cursors.Hand;
            btnRaiz.FlatAppearance.BorderColor = SystemColors.Window;
            btnRaiz.FlatAppearance.BorderSize = 3;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRaiz.ForeColor = SystemColors.ButtonFace;
            btnRaiz.Location = new Point(258, 306);
            btnRaiz.MaximumSize = new Size(100, 65);
            btnRaiz.MinimumSize = new Size(100, 65);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Padding = new Padding(5);
            btnRaiz.Size = new Size(100, 65);
            btnRaiz.TabIndex = 11;
            btnRaiz.Text = "√ ";
            btnRaiz.UseVisualStyleBackColor = false;
            // 
            // btnDobro
            // 
            btnDobro.BackColor = Color.FromArgb(255, 127, 84);
            btnDobro.Cursor = Cursors.Hand;
            btnDobro.FlatAppearance.BorderColor = SystemColors.Window;
            btnDobro.FlatAppearance.BorderSize = 3;
            btnDobro.FlatStyle = FlatStyle.Flat;
            btnDobro.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDobro.ForeColor = SystemColors.ButtonFace;
            btnDobro.Location = new Point(136, 306);
            btnDobro.MaximumSize = new Size(100, 65);
            btnDobro.MinimumSize = new Size(100, 65);
            btnDobro.Name = "btnDobro";
            btnDobro.Padding = new Padding(5);
            btnDobro.Size = new Size(100, 65);
            btnDobro.TabIndex = 10;
            btnDobro.Text = "x²";
            btnDobro.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(255, 127, 84);
            btnDiv.Cursor = Cursors.Hand;
            btnDiv.FlatAppearance.BorderColor = SystemColors.Window;
            btnDiv.FlatAppearance.BorderSize = 3;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDiv.ForeColor = SystemColors.ButtonFace;
            btnDiv.Location = new Point(16, 306);
            btnDiv.MaximumSize = new Size(100, 65);
            btnDiv.MinimumSize = new Size(100, 65);
            btnDiv.Name = "btnDiv";
            btnDiv.Padding = new Padding(5);
            btnDiv.Size = new Size(100, 65);
            btnDiv.TabIndex = 9;
            btnDiv.Text = " / ";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 127, 84);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = SystemColors.Window;
            button6.FlatAppearance.BorderSize = 3;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(258, 377);
            button6.MaximumSize = new Size(100, 65);
            button6.MinimumSize = new Size(100, 65);
            button6.Name = "button6";
            button6.Padding = new Padding(5);
            button6.Size = new Size(100, 65);
            button6.TabIndex = 14;
            button6.Text = "X^y";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 127, 84);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = SystemColors.Window;
            button7.FlatAppearance.BorderSize = 3;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(136, 377);
            button7.MaximumSize = new Size(100, 65);
            button7.MinimumSize = new Size(100, 65);
            button7.Name = "button7";
            button7.Padding = new Padding(5);
            button7.Size = new Size(100, 65);
            button7.TabIndex = 13;
            button7.Text = "01010";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // btnPorcent
            // 
            btnPorcent.BackColor = Color.FromArgb(255, 127, 84);
            btnPorcent.Cursor = Cursors.Hand;
            btnPorcent.FlatAppearance.BorderColor = SystemColors.Window;
            btnPorcent.FlatAppearance.BorderSize = 3;
            btnPorcent.FlatStyle = FlatStyle.Flat;
            btnPorcent.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPorcent.ForeColor = SystemColors.ButtonFace;
            btnPorcent.Location = new Point(16, 377);
            btnPorcent.MaximumSize = new Size(100, 65);
            btnPorcent.MinimumSize = new Size(100, 65);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.Padding = new Padding(5);
            btnPorcent.Size = new Size(100, 65);
            btnPorcent.TabIndex = 12;
            btnPorcent.Text = "%";
            btnPorcent.UseVisualStyleBackColor = false;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.FromArgb(40, 42, 54);
            labelResult.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelResult.ForeColor = Color.Coral;
            labelResult.Location = new Point(447, 117);
            labelResult.MaximumSize = new Size(250, 200);
            labelResult.MinimumSize = new Size(250, 200);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(250, 200);
            labelResult.TabIndex = 15;
            labelResult.Text = "000000";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(btnPorcent);
            Controls.Add(btnRaiz);
            Controls.Add(btnDobro);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(label1);
            Controls.Add(labelX);
            Controls.Add(inputTextY);
            Controls.Add(btnSoma);
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
        private Button btnSoma;
        private TextBox inputTextY;
        private Label labelX;
        private Label label1;
        private Button btnSub;
        private Button btnMult;
        private Button btnRaiz;
        private Button btnDobro;
        private Button btnDiv;
        private Button button6;
        private Button button7;
        private Button btnPorcent;
        private Label labelResult;
    }
}
