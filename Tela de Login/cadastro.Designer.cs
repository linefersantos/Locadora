
namespace Tela_de_Login
{
    partial class cadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.s = new System.Windows.Forms.Label();
            this.txtnome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttel = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtendereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbFoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbestado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mtxtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDtCad = new System.Windows.Forms.MaskedTextBox();
            this.lblcriar = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-295, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG (*.png)|*.png";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(928, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(53, 46);
            this.guna2ImageButton1.TabIndex = 49;
            this.guna2ImageButton1.Click += new System.EventHandler(this.Guna2ImageButton1_Click);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.SteelBlue;
            this.s.Location = new System.Drawing.Point(479, 131);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(177, 16);
            this.s.TabIndex = 3;
            this.s.Text = "Faça seu Cadastro Aqui!";
            // 
            // txtnome
            // 
            this.txtnome.BorderColor = System.Drawing.Color.Blue;
            this.txtnome.BorderRadius = 5;
            this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome.DefaultText = "";
            this.txtnome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtnome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtnome.IconLeft")));
            this.txtnome.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txtnome.Location = new System.Drawing.Point(359, 159);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtnome.PlaceholderText = "Nome";
            this.txtnome.SelectedText = "";
            this.txtnome.Size = new System.Drawing.Size(200, 40);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttel
            // 
            this.txttel.BorderColor = System.Drawing.Color.Blue;
            this.txttel.BorderRadius = 5;
            this.txttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttel.DefaultText = "";
            this.txttel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttel.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txttel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txttel.ForeColor = System.Drawing.Color.White;
            this.txttel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttel.IconLeft = ((System.Drawing.Image)(resources.GetObject("txttel.IconLeft")));
            this.txttel.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txttel.Location = new System.Drawing.Point(359, 219);
            this.txttel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txttel.Name = "txttel";
            this.txttel.PasswordChar = '\0';
            this.txttel.PlaceholderForeColor = System.Drawing.Color.White;
            this.txttel.PlaceholderText = "Telefone";
            this.txttel.SelectedText = "";
            this.txttel.Size = new System.Drawing.Size(200, 40);
            this.txttel.TabIndex = 6;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.BorderRadius = 20;
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(668, 475);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(180, 45);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Cadastrar";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtendereco
            // 
            this.txtendereco.BorderColor = System.Drawing.Color.Blue;
            this.txtendereco.BorderRadius = 5;
            this.txtendereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtendereco.DefaultText = "";
            this.txtendereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtendereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtendereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtendereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtendereco.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtendereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtendereco.ForeColor = System.Drawing.Color.White;
            this.txtendereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtendereco.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtendereco.IconLeft")));
            this.txtendereco.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txtendereco.Location = new System.Drawing.Point(591, 159);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.PasswordChar = '\0';
            this.txtendereco.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtendereco.PlaceholderText = "Endereço";
            this.txtendereco.SelectedText = "";
            this.txtendereco.Size = new System.Drawing.Size(200, 40);
            this.txtendereco.TabIndex = 20;
            this.txtendereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcidade
            // 
            this.txtcidade.BorderColor = System.Drawing.Color.Blue;
            this.txtcidade.BorderRadius = 5;
            this.txtcidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcidade.DefaultText = "";
            this.txtcidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcidade.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcidade.ForeColor = System.Drawing.Color.White;
            this.txtcidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcidade.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtcidade.IconLeft")));
            this.txtcidade.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txtcidade.Location = new System.Drawing.Point(591, 219);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.PasswordChar = '\0';
            this.txtcidade.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtcidade.PlaceholderText = "Cidade";
            this.txtcidade.SelectedText = "";
            this.txtcidade.Size = new System.Drawing.Size(200, 40);
            this.txtcidade.TabIndex = 19;
            this.txtcidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbairro
            // 
            this.txtbairro.BorderColor = System.Drawing.Color.Blue;
            this.txtbairro.BorderRadius = 5;
            this.txtbairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbairro.DefaultText = "";
            this.txtbairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbairro.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtbairro.ForeColor = System.Drawing.Color.White;
            this.txtbairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbairro.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtbairro.IconLeft")));
            this.txtbairro.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txtbairro.Location = new System.Drawing.Point(591, 279);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.PasswordChar = '\0';
            this.txtbairro.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtbairro.PlaceholderText = "Bairro";
            this.txtbairro.SelectedText = "";
            this.txtbairro.Size = new System.Drawing.Size(200, 40);
            this.txtbairro.TabIndex = 18;
            this.txtbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsenha
            // 
            this.txtsenha.BorderColor = System.Drawing.Color.Blue;
            this.txtsenha.BorderRadius = 5;
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha.DefaultText = "";
            this.txtsenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtsenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtsenha.IconLeft")));
            this.txtsenha.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txtsenha.Location = new System.Drawing.Point(359, 401);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '\0';
            this.txtsenha.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtsenha.PlaceholderText = "Senha";
            this.txtsenha.SelectedText = "";
            this.txtsenha.Size = new System.Drawing.Size(200, 40);
            this.txtsenha.TabIndex = 25;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbFoto
            // 
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.ImageRotate = 0F;
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(506, 11);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFoto.Size = new System.Drawing.Size(115, 105);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 40;
            this.pbFoto.TabStop = false;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton2.Location = new System.Drawing.Point(800, 22);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(60, 55);
            this.guna2ImageButton2.TabIndex = 50;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderColor = System.Drawing.Color.Blue;
            this.txtemail.BorderRadius = 5;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtemail.IconLeft")));
            this.txtemail.IconLeftSize = new System.Drawing.Size(55, 55);
            this.txtemail.Location = new System.Drawing.Point(359, 339);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(200, 40);
            this.txtemail.TabIndex = 51;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(599, 343);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 79;
            this.pictureBox2.TabStop = false;
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.Transparent;
            this.cbestado.BorderColor = System.Drawing.Color.Blue;
            this.cbestado.BorderRadius = 5;
            this.cbestado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbestado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbestado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbestado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbestado.ForeColor = System.Drawing.Color.White;
            this.cbestado.ItemHeight = 30;
            this.cbestado.Items.AddRange(new object[] {
            "RR",
            "AP",
            "AM",
            "PA",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "AC",
            "RO",
            "MT",
            "TO",
            "BA",
            "MS",
            "GO",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PN",
            "SC",
            "RS"});
            this.cbestado.Location = new System.Drawing.Point(591, 343);
            this.cbestado.Margin = new System.Windows.Forms.Padding(2);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(200, 36);
            this.cbestado.TabIndex = 78;
            this.cbestado.Click += new System.EventHandler(this.cbestado_Click);
            // 
            // mtxtDtNasc
            // 
            this.mtxtDtNasc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtxtDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.mtxtDtNasc.ForeColor = System.Drawing.SystemColors.Control;
            this.mtxtDtNasc.Location = new System.Drawing.Point(359, 289);
            this.mtxtDtNasc.Mask = "00/00/0000";
            this.mtxtDtNasc.Name = "mtxtDtNasc";
            this.mtxtDtNasc.Size = new System.Drawing.Size(200, 23);
            this.mtxtDtNasc.TabIndex = 80;
            this.mtxtDtNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDtNasc.ValidatingType = typeof(System.DateTime);
            this.mtxtDtNasc.Click += new System.EventHandler(this.mtxtDtNasc_Click);
            // 
            // mtxtDtCad
            // 
            this.mtxtDtCad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtxtDtCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.mtxtDtCad.ForeColor = System.Drawing.SystemColors.Control;
            this.mtxtDtCad.Location = new System.Drawing.Point(591, 418);
            this.mtxtDtCad.Mask = "00/00/0000";
            this.mtxtDtCad.Name = "mtxtDtCad";
            this.mtxtDtCad.Size = new System.Drawing.Size(200, 23);
            this.mtxtDtCad.TabIndex = 82;
            this.mtxtDtCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDtCad.ValidatingType = typeof(System.DateTime);
            this.mtxtDtCad.Click += new System.EventHandler(this.mtxtDtCad_Click);
            // 
            // lblcriar
            // 
            this.lblcriar.Location = new System.Drawing.Point(0, 0);
            this.lblcriar.Name = "lblcriar";
            this.lblcriar.Size = new System.Drawing.Size(100, 23);
            this.lblcriar.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(691, 350);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 20);
            this.lblEstado.TabIndex = 101;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDtCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDtCadastro.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.White;
            this.lblDtCadastro.Location = new System.Drawing.Point(635, 421);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(112, 17);
            this.lblDtCadastro.TabIndex = 105;
            this.lblDtCadastro.Text = "Data de cadastro";
            this.lblDtCadastro.Click += new System.EventHandler(this.lblDtCadastro_Click);
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDtNasc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDtNasc.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDtNasc.ForeColor = System.Drawing.Color.White;
            this.lblDtNasc.Location = new System.Drawing.Point(389, 292);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(133, 17);
            this.lblDtNasc.TabIndex = 106;
            this.lblDtNasc.Text = "Data de Nascimento";
            this.lblDtNasc.Click += new System.EventHandler(this.lblDtNasc_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(882, 546);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblDtCadastro);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblcriar);
            this.Controls.Add(this.mtxtDtCad);
            this.Controls.Add(this.mtxtDtNasc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.s);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label s;
        private Guna.UI2.WinForms.Guna2TextBox txtnome;
        private Guna.UI2.WinForms.Guna2TextBox txttel;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtendereco;
        private Guna.UI2.WinForms.Guna2TextBox txtcidade;
        private Guna.UI2.WinForms.Guna2TextBox txtbairro;
        private Guna.UI2.WinForms.Guna2TextBox txtsenha;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFoto;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbestado;
        private System.Windows.Forms.MaskedTextBox mtxtDtNasc;
        private System.Windows.Forms.MaskedTextBox mtxtDtCad;
        private System.Windows.Forms.Label lblcriar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.Label lblDtNasc;
    }
}

