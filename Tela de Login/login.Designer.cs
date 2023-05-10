
namespace Tela_de_Login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.exibir = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnlog = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblcriar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-179, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(475, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(472, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Faça seu login Aqui!";
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
            this.txtemail.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txtemail.Location = new System.Drawing.Point(428, 150);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(220, 37);
            this.txtemail.TabIndex = 5;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtsenha.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txtsenha.Location = new System.Drawing.Point(428, 208);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '\0';
            this.txtsenha.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtsenha.PlaceholderText = "";
            this.txtsenha.SelectedText = "";
            this.txtsenha.Size = new System.Drawing.Size(218, 34);
            this.txtsenha.TabIndex = 6;
            this.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exibir
            // 
            this.exibir.AutoSize = true;
            this.exibir.CheckedState.BorderColor = System.Drawing.Color.SteelBlue;
            this.exibir.CheckedState.BorderRadius = 2;
            this.exibir.CheckedState.BorderThickness = 0;
            this.exibir.CheckedState.FillColor = System.Drawing.Color.SteelBlue;
            this.exibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.exibir.ForeColor = System.Drawing.Color.SteelBlue;
            this.exibir.Location = new System.Drawing.Point(438, 249);
            this.exibir.Margin = new System.Windows.Forms.Padding(2);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(106, 34);
            this.exibir.TabIndex = 9;
            this.exibir.Text = "Exibir senha\r\n\r\n";
            this.exibir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exibir.UncheckedState.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.exibir.UncheckedState.BorderRadius = 2;
            this.exibir.UncheckedState.BorderThickness = 0;
            this.exibir.UncheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.exibir.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // btnlog
            // 
            this.btnlog.BorderRadius = 20;
            this.btnlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlog.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.Color.White;
            this.btnlog.Location = new System.Drawing.Point(475, 295);
            this.btnlog.Margin = new System.Windows.Forms.Padding(2);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(123, 35);
            this.btnlog.TabIndex = 10;
            this.btnlog.Text = "Login";
            this.btnlog.Click += new System.EventHandler(this.Button1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(688, 8);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(62, 65);
            this.guna2ImageButton1.TabIndex = 13;
            this.guna2ImageButton1.Click += new System.EventHandler(this.Guna2ImageButton1_Click);
            // 
            // lblcriar
            // 
            this.lblcriar.AutoSize = true;
            this.lblcriar.BackColor = System.Drawing.Color.Transparent;
            this.lblcriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcriar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcriar.Location = new System.Drawing.Point(505, 365);
            this.lblcriar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcriar.Name = "lblcriar";
            this.lblcriar.Size = new System.Drawing.Size(77, 15);
            this.lblcriar.TabIndex = 49;
            this.lblcriar.Text = "Criar conta";
            this.lblcriar.Click += new System.EventHandler(this.lblcriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(456, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Não possui uma conta? Crie agora";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(761, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcriar);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtsenha;
        private Guna.UI2.WinForms.Guna2CheckBox exibir;
        private Guna.UI2.WinForms.Guna2Button btnlog;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblcriar;
        private System.Windows.Forms.Label label1;
    }
}

