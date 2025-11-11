namespace winform_calculator
{
    partial class MainScreen
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
            btnXPowY = new Button();
            btnBinary = new Button();
            btnPorcent = new Button();
            labelResult = new Label();
            btnClean = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Font = new Font("Segoe UI", 12F);
            inputTextX.Location = new Point(57, 47);
            inputTextX.Margin = new Padding(2);
            inputTextX.Name = "inputTextX";
            inputTextX.Size = new Size(132, 29);
            inputTextX.TabIndex = 1;
            inputTextX.Text = "...";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Coral;
            labelTitle.Location = new Point(1, -1);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.MaximumSize = new Size(210, 39);
            labelTitle.MinimumSize = new Size(210, 39);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(210, 39);
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
            labelOutput.Location = new Point(261, 13);
            labelOutput.Margin = new Padding(2, 0, 2, 0);
            labelOutput.MaximumSize = new Size(280, 210);
            labelOutput.MinimumSize = new Size(280, 210);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(7, 12, 14, 6);
            labelOutput.Size = new Size(280, 210);
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
            btnSoma.Location = new Point(11, 139);
            btnSoma.Margin = new Padding(2);
            btnSoma.MaximumSize = new Size(70, 45);
            btnSoma.MinimumSize = new Size(70, 45);
            btnSoma.Name = "btnSoma";
            btnSoma.Padding = new Padding(4, 3, 4, 3);
            btnSoma.Size = new Size(70, 45);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            // 
            // inputTextY
            // 
            inputTextY.Font = new Font("Segoe UI", 12F);
            inputTextY.Location = new Point(57, 82);
            inputTextY.Margin = new Padding(2);
            inputTextY.Name = "inputTextY";
            inputTextY.Size = new Size(132, 29);
            inputTextY.TabIndex = 2;
            inputTextY.Text = "...";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.BackColor = Color.Transparent;
            labelX.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelX.ForeColor = Color.Coral;
            labelX.Location = new Point(1, 39);
            labelX.Margin = new Padding(2, 0, 2, 0);
            labelX.MaximumSize = new Size(46, 39);
            labelX.MinimumSize = new Size(46, 39);
            labelX.Name = "labelX";
            labelX.Size = new Size(46, 39);
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
            label1.Location = new Point(1, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MaximumSize = new Size(46, 39);
            label1.MinimumSize = new Size(46, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 39);
            label1.TabIndex = 6;
            label1.Text = "Y";
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
            btnSub.Location = new Point(95, 139);
            btnSub.Margin = new Padding(2);
            btnSub.MaximumSize = new Size(70, 45);
            btnSub.MinimumSize = new Size(70, 45);
            btnSub.Name = "btnSub";
            btnSub.Padding = new Padding(4, 3, 4, 3);
            btnSub.Size = new Size(70, 45);
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
            btnMult.Location = new Point(181, 139);
            btnMult.Margin = new Padding(2);
            btnMult.MaximumSize = new Size(70, 45);
            btnMult.MinimumSize = new Size(70, 45);
            btnMult.Name = "btnMult";
            btnMult.Padding = new Padding(4, 3, 4, 3);
            btnMult.Size = new Size(70, 45);
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
            btnRaiz.Location = new Point(181, 188);
            btnRaiz.Margin = new Padding(2);
            btnRaiz.MaximumSize = new Size(70, 45);
            btnRaiz.MinimumSize = new Size(70, 45);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Padding = new Padding(4, 3, 4, 3);
            btnRaiz.Size = new Size(70, 45);
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
            btnDobro.Location = new Point(95, 188);
            btnDobro.Margin = new Padding(2);
            btnDobro.MaximumSize = new Size(70, 45);
            btnDobro.MinimumSize = new Size(70, 45);
            btnDobro.Name = "btnDobro";
            btnDobro.Padding = new Padding(4, 3, 4, 3);
            btnDobro.Size = new Size(70, 45);
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
            btnDiv.Location = new Point(11, 188);
            btnDiv.Margin = new Padding(2);
            btnDiv.MaximumSize = new Size(70, 45);
            btnDiv.MinimumSize = new Size(70, 45);
            btnDiv.Name = "btnDiv";
            btnDiv.Padding = new Padding(4, 3, 4, 3);
            btnDiv.Size = new Size(70, 45);
            btnDiv.TabIndex = 9;
            btnDiv.Text = " / ";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnXPowY
            // 
            btnXPowY.BackColor = Color.FromArgb(255, 127, 84);
            btnXPowY.Cursor = Cursors.Hand;
            btnXPowY.FlatAppearance.BorderColor = SystemColors.Window;
            btnXPowY.FlatAppearance.BorderSize = 3;
            btnXPowY.FlatStyle = FlatStyle.Flat;
            btnXPowY.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnXPowY.ForeColor = SystemColors.ButtonFace;
            btnXPowY.Location = new Point(181, 237);
            btnXPowY.Margin = new Padding(2);
            btnXPowY.MaximumSize = new Size(70, 45);
            btnXPowY.MinimumSize = new Size(70, 45);
            btnXPowY.Name = "btnXPowY";
            btnXPowY.Padding = new Padding(4, 3, 4, 3);
            btnXPowY.Size = new Size(70, 45);
            btnXPowY.TabIndex = 14;
            btnXPowY.Text = "x^Y";
            btnXPowY.UseVisualStyleBackColor = false;
            // 
            // btnBinary
            // 
            btnBinary.BackColor = Color.FromArgb(255, 127, 84);
            btnBinary.Cursor = Cursors.Hand;
            btnBinary.FlatAppearance.BorderColor = SystemColors.Window;
            btnBinary.FlatAppearance.BorderSize = 3;
            btnBinary.FlatStyle = FlatStyle.Flat;
            btnBinary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBinary.ForeColor = SystemColors.ButtonFace;
            btnBinary.Location = new Point(95, 237);
            btnBinary.Margin = new Padding(2);
            btnBinary.MaximumSize = new Size(70, 45);
            btnBinary.MinimumSize = new Size(70, 45);
            btnBinary.Name = "btnBinary";
            btnBinary.Padding = new Padding(4, 3, 4, 3);
            btnBinary.Size = new Size(70, 45);
            btnBinary.TabIndex = 13;
            btnBinary.Text = "01010";
            btnBinary.UseVisualStyleBackColor = false;
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
            btnPorcent.Location = new Point(11, 237);
            btnPorcent.Margin = new Padding(2);
            btnPorcent.MaximumSize = new Size(70, 45);
            btnPorcent.MinimumSize = new Size(70, 45);
            btnPorcent.Name = "btnPorcent";
            btnPorcent.Padding = new Padding(4, 3, 4, 3);
            btnPorcent.Size = new Size(70, 45);
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
            labelResult.Location = new Point(313, 70);
            labelResult.Margin = new Padding(2, 0, 2, 0);
            labelResult.MaximumSize = new Size(175, 120);
            labelResult.MinimumSize = new Size(175, 120);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(175, 120);
            labelResult.TabIndex = 15;
            labelResult.Text = "000000";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            labelResult.Visible = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(255, 127, 84);
            btnClean.Cursor = Cursors.Hand;
            btnClean.FlatAppearance.BorderColor = SystemColors.Window;
            btnClean.FlatAppearance.BorderSize = 3;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnClean.ForeColor = SystemColors.ButtonFace;
            btnClean.Location = new Point(313, 237);
            btnClean.Margin = new Padding(2);
            btnClean.MaximumSize = new Size(175, 45);
            btnClean.MinimumSize = new Size(175, 45);
            btnClean.Name = "btnClean";
            btnClean.Padding = new Padding(4, 3, 4, 3);
            btnClean.Size = new Size(175, 45);
            btnClean.TabIndex = 16;
            btnClean.Text = "CE";
            btnClean.UseVisualStyleBackColor = false;

            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 83, 102);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(560, 304);
            Controls.Add(btnClean);
            Controls.Add(btnXPowY);
            Controls.Add(btnBinary);
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
            Controls.Add(labelTitle);
            Controls.Add(inputTextX);
            Controls.Add(labelResult);
            Controls.Add(labelOutput);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VLS CALCULATOR";
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
        private Button btnXPowY;
        private Button btnBinary;
        private Button btnPorcent;
        private Label labelResult;
        private Button btnClean;
    }
}
