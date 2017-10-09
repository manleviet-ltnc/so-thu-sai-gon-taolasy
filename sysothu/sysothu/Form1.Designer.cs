namespace See4urselfAnimal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNewAnimals = new System.Windows.Forms.ListBox();
            this.lstAnimalList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoChépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.45852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.54148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstNewAnimals, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstAnimalList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.762887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.23711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 217);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thú mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách thú";
            // 
            // lstNewAnimals
            // 
            this.lstNewAnimals.AllowDrop = true;
            this.lstNewAnimals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNewAnimals.FormattingEnabled = true;
            this.lstNewAnimals.Location = new System.Drawing.Point(3, 17);
            this.lstNewAnimals.Name = "lstNewAnimals";
            this.lstNewAnimals.Size = new System.Drawing.Size(112, 139);
            this.lstNewAnimals.TabIndex = 2;
            this.toolTip1.SetToolTip(this.lstNewAnimals, "Kéo và thả sang Danh Sách Thú để thêm thú mới");
            this.lstNewAnimals.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstNewAnimals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lstAnimalList
            // 
            this.lstAnimalList.AllowDrop = true;
            this.lstAnimalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAnimalList.FormattingEnabled = true;
            this.lstAnimalList.Location = new System.Drawing.Point(216, 17);
            this.lstAnimalList.Name = "lstAnimalList";
            this.lstAnimalList.Size = new System.Drawing.Size(124, 139);
            this.lstAnimalList.TabIndex = 3;
            this.lstAnimalList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstAnimalList_DragDrop);
            this.lstAnimalList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstAnimalList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnPick, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRemove, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(121, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(89, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnPick
            // 
            this.btnPick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPick.Location = new System.Drawing.Point(3, 41);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(83, 23);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Chọn";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.Location = new System.Drawing.Point(3, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 24);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(265, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.toolTip1.SetToolTip(this.btnSave, "Bấm vào để lưu danh sách thú");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 159);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Bây giờ là ...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tảiDanhSáchToolStripMenuItem,
            this.lưuDanhSáchToolStripMenuItem,
            this.toolStripSeparator1,
            this.đóngToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // tảiDanhSáchToolStripMenuItem
            // 
            this.tảiDanhSáchToolStripMenuItem.Name = "tảiDanhSáchToolStripMenuItem";
            this.tảiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tảiDanhSáchToolStripMenuItem.Text = "Tải Danh Sách";
            this.tảiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // lưuDanhSáchToolStripMenuItem
            // 
            this.lưuDanhSáchToolStripMenuItem.Name = "lưuDanhSáchToolStripMenuItem";
            this.lưuDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.lưuDanhSáchToolStripMenuItem.Text = "Lưu Danh Sách";
            this.lưuDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.đóngToolStripMenuItem.Text = "Đóng";
            this.đóngToolStripMenuItem.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoChépToolStripMenuItem,
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // saoChépToolStripMenuItem
            // 
            this.saoChépToolStripMenuItem.Name = "saoChépToolStripMenuItem";
            this.saoChépToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoChépToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saoChépToolStripMenuItem.Text = "Sao chép";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sở Thú";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNewAnimals;
        private System.Windows.Forms.ListBox lstAnimalList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoChépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}

