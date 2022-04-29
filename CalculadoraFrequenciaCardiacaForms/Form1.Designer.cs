namespace CalculadoraFrequenciaCardiacaForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFrequenciaRepouso = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIntensidade = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.lblSexo = new MaterialSkin.Controls.MaterialLabel();
            this.btnFeminino = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnCalcular = new MaterialSkin.Controls.MaterialButton();
            this.txtIdade = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.lblIdade = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFrequenciaMaxima = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFrequenciaMinima = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLimpar = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckedListBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(16, 75);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(238, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Frequência Cardiaca em Repouso";
            // 
            // txtFrequenciaRepouso
            // 
            this.txtFrequenciaRepouso.AllowPromptAsInput = true;
            this.txtFrequenciaRepouso.AnimateReadOnly = false;
            this.txtFrequenciaRepouso.AsciiOnly = false;
            this.txtFrequenciaRepouso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFrequenciaRepouso.BeepOnError = false;
            this.txtFrequenciaRepouso.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFrequenciaRepouso.Depth = 0;
            this.txtFrequenciaRepouso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFrequenciaRepouso.HidePromptOnLeave = false;
            this.txtFrequenciaRepouso.HideSelection = true;
            this.txtFrequenciaRepouso.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFrequenciaRepouso.LeadingIcon = null;
            this.txtFrequenciaRepouso.Location = new System.Drawing.Point(20, 107);
            this.txtFrequenciaRepouso.Mask = "";
            this.txtFrequenciaRepouso.MaxLength = 32767;
            this.txtFrequenciaRepouso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFrequenciaRepouso.Name = "txtFrequenciaRepouso";
            this.txtFrequenciaRepouso.PasswordChar = '\0';
            this.txtFrequenciaRepouso.PrefixSuffixText = null;
            this.txtFrequenciaRepouso.PromptChar = '_';
            this.txtFrequenciaRepouso.ReadOnly = false;
            this.txtFrequenciaRepouso.RejectInputOnFirstFailure = false;
            this.txtFrequenciaRepouso.ResetOnPrompt = true;
            this.txtFrequenciaRepouso.ResetOnSpace = true;
            this.txtFrequenciaRepouso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFrequenciaRepouso.SelectedText = "";
            this.txtFrequenciaRepouso.SelectionLength = 0;
            this.txtFrequenciaRepouso.SelectionStart = 0;
            this.txtFrequenciaRepouso.ShortcutsEnabled = true;
            this.txtFrequenciaRepouso.Size = new System.Drawing.Size(123, 48);
            this.txtFrequenciaRepouso.SkipLiterals = true;
            this.txtFrequenciaRepouso.TabIndex = 1;
            this.txtFrequenciaRepouso.TabStop = false;
            this.txtFrequenciaRepouso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFrequenciaRepouso.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFrequenciaRepouso.TrailingIcon = null;
            this.txtFrequenciaRepouso.UseSystemPasswordChar = false;
            this.txtFrequenciaRepouso.ValidatingType = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(16, 275);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(136, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Intensidade (em %)";
            // 
            // txtIntensidade
            // 
            this.txtIntensidade.AllowPromptAsInput = true;
            this.txtIntensidade.AnimateReadOnly = false;
            this.txtIntensidade.AsciiOnly = false;
            this.txtIntensidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIntensidade.BeepOnError = false;
            this.txtIntensidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtIntensidade.Depth = 0;
            this.txtIntensidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIntensidade.HidePromptOnLeave = false;
            this.txtIntensidade.HideSelection = true;
            this.txtIntensidade.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtIntensidade.LeadingIcon = null;
            this.txtIntensidade.Location = new System.Drawing.Point(20, 310);
            this.txtIntensidade.Mask = "";
            this.txtIntensidade.MaxLength = 32767;
            this.txtIntensidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIntensidade.Name = "txtIntensidade";
            this.txtIntensidade.PasswordChar = '\0';
            this.txtIntensidade.PrefixSuffixText = null;
            this.txtIntensidade.PromptChar = '_';
            this.txtIntensidade.ReadOnly = false;
            this.txtIntensidade.RejectInputOnFirstFailure = false;
            this.txtIntensidade.ResetOnPrompt = true;
            this.txtIntensidade.ResetOnSpace = true;
            this.txtIntensidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIntensidade.SelectedText = "";
            this.txtIntensidade.SelectionLength = 0;
            this.txtIntensidade.SelectionStart = 0;
            this.txtIntensidade.ShortcutsEnabled = true;
            this.txtIntensidade.Size = new System.Drawing.Size(123, 48);
            this.txtIntensidade.SkipLiterals = true;
            this.txtIntensidade.TabIndex = 1;
            this.txtIntensidade.TabStop = false;
            this.txtIntensidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIntensidade.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtIntensidade.TrailingIcon = null;
            this.txtIntensidade.UseSystemPasswordChar = false;
            this.txtIntensidade.ValidatingType = null;
            // 
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox1.Controls.Add(this.lblSexo);
            this.materialCheckedListBox1.Controls.Add(this.btnFeminino);
            this.materialCheckedListBox1.Controls.Add(this.btnMasculino);
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(19, 393);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(281, 66);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 3;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Depth = 0;
            this.lblSexo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSexo.Location = new System.Drawing.Point(8, 9);
            this.lblSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 19);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo";
            // 
            // btnFeminino
            // 
            this.btnFeminino.Depth = 0;
            this.btnFeminino.Location = new System.Drawing.Point(123, 28);
            this.btnFeminino.Margin = new System.Windows.Forms.Padding(0);
            this.btnFeminino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnFeminino.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFeminino.Name = "btnFeminino";
            this.btnFeminino.Ripple = true;
            this.btnFeminino.Size = new System.Drawing.Size(112, 28);
            this.btnFeminino.TabIndex = 0;
            this.btnFeminino.TabStop = true;
            this.btnFeminino.Text = "Feminino";
            this.btnFeminino.UseVisualStyleBackColor = true;
            this.btnFeminino.CheckedChanged += new System.EventHandler(this.btnFeminino_CheckedChanged);
            // 
            // btnMasculino
            // 
            this.btnMasculino.Depth = 0;
            this.btnMasculino.Location = new System.Drawing.Point(1, 28);
            this.btnMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.btnMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMasculino.Name = "btnMasculino";
            this.btnMasculino.Ripple = true;
            this.btnMasculino.Size = new System.Drawing.Size(112, 28);
            this.btnMasculino.TabIndex = 0;
            this.btnMasculino.TabStop = true;
            this.btnMasculino.Text = "Masculino";
            this.btnMasculino.UseVisualStyleBackColor = true;
            this.btnMasculino.CheckedChanged += new System.EventHandler(this.btnMasculino_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = false;
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalcular.Depth = 0;
            this.btnCalcular.HighEmphasis = true;
            this.btnCalcular.Icon = null;
            this.btnCalcular.Location = new System.Drawing.Point(201, 310);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalcular.Size = new System.Drawing.Size(99, 48);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalcular.UseAccentColor = false;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.AllowPromptAsInput = true;
            this.txtIdade.AnimateReadOnly = false;
            this.txtIdade.AsciiOnly = false;
            this.txtIdade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdade.BeepOnError = false;
            this.txtIdade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtIdade.Depth = 0;
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdade.HidePromptOnLeave = false;
            this.txtIdade.HideSelection = true;
            this.txtIdade.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtIdade.LeadingIcon = null;
            this.txtIdade.Location = new System.Drawing.Point(19, 206);
            this.txtIdade.Mask = "";
            this.txtIdade.MaxLength = 32767;
            this.txtIdade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.PasswordChar = '\0';
            this.txtIdade.PrefixSuffixText = null;
            this.txtIdade.PromptChar = '_';
            this.txtIdade.ReadOnly = false;
            this.txtIdade.RejectInputOnFirstFailure = false;
            this.txtIdade.ResetOnPrompt = true;
            this.txtIdade.ResetOnSpace = true;
            this.txtIdade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdade.SelectedText = "";
            this.txtIdade.SelectionLength = 0;
            this.txtIdade.SelectionStart = 0;
            this.txtIdade.ShortcutsEnabled = true;
            this.txtIdade.Size = new System.Drawing.Size(123, 48);
            this.txtIdade.SkipLiterals = true;
            this.txtIdade.TabIndex = 1;
            this.txtIdade.TabStop = false;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdade.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtIdade.TrailingIcon = null;
            this.txtIdade.UseSystemPasswordChar = false;
            this.txtIdade.ValidatingType = null;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Depth = 0;
            this.lblIdade.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIdade.Location = new System.Drawing.Point(16, 170);
            this.lblIdade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(40, 19);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.Location = new System.Drawing.Point(386, 75);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(141, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Frequência Máxima";
            // 
            // txtFrequenciaMaxima
            // 
            this.txtFrequenciaMaxima.AutoSize = true;
            this.txtFrequenciaMaxima.Depth = 0;
            this.txtFrequenciaMaxima.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtFrequenciaMaxima.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.txtFrequenciaMaxima.Location = new System.Drawing.Point(390, 107);
            this.txtFrequenciaMaxima.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFrequenciaMaxima.Name = "txtFrequenciaMaxima";
            this.txtFrequenciaMaxima.Size = new System.Drawing.Size(1, 0);
            this.txtFrequenciaMaxima.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(386, 206);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(137, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Frequência Mínima";
            // 
            // txtFrequenciaMinima
            // 
            this.txtFrequenciaMinima.AutoSize = true;
            this.txtFrequenciaMinima.Depth = 0;
            this.txtFrequenciaMinima.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtFrequenciaMinima.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.txtFrequenciaMinima.Location = new System.Drawing.Point(390, 238);
            this.txtFrequenciaMinima.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFrequenciaMinima.Name = "txtFrequenciaMinima";
            this.txtFrequenciaMinima.Size = new System.Drawing.Size(1, 0);
            this.txtFrequenciaMinima.TabIndex = 6;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel5.Location = new System.Drawing.Point(390, 302);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(1, 0);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = false;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.HighEmphasis = true;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(201, 251);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpar.Size = new System.Drawing.Size(99, 48);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpar.UseAccentColor = false;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 495);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtFrequenciaMinima);
            this.Controls.Add(this.txtFrequenciaMaxima);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtIntensidade);
            this.Controls.Add(this.txtFrequenciaRepouso);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCheckedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Frequência Cardiaca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialCheckedListBox1.ResumeLayout(false);
            this.materialCheckedListBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFrequenciaRepouso;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtIntensidade;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialRadioButton btnMasculino;
        private MaterialSkin.Controls.MaterialLabel lblSexo;
        private MaterialSkin.Controls.MaterialRadioButton btnFeminino;
        private MaterialSkin.Controls.MaterialButton btnCalcular;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtIdade;
        private MaterialSkin.Controls.MaterialLabel lblIdade;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel txtFrequenciaMaxima;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel txtFrequenciaMinima;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnLimpar;
    }
}

