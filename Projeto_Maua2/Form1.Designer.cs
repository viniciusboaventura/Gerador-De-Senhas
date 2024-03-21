namespace Projeto_Maua2
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
            txtTamanho = new TextBox();
            lbTitulo = new Label();
            lbInstrucao = new Label();
            txtResult = new TextBox();
            label1 = new Label();
            rbNums = new RadioButton();
            rbLetras = new RadioButton();
            rbLetrNum = new RadioButton();
            rbTudo = new RadioButton();
            btnGerar = new Button();
            lbAviso = new Label();
            SuspendLayout();
            // 
            // txtTamanho
            // 
            txtTamanho.Location = new Point(418, 85);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(33, 27);
            txtTamanho.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitulo.Location = new Point(255, 23);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(243, 32);
            lbTitulo.TabIndex = 5;
            lbTitulo.Text = "Gerador de Senha";
            // 
            // lbInstrucao
            // 
            lbInstrucao.AutoSize = true;
            lbInstrucao.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbInstrucao.Location = new Point(136, 85);
            lbInstrucao.Name = "lbInstrucao";
            lbInstrucao.Size = new Size(250, 23);
            lbInstrucao.TabIndex = 6;
            lbInstrucao.Text = "Nº de caracteres desejado:";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(153, 228);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(646, 55);
            txtResult.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 228);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 8;
            label1.Text = "Senha gerada: ";
            // 
            // rbNums
            // 
            rbNums.AutoSize = true;
            rbNums.Location = new Point(24, 146);
            rbNums.Name = "rbNums";
            rbNums.Size = new Size(143, 24);
            rbNums.TabIndex = 9;
            rbNums.TabStop = true;
            rbNums.Text = "Apenas Números";
            rbNums.UseVisualStyleBackColor = true;
            // 
            // rbLetras
            // 
            rbLetras.AutoSize = true;
            rbLetras.Location = new Point(223, 146);
            rbLetras.Name = "rbLetras";
            rbLetras.Size = new Size(122, 24);
            rbLetras.TabIndex = 10;
            rbLetras.TabStop = true;
            rbLetras.Text = "Apenas Letras";
            rbLetras.UseVisualStyleBackColor = true;
            // 
            // rbLetrNum
            // 
            rbLetrNum.AutoSize = true;
            rbLetrNum.Location = new Point(393, 146);
            rbLetrNum.Name = "rbLetrNum";
            rbLetrNum.Size = new Size(145, 24);
            rbLetrNum.TabIndex = 11;
            rbLetrNum.TabStop = true;
            rbLetrNum.Text = "Letras e Números";
            rbLetrNum.UseVisualStyleBackColor = true;
            // 
            // rbTudo
            // 
            rbTudo.AutoSize = true;
            rbTudo.Location = new Point(574, 146);
            rbTudo.Name = "rbTudo";
            rbTudo.Size = new Size(214, 24);
            rbTudo.TabIndex = 12;
            rbTudo.TabStop = true;
            rbTudo.Text = "Letras, Números e Simbolos";
            rbTudo.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(311, 187);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(140, 29);
            btnGerar.TabIndex = 13;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lbAviso
            // 
            lbAviso.AutoSize = true;
            lbAviso.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbAviso.ForeColor = SystemColors.ActiveBorder;
            lbAviso.Location = new Point(522, 85);
            lbAviso.Name = "lbAviso";
            lbAviso.Size = new Size(122, 19);
            lbAviso.TabIndex = 14;
            lbAviso.Text = "**Entre 4 e 120";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 307);
            Controls.Add(lbAviso);
            Controls.Add(btnGerar);
            Controls.Add(rbTudo);
            Controls.Add(rbLetrNum);
            Controls.Add(rbLetras);
            Controls.Add(rbNums);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(lbInstrucao);
            Controls.Add(lbTitulo);
            Controls.Add(txtTamanho);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTamanho;
        private Label lbTitulo;
        private Label lbInstrucao;
        private TextBox txtResult;
        private Label label1;
        private RadioButton rbNums;
        private RadioButton rbLetras;
        private RadioButton rbLetrNum;
        private RadioButton rbTudo;
        private Button btnGerar;
        private Label lbAviso;
    }
}
