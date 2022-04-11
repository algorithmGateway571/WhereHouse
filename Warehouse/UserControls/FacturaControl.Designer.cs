
namespace Warehouse.UserControls
{
    partial class FacturaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaControl));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQayta = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.historyType_comboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.search_filial_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.FakturaDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.FakturaItemDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FakturaDataGrid)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FakturaItemDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.86622F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1242, 739);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblQayta);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 34);
            this.panel1.TabIndex = 5;
            // 
            // lblQayta
            // 
            this.lblQayta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQayta.AutoSize = true;
            this.lblQayta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQayta.ForeColor = System.Drawing.Color.White;
            this.lblQayta.Location = new System.Drawing.Point(1113, 7);
            this.lblQayta.Name = "lblQayta";
            this.lblQayta.Size = new System.Drawing.Size(108, 20);
            this.lblQayta.TabIndex = 27;
            this.lblQayta.Text = "Qayta yuklash";
            this.lblQayta.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(3, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(289, 20);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Ma\'lumotlar yuklanmoqda, Iltimos kuting";
            this.lblStatus.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.historyType_comboBox);
            this.panel6.Controls.Add(this.search_filial_txt);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1236, 34);
            this.panel6.TabIndex = 1;
            // 
            // historyType_comboBox
            // 
            this.historyType_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.historyType_comboBox.BackColor = System.Drawing.Color.Transparent;
            this.historyType_comboBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.historyType_comboBox.BorderColor = System.Drawing.Color.Silver;
            this.historyType_comboBox.BorderRadius = 8;
            this.historyType_comboBox.Color = System.Drawing.Color.Silver;
            this.historyType_comboBox.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.historyType_comboBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.historyType_comboBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.historyType_comboBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.historyType_comboBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.historyType_comboBox.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.historyType_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.historyType_comboBox.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.historyType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.historyType_comboBox.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.historyType_comboBox.FillDropDown = true;
            this.historyType_comboBox.FillIndicator = false;
            this.historyType_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyType_comboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyType_comboBox.ForeColor = System.Drawing.Color.White;
            this.historyType_comboBox.FormattingEnabled = true;
            this.historyType_comboBox.Icon = null;
            this.historyType_comboBox.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.historyType_comboBox.IndicatorColor = System.Drawing.Color.Gray;
            this.historyType_comboBox.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.historyType_comboBox.ItemBackColor = System.Drawing.Color.White;
            this.historyType_comboBox.ItemBorderColor = System.Drawing.Color.White;
            this.historyType_comboBox.ItemForeColor = System.Drawing.Color.Black;
            this.historyType_comboBox.ItemHeight = 26;
            this.historyType_comboBox.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.historyType_comboBox.ItemHighLightForeColor = System.Drawing.Color.White;
            this.historyType_comboBox.Items.AddRange(new object[] {
            "Faktura history",
            "Mahsulot qabul history"});
            this.historyType_comboBox.ItemTopMargin = 3;
            this.historyType_comboBox.Location = new System.Drawing.Point(950, 0);
            this.historyType_comboBox.Name = "historyType_comboBox";
            this.historyType_comboBox.Size = new System.Drawing.Size(271, 32);
            this.historyType_comboBox.TabIndex = 3;
            this.historyType_comboBox.Text = "Faktura turi";
            this.historyType_comboBox.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.historyType_comboBox.TextLeftMargin = 5;
            this.historyType_comboBox.SelectedIndexChanged += new System.EventHandler(this.historyType_comboBox_SelectedIndexChanged);
            // 
            // search_filial_txt
            // 
            this.search_filial_txt.AcceptsReturn = false;
            this.search_filial_txt.AcceptsTab = false;
            this.search_filial_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_filial_txt.AnimationSpeed = 200;
            this.search_filial_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search_filial_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search_filial_txt.BackColor = System.Drawing.Color.Transparent;
            this.search_filial_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_filial_txt.BackgroundImage")));
            this.search_filial_txt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.search_filial_txt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search_filial_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_filial_txt.BorderColorIdle = System.Drawing.Color.Silver;
            this.search_filial_txt.BorderRadius = 10;
            this.search_filial_txt.BorderThickness = 0;
            this.search_filial_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search_filial_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_filial_txt.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_filial_txt.DefaultText = "";
            this.search_filial_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.search_filial_txt.ForeColor = System.Drawing.Color.White;
            this.search_filial_txt.HideSelection = true;
            this.search_filial_txt.IconLeft = null;
            this.search_filial_txt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.search_filial_txt.IconPadding = 10;
            this.search_filial_txt.IconRight = null;
            this.search_filial_txt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.search_filial_txt.Lines = new string[0];
            this.search_filial_txt.Location = new System.Drawing.Point(47, 0);
            this.search_filial_txt.MaxLength = 32767;
            this.search_filial_txt.MinimumSize = new System.Drawing.Size(1, 1);
            this.search_filial_txt.Modified = false;
            this.search_filial_txt.Multiline = false;
            this.search_filial_txt.Name = "search_filial_txt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_filial_txt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search_filial_txt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_filial_txt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_filial_txt.OnIdleState = stateProperties4;
            this.search_filial_txt.Padding = new System.Windows.Forms.Padding(3);
            this.search_filial_txt.PasswordChar = '\0';
            this.search_filial_txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.search_filial_txt.PlaceholderText = "Filial nomi ...";
            this.search_filial_txt.ReadOnly = false;
            this.search_filial_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_filial_txt.SelectedText = "";
            this.search_filial_txt.SelectionLength = 0;
            this.search_filial_txt.SelectionStart = 0;
            this.search_filial_txt.ShortcutsEnabled = true;
            this.search_filial_txt.Size = new System.Drawing.Size(280, 31);
            this.search_filial_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search_filial_txt.TabIndex = 1;
            this.search_filial_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search_filial_txt.TextMarginBottom = 0;
            this.search_filial_txt.TextMarginLeft = 3;
            this.search_filial_txt.TextMarginTop = 0;
            this.search_filial_txt.TextPlaceholder = "Filial nomi ...";
            this.search_filial_txt.UseSystemPasswordChar = false;
            this.search_filial_txt.WordWrap = true;
            this.search_filial_txt.TextChanged += new System.EventHandler(this.search_filial_txt_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.FakturaDataGrid);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 83);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1236, 258);
            this.panel8.TabIndex = 3;
            // 
            // FakturaDataGrid
            // 
            this.FakturaDataGrid.AllowCustomTheming = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.FakturaDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FakturaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FakturaDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.FakturaDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FakturaDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FakturaDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FakturaDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FakturaDataGrid.ColumnHeadersHeight = 40;
            this.FakturaDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.FakturaDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FakturaDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.FakturaDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.FakturaDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.FakturaDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.FakturaDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FakturaDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.FakturaDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.FakturaDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FakturaDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.FakturaDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.FakturaDataGrid.CurrentTheme.Name = null;
            this.FakturaDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FakturaDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FakturaDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.FakturaDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.FakturaDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FakturaDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.FakturaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FakturaDataGrid.EnableHeadersVisualStyles = false;
            this.FakturaDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FakturaDataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.FakturaDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.FakturaDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.FakturaDataGrid.Location = new System.Drawing.Point(0, 0);
            this.FakturaDataGrid.Name = "FakturaDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FakturaDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FakturaDataGrid.RowHeadersVisible = false;
            this.FakturaDataGrid.RowTemplate.Height = 40;
            this.FakturaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FakturaDataGrid.Size = new System.Drawing.Size(1236, 258);
            this.FakturaDataGrid.TabIndex = 0;
            this.FakturaDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.FakturaItemDataGrid);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 347);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1236, 389);
            this.panel9.TabIndex = 4;
            // 
            // FakturaItemDataGrid
            // 
            this.FakturaItemDataGrid.AllowCustomTheming = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.FakturaItemDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FakturaItemDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FakturaItemDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.FakturaItemDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FakturaItemDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FakturaItemDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FakturaItemDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FakturaItemDataGrid.ColumnHeadersHeight = 40;
            this.FakturaItemDataGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.FakturaItemDataGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FakturaItemDataGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.FakturaItemDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.FakturaItemDataGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.FakturaItemDataGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.FakturaItemDataGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FakturaItemDataGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.FakturaItemDataGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.FakturaItemDataGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FakturaItemDataGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.FakturaItemDataGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.FakturaItemDataGrid.CurrentTheme.Name = null;
            this.FakturaItemDataGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FakturaItemDataGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FakturaItemDataGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.FakturaItemDataGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.FakturaItemDataGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FakturaItemDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.FakturaItemDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FakturaItemDataGrid.EnableHeadersVisualStyles = false;
            this.FakturaItemDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.FakturaItemDataGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.FakturaItemDataGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.FakturaItemDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.FakturaItemDataGrid.Location = new System.Drawing.Point(0, 0);
            this.FakturaItemDataGrid.Name = "FakturaItemDataGrid";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FakturaItemDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.FakturaItemDataGrid.RowHeadersVisible = false;
            this.FakturaItemDataGrid.RowTemplate.Height = 40;
            this.FakturaItemDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FakturaItemDataGrid.Size = new System.Drawing.Size(1236, 389);
            this.FakturaItemDataGrid.TabIndex = 0;
            this.FakturaItemDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // FacturaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "FacturaControl";
            this.Size = new System.Drawing.Size(1242, 739);
            this.Load += new System.EventHandler(this.FacturaControl_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FakturaDataGrid)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FakturaItemDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.UI.WinForms.BunifuTextBox search_filial_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel8;
        private Bunifu.UI.WinForms.BunifuDataGridView FakturaDataGrid;
        private System.Windows.Forms.Panel panel9;
        private Bunifu.UI.WinForms.BunifuDataGridView FakturaItemDataGrid;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblQayta;
        public System.Windows.Forms.Label lblStatus;
        private Bunifu.UI.WinForms.BunifuDropdown historyType_comboBox;
    }
}
