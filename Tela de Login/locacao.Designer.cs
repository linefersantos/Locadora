
namespace Tela_de_Login
{
    partial class locacao
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
            this.txtCodigoLocacao = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListarlocacao = new System.Windows.Forms.DataGridView();
            this.mtxtDtFimLocacao = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDtIníciolocacao = new System.Windows.Forms.MaskedTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnatu = new Guna.UI2.WinForms.Guna2Button();
            this.cbidFuncionario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbidCliente = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbidVeiculo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.txtValorLocacao = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblValorlocacao = new System.Windows.Forms.Label();
            this.lblTipoLocacao = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblNomeVeiculo = new System.Windows.Forms.Label();
            this.lblInicioLocacao = new System.Windows.Forms.Label();
            this.lblFimLocacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarlocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoLocacao
            // 
            this.txtCodigoLocacao.BorderColor = System.Drawing.Color.Blue;
            this.txtCodigoLocacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoLocacao.DefaultText = "";
            this.txtCodigoLocacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoLocacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoLocacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoLocacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoLocacao.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCodigoLocacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCodigoLocacao.ForeColor = System.Drawing.Color.White;
            this.txtCodigoLocacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoLocacao.Location = new System.Drawing.Point(26, 17);
            this.txtCodigoLocacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoLocacao.Name = "txtCodigoLocacao";
            this.txtCodigoLocacao.PasswordChar = '\0';
            this.txtCodigoLocacao.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCodigoLocacao.PlaceholderText = "ID";
            this.txtCodigoLocacao.SelectedText = "";
            this.txtCodigoLocacao.Size = new System.Drawing.Size(84, 27);
            this.txtCodigoLocacao.TabIndex = 49;
            this.txtCodigoLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvListarlocacao
            // 
            this.dgvListarlocacao.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListarlocacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarlocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarlocacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListarlocacao.Location = new System.Drawing.Point(0, 255);
            this.dgvListarlocacao.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListarlocacao.Name = "dgvListarlocacao";
            this.dgvListarlocacao.RowHeadersWidth = 51;
            this.dgvListarlocacao.RowTemplate.Height = 24;
            this.dgvListarlocacao.Size = new System.Drawing.Size(748, 265);
            this.dgvListarlocacao.TabIndex = 60;
            this.dgvListarlocacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarlocacao_CellClick);
            // 
            // mtxtDtFimLocacao
            // 
            this.mtxtDtFimLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtxtDtFimLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.mtxtDtFimLocacao.ForeColor = System.Drawing.SystemColors.Control;
            this.mtxtDtFimLocacao.Location = new System.Drawing.Point(529, 138);
            this.mtxtDtFimLocacao.Mask = "00/00/0000";
            this.mtxtDtFimLocacao.Name = "mtxtDtFimLocacao";
            this.mtxtDtFimLocacao.Size = new System.Drawing.Size(180, 23);
            this.mtxtDtFimLocacao.TabIndex = 75;
            this.mtxtDtFimLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDtFimLocacao.ValidatingType = typeof(System.DateTime);
            this.mtxtDtFimLocacao.Click += new System.EventHandler(this.mtxtDtFimLocacao_Click);
            // 
            // mtxtDtIníciolocacao
            // 
            this.mtxtDtIníciolocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtxtDtIníciolocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.mtxtDtIníciolocacao.ForeColor = System.Drawing.SystemColors.Control;
            this.mtxtDtIníciolocacao.Location = new System.Drawing.Point(529, 63);
            this.mtxtDtIníciolocacao.Mask = "00/00/0000";
            this.mtxtDtIníciolocacao.Name = "mtxtDtIníciolocacao";
            this.mtxtDtIníciolocacao.Size = new System.Drawing.Size(180, 23);
            this.mtxtDtIníciolocacao.TabIndex = 74;
            this.mtxtDtIníciolocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDtIníciolocacao.ValidatingType = typeof(System.DateTime);
            this.mtxtDtIníciolocacao.Click += new System.EventHandler(this.mtxtDtIníciolocacao_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(423, 211);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(125, 40);
            this.guna2Button1.TabIndex = 77;
            this.guna2Button1.Text = "Cadastrar";
            this.guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // btnatu
            // 
            this.btnatu.BorderRadius = 20;
            this.btnatu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnatu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnatu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnatu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnatu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnatu.ForeColor = System.Drawing.Color.White;
            this.btnatu.Location = new System.Drawing.Point(584, 211);
            this.btnatu.Margin = new System.Windows.Forms.Padding(2);
            this.btnatu.Name = "btnatu";
            this.btnatu.Size = new System.Drawing.Size(125, 40);
            this.btnatu.TabIndex = 76;
            this.btnatu.Text = "Atualizar";
            this.btnatu.Click += new System.EventHandler(this.btnatu_Click);
            // 
            // cbidFuncionario
            // 
            this.cbidFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.cbidFuncionario.BorderColor = System.Drawing.Color.Blue;
            this.cbidFuncionario.BorderRadius = 5;
            this.cbidFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbidFuncionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidFuncionario.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbidFuncionario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidFuncionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidFuncionario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbidFuncionario.ForeColor = System.Drawing.Color.White;
            this.cbidFuncionario.ItemHeight = 30;
            this.cbidFuncionario.Location = new System.Drawing.Point(270, 17);
            this.cbidFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cbidFuncionario.Name = "cbidFuncionario";
            this.cbidFuncionario.Size = new System.Drawing.Size(223, 36);
            this.cbidFuncionario.TabIndex = 79;
            this.cbidFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbidFuncionario.Click += new System.EventHandler(this.cbidFuncionario_Click);
            // 
            // cbidCliente
            // 
            this.cbidCliente.BackColor = System.Drawing.Color.Transparent;
            this.cbidCliente.BorderColor = System.Drawing.Color.Blue;
            this.cbidCliente.BorderRadius = 5;
            this.cbidCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbidCliente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidCliente.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbidCliente.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbidCliente.ForeColor = System.Drawing.Color.White;
            this.cbidCliente.ItemHeight = 30;
            this.cbidCliente.Location = new System.Drawing.Point(270, 90);
            this.cbidCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbidCliente.Name = "cbidCliente";
            this.cbidCliente.Size = new System.Drawing.Size(223, 36);
            this.cbidCliente.TabIndex = 78;
            this.cbidCliente.Click += new System.EventHandler(this.cbidCliente_Click);
            // 
            // cbidVeiculo
            // 
            this.cbidVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.cbidVeiculo.BorderColor = System.Drawing.Color.Blue;
            this.cbidVeiculo.BorderRadius = 5;
            this.cbidVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbidVeiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbidVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidVeiculo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbidVeiculo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidVeiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbidVeiculo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbidVeiculo.ForeColor = System.Drawing.Color.White;
            this.cbidVeiculo.ItemHeight = 30;
            this.cbidVeiculo.Location = new System.Drawing.Point(270, 160);
            this.cbidVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.cbidVeiculo.Name = "cbidVeiculo";
            this.cbidVeiculo.Size = new System.Drawing.Size(223, 36);
            this.cbidVeiculo.TabIndex = 80;
            this.cbidVeiculo.Click += new System.EventHandler(this.cbidVeiculo_Click);
            // 
            // txtValorLocacao
            // 
            this.txtValorLocacao.BackColor = System.Drawing.Color.Transparent;
            this.txtValorLocacao.BorderRadius = 5;
            this.txtValorLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtValorLocacao.DecimalPlaces = 2;
            this.txtValorLocacao.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorLocacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValorLocacao.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtValorLocacao.Location = new System.Drawing.Point(26, 83);
            this.txtValorLocacao.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtValorLocacao.Name = "txtValorLocacao";
            this.txtValorLocacao.Size = new System.Drawing.Size(229, 32);
            this.txtValorLocacao.TabIndex = 81;
            this.txtValorLocacao.ThousandsSeparator = true;
            this.txtValorLocacao.UpDownButtonFillColor = System.Drawing.Color.White;
            this.txtValorLocacao.Click += new System.EventHandler(this.txtValorLocacao_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.Transparent;
            this.cbTipo.BorderColor = System.Drawing.Color.Blue;
            this.cbTipo.BorderRadius = 5;
            this.cbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbTipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipo.ForeColor = System.Drawing.Color.White;
            this.cbTipo.ItemHeight = 30;
            this.cbTipo.Items.AddRange(new object[] {
            "DIARIO",
            "SEMANAL",
            "MENSAL",
            "ANUAL"});
            this.cbTipo.Location = new System.Drawing.Point(26, 160);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(229, 36);
            this.cbTipo.TabIndex = 82;
            this.cbTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbTipo.Click += new System.EventHandler(this.cbTipo_Click);
            // 
            // lblValorlocacao
            // 
            this.lblValorlocacao.AutoSize = true;
            this.lblValorlocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorlocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblValorlocacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblValorlocacao.ForeColor = System.Drawing.Color.White;
            this.lblValorlocacao.Location = new System.Drawing.Point(35, 89);
            this.lblValorlocacao.Name = "lblValorlocacao";
            this.lblValorlocacao.Size = new System.Drawing.Size(140, 20);
            this.lblValorlocacao.TabIndex = 94;
            this.lblValorlocacao.Text = "Selecione um valor";
            this.lblValorlocacao.Click += new System.EventHandler(this.lblValorlocacao_Click);
            // 
            // lblTipoLocacao
            // 
            this.lblTipoLocacao.AutoSize = true;
            this.lblTipoLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipoLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTipoLocacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoLocacao.ForeColor = System.Drawing.Color.White;
            this.lblTipoLocacao.Location = new System.Drawing.Point(34, 168);
            this.lblTipoLocacao.Name = "lblTipoLocacao";
            this.lblTipoLocacao.Size = new System.Drawing.Size(121, 20);
            this.lblTipoLocacao.TabIndex = 95;
            this.lblTipoLocacao.Text = "Tipo de Locação";
            this.lblTipoLocacao.Click += new System.EventHandler(this.lblTipoLocacao_Click);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomeFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(275, 25);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(158, 20);
            this.lblNomeFuncionario.TabIndex = 96;
            this.lblNomeFuncionario.Text = "Nome do funcionário";
            this.lblNomeFuncionario.Click += new System.EventHandler(this.lblNomeFuncionario_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomeCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(272, 98);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(124, 20);
            this.lblNomeCliente.TabIndex = 97;
            this.lblNomeCliente.Text = "Nome do cliente";
            this.lblNomeCliente.Click += new System.EventHandler(this.lblNomeCliente_Click);
            // 
            // lblNomeVeiculo
            // 
            this.lblNomeVeiculo.AutoSize = true;
            this.lblNomeVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNomeVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomeVeiculo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNomeVeiculo.ForeColor = System.Drawing.Color.White;
            this.lblNomeVeiculo.Location = new System.Drawing.Point(275, 168);
            this.lblNomeVeiculo.Name = "lblNomeVeiculo";
            this.lblNomeVeiculo.Size = new System.Drawing.Size(127, 20);
            this.lblNomeVeiculo.TabIndex = 98;
            this.lblNomeVeiculo.Text = "Nome do veículo";
            this.lblNomeVeiculo.Click += new System.EventHandler(this.lblNomeVeiculo_Click);
            // 
            // lblInicioLocacao
            // 
            this.lblInicioLocacao.AutoSize = true;
            this.lblInicioLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInicioLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInicioLocacao.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblInicioLocacao.ForeColor = System.Drawing.Color.White;
            this.lblInicioLocacao.Location = new System.Drawing.Point(560, 66);
            this.lblInicioLocacao.Name = "lblInicioLocacao";
            this.lblInicioLocacao.Size = new System.Drawing.Size(111, 17);
            this.lblInicioLocacao.TabIndex = 99;
            this.lblInicioLocacao.Text = "início da locação";
            this.lblInicioLocacao.Click += new System.EventHandler(this.lblInicioLocacao_Click);
            // 
            // lblFimLocacao
            // 
            this.lblFimLocacao.AutoSize = true;
            this.lblFimLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFimLocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFimLocacao.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblFimLocacao.ForeColor = System.Drawing.Color.White;
            this.lblFimLocacao.Location = new System.Drawing.Point(564, 141);
            this.lblFimLocacao.Name = "lblFimLocacao";
            this.lblFimLocacao.Size = new System.Drawing.Size(100, 17);
            this.lblFimLocacao.TabIndex = 100;
            this.lblFimLocacao.Text = "Fim da locação";
            this.lblFimLocacao.Click += new System.EventHandler(this.lblFimLocacao_Click);
            // 
            // locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 520);
            this.Controls.Add(this.lblFimLocacao);
            this.Controls.Add(this.lblInicioLocacao);
            this.Controls.Add(this.lblNomeVeiculo);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.lblTipoLocacao);
            this.Controls.Add(this.lblValorlocacao);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtValorLocacao);
            this.Controls.Add(this.cbidVeiculo);
            this.Controls.Add(this.cbidFuncionario);
            this.Controls.Add(this.cbidCliente);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnatu);
            this.Controls.Add(this.mtxtDtFimLocacao);
            this.Controls.Add(this.mtxtDtIníciolocacao);
            this.Controls.Add(this.dgvListarlocacao);
            this.Controls.Add(this.txtCodigoLocacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "locacao";
            this.Text = "locacao";
            this.Load += new System.EventHandler(this.locacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarlocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoLocacao;
        private System.Windows.Forms.DataGridView dgvListarlocacao;
        private System.Windows.Forms.MaskedTextBox mtxtDtFimLocacao;
        private System.Windows.Forms.MaskedTextBox mtxtDtIníciolocacao;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnatu;
        private Guna.UI2.WinForms.Guna2ComboBox cbidFuncionario;
        private Guna.UI2.WinForms.Guna2ComboBox cbidCliente;
        private Guna.UI2.WinForms.Guna2ComboBox cbidVeiculo;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtValorLocacao;
        private Guna.UI2.WinForms.Guna2ComboBox cbTipo;
        private System.Windows.Forms.Label lblValorlocacao;
        private System.Windows.Forms.Label lblTipoLocacao;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblNomeVeiculo;
        private System.Windows.Forms.Label lblInicioLocacao;
        private System.Windows.Forms.Label lblFimLocacao;
    }
}