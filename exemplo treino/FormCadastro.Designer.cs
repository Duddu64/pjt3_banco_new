using ReaLTaiizor.Forms;

namespace exemplo_treino

{
    partial class FormCadastro : MaterialForm
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
            this.tabpage = new ReaLTaiizor.Controls.AirTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.txtsenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtuf = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtcidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtbairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtendereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtmatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtdata = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialButton5 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton4 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            this.tabpage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpage
            // 
            this.tabpage.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabpage.BaseColor = System.Drawing.Color.White;
            this.tabpage.Controls.Add(this.tabPage1);
            this.tabpage.Controls.Add(this.tabPage2);
            this.tabpage.ItemSize = new System.Drawing.Size(30, 115);
            this.tabpage.Location = new System.Drawing.Point(6, 67);
            this.tabpage.Multiline = true;
            this.tabpage.Name = "tabpage";
            this.tabpage.NormalTextColor = System.Drawing.Color.DimGray;
            this.tabpage.SelectedIndex = 0;
            this.tabpage.SelectedTabBackColor = System.Drawing.Color.White;
            this.tabpage.SelectedTextColor = System.Drawing.Color.Black;
            this.tabpage.ShowOuterBorders = false;
            this.tabpage.Size = new System.Drawing.Size(788, 461);
            this.tabpage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabpage.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.tabpage.TabCursor = System.Windows.Forms.Cursors.Hand;
            this.tabpage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.txtsenha);
            this.tabPage1.Controls.Add(this.txtuf);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.txtmatricula);
            this.tabPage1.Controls.Add(this.txtdata);
            this.tabPage1.Location = new System.Drawing.Point(119, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(466, 348);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(96, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "CANCELAR";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(570, 348);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(76, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Salvar";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.AnimateReadOnly = false;
            this.txtsenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtsenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtsenha.Depth = 0;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtsenha.HideSelection = true;
            this.txtsenha.Hint = "Senha";
            this.txtsenha.LeadingIcon = null;
            this.txtsenha.Location = new System.Drawing.Point(17, 291);
            this.txtsenha.MaxLength = 32767;
            this.txtsenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.PrefixSuffixText = null;
            this.txtsenha.ReadOnly = false;
            this.txtsenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtsenha.SelectedText = "";
            this.txtsenha.SelectionLength = 0;
            this.txtsenha.SelectionStart = 0;
            this.txtsenha.ShortcutsEnabled = true;
            this.txtsenha.Size = new System.Drawing.Size(629, 48);
            this.txtsenha.TabIndex = 7;
            this.txtsenha.TabStop = false;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsenha.TrailingIcon = null;
            this.txtsenha.UseSystemPasswordChar = false;
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
            this.txtuf.Location = new System.Drawing.Point(525, 236);
            this.txtuf.MaxDropDownItems = 4;
            this.txtuf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(121, 49);
            this.txtuf.StartIndex = 0;
            this.txtuf.TabIndex = 6;
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
            this.txtcidade.Location = new System.Drawing.Point(17, 236);
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
            this.txtcidade.Size = new System.Drawing.Size(502, 48);
            this.txtcidade.TabIndex = 5;
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
            this.txtbairro.Location = new System.Drawing.Point(17, 182);
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
            this.txtbairro.Size = new System.Drawing.Size(629, 48);
            this.txtbairro.TabIndex = 4;
            this.txtbairro.TabStop = false;
            this.txtbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbairro.TrailingIcon = null;
            this.txtbairro.UseSystemPasswordChar = false;
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
            this.txtendereco.Location = new System.Drawing.Point(17, 128);
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
            this.txtendereco.Size = new System.Drawing.Size(629, 48);
            this.txtendereco.TabIndex = 3;
            this.txtendereco.TabStop = false;
            this.txtendereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtendereco.TrailingIcon = null;
            this.txtendereco.UseSystemPasswordChar = false;
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
            this.txtNome.Location = new System.Drawing.Point(17, 74);
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
            this.txtNome.Size = new System.Drawing.Size(629, 48);
            this.txtNome.TabIndex = 2;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            this.txtNome.Click += new System.EventHandler(this.materialTextBoxEdit1_Click);
            // 
            // txtmatricula
            // 
            this.txtmatricula.AnimateReadOnly = false;
            this.txtmatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtmatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtmatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtmatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtmatricula.Depth = 0;
            this.txtmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtmatricula.HideSelection = true;
            this.txtmatricula.Hint = "Matricula";
            this.txtmatricula.LeadingIcon = null;
            this.txtmatricula.Location = new System.Drawing.Point(17, 20);
            this.txtmatricula.MaxLength = 32767;
            this.txtmatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.PasswordChar = '\0';
            this.txtmatricula.PrefixSuffixText = null;
            this.txtmatricula.ReadOnly = false;
            this.txtmatricula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmatricula.SelectedText = "";
            this.txtmatricula.SelectionLength = 0;
            this.txtmatricula.SelectionStart = 0;
            this.txtmatricula.ShortcutsEnabled = true;
            this.txtmatricula.Size = new System.Drawing.Size(373, 48);
            this.txtmatricula.TabIndex = 0;
            this.txtmatricula.TabStop = false;
            this.txtmatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmatricula.TrailingIcon = null;
            this.txtmatricula.UseSystemPasswordChar = false;
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
            this.txtdata.Hint = "Data de nascimento";
            this.txtdata.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtdata.LeadingIcon = null;
            this.txtdata.Location = new System.Drawing.Point(396, 20);
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
            this.txtdata.TabIndex = 1;
            this.txtdata.TabStop = false;
            this.txtdata.Text = "  /  /";
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdata.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.TrailingIcon = null;
            this.txtdata.UseSystemPasswordChar = false;
            this.txtdata.ValidatingType = null;
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
            this.tabPage2.Size = new System.Drawing.Size(665, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(652, 386);
            this.dataGridView1.TabIndex = 4;
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton5.Location = new System.Drawing.Point(391, 401);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(80, 36);
            this.materialButton5.TabIndex = 3;
            this.materialButton5.Text = "EXCLUIR";
            this.materialButton5.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton4.Location = new System.Drawing.Point(594, 401);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(64, 36);
            this.materialButton4.TabIndex = 2;
            this.materialButton4.Text = "NOVO";
            this.materialButton4.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton3.Location = new System.Drawing.Point(496, 401);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(71, 36);
            this.materialButton3.TabIndex = 1;
            this.materialButton3.Text = "EDITAR";
            this.materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tabpage);
            this.Name = "FormCadastro";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.tabpage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage tabpage;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtbairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtendereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtmatricula;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtdata;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialComboBox txtuf;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtcidade;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtsenha;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
        private DataGridView dataGridView1;
    }
}