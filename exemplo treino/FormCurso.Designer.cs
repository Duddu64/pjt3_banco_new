namespace exemplo_treino
{
    partial class FormCurso
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
            this.tabpageprof = new ReaLTaiizor.Controls.AirTabPage();
            this.taPage1 = new System.Windows.Forms.TabPage();
            this.txttipo = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtid = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtdata = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialButton5 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton4 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            this.tabpageprof.SuspendLayout();
            this.taPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpageprof
            // 
            this.tabpageprof.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabpageprof.BaseColor = System.Drawing.Color.White;
            this.tabpageprof.Controls.Add(this.taPage1);
            this.tabpageprof.Controls.Add(this.tabPage2);
            this.tabpageprof.ItemSize = new System.Drawing.Size(30, 115);
            this.tabpageprof.Location = new System.Drawing.Point(6, 67);
            this.tabpageprof.Multiline = true;
            this.tabpageprof.Name = "tabpageprof";
            this.tabpageprof.NormalTextColor = System.Drawing.Color.DimGray;
            this.tabpageprof.SelectedIndex = 0;
            this.tabpageprof.SelectedTabBackColor = System.Drawing.Color.White;
            this.tabpageprof.SelectedTextColor = System.Drawing.Color.Black;
            this.tabpageprof.ShowOuterBorders = false;
            this.tabpageprof.Size = new System.Drawing.Size(880, 280);
            this.tabpageprof.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabpageprof.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.tabpageprof.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.tabpageprof.TabIndex = 1;
            // 
            // taPage1
            // 
            this.taPage1.BackColor = System.Drawing.Color.White;
            this.taPage1.Controls.Add(this.txttipo);
            this.taPage1.Controls.Add(this.txtid);
            this.taPage1.Controls.Add(this.txtNome);
            this.taPage1.Controls.Add(this.txtdata);
            this.taPage1.Controls.Add(this.btnCancelar);
            this.taPage1.Controls.Add(this.btnSalvar);
            this.taPage1.Location = new System.Drawing.Point(119, 4);
            this.taPage1.Name = "taPage1";
            this.taPage1.Padding = new System.Windows.Forms.Padding(3);
            this.taPage1.Size = new System.Drawing.Size(757, 272);
            this.taPage1.TabIndex = 0;
            this.taPage1.Text = "Cadastro";
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
            "Técnico",
            "Técnologo",
            "Bacharelado",
            "Licenciatura"});
            this.txttipo.Location = new System.Drawing.Point(19, 60);
            this.txttipo.MaxDropDownItems = 4;
            this.txttipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(444, 49);
            this.txttipo.StartIndex = 0;
            this.txttipo.TabIndex = 15;
            // 
            // txtid
            // 
            this.txtid.AnimateReadOnly = false;
            this.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtid.Depth = 0;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtid.HideSelection = true;
            this.txtid.Hint = "id";
            this.txtid.LeadingIcon = null;
            this.txtid.Location = new System.Drawing.Point(584, 6);
            this.txtid.MaxLength = 32767;
            this.txtid.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PrefixSuffixText = null;
            this.txtid.ReadOnly = true;
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.ShortcutsEnabled = true;
            this.txtid.Size = new System.Drawing.Size(135, 48);
            this.txtid.TabIndex = 14;
            this.txtid.TabStop = false;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtid.TrailingIcon = null;
            this.txtid.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(19, 6);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(559, 48);
            this.txtNome.TabIndex = 9;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
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
            this.txtdata.Hint = "Ano de criação";
            this.txtdata.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtdata.LeadingIcon = null;
            this.txtdata.Location = new System.Drawing.Point(469, 60);
            this.txtdata.Mask = "99/99/9999";
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
            this.txtdata.Size = new System.Drawing.Size(250, 48);
            this.txtdata.SkipLiterals = true;
            this.txtdata.TabIndex = 8;
            this.txtdata.TabStop = false;
            this.txtdata.Text = "  /  /";
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdata.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.TrailingIcon = null;
            this.txtdata.UseSystemPasswordChar = false;
            this.txtdata.ValidatingType = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(526, 131);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(643, 131);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(76, 36);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.materialButton5);
            this.tabPage2.Controls.Add(this.materialButton4);
            this.tabPage2.Controls.Add(this.materialButton3);
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 199);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton5.Location = new System.Drawing.Point(484, 214);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(80, 36);
            this.materialButton5.TabIndex = 6;
            this.materialButton5.Text = "EXCLUIR";
            this.materialButton5.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton4.Location = new System.Drawing.Point(687, 214);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(64, 36);
            this.materialButton4.TabIndex = 5;
            this.materialButton4.Text = "NOVO";
            this.materialButton4.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton3.Location = new System.Drawing.Point(589, 214);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(71, 36);
            this.materialButton3.TabIndex = 4;
            this.materialButton3.Text = "EDITAR";
            this.materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 356);
            this.Controls.Add(this.tabpageprof);
            this.Name = "FormCurso";
            this.Text = "FormCurso";
            this.tabpageprof.ResumeLayout(false);
            this.taPage1.ResumeLayout(false);
            this.taPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage tabpageprof;
        private TabPage taPage1;
        private ReaLTaiizor.Controls.MaterialComboBox txttipo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtid;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtdata;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
    }
}