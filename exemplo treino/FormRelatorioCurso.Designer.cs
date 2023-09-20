namespace exemplo_treino
{
    partial class FormRelatorioCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttipo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtdata = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialComboBox2 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialComboBox3 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttipo);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // txttipo
            // 
            this.txttipo.AutoResize = false;
            this.txttipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txttipo.Depth = 0;
            this.txttipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txttipo.DropDownHeight = 174;
            this.txttipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttipo.DropDownWidth = 121;
            this.txttipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txttipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txttipo.FormattingEnabled = true;
            this.txttipo.Hint = "Tipo";
            this.txttipo.IntegralHeight = false;
            this.txttipo.ItemHeight = 43;
            this.txttipo.Items.AddRange(new object[] {
            "",
            "Técnico",
            "Técnologo",
            "Bacharelado",
            "Licenciatura"});
            this.txttipo.Location = new System.Drawing.Point(6, 22);
            this.txttipo.MaxDropDownItems = 4;
            this.txttipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(578, 49);
            this.txttipo.StartIndex = 0;
            this.txttipo.TabIndex = 16;
            // 
            // txtdata
            // 
            this.txtdata.AllowPromptAsInput = true;
            this.txtdata.AnimateReadOnly = false;
            this.txtdata.AsciiOnly = false;
            this.txtdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdata.BeepOnError = false;
            this.txtdata.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.Depth = 0;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdata.HidePromptOnLeave = false;
            this.txtdata.HideSelection = true;
            this.txtdata.Hint = "Ano de Criação";
            this.txtdata.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtdata.LeadingIcon = null;
            this.txtdata.Location = new System.Drawing.Point(590, 22);
            this.txtdata.Mask = "9999";
            this.txtdata.MaxLength = 32767;
            this.txtdata.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtdata.Name = "txtdata";
            this.txtdata.PasswordChar = '\0';
            this.txtdata.PrefixSuffixText = null;
            this.txtdata.PromptChar = '_';
            this.txtdata.ReadOnly = false;
            this.txtdata.RejectInputOnFirstFailure = false;
            this.txtdata.ResetOnPrompt = true;
            this.txtdata.ResetOnSpace = true;
            this.txtdata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdata.SelectedText = "";
            this.txtdata.SelectionLength = 0;
            this.txtdata.SelectionStart = 0;
            this.txtdata.ShortcutsEnabled = true;
            this.txtdata.Size = new System.Drawing.Size(192, 48);
            this.txtdata.SkipLiterals = true;
            this.txtdata.TabIndex = 9;
            this.txtdata.TabStop = false;
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdata.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.TrailingIcon = null;
            this.txtdata.UseSystemPasswordChar = false;
            this.txtdata.ValidatingType = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialComboBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.Hint = "Agrupamento";
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Items.AddRange(new object[] {
            "Nenhum",
            "Ano",
            "Tipo"});
            this.materialComboBox2.Location = new System.Drawing.Point(6, 22);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(776, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialComboBox3);
            this.groupBox3.Location = new System.Drawing.Point(6, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(788, 103);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impressora";
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoResize = false;
            this.materialComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox3.Depth = 0;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownHeight = 174;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.Hint = "Impressora";
            this.materialComboBox3.IntegralHeight = false;
            this.materialComboBox3.ItemHeight = 43;
            this.materialComboBox3.Location = new System.Drawing.Point(6, 22);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.Size = new System.Drawing.Size(776, 49);
            this.materialComboBox3.StartIndex = 0;
            this.materialComboBox3.TabIndex = 3;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(596, 393);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(87, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "Imprimir";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(691, 393);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(103, 36);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Visualizar";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // FormRelatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Name = "FormRelatorioCurso";
            this.Text = "FormRelatorioCurso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox3;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtdata;
        private ReaLTaiizor.Controls.MaterialComboBox txttipo;
    }
}