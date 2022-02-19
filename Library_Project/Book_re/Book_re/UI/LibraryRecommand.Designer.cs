
namespace Book_re
{
    partial class LibraryRecommand
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryRecommand));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_Location = new Sunny.UI.UIDataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Listbox = new System.Windows.Forms.ListBox();
            this.label_Susung = new System.Windows.Forms.Label();
            this.label_Dal2 = new System.Windows.Forms.Label();
            this.label_Dal = new System.Windows.Forms.Label();
            this.label_Center = new System.Windows.Forms.Label();
            this.label_North = new System.Windows.Forms.Label();
            this.label_South = new System.Windows.Forms.Label();
            this.label_West = new System.Windows.Forms.Label();
            this.label_East = new System.Windows.Forms.Label();
            this.bt_exit = new Sunny.UI.UIImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DGV_Location);
            this.panel1.Controls.Add(this.uiPanel1);
            this.panel1.Controls.Add(this.label_Susung);
            this.panel1.Controls.Add(this.label_Dal2);
            this.panel1.Controls.Add(this.label_Dal);
            this.panel1.Controls.Add(this.label_Center);
            this.panel1.Controls.Add(this.label_North);
            this.panel1.Controls.Add(this.label_South);
            this.panel1.Controls.Add(this.label_West);
            this.panel1.Controls.Add(this.label_East);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 532);
            this.panel1.TabIndex = 0;
            // 
            // DGV_Location
            // 
            this.DGV_Location.AllowUserToAddRows = false;
            this.DGV_Location.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Location.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Location.AutoGenerateColumns = false;
            this.DGV_Location.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Location.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Location.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Location.ColumnHeadersHeight = 32;
            this.DGV_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Location.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.DGV_Location.DataSource = this.libraryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Location.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Location.EnableHeadersVisualStyles = false;
            this.DGV_Location.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DGV_Location.GridColor = System.Drawing.Color.Maroon;
            this.DGV_Location.Location = new System.Drawing.Point(12, 86);
            this.DGV_Location.Name = "DGV_Location";
            this.DGV_Location.ReadOnly = true;
            this.DGV_Location.RectColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Location.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Location.RowHeadersVisible = false;
            this.DGV_Location.RowHeadersWidth = 82;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Location.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Location.RowTemplate.Height = 29;
            this.DGV_Location.SelectedIndex = -1;
            this.DGV_Location.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Location.ShowGridLine = true;
            this.DGV_Location.Size = new System.Drawing.Size(250, 438);
            this.DGV_Location.StripeEvenColor = System.Drawing.Color.Snow;
            this.DGV_Location.StripeOddColor = System.Drawing.Color.Snow;
            this.DGV_Location.Style = Sunny.UI.UIStyle.Custom;
            this.DGV_Location.StyleCustomMode = true;
            this.DGV_Location.TabIndex = 50;
            this.DGV_Location.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Location_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "지역";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataSource = typeof(Book_re.Model.Library);
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.Maroon;
            this.uiPanel1.Controls.Add(this.webBrowser1);
            this.uiPanel1.Controls.Add(this.Listbox);
            this.uiPanel1.FillColor = System.Drawing.Color.Maroon;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(4, 74);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Maroon;
            this.uiPanel1.RectDisableColor = System.Drawing.Color.Maroon;
            this.uiPanel1.Size = new System.Drawing.Size(618, 453);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 51;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(267, 127);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(333, 323);
            this.webBrowser1.TabIndex = 5;
            // 
            // Listbox
            // 
            this.Listbox.FormattingEnabled = true;
            this.Listbox.ItemHeight = 21;
            this.Listbox.Location = new System.Drawing.Point(267, 12);
            this.Listbox.Name = "Listbox";
            this.Listbox.Size = new System.Drawing.Size(333, 109);
            this.Listbox.TabIndex = 1;
            this.Listbox.SelectedIndexChanged += new System.EventHandler(this.Listbox_SelectedIndexChanged);
            // 
            // label_Susung
            // 
            this.label_Susung.BackColor = System.Drawing.Color.Maroon;
            this.label_Susung.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Susung.ForeColor = System.Drawing.Color.Transparent;
            this.label_Susung.Location = new System.Drawing.Point(463, 44);
            this.label_Susung.Name = "label_Susung";
            this.label_Susung.Size = new System.Drawing.Size(59, 25);
            this.label_Susung.TabIndex = 49;
            this.label_Susung.Text = "수성구";
            this.label_Susung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Susung.Click += new System.EventHandler(this.button_kinggod_Click);
            // 
            // label_Dal2
            // 
            this.label_Dal2.BackColor = System.Drawing.Color.Maroon;
            this.label_Dal2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Dal2.ForeColor = System.Drawing.Color.Transparent;
            this.label_Dal2.Location = new System.Drawing.Point(398, 44);
            this.label_Dal2.Name = "label_Dal2";
            this.label_Dal2.Size = new System.Drawing.Size(59, 25);
            this.label_Dal2.TabIndex = 48;
            this.label_Dal2.Text = "달성군";
            this.label_Dal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Dal2.Click += new System.EventHandler(this.button_Dal2_Click);
            // 
            // label_Dal
            // 
            this.label_Dal.BackColor = System.Drawing.Color.Maroon;
            this.label_Dal.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Dal.ForeColor = System.Drawing.Color.Transparent;
            this.label_Dal.Location = new System.Drawing.Point(333, 44);
            this.label_Dal.Name = "label_Dal";
            this.label_Dal.Size = new System.Drawing.Size(59, 25);
            this.label_Dal.TabIndex = 47;
            this.label_Dal.Text = "달서구";
            this.label_Dal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Dal.Click += new System.EventHandler(this.button_Dal_Click);
            // 
            // label_Center
            // 
            this.label_Center.BackColor = System.Drawing.Color.Maroon;
            this.label_Center.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Center.ForeColor = System.Drawing.Color.Transparent;
            this.label_Center.Location = new System.Drawing.Point(268, 44);
            this.label_Center.Name = "label_Center";
            this.label_Center.Size = new System.Drawing.Size(59, 25);
            this.label_Center.TabIndex = 46;
            this.label_Center.Text = "중구";
            this.label_Center.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Center.Click += new System.EventHandler(this.button_Center_Click);
            // 
            // label_North
            // 
            this.label_North.BackColor = System.Drawing.Color.Maroon;
            this.label_North.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_North.ForeColor = System.Drawing.Color.Transparent;
            this.label_North.Location = new System.Drawing.Point(203, 44);
            this.label_North.Name = "label_North";
            this.label_North.Size = new System.Drawing.Size(59, 25);
            this.label_North.TabIndex = 45;
            this.label_North.Text = "북구";
            this.label_North.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_North.Click += new System.EventHandler(this.button_North_Click);
            // 
            // label_South
            // 
            this.label_South.BackColor = System.Drawing.Color.Maroon;
            this.label_South.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_South.ForeColor = System.Drawing.Color.Transparent;
            this.label_South.Location = new System.Drawing.Point(138, 44);
            this.label_South.Name = "label_South";
            this.label_South.Size = new System.Drawing.Size(59, 25);
            this.label_South.TabIndex = 44;
            this.label_South.Text = "남구";
            this.label_South.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_South.Click += new System.EventHandler(this.button_South_Click);
            // 
            // label_West
            // 
            this.label_West.BackColor = System.Drawing.Color.Maroon;
            this.label_West.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_West.ForeColor = System.Drawing.Color.Transparent;
            this.label_West.Location = new System.Drawing.Point(74, 44);
            this.label_West.Name = "label_West";
            this.label_West.Size = new System.Drawing.Size(59, 25);
            this.label_West.TabIndex = 45;
            this.label_West.Text = "서구";
            this.label_West.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_West.Click += new System.EventHandler(this.button_West_Click);
            // 
            // label_East
            // 
            this.label_East.BackColor = System.Drawing.Color.Maroon;
            this.label_East.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_East.ForeColor = System.Drawing.Color.Transparent;
            this.label_East.Location = new System.Drawing.Point(9, 44);
            this.label_East.Name = "label_East";
            this.label_East.Size = new System.Drawing.Size(59, 25);
            this.label_East.TabIndex = 44;
            this.label_East.Text = "동구";
            this.label_East.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_East.Click += new System.EventHandler(this.button_East_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.Location = new System.Drawing.Point(606, 3);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(29, 28);
            this.bt_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bt_exit.TabIndex = 4;
            this.bt_exit.TabStop = false;
            this.bt_exit.Text = null;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // LibraryRecommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(648, 542);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryRecommand";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UIImageButton bt_exit;
        private System.Windows.Forms.Label label_East;
        private System.Windows.Forms.Label label_West;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private System.Windows.Forms.Label label_North;
        private System.Windows.Forms.Label label_South;
        private System.Windows.Forms.Label label_Center;
        private System.Windows.Forms.Label label_Dal;
        private System.Windows.Forms.Label label_Dal2;
        private System.Windows.Forms.Label label_Susung;
        private Sunny.UI.UIDataGridView DGV_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.ListBox Listbox;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}