namespace Qlxm
{
    partial class ThueXe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthuexe = new System.Windows.Forms.Button();
            this.btntraxe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbsearch = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.quảnLíToolStripMenuItem.Text = "Quản Lí";
            this.quảnLíToolStripMenuItem.Click += new System.EventHandler(this.quảnLíToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-11, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnthuexe
            // 
            this.btnthuexe.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnthuexe.Location = new System.Drawing.Point(169, 357);
            this.btnthuexe.Name = "btnthuexe";
            this.btnthuexe.Size = new System.Drawing.Size(100, 48);
            this.btnthuexe.TabIndex = 2;
            this.btnthuexe.Text = "Thuê Xe";
            this.btnthuexe.UseVisualStyleBackColor = false;
            this.btnthuexe.Click += new System.EventHandler(this.btnthuexe_Click);
            // 
            // btntraxe
            // 
            this.btntraxe.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btntraxe.Location = new System.Drawing.Point(463, 357);
            this.btntraxe.Name = "btntraxe";
            this.btntraxe.Size = new System.Drawing.Size(102, 48);
            this.btntraxe.TabIndex = 3;
            this.btntraxe.Text = "Trả Xe";
            this.btntraxe.UseVisualStyleBackColor = false;
            this.btntraxe.Click += new System.EventHandler(this.btntraxe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh Sách Xe Trong Hệ Thống";
            // 
            // cbbsearch
            // 
            this.cbbsearch.FormattingEnabled = true;
            this.cbbsearch.Location = new System.Drawing.Point(560, 79);
            this.cbbsearch.Name = "cbbsearch";
            this.cbbsearch.Size = new System.Drawing.Size(121, 24);
            this.cbbsearch.TabIndex = 5;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DimGray;
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsearch.Location = new System.Drawing.Point(687, 72);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(92, 37);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Tìm Kiếm";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // ThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cbbsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntraxe);
            this.Controls.Add(this.btnthuexe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThueXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê Xe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthuexe;
        private System.Windows.Forms.Button btntraxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbsearch;
        private System.Windows.Forms.Button btnsearch;
    }
}