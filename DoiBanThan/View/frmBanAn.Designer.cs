namespace DoiBanThan.View
{
    partial class frmBanAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.grvBanAn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaBanAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenBanAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiemBan = new System.Windows.Forms.TextBox();
            this.btnTimKiemBan = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBanAn)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(764, 512);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.grvBanAn);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 199);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(764, 313);
            this.guna2Panel3.TabIndex = 1;
            // 
            // grvBanAn
            // 
            this.grvBanAn.AllowUserToAddRows = false;
            this.grvBanAn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grvBanAn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBanAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvBanAn.ColumnHeadersHeight = 40;
            this.grvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.dgvMaBanAn,
            this.dgvTenBanAn,
            this.dgvEdit,
            this.dgvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvBanAn.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvBanAn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.grvBanAn.Location = new System.Drawing.Point(0, 0);
            this.grvBanAn.Name = "grvBanAn";
            this.grvBanAn.ReadOnly = true;
            this.grvBanAn.RowHeadersVisible = false;
            this.grvBanAn.RowHeadersWidth = 51;
            this.grvBanAn.RowTemplate.Height = 24;
            this.grvBanAn.Size = new System.Drawing.Size(764, 313);
            this.grvBanAn.TabIndex = 0;
            this.grvBanAn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grvBanAn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grvBanAn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grvBanAn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grvBanAn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grvBanAn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grvBanAn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.grvBanAn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.grvBanAn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grvBanAn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBanAn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grvBanAn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grvBanAn.ThemeStyle.HeaderStyle.Height = 40;
            this.grvBanAn.ThemeStyle.ReadOnly = true;
            this.grvBanAn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grvBanAn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grvBanAn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBanAn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvBanAn.ThemeStyle.RowsStyle.Height = 24;
            this.grvBanAn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grvBanAn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grvBanAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBanAn_CellClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 10F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // dgvMaBanAn
            // 
            this.dgvMaBanAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMaBanAn.FillWeight = 150F;
            this.dgvMaBanAn.HeaderText = "Mã Bàn";
            this.dgvMaBanAn.MinimumWidth = 150;
            this.dgvMaBanAn.Name = "dgvMaBanAn";
            this.dgvMaBanAn.ReadOnly = true;
            this.dgvMaBanAn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaBanAn.Visible = false;
            this.dgvMaBanAn.Width = 150;
            // 
            // dgvTenBanAn
            // 
            this.dgvTenBanAn.FillWeight = 68.2906F;
            this.dgvTenBanAn.HeaderText = "Tên Bàn";
            this.dgvTenBanAn.MinimumWidth = 6;
            this.dgvTenBanAn.Name = "dgvTenBanAn";
            this.dgvTenBanAn.ReadOnly = true;
            this.dgvTenBanAn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 50F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::DoiBanThan.Properties.Resources.update;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Width = 50;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDelete.FillWeight = 50F;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = global::DoiBanThan.Properties.Resources.delete;
            this.dgvDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDelete.MinimumWidth = 50;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.Width = 50;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.txtTimKiemBan);
            this.guna2Panel2.Controls.Add(this.btnTimKiemBan);
            this.guna2Panel2.Controls.Add(this.guna2Separator2);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.btnThemBan);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(764, 199);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tìm Kiếm";
            // 
            // txtTimKiemBan
            // 
            this.txtTimKiemBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemBan.Location = new System.Drawing.Point(472, 102);
            this.txtTimKiemBan.Name = "txtTimKiemBan";
            this.txtTimKiemBan.Size = new System.Drawing.Size(212, 26);
            this.txtTimKiemBan.TabIndex = 1;
            this.txtTimKiemBan.TextChanged += new System.EventHandler(this.txtTimKiemBan_TextChanged);
            // 
            // btnTimKiemBan
            // 
            this.btnTimKiemBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemBan.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnTimKiemBan.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnTimKiemBan.Image = global::DoiBanThan.Properties.Resources.search;
            this.btnTimKiemBan.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnTimKiemBan.ImageRotate = 0F;
            this.btnTimKiemBan.ImageSize = new System.Drawing.Size(32, 32);
            this.btnTimKiemBan.IndicateFocus = true;
            this.btnTimKiemBan.Location = new System.Drawing.Point(690, 102);
            this.btnTimKiemBan.Name = "btnTimKiemBan";
            this.btnTimKiemBan.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnTimKiemBan.Size = new System.Drawing.Size(29, 29);
            this.btnTimKiemBan.TabIndex = 2;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(21, 183);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(713, 10);
            this.guna2Separator2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thêm bàn ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "Danh Sách Bàn Ăn";
            // 
            // btnThemBan
            // 
            this.btnThemBan.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemBan.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemBan.Image = global::DoiBanThan.Properties.Resources.add;
            this.btnThemBan.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThemBan.ImageRotate = 0F;
            this.btnThemBan.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThemBan.Location = new System.Drawing.Point(44, 102);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThemBan.Size = new System.Drawing.Size(55, 55);
            this.btnThemBan.TabIndex = 0;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 512);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanAn";
            this.Text = "frmBanAn";
            this.Load += new System.EventHandler(this.frmBanAn_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvBanAn)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ImageButton btnThemBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiemBan;
        private Guna.UI2.WinForms.Guna2ImageButton btnTimKiemBan;
        private Guna.UI2.WinForms.Guna2DataGridView grvBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenBanAn;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
    }
}