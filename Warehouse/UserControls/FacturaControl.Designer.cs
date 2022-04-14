
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.filiallar_combo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.historyType_comboBox = new Bunifu.UI.WinForms.BunifuDropdown();
            this.search_filial_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.FakturaDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.FakturaItemDataGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.13378F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.86622F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1242, 739);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bunifuButton3);
            this.panel6.Controls.Add(this.filiallar_combo);
            this.panel6.Controls.Add(this.bunifuDropdown1);
            this.panel6.Controls.Add(this.historyType_comboBox);
            this.panel6.Controls.Add(this.search_filial_txt);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1236, 34);
            this.panel6.TabIndex = 1;
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = true;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "Yangilash";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges1;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.bunifuButton3.IdleBorderRadius = 10;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(349, 0);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 10;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.BorderRadius = 10;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.bunifuButton3.OnIdleState.BorderRadius = 10;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = null;
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.BorderRadius = 10;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(93, 30);
            this.bunifuButton3.TabIndex = 4;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.Yangilash_btn_Click);
            // 
            // filiallar_combo
            // 
            this.filiallar_combo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filiallar_combo.BackColor = System.Drawing.Color.Transparent;
            this.filiallar_combo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.filiallar_combo.BorderColor = System.Drawing.Color.Silver;
            this.filiallar_combo.BorderRadius = 8;
            this.filiallar_combo.Color = System.Drawing.Color.Silver;
            this.filiallar_combo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.filiallar_combo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filiallar_combo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.filiallar_combo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.filiallar_combo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filiallar_combo.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.filiallar_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filiallar_combo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.filiallar_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiallar_combo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.filiallar_combo.FillDropDown = true;
            this.filiallar_combo.FillIndicator = false;
            this.filiallar_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filiallar_combo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filiallar_combo.ForeColor = System.Drawing.Color.White;
            this.filiallar_combo.FormattingEnabled = true;
            this.filiallar_combo.Icon = null;
            this.filiallar_combo.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.filiallar_combo.IndicatorColor = System.Drawing.Color.Gray;
            this.filiallar_combo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.filiallar_combo.ItemBackColor = System.Drawing.Color.White;
            this.filiallar_combo.ItemBorderColor = System.Drawing.Color.White;
            this.filiallar_combo.ItemForeColor = System.Drawing.Color.Black;
            this.filiallar_combo.ItemHeight = 26;
            this.filiallar_combo.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.filiallar_combo.ItemHighLightForeColor = System.Drawing.Color.White;
            this.filiallar_combo.ItemTopMargin = 3;
            this.filiallar_combo.Location = new System.Drawing.Point(574, 0);
            this.filiallar_combo.Name = "filiallar_combo";
            this.filiallar_combo.Size = new System.Drawing.Size(155, 32);
            this.filiallar_combo.TabIndex = 3;
            this.filiallar_combo.Text = "Filiallar";
            this.filiallar_combo.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.filiallar_combo.TextLeftMargin = 5;
            this.filiallar_combo.SelectedIndexChanged += new System.EventHandler(this.filialCombo_selectedIndexChanged);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.bunifuDropdown1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdown1.BorderRadius = 8;
            this.bunifuDropdown1.Color = System.Drawing.Color.Silver;
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdown1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdown1.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = true;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.ItemHeight = 26;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdown1.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items.AddRange(new object[] {
            "Yaratilgan",
            "Jo\'natilgan",
            "Qabul qilingan"});
            this.bunifuDropdown1.ItemTopMargin = 3;
            this.bunifuDropdown1.Location = new System.Drawing.Point(814, 0);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(148, 32);
            this.bunifuDropdown1.TabIndex = 3;
            this.bunifuDropdown1.Text = "Barchasi";
            this.bunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.TextLeftMargin = 5;
            this.bunifuDropdown1.SelectedIndexChanged += new System.EventHandler(this.historyType_comboBox_SelectedIndexChanged);
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
            "Faktura tarixi",
            "Mahsulot qabul tarixi"});
            this.historyType_comboBox.ItemTopMargin = 3;
            this.historyType_comboBox.Location = new System.Drawing.Point(1025, 0);
            this.historyType_comboBox.Name = "historyType_comboBox";
            this.historyType_comboBox.Size = new System.Drawing.Size(196, 32);
            this.historyType_comboBox.TabIndex = 3;
            this.historyType_comboBox.Text = "Fakturalar";
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
            this.panel8.Location = new System.Drawing.Point(3, 43);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1236, 274);
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
            this.FakturaDataGrid.ReadOnly = true;
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
            this.FakturaDataGrid.Size = new System.Drawing.Size(1236, 274);
            this.FakturaDataGrid.TabIndex = 0;
            this.FakturaDataGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.FakturaDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FakturaDataGrid_CellClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.FakturaItemDataGrid);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 323);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1236, 413);
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
            this.FakturaItemDataGrid.ReadOnly = true;
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
            this.FakturaItemDataGrid.Size = new System.Drawing.Size(1236, 413);
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
        private Bunifu.UI.WinForms.BunifuDropdown historyType_comboBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuDropdown filiallar_combo;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
    }
}
