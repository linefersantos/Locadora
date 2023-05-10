
namespace Tela_de_Login
{
    partial class Veiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Veiculo));
            this.btnAtuVeiculo = new Guna.UI2.WinForms.Guna2Button();
            this.btnCadVeiculo = new Guna.UI2.WinForms.Guna2Button();
            this.dgvListarVeiculo = new System.Windows.Forms.DataGridView();
            this.cbModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.cbMarca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtVeiculoId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKmVeiculo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAnoFab = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorVeiculo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomeVeiculo = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtValorVeiculo = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblValorVeiculo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtuVeiculo
            // 
            this.btnAtuVeiculo.Animated = true;
            this.btnAtuVeiculo.BorderRadius = 20;
            this.btnAtuVeiculo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAtuVeiculo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAtuVeiculo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAtuVeiculo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAtuVeiculo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAtuVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnAtuVeiculo.Location = new System.Drawing.Point(605, 200);
            this.btnAtuVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtuVeiculo.Name = "btnAtuVeiculo";
            this.btnAtuVeiculo.Size = new System.Drawing.Size(132, 37);
            this.btnAtuVeiculo.TabIndex = 42;
            this.btnAtuVeiculo.Text = "Atualizar";
            this.btnAtuVeiculo.Click += new System.EventHandler(this.BtnAtuVeiculo_Click);
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Animated = true;
            this.btnCadVeiculo.BorderRadius = 20;
            this.btnCadVeiculo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadVeiculo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadVeiculo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadVeiculo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadVeiculo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCadVeiculo.ForeColor = System.Drawing.Color.White;
            this.btnCadVeiculo.Location = new System.Drawing.Point(447, 200);
            this.btnCadVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(132, 37);
            this.btnCadVeiculo.TabIndex = 41;
            this.btnCadVeiculo.Text = "Cadastrar";
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // dgvListarVeiculo
            // 
            this.dgvListarVeiculo.BackgroundColor = System.Drawing.Color.White;
            this.dgvListarVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarVeiculo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListarVeiculo.Location = new System.Drawing.Point(0, 241);
            this.dgvListarVeiculo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListarVeiculo.Name = "dgvListarVeiculo";
            this.dgvListarVeiculo.RowHeadersWidth = 51;
            this.dgvListarVeiculo.RowTemplate.Height = 24;
            this.dgvListarVeiculo.Size = new System.Drawing.Size(748, 279);
            this.dgvListarVeiculo.TabIndex = 36;
            this.dgvListarVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarVeiculo_CellClick);
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.Color.Transparent;
            this.cbModelo.BorderColor = System.Drawing.Color.Blue;
            this.cbModelo.BorderRadius = 5;
            this.cbModelo.DataSource = this.mySqlCommand1.Parameters;
            this.cbModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbModelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbModelo.ForeColor = System.Drawing.Color.White;
            this.cbModelo.ItemHeight = 30;
            this.cbModelo.Location = new System.Drawing.Point(479, 8);
            this.cbModelo.Margin = new System.Windows.Forms.Padding(2);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(184, 36);
            this.cbModelo.TabIndex = 75;
            this.cbModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            this.cbModelo.Click += new System.EventHandler(this.CbModelo_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.Transparent;
            this.cbMarca.BorderColor = System.Drawing.Color.Blue;
            this.cbMarca.BorderRadius = 5;
            this.cbMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbMarca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbMarca.ForeColor = System.Drawing.Color.White;
            this.cbMarca.ItemHeight = 30;
            this.cbMarca.Location = new System.Drawing.Point(244, 177);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(184, 36);
            this.cbMarca.TabIndex = 74;
            this.cbMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            this.cbMarca.Click += new System.EventHandler(this.CbMarca_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.Blue;
            this.cbStatus.BorderRadius = 5;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "DISPONÍVEL",
            "INDISPONÍVEL"});
            this.cbStatus.Location = new System.Drawing.Point(244, 114);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(184, 36);
            this.cbStatus.TabIndex = 73;
            this.cbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.CbStatus_Click);
            // 
            // txtVeiculoId
            // 
            this.txtVeiculoId.BorderColor = System.Drawing.Color.Transparent;
            this.txtVeiculoId.BorderRadius = 5;
            this.txtVeiculoId.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtVeiculoId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVeiculoId.DefaultText = "";
            this.txtVeiculoId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVeiculoId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVeiculoId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVeiculoId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVeiculoId.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtVeiculoId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVeiculoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtVeiculoId.ForeColor = System.Drawing.Color.White;
            this.txtVeiculoId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVeiculoId.Location = new System.Drawing.Point(12, 11);
            this.txtVeiculoId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVeiculoId.Name = "txtVeiculoId";
            this.txtVeiculoId.PasswordChar = '\0';
            this.txtVeiculoId.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtVeiculoId.PlaceholderText = "ID";
            this.txtVeiculoId.SelectedText = "";
            this.txtVeiculoId.Size = new System.Drawing.Size(59, 29);
            this.txtVeiculoId.TabIndex = 72;
            this.txtVeiculoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKmVeiculo
            // 
            this.txtKmVeiculo.BorderColor = System.Drawing.Color.Blue;
            this.txtKmVeiculo.BorderRadius = 5;
            this.txtKmVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKmVeiculo.DefaultText = "";
            this.txtKmVeiculo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKmVeiculo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKmVeiculo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKmVeiculo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKmVeiculo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtKmVeiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKmVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtKmVeiculo.ForeColor = System.Drawing.Color.White;
            this.txtKmVeiculo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKmVeiculo.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtKmVeiculo.IconLeft")));
            this.txtKmVeiculo.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txtKmVeiculo.Location = new System.Drawing.Point(244, 8);
            this.txtKmVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKmVeiculo.Name = "txtKmVeiculo";
            this.txtKmVeiculo.PasswordChar = '\0';
            this.txtKmVeiculo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtKmVeiculo.PlaceholderText = "Km";
            this.txtKmVeiculo.SelectedText = "";
            this.txtKmVeiculo.Size = new System.Drawing.Size(184, 32);
            this.txtKmVeiculo.TabIndex = 70;
            this.txtKmVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnoFab
            // 
            this.txtAnoFab.BorderColor = System.Drawing.Color.Blue;
            this.txtAnoFab.BorderRadius = 5;
            this.txtAnoFab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnoFab.DefaultText = "";
            this.txtAnoFab.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnoFab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnoFab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnoFab.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnoFab.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAnoFab.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnoFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtAnoFab.ForeColor = System.Drawing.Color.White;
            this.txtAnoFab.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnoFab.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtAnoFab.IconLeft")));
            this.txtAnoFab.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txtAnoFab.Location = new System.Drawing.Point(12, 118);
            this.txtAnoFab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnoFab.Name = "txtAnoFab";
            this.txtAnoFab.PasswordChar = '\0';
            this.txtAnoFab.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAnoFab.PlaceholderText = "Ano/Fab";
            this.txtAnoFab.SelectedText = "";
            this.txtAnoFab.Size = new System.Drawing.Size(214, 32);
            this.txtAnoFab.TabIndex = 69;
            this.txtAnoFab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorVeiculo
            // 
            this.txtCorVeiculo.BorderColor = System.Drawing.Color.Blue;
            this.txtCorVeiculo.BorderRadius = 5;
            this.txtCorVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorVeiculo.DefaultText = "";
            this.txtCorVeiculo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorVeiculo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorVeiculo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorVeiculo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorVeiculo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCorVeiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCorVeiculo.ForeColor = System.Drawing.Color.White;
            this.txtCorVeiculo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorVeiculo.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtCorVeiculo.IconLeft")));
            this.txtCorVeiculo.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txtCorVeiculo.Location = new System.Drawing.Point(12, 181);
            this.txtCorVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorVeiculo.Name = "txtCorVeiculo";
            this.txtCorVeiculo.PasswordChar = '\0';
            this.txtCorVeiculo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCorVeiculo.PlaceholderText = "Cor";
            this.txtCorVeiculo.SelectedText = "";
            this.txtCorVeiculo.Size = new System.Drawing.Size(214, 32);
            this.txtCorVeiculo.TabIndex = 68;
            this.txtCorVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeVeiculo
            // 
            this.txtNomeVeiculo.BorderColor = System.Drawing.Color.Blue;
            this.txtNomeVeiculo.BorderRadius = 5;
            this.txtNomeVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeVeiculo.DefaultText = "";
            this.txtNomeVeiculo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeVeiculo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeVeiculo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeVeiculo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeVeiculo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNomeVeiculo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNomeVeiculo.ForeColor = System.Drawing.Color.White;
            this.txtNomeVeiculo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeVeiculo.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNomeVeiculo.IconLeft")));
            this.txtNomeVeiculo.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txtNomeVeiculo.Location = new System.Drawing.Point(12, 59);
            this.txtNomeVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeVeiculo.Name = "txtNomeVeiculo";
            this.txtNomeVeiculo.PasswordChar = '\0';
            this.txtNomeVeiculo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtNomeVeiculo.PlaceholderText = "Nome";
            this.txtNomeVeiculo.SelectedText = "";
            this.txtNomeVeiculo.Size = new System.Drawing.Size(214, 32);
            this.txtNomeVeiculo.TabIndex = 67;
            this.txtNomeVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 181);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(484, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(479, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(230, 110);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            // 
            // txtValorVeiculo
            // 
            this.txtValorVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.txtValorVeiculo.BorderColor = System.Drawing.Color.Blue;
            this.txtValorVeiculo.BorderRadius = 5;
            this.txtValorVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorVeiculo.DecimalPlaces = 2;
            this.txtValorVeiculo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtValorVeiculo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVeiculo.ForeColor = System.Drawing.Color.White;
            this.txtValorVeiculo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtValorVeiculo.Location = new System.Drawing.Point(244, 59);
            this.txtValorVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValorVeiculo.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtValorVeiculo.Name = "txtValorVeiculo";
            this.txtValorVeiculo.Size = new System.Drawing.Size(184, 36);
            this.txtValorVeiculo.TabIndex = 85;
            this.txtValorVeiculo.ThousandsSeparator = true;
            this.txtValorVeiculo.UpDownButtonFillColor = System.Drawing.Color.Gainsboro;
            // 
            // lblValorVeiculo
            // 
            this.lblValorVeiculo.AutoSize = true;
            this.lblValorVeiculo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorVeiculo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblValorVeiculo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblValorVeiculo.ForeColor = System.Drawing.Color.White;
            this.lblValorVeiculo.Location = new System.Drawing.Point(253, 67);
            this.lblValorVeiculo.Name = "lblValorVeiculo";
            this.lblValorVeiculo.Size = new System.Drawing.Size(140, 20);
            this.lblValorVeiculo.TabIndex = 86;
            this.lblValorVeiculo.Text = "Selecione um valor";
            this.lblValorVeiculo.Click += new System.EventHandler(this.LblValorVeiculo_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(308, 185);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 20);
            this.lblMarca.TabIndex = 87;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.LblMarca_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(308, 122);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 88;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblModelo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(549, 16);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(62, 20);
            this.lblModelo.TabIndex = 89;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.LblModelo_Click);
            // 
            // Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(748, 520);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblValorVeiculo);
            this.Controls.Add(this.txtValorVeiculo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtVeiculoId);
            this.Controls.Add(this.txtKmVeiculo);
            this.Controls.Add(this.txtAnoFab);
            this.Controls.Add(this.txtCorVeiculo);
            this.Controls.Add(this.txtNomeVeiculo);
            this.Controls.Add(this.btnAtuVeiculo);
            this.Controls.Add(this.btnCadVeiculo);
            this.Controls.Add(this.dgvListarVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Veiculo";
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.Veiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAtuVeiculo;
        private Guna.UI2.WinForms.Guna2Button btnCadVeiculo;
        private System.Windows.Forms.DataGridView dgvListarVeiculo;
        private Guna.UI2.WinForms.Guna2ComboBox cbModelo;
        private Guna.UI2.WinForms.Guna2ComboBox cbMarca;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtVeiculoId;
        private Guna.UI2.WinForms.Guna2TextBox txtKmVeiculo;
        private Guna.UI2.WinForms.Guna2TextBox txtAnoFab;
        private Guna.UI2.WinForms.Guna2TextBox txtCorVeiculo;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeVeiculo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtValorVeiculo;
        private System.Windows.Forms.Label lblValorVeiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblModelo;
    }
}