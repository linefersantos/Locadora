
namespace Tela_de_Login
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.cbCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtcodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnome = new Guna.UI2.WinForms.Guna2TextBox();
            this.mtxtDtContrato = new System.Windows.Forms.MaskedTextBox();
            this.dgvListarFuncionario = new System.Windows.Forms.DataGridView();
            this.btnCadFuncionario = new Guna.UI2.WinForms.Guna2Button();
            this.btnatu = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.Transparent;
            this.cbCargo.BorderColor = System.Drawing.Color.Blue;
            this.cbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbCargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cbCargo.ForeColor = System.Drawing.Color.White;
            this.cbCargo.ItemHeight = 30;
            this.cbCargo.Location = new System.Drawing.Point(300, 72);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(212, 36);
            this.cbCargo.TabIndex = 77;
            this.cbCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            this.cbCargo.Click += new System.EventHandler(this.cbCargo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderColor = System.Drawing.Color.Transparent;
            this.txtcodigo.BorderRadius = 5;
            this.txtcodigo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.DefaultText = "";
            this.txtcodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcodigo.ForeColor = System.Drawing.Color.White;
            this.txtcodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.Location = new System.Drawing.Point(21, 24);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtcodigo.PlaceholderText = "ID";
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.Size = new System.Drawing.Size(59, 29);
            this.txtcodigo.TabIndex = 76;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txttel.IconLeftOffset = new System.Drawing.Point(0, 2);
            this.txttel.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txttel.Location = new System.Drawing.Point(21, 123);
            this.txttel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttel.Name = "txttel";
            this.txttel.PasswordChar = '\0';
            this.txttel.PlaceholderForeColor = System.Drawing.Color.White;
            this.txttel.PlaceholderText = "Telefone";
            this.txttel.SelectedText = "";
            this.txttel.Size = new System.Drawing.Size(214, 32);
            this.txttel.TabIndex = 75;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtnome.IconLeftOffset = new System.Drawing.Point(0, 2);
            this.txtnome.IconLeftSize = new System.Drawing.Size(48, 48);
            this.txtnome.Location = new System.Drawing.Point(21, 72);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtnome.PlaceholderText = "Nome";
            this.txtnome.SelectedText = "";
            this.txtnome.Size = new System.Drawing.Size(214, 32);
            this.txtnome.TabIndex = 74;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtDtContrato
            // 
            this.mtxtDtContrato.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtxtDtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.mtxtDtContrato.ForeColor = System.Drawing.SystemColors.Control;
            this.mtxtDtContrato.Location = new System.Drawing.Point(300, 30);
            this.mtxtDtContrato.Mask = "00/00/0000";
            this.mtxtDtContrato.Name = "mtxtDtContrato";
            this.mtxtDtContrato.Size = new System.Drawing.Size(212, 23);
            this.mtxtDtContrato.TabIndex = 78;
            this.mtxtDtContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtDtContrato.ValidatingType = typeof(System.DateTime);
            // 
            // dgvListarFuncionario
            // 
            this.dgvListarFuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarFuncionario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListarFuncionario.Location = new System.Drawing.Point(0, 189);
            this.dgvListarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListarFuncionario.Name = "dgvListarFuncionario";
            this.dgvListarFuncionario.RowHeadersWidth = 51;
            this.dgvListarFuncionario.RowTemplate.Height = 24;
            this.dgvListarFuncionario.Size = new System.Drawing.Size(748, 331);
            this.dgvListarFuncionario.TabIndex = 81;
            this.dgvListarFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarFuncionario_CellClick);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.BorderRadius = 20;
            this.btnCadFuncionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadFuncionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadFuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadFuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadFuncionario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCadFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadFuncionario.Location = new System.Drawing.Point(271, 123);
            this.btnCadFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(125, 40);
            this.btnCadFuncionario.TabIndex = 83;
            this.btnCadFuncionario.Text = "Cadastrar";
            this.btnCadFuncionario.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnatu.Location = new System.Drawing.Point(411, 123);
            this.btnatu.Margin = new System.Windows.Forms.Padding(2);
            this.btnatu.Name = "btnatu";
            this.btnatu.Size = new System.Drawing.Size(125, 40);
            this.btnatu.TabIndex = 82;
            this.btnatu.Text = "Atualizar";
            this.btnatu.Click += new System.EventHandler(this.btnatu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(574, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 140);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(378, 79);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 20);
            this.lblCargo.TabIndex = 99;
            this.lblCargo.Text = "Cargo";
            this.lblCargo.Click += new System.EventHandler(this.lblCargo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Data de contrato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(748, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadFuncionario);
            this.Controls.Add(this.btnatu);
            this.Controls.Add(this.dgvListarFuncionario);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.mtxtDtContrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbCargo;
        private Guna.UI2.WinForms.Guna2TextBox txtcodigo;
        private Guna.UI2.WinForms.Guna2TextBox txttel;
        private Guna.UI2.WinForms.Guna2TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox mtxtDtContrato;
        private System.Windows.Forms.DataGridView dgvListarFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnCadFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnatu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label1;
    }
}