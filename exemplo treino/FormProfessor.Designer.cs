namespace exemplo_treino
{
    partial class FormProfessor
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
            this.txtuf = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txttitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtid = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtcidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtbairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtendereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtarea = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtdata = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtmatriculaprof = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            this.tabpageprof.Size = new System.Drawing.Size(882, 478);
            this.tabpageprof.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabpageprof.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.tabpageprof.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.tabpageprof.TabIndex = 0;
            // 
            // taPage1
            // 
            this.taPage1.BackColor = System.Drawing.Color.White;
            this.taPage1.Controls.Add(this.txtuf);
            this.taPage1.Controls.Add(this.txttitulacao);
            this.taPage1.Controls.Add(this.txtid);
            this.taPage1.Controls.Add(this.txtcidade);
            this.taPage1.Controls.Add(this.txtbairro);
            this.taPage1.Controls.Add(this.txtendereco);
            this.taPage1.Controls.Add(this.txtarea);
            this.taPage1.Controls.Add(this.txtNome);
            this.taPage1.Controls.Add(this.txtdata);
            this.taPage1.Controls.Add(this.txtmatriculaprof);
            this.taPage1.Controls.Add(this.btnCancelar);
            this.taPage1.Controls.Add(this.btnSalvar);
            this.taPage1.Location = new System.Drawing.Point(119, 4);
            this.taPage1.Name = "taPage1";
            this.taPage1.Padding = new System.Windows.Forms.Padding(3);
            this.taPage1.Size = new System.Drawing.Size(759, 470);
            this.taPage1.TabIndex = 0;
            this.taPage1.Text = "Cadastro";
            // 
            // txtuf
            // 
            this.txtuf.AutoResize = false;
            this.txtuf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtuf.Depth = 0;
            this.txtuf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtuf.DropDownHeight = 174;
            this.txtuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtuf.DropDownWidth = 121;
            this.txtuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtuf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Hint = "UF";
            this.txtuf.IntegralHeight = false;
            this.txtuf.ItemHeight = 43;
            this.txtuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MS",
            "MT",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(469, 275);
            this.txtuf.MaxDropDownItems = 4;
            this.txtuf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(250, 49);
            this.txtuf.StartIndex = 0;
            this.txtuf.TabIndex = 16;
            // 
            // txttitulacao
            // 
            this.txttitulacao.AutoResize = false;
            this.txttitulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txttitulacao.Depth = 0;
            this.txttitulacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txttitulacao.DropDownHeight = 174;
            this.txttitulacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttitulacao.DropDownWidth = 121;
            this.txttitulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txttitulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txttitulacao.FormattingEnabled = true;
            this.txttitulacao.Hint = "Titulação";
            this.txttitulacao.IntegralHeight = false;
            this.txttitulacao.ItemHeight = 43;
            this.txttitulacao.Items.AddRange(new object[] {
            "Graduado",
            "Especalizado",
            "Mestrado",
            "Doutorado"});
            this.txttitulacao.Location = new System.Drawing.Point(469, 114);
            this.txttitulacao.MaxDropDownItems = 4;
            this.txttitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txttitulacao.Name = "txttitulacao";
            this.txttitulacao.Size = new System.Drawing.Size(250, 49);
            this.txttitulacao.StartIndex = 0;
            this.txttitulacao.TabIndex = 15;
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
            // txtcidade
            // 
            this.txtcidade.AnimateReadOnly = false;
            this.txtcidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcidade.Depth = 0;
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcidade.HideSelection = true;
            this.txtcidade.Hint = "Cidade";
            this.txtcidade.LeadingIcon = null;
            this.txtcidade.Location = new System.Drawing.Point(19, 276);
            this.txtcidade.MaxLength = 32767;
            this.txtcidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.PasswordChar = '\0';
            this.txtcidade.PrefixSuffixText = null;
            this.txtcidade.ReadOnly = false;
            this.txtcidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcidade.SelectedText = "";
            this.txtcidade.SelectionLength = 0;
            this.txtcidade.SelectionStart = 0;
            this.txtcidade.ShortcutsEnabled = true;
            this.txtcidade.Size = new System.Drawing.Size(444, 48);
            this.txtcidade.TabIndex = 13;
            this.txtcidade.TabStop = false;
            this.txtcidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcidade.TrailingIcon = null;
            this.txtcidade.UseSystemPasswordChar = false;
            // 
            // txtbairro
            // 
            this.txtbairro.AnimateReadOnly = false;
            this.txtbairro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtbairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtbairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbairro.Depth = 0;
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbairro.HideSelection = true;
            this.txtbairro.Hint = "Bairro";
            this.txtbairro.LeadingIcon = null;
            this.txtbairro.Location = new System.Drawing.Point(19, 222);
            this.txtbairro.MaxLength = 32767;
            this.txtbairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.PasswordChar = '\0';
            this.txtbairro.PrefixSuffixText = null;
            this.txtbairro.ReadOnly = false;
            this.txtbairro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbairro.SelectedText = "";
            this.txtbairro.SelectionLength = 0;
            this.txtbairro.SelectionStart = 0;
            this.txtbairro.ShortcutsEnabled = true;
            this.txtbairro.Size = new System.Drawing.Size(700, 48);
            this.txtbairro.TabIndex = 12;
            this.txtbairro.TabStop = false;
            this.txtbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbairro.TrailingIcon = null;
            this.txtbairro.UseSystemPasswordChar = false;
            this.txtbairro.Click += new System.EventHandler(this.materialTextBoxEdit4_Click);
            // 
            // txtendereco
            // 
            this.txtendereco.AnimateReadOnly = false;
            this.txtendereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtendereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtendereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtendereco.Depth = 0;
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtendereco.HideSelection = true;
            this.txtendereco.Hint = "Endereço";
            this.txtendereco.LeadingIcon = null;
            this.txtendereco.Location = new System.Drawing.Point(19, 168);
            this.txtendereco.MaxLength = 32767;
            this.txtendereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.PasswordChar = '\0';
            this.txtendereco.PrefixSuffixText = null;
            this.txtendereco.ReadOnly = false;
            this.txtendereco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtendereco.SelectedText = "";
            this.txtendereco.SelectionLength = 0;
            this.txtendereco.SelectionStart = 0;
            this.txtendereco.ShortcutsEnabled = true;
            this.txtendereco.Size = new System.Drawing.Size(700, 48);
            this.txtendereco.TabIndex = 11;
            this.txtendereco.TabStop = false;
            this.txtendereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtendereco.TrailingIcon = null;
            this.txtendereco.UseSystemPasswordChar = false;
            // 
            // txtarea
            // 
            this.txtarea.AnimateReadOnly = false;
            this.txtarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtarea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtarea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtarea.Depth = 0;
            this.txtarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtarea.HideSelection = true;
            this.txtarea.Hint = "Area de formação";
            this.txtarea.LeadingIcon = null;
            this.txtarea.Location = new System.Drawing.Point(19, 114);
            this.txtarea.MaxLength = 32767;
            this.txtarea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtarea.Name = "txtarea";
            this.txtarea.PasswordChar = '\0';
            this.txtarea.PrefixSuffixText = null;
            this.txtarea.ReadOnly = false;
            this.txtarea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtarea.SelectedText = "";
            this.txtarea.SelectionLength = 0;
            this.txtarea.SelectionStart = 0;
            this.txtarea.ShortcutsEnabled = true;
            this.txtarea.Size = new System.Drawing.Size(444, 48);
            this.txtarea.TabIndex = 10;
            this.txtarea.TabStop = false;
            this.txtarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtarea.TrailingIcon = null;
            this.txtarea.UseSystemPasswordChar = false;
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
            this.txtNome.Location = new System.Drawing.Point(19, 60);
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
            this.txtNome.Size = new System.Drawing.Size(444, 48);
            this.txtNome.TabIndex = 9;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
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
            this.txtdata.Hint = "Data de Nascimento";
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
            // txtmatriculaprof
            // 
            this.txtmatriculaprof.AnimateReadOnly = false;
            this.txtmatriculaprof.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmatriculaprof.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmatriculaprof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtmatriculaprof.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmatriculaprof.Depth = 0;
            this.txtmatriculaprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmatriculaprof.HideSelection = true;
            this.txtmatriculaprof.Hint = "Matricula";
            this.txtmatriculaprof.LeadingIcon = null;
            this.txtmatriculaprof.Location = new System.Drawing.Point(19, 6);
            this.txtmatriculaprof.MaxLength = 32767;
            this.txtmatriculaprof.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtmatriculaprof.Name = "txtmatriculaprof";
            this.txtmatriculaprof.PasswordChar = '\0';
            this.txtmatriculaprof.PrefixSuffixText = null;
            this.txtmatriculaprof.ReadOnly = false;
            this.txtmatriculaprof.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmatriculaprof.SelectedText = "";
            this.txtmatriculaprof.SelectionLength = 0;
            this.txtmatriculaprof.SelectionStart = 0;
            this.txtmatriculaprof.ShortcutsEnabled = true;
            this.txtmatriculaprof.Size = new System.Drawing.Size(559, 48);
            this.txtmatriculaprof.TabIndex = 2;
            this.txtmatriculaprof.TabStop = false;
            this.txtmatriculaprof.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmatriculaprof.TrailingIcon = null;
            this.txtmatriculaprof.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCancelar.Location = new System.Drawing.Point(528, 371);
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
            this.btnSalvar.Location = new System.Drawing.Point(643, 371);
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
            this.tabPage2.Size = new System.Drawing.Size(759, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
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
            this.dataGridView1.Size = new System.Drawing.Size(747, 396);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton5.Location = new System.Drawing.Point(486, 411);
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
            this.materialButton4.Location = new System.Drawing.Point(689, 411);
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
            this.materialButton3.Location = new System.Drawing.Point(591, 411);
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
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 551);
            this.Controls.Add(this.tabpageprof);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
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
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtmatriculaprof;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtdata;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtbairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtendereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtarea;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtid;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtcidade;
        private ReaLTaiizor.Controls.MaterialComboBox txttitulacao;
        private ReaLTaiizor.Controls.MaterialComboBox txtuf;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private DataGridView dataGridView1;
    }
}