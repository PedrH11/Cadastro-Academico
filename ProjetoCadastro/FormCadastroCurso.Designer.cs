namespace ProjetoCadastro
{
    partial class FormCadastroCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroCurso));
            TabControlCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastroCurso = new TabPage();
            cbxDuracao = new ReaLTaiizor.Controls.MaterialComboBox();
            btnCancelarCurso = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvarCurso = new ReaLTaiizor.Controls.MaterialButton();
            cbxPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxArea = new ReaLTaiizor.Controls.MaterialComboBox();
            cbxNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsultaCurso = new TabPage();
            btnNovoCurso = new ReaLTaiizor.Controls.MaterialButton();
            btnEditarCurso = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluirCurso = new ReaLTaiizor.Controls.MaterialButton();
            lvCursos = new ListView();
            imageList1 = new ImageList(components);
            TabControlCurso.SuspendLayout();
            tabPageCadastroCurso.SuspendLayout();
            tabPageConsultaCurso.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCurso
            // 
            TabControlCurso.Controls.Add(tabPageCadastroCurso);
            TabControlCurso.Controls.Add(tabPageConsultaCurso);
            TabControlCurso.Depth = 0;
            TabControlCurso.ImageList = imageList1;
            TabControlCurso.Location = new Point(6, 67);
            TabControlCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCurso.Multiline = true;
            TabControlCurso.Name = "TabControlCurso";
            TabControlCurso.SelectedIndex = 0;
            TabControlCurso.Size = new Size(712, 377);
            TabControlCurso.TabIndex = 0;
            // 
            // tabPageCadastroCurso
            // 
            tabPageCadastroCurso.Controls.Add(cbxDuracao);
            tabPageCadastroCurso.Controls.Add(btnCancelarCurso);
            tabPageCadastroCurso.Controls.Add(btnSalvarCurso);
            tabPageCadastroCurso.Controls.Add(cbxPeriodo);
            tabPageCadastroCurso.Controls.Add(cbxArea);
            tabPageCadastroCurso.Controls.Add(cbxNivel);
            tabPageCadastroCurso.Controls.Add(txtNomeCurso);
            tabPageCadastroCurso.Controls.Add(txtCodCurso);
            tabPageCadastroCurso.ImageKey = "form.png";
            tabPageCadastroCurso.Location = new Point(4, 29);
            tabPageCadastroCurso.Name = "tabPageCadastroCurso";
            tabPageCadastroCurso.Padding = new Padding(3);
            tabPageCadastroCurso.Size = new Size(780, 344);
            tabPageCadastroCurso.TabIndex = 0;
            tabPageCadastroCurso.Text = "Cadastro";
            tabPageCadastroCurso.UseVisualStyleBackColor = true;
            // 
            // cbxDuracao
            // 
            cbxDuracao.AutoResize = false;
            cbxDuracao.BackColor = Color.FromArgb(255, 255, 255);
            cbxDuracao.Depth = 0;
            cbxDuracao.DrawMode = DrawMode.OwnerDrawVariable;
            cbxDuracao.DropDownHeight = 174;
            cbxDuracao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDuracao.DropDownWidth = 121;
            cbxDuracao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxDuracao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxDuracao.FormattingEnabled = true;
            cbxDuracao.Hint = "Duração em semestres";
            cbxDuracao.IntegralHeight = false;
            cbxDuracao.ItemHeight = 43;
            cbxDuracao.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbxDuracao.Location = new Point(323, 149);
            cbxDuracao.MaxDropDownItems = 4;
            cbxDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxDuracao.Name = "cbxDuracao";
            cbxDuracao.Size = new Size(376, 49);
            cbxDuracao.StartIndex = 0;
            cbxDuracao.TabIndex = 9;
            // 
            // btnCancelarCurso
            // 
            btnCancelarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelarCurso.Depth = 0;
            btnCancelarCurso.HighEmphasis = true;
            btnCancelarCurso.Icon = null;
            btnCancelarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelarCurso.Location = new Point(509, 302);
            btnCancelarCurso.Margin = new Padding(4, 6, 4, 6);
            btnCancelarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelarCurso.Name = "btnCancelarCurso";
            btnCancelarCurso.NoAccentTextColor = Color.Empty;
            btnCancelarCurso.Size = new Size(96, 36);
            btnCancelarCurso.TabIndex = 12;
            btnCancelarCurso.Text = "Cancelar";
            btnCancelarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelarCurso.UseAccentColor = false;
            btnCancelarCurso.UseVisualStyleBackColor = true;
            btnCancelarCurso.Click += btnCancelarCurso_Click;
            // 
            // btnSalvarCurso
            // 
            btnSalvarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvarCurso.Depth = 0;
            btnSalvarCurso.HighEmphasis = true;
            btnSalvarCurso.Icon = null;
            btnSalvarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvarCurso.Location = new Point(623, 302);
            btnSalvarCurso.Margin = new Padding(4, 6, 4, 6);
            btnSalvarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvarCurso.Name = "btnSalvarCurso";
            btnSalvarCurso.NoAccentTextColor = Color.Empty;
            btnSalvarCurso.Size = new Size(76, 36);
            btnSalvarCurso.TabIndex = 13;
            btnSalvarCurso.Text = "Salvar";
            btnSalvarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvarCurso.UseAccentColor = false;
            btnSalvarCurso.UseVisualStyleBackColor = true;
            btnSalvarCurso.Click += btnSalvarCurso_Click;
            // 
            // cbxPeriodo
            // 
            cbxPeriodo.AutoResize = false;
            cbxPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cbxPeriodo.Depth = 0;
            cbxPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cbxPeriodo.DropDownHeight = 174;
            cbxPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPeriodo.DropDownWidth = 121;
            cbxPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxPeriodo.FormattingEnabled = true;
            cbxPeriodo.Hint = "Período";
            cbxPeriodo.IntegralHeight = false;
            cbxPeriodo.ItemHeight = 43;
            cbxPeriodo.Items.AddRange(new object[] { "Integral", "Matutino", "Noturno", "Vespertino", "" });
            cbxPeriodo.Location = new Point(323, 225);
            cbxPeriodo.MaxDropDownItems = 4;
            cbxPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxPeriodo.Name = "cbxPeriodo";
            cbxPeriodo.Size = new Size(376, 49);
            cbxPeriodo.StartIndex = 0;
            cbxPeriodo.TabIndex = 11;
            // 
            // cbxArea
            // 
            cbxArea.AutoResize = false;
            cbxArea.BackColor = Color.FromArgb(255, 255, 255);
            cbxArea.Depth = 0;
            cbxArea.DrawMode = DrawMode.OwnerDrawVariable;
            cbxArea.DropDownHeight = 174;
            cbxArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxArea.DropDownWidth = 121;
            cbxArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxArea.FormattingEnabled = true;
            cbxArea.Hint = "Área";
            cbxArea.IntegralHeight = false;
            cbxArea.ItemHeight = 43;
            cbxArea.Items.AddRange(new object[] { "Administração", "Indústria", "Informática", "Licenciatura" });
            cbxArea.Location = new Point(35, 225);
            cbxArea.MaxDropDownItems = 4;
            cbxArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxArea.Name = "cbxArea";
            cbxArea.Size = new Size(257, 49);
            cbxArea.StartIndex = 0;
            cbxArea.TabIndex = 10;
            // 
            // cbxNivel
            // 
            cbxNivel.AutoResize = false;
            cbxNivel.BackColor = Color.FromArgb(255, 255, 255);
            cbxNivel.Depth = 0;
            cbxNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cbxNivel.DropDownHeight = 174;
            cbxNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNivel.DropDownWidth = 121;
            cbxNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxNivel.FormattingEnabled = true;
            cbxNivel.Hint = "Nível";
            cbxNivel.IntegralHeight = false;
            cbxNivel.ItemHeight = 43;
            cbxNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cbxNivel.Location = new Point(35, 149);
            cbxNivel.MaxDropDownItems = 4;
            cbxNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbxNivel.Name = "cbxNivel";
            cbxNivel.Size = new Size(257, 49);
            cbxNivel.StartIndex = 0;
            cbxNivel.TabIndex = 8;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.AnimateReadOnly = false;
            txtNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCurso.BackgroundImageLayout = ImageLayout.None;
            txtNomeCurso.CharacterCasing = CharacterCasing.Normal;
            txtNomeCurso.Depth = 0;
            txtNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCurso.HideSelection = true;
            txtNomeCurso.Hint = "Nome do curso";
            txtNomeCurso.LeadingIcon = null;
            txtNomeCurso.Location = new Point(35, 85);
            txtNomeCurso.MaxLength = 32767;
            txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.PasswordChar = '\0';
            txtNomeCurso.PrefixSuffixText = null;
            txtNomeCurso.ReadOnly = false;
            txtNomeCurso.RightToLeft = RightToLeft.No;
            txtNomeCurso.SelectedText = "";
            txtNomeCurso.SelectionLength = 0;
            txtNomeCurso.SelectionStart = 0;
            txtNomeCurso.ShortcutsEnabled = true;
            txtNomeCurso.Size = new Size(664, 48);
            txtNomeCurso.TabIndex = 7;
            txtNomeCurso.TabStop = false;
            txtNomeCurso.TextAlign = HorizontalAlignment.Left;
            txtNomeCurso.TrailingIcon = null;
            txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // txtCodCurso
            // 
            txtCodCurso.AnimateReadOnly = false;
            txtCodCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtCodCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtCodCurso.BackgroundImageLayout = ImageLayout.None;
            txtCodCurso.CharacterCasing = CharacterCasing.Normal;
            txtCodCurso.Depth = 0;
            txtCodCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodCurso.HideSelection = true;
            txtCodCurso.Hint = "Código do curso";
            txtCodCurso.LeadingIcon = null;
            txtCodCurso.Location = new Point(35, 31);
            txtCodCurso.MaxLength = 32767;
            txtCodCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodCurso.Name = "txtCodCurso";
            txtCodCurso.PasswordChar = '\0';
            txtCodCurso.PrefixSuffixText = null;
            txtCodCurso.ReadOnly = false;
            txtCodCurso.RightToLeft = RightToLeft.No;
            txtCodCurso.SelectedText = "";
            txtCodCurso.SelectionLength = 0;
            txtCodCurso.SelectionStart = 0;
            txtCodCurso.ShortcutsEnabled = true;
            txtCodCurso.Size = new Size(664, 48);
            txtCodCurso.TabIndex = 6;
            txtCodCurso.TabStop = false;
            txtCodCurso.TextAlign = HorizontalAlignment.Left;
            txtCodCurso.TrailingIcon = null;
            txtCodCurso.UseSystemPasswordChar = false;
            // 
            // tabPageConsultaCurso
            // 
            tabPageConsultaCurso.Controls.Add(btnNovoCurso);
            tabPageConsultaCurso.Controls.Add(btnEditarCurso);
            tabPageConsultaCurso.Controls.Add(btnExcluirCurso);
            tabPageConsultaCurso.Controls.Add(lvCursos);
            tabPageConsultaCurso.ImageKey = "search.png";
            tabPageConsultaCurso.Location = new Point(4, 29);
            tabPageConsultaCurso.Name = "tabPageConsultaCurso";
            tabPageConsultaCurso.Padding = new Padding(3);
            tabPageConsultaCurso.Size = new Size(704, 344);
            tabPageConsultaCurso.TabIndex = 1;
            tabPageConsultaCurso.Text = "Consulta";
            tabPageConsultaCurso.UseVisualStyleBackColor = true;
            tabPageConsultaCurso.Enter += tabPageConsultaCurso_Enter;
            // 
            // btnNovoCurso
            // 
            btnNovoCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovoCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovoCurso.Depth = 0;
            btnNovoCurso.HighEmphasis = true;
            btnNovoCurso.Icon = null;
            btnNovoCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovoCurso.Location = new Point(456, 302);
            btnNovoCurso.Margin = new Padding(4, 6, 4, 6);
            btnNovoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovoCurso.Name = "btnNovoCurso";
            btnNovoCurso.NoAccentTextColor = Color.Empty;
            btnNovoCurso.Size = new Size(64, 36);
            btnNovoCurso.TabIndex = 3;
            btnNovoCurso.Text = "NOVO";
            btnNovoCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovoCurso.UseAccentColor = false;
            btnNovoCurso.UseVisualStyleBackColor = true;
            btnNovoCurso.Click += btnNovoCurso_Click;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarCurso.Depth = 0;
            btnEditarCurso.HighEmphasis = true;
            btnEditarCurso.Icon = null;
            btnEditarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditarCurso.Location = new Point(528, 302);
            btnEditarCurso.Margin = new Padding(4, 6, 4, 6);
            btnEditarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.NoAccentTextColor = Color.Empty;
            btnEditarCurso.Size = new Size(71, 36);
            btnEditarCurso.TabIndex = 2;
            btnEditarCurso.Text = "EDITAR";
            btnEditarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarCurso.UseAccentColor = false;
            btnEditarCurso.UseVisualStyleBackColor = true;
            btnEditarCurso.Click += btnEditarCurso_Click;
            // 
            // btnExcluirCurso
            // 
            btnExcluirCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluirCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluirCurso.Depth = 0;
            btnExcluirCurso.HighEmphasis = true;
            btnExcluirCurso.Icon = null;
            btnExcluirCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluirCurso.Location = new Point(607, 302);
            btnExcluirCurso.Margin = new Padding(4, 6, 4, 6);
            btnExcluirCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluirCurso.Name = "btnExcluirCurso";
            btnExcluirCurso.NoAccentTextColor = Color.Empty;
            btnExcluirCurso.Size = new Size(80, 36);
            btnExcluirCurso.TabIndex = 1;
            btnExcluirCurso.Text = "Excluir";
            btnExcluirCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluirCurso.UseAccentColor = false;
            btnExcluirCurso.UseVisualStyleBackColor = true;
            btnExcluirCurso.Click += btnExcluirCurso_Click;
            // 
            // lvCursos
            // 
            lvCursos.AutoArrange = false;
            lvCursos.FullRowSelect = true;
            lvCursos.Location = new Point(4, 0);
            lvCursos.Name = "lvCursos";
            lvCursos.Size = new Size(780, 302);
            lvCursos.TabIndex = 0;
            lvCursos.UseCompatibleStateImageBehavior = false;
            lvCursos.View = View.Details;
            lvCursos.MouseDoubleClick += lvCursos_MouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            imageList1.Images.SetKeyName(2, "logo.png");
            imageList1.Images.SetKeyName(3, "ifsp_icon.ico");
            imageList1.Images.SetKeyName(4, "baseline_fingerprint_black_24dp.png");
            // 
            // FormCadastroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(TabControlCurso);
            DrawerTabControl = TabControlCurso;
            Name = "FormCadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            TabControlCurso.ResumeLayout(false);
            tabPageCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.PerformLayout();
            tabPageConsultaCurso.ResumeLayout(false);
            tabPageConsultaCurso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCurso;
        private TabPage tabPageCadastroCurso;
        private TabPage tabPageConsultaCurso;
        private ReaLTaiizor.Controls.MaterialComboBox cbxPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cbxArea;
        private ReaLTaiizor.Controls.MaterialComboBox cbxNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodCurso;
        private ReaLTaiizor.Controls.MaterialButton btnCancelarCurso;
        private ReaLTaiizor.Controls.MaterialButton btnSalvarCurso;
        private ListView lvCursos;
        private ReaLTaiizor.Controls.MaterialButton btnNovoCurso;
        private ReaLTaiizor.Controls.MaterialButton btnEditarCurso;
        private ReaLTaiizor.Controls.MaterialButton btnExcluirCurso;
        private ReaLTaiizor.Controls.MaterialComboBox cbxDuracao;
        private ImageList imageList1;
    }
}