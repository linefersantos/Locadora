
namespace Tela_de_Login
{
    partial class modelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modelo));
            this.dgvListarModelo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.txtdescmodelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmodeloid = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnatualizarmodelo = new Guna.UI2.WinForms.Guna2Button();
            this.btncadastromodelo = new Guna.UI2.WinForms.Guna2Button();
            this.cbModeloStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.sairModelo = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarModelo
            // 
            this.dgvListarModelo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListarModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarModelo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvListarModelo.Location = new System.Drawing.Point(0, 0);
            this.dgvListarModelo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListarModelo.Name = "dgvListarModelo";
            this.dgvListarModelo.RowHeadersWidth = 51;
            this.dgvListarModelo.RowTemplate.Height = 24;
            this.dgvListarModelo.Size = new System.Drawing.Size(329, 444);
            this.dgvListarModelo.TabIndex = 27;
            this.dgvListarModelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarModelo_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(344, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Código:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.SteelBlue;
            this.s.Location = new System.Drawing.Point(344, 156);
            this.s.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(63, 16);
            this.s.TabIndex = 30;
            this.s.Text = "Modelo:";
            // 
            // txtdescmodelo
            // 
            this.txtdescmodelo.BorderColor = System.Drawing.Color.Blue;
            this.txtdescmodelo.BorderRadius = 5;
            this.txtdescmodelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdescmodelo.DefaultText = "";
            this.txtdescmodelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdescmodelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdescmodelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdescmodelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdescmodelo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdescmodelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdescmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtdescmodelo.ForeColor = System.Drawing.Color.White;
            this.txtdescmodelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdescmodelo.Location = new System.Drawing.Point(415, 144);
            this.txtdescmodelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescmodelo.Name = "txtdescmodelo";
            this.txtdescmodelo.PasswordChar = '\0';
            this.txtdescmodelo.PlaceholderText = "";
            this.txtdescmodelo.SelectedText = "";
            this.txtdescmodelo.Size = new System.Drawing.Size(202, 39);
            this.txtdescmodelo.TabIndex = 29;
            this.txtdescmodelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmodeloid
            // 
            this.txtmodeloid.BorderColor = System.Drawing.Color.Blue;
            this.txtmodeloid.BorderRadius = 5;
            this.txtmodeloid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmodeloid.DefaultText = "";
            this.txtmodeloid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmodeloid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmodeloid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmodeloid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmodeloid.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtmodeloid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmodeloid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtmodeloid.ForeColor = System.Drawing.Color.White;
            this.txtmodeloid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmodeloid.Location = new System.Drawing.Point(415, 63);
            this.txtmodeloid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmodeloid.Name = "txtmodeloid";
            this.txtmodeloid.PasswordChar = '\0';
            this.txtmodeloid.PlaceholderText = "";
            this.txtmodeloid.SelectedText = "";
            this.txtmodeloid.Size = new System.Drawing.Size(202, 39);
            this.txtmodeloid.TabIndex = 28;
            this.txtmodeloid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnatualizarmodelo
            // 
            this.btnatualizarmodelo.Animated = true;
            this.btnatualizarmodelo.BorderRadius = 20;
            this.btnatualizarmodelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnatualizarmodelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnatualizarmodelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnatualizarmodelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnatualizarmodelo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnatualizarmodelo.ForeColor = System.Drawing.Color.White;
            this.btnatualizarmodelo.Location = new System.Drawing.Point(346, 311);
            this.btnatualizarmodelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnatualizarmodelo.Name = "btnatualizarmodelo";
            this.btnatualizarmodelo.Size = new System.Drawing.Size(132, 37);
            this.btnatualizarmodelo.TabIndex = 33;
            this.btnatualizarmodelo.Text = "Atualizar";
            this.btnatualizarmodelo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnatualizarmodelo_MouseClick);
            // 
            // btncadastromodelo
            // 
            this.btncadastromodelo.Animated = true;
            this.btncadastromodelo.BorderRadius = 20;
            this.btncadastromodelo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncadastromodelo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncadastromodelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncadastromodelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncadastromodelo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncadastromodelo.ForeColor = System.Drawing.Color.White;
            this.btncadastromodelo.Location = new System.Drawing.Point(508, 311);
            this.btncadastromodelo.Margin = new System.Windows.Forms.Padding(2);
            this.btncadastromodelo.Name = "btncadastromodelo";
            this.btncadastromodelo.Size = new System.Drawing.Size(132, 37);
            this.btncadastromodelo.TabIndex = 32;
            this.btncadastromodelo.Text = "Cadastrar";
            this.btncadastromodelo.Click += new System.EventHandler(this.btncadastromodelo_Click);
            // 
            // cbModeloStatus
            // 
            this.cbModeloStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbModeloStatus.BorderColor = System.Drawing.Color.Blue;
            this.cbModeloStatus.BorderRadius = 5;
            this.cbModeloStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModeloStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeloStatus.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbModeloStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModeloStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModeloStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbModeloStatus.ForeColor = System.Drawing.Color.White;
            this.cbModeloStatus.ItemHeight = 30;
            this.cbModeloStatus.Items.AddRange(new object[] {
            "DISPONIVEL",
            "INDISPONIVEL"});
            this.cbModeloStatus.Location = new System.Drawing.Point(415, 224);
            this.cbModeloStatus.Name = "cbModeloStatus";
            this.cbModeloStatus.Size = new System.Drawing.Size(202, 36);
            this.cbModeloStatus.TabIndex = 34;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblStatus.Location = new System.Drawing.Point(344, 235);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 16);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "Status:";
            // 
            // sairModelo
            // 
            this.sairModelo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sairModelo.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.sairModelo.Image = ((System.Drawing.Image)(resources.GetObject("sairModelo.Image")));
            this.sairModelo.ImageOffset = new System.Drawing.Point(0, 0);
            this.sairModelo.ImageRotate = 0F;
            this.sairModelo.ImageSize = new System.Drawing.Size(32, 32);
            this.sairModelo.Location = new System.Drawing.Point(598, 0);
            this.sairModelo.Margin = new System.Windows.Forms.Padding(2);
            this.sairModelo.Name = "sairModelo";
            this.sairModelo.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sairModelo.Size = new System.Drawing.Size(53, 59);
            this.sairModelo.TabIndex = 36;
            this.sairModelo.Click += new System.EventHandler(this.sairModelo_Click);
            // 
            // modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(662, 444);
            this.Controls.Add(this.sairModelo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbModeloStatus);
            this.Controls.Add(this.btnatualizarmodelo);
            this.Controls.Add(this.btncadastromodelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.txtdescmodelo);
            this.Controls.Add(this.txtmodeloid);
            this.Controls.Add(this.dgvListarModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modelo";
            this.Text = "modelo";
            this.Load += new System.EventHandler(this.modelo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label s;
        private Guna.UI2.WinForms.Guna2TextBox txtdescmodelo;
        private Guna.UI2.WinForms.Guna2TextBox txtmodeloid;
        private Guna.UI2.WinForms.Guna2Button btnatualizarmodelo;
        private Guna.UI2.WinForms.Guna2Button btncadastromodelo;
        private Guna.UI2.WinForms.Guna2ComboBox cbModeloStatus;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2ImageButton sairModelo;
    }
}