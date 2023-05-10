
namespace Tela_de_Login
{
    partial class cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cargo));
            this.btncadastroc = new Guna.UI2.WinForms.Guna2Button();
            this.btnatualizarc = new Guna.UI2.WinForms.Guna2Button();
            this.dgvListarCargo = new System.Windows.Forms.DataGridView();
            this.s = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcargoid = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcargonome = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sairCargo = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // btncadastroc
            // 
            this.btncadastroc.Animated = true;
            this.btncadastroc.BorderRadius = 20;
            this.btncadastroc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncadastroc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncadastroc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncadastroc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncadastroc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncadastroc.ForeColor = System.Drawing.Color.White;
            this.btncadastroc.Location = new System.Drawing.Point(518, 322);
            this.btncadastroc.Margin = new System.Windows.Forms.Padding(2);
            this.btncadastroc.Name = "btncadastroc";
            this.btncadastroc.Size = new System.Drawing.Size(132, 37);
            this.btncadastroc.TabIndex = 11;
            this.btncadastroc.Text = "Cadastrar";
            this.btncadastroc.Click += new System.EventHandler(this.btncadastroc_Click);
            // 
            // btnatualizarc
            // 
            this.btnatualizarc.Animated = true;
            this.btnatualizarc.BorderRadius = 20;
            this.btnatualizarc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnatualizarc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnatualizarc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnatualizarc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnatualizarc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnatualizarc.ForeColor = System.Drawing.Color.White;
            this.btnatualizarc.Location = new System.Drawing.Point(361, 322);
            this.btnatualizarc.Margin = new System.Windows.Forms.Padding(2);
            this.btnatualizarc.Name = "btnatualizarc";
            this.btnatualizarc.Size = new System.Drawing.Size(132, 37);
            this.btnatualizarc.TabIndex = 12;
            this.btnatualizarc.Text = "Atualizar";
            this.btnatualizarc.Click += new System.EventHandler(this.btnatualizarc_Click);
            // 
            // dgvListarCargo
            // 
            this.dgvListarCargo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListarCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCargo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvListarCargo.Location = new System.Drawing.Point(0, 0);
            this.dgvListarCargo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListarCargo.Name = "dgvListarCargo";
            this.dgvListarCargo.RowHeadersWidth = 51;
            this.dgvListarCargo.RowTemplate.Height = 24;
            this.dgvListarCargo.Size = new System.Drawing.Size(329, 444);
            this.dgvListarCargo.TabIndex = 13;
            this.dgvListarCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarCargo_CellClick);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.SteelBlue;
            this.s.Location = new System.Drawing.Point(369, 168);
            this.s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(53, 16);
            this.s.TabIndex = 20;
            this.s.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(361, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código:";
            // 
            // txtcargoid
            // 
            this.txtcargoid.BorderColor = System.Drawing.Color.Blue;
            this.txtcargoid.BorderRadius = 5;
            this.txtcargoid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcargoid.DefaultText = "";
            this.txtcargoid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcargoid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcargoid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcargoid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcargoid.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcargoid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcargoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcargoid.ForeColor = System.Drawing.Color.White;
            this.txtcargoid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcargoid.Location = new System.Drawing.Point(447, 75);
            this.txtcargoid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcargoid.Name = "txtcargoid";
            this.txtcargoid.PasswordChar = '\0';
            this.txtcargoid.PlaceholderText = "";
            this.txtcargoid.SelectedText = "";
            this.txtcargoid.Size = new System.Drawing.Size(190, 37);
            this.txtcargoid.TabIndex = 16;
            this.txtcargoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcargonome
            // 
            this.txtcargonome.BorderColor = System.Drawing.Color.Blue;
            this.txtcargonome.BorderRadius = 5;
            this.txtcargonome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcargonome.DefaultText = "";
            this.txtcargonome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcargonome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcargonome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcargonome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcargonome.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcargonome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcargonome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcargonome.ForeColor = System.Drawing.Color.White;
            this.txtcargonome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcargonome.Location = new System.Drawing.Point(447, 158);
            this.txtcargonome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcargonome.Name = "txtcargonome";
            this.txtcargonome.PasswordChar = '\0';
            this.txtcargonome.PlaceholderText = "";
            this.txtcargonome.SelectedText = "";
            this.txtcargonome.Size = new System.Drawing.Size(190, 38);
            this.txtcargonome.TabIndex = 17;
            this.txtcargonome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(447, 254);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(190, 36);
            this.cbStatus.TabIndex = 65;
            this.cbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(367, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Status:";
            // 
            // sairCargo
            // 
            this.sairCargo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sairCargo.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.sairCargo.Image = ((System.Drawing.Image)(resources.GetObject("sairCargo.Image")));
            this.sairCargo.ImageOffset = new System.Drawing.Point(0, 0);
            this.sairCargo.ImageRotate = 0F;
            this.sairCargo.ImageSize = new System.Drawing.Size(32, 32);
            this.sairCargo.Location = new System.Drawing.Point(613, 0);
            this.sairCargo.Margin = new System.Windows.Forms.Padding(2);
            this.sairCargo.Name = "sairCargo";
            this.sairCargo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sairCargo.Size = new System.Drawing.Size(53, 59);
            this.sairCargo.TabIndex = 67;
            this.sairCargo.Click += new System.EventHandler(this.sairCargo_Click);
            // 
            // cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(662, 444);
            this.Controls.Add(this.sairCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.txtcargonome);
            this.Controls.Add(this.txtcargoid);
            this.Controls.Add(this.dgvListarCargo);
            this.Controls.Add(this.btnatualizarc);
            this.Controls.Add(this.btncadastroc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cargo";
            this.Text = "cargo";
            this.Load += new System.EventHandler(this.cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btncadastroc;
        private Guna.UI2.WinForms.Guna2Button btnatualizarc;
        private System.Windows.Forms.DataGridView dgvListarCargo;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtcargoid;
        private Guna.UI2.WinForms.Guna2TextBox txtcargonome;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton sairCargo;
    }
}