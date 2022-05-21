namespace IAPM
{
    partial class FrmRechClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechClient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblTitre = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbSeparateur = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.shwPnlDgv = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.dgvRechClient = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.scrBarDgv = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.bunifuFormDockRechClient = new Bunifu.UI.WinForms.BunifuFormDock();
            this.tbMotCle = new Bunifu.UI.WinForms.BunifuTextBox();
            this.snackBarClient = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparateur)).BeginInit();
            this.shwPnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AllowParentOverrides = false;
            this.lblTitre.AutoEllipsis = false;
            this.lblTitre.CursorType = null;
            this.lblTitre.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.lblTitre.Location = new System.Drawing.Point(571, 54);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitre.Size = new System.Drawing.Size(219, 40);
            this.lblTitre.TabIndex = 15;
            this.lblTitre.Text = "Recherche de client";
            this.lblTitre.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitre.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbSeparateur
            // 
            this.pbSeparateur.AllowFocused = false;
            this.pbSeparateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbSeparateur.AutoSizeHeight = false;
            this.pbSeparateur.BackColor = System.Drawing.Color.Transparent;
            this.pbSeparateur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSeparateur.BorderRadius = 0;
            this.pbSeparateur.Image = global::IAPM.Properties.Resources.img_separator;
            this.pbSeparateur.IsCircle = false;
            this.pbSeparateur.Location = new System.Drawing.Point(49, 68);
            this.pbSeparateur.Name = "pbSeparateur";
            this.pbSeparateur.Size = new System.Drawing.Size(771, 81);
            this.pbSeparateur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeparateur.TabIndex = 16;
            this.pbSeparateur.TabStop = false;
            this.pbSeparateur.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // shwPnlDgv
            // 
            this.shwPnlDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.shwPnlDgv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.shwPnlDgv.BorderRadius = 3;
            this.shwPnlDgv.BorderThickness = 5;
            this.shwPnlDgv.Controls.Add(this.dgvRechClient);
            this.shwPnlDgv.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.shwPnlDgv.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.shwPnlDgv.Location = new System.Drawing.Point(49, 156);
            this.shwPnlDgv.Name = "shwPnlDgv";
            this.shwPnlDgv.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.shwPnlDgv.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.shwPnlDgv.ShadowColor = System.Drawing.Color.DarkGray;
            this.shwPnlDgv.ShadowDept = 2;
            this.shwPnlDgv.ShadowDepth = 5;
            this.shwPnlDgv.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.shwPnlDgv.ShadowTopLeftVisible = false;
            this.shwPnlDgv.Size = new System.Drawing.Size(787, 379);
            this.shwPnlDgv.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.shwPnlDgv.TabIndex = 23;
            // 
            // dgvRechClient
            // 
            this.dgvRechClient.AllowCustomTheming = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.dgvRechClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRechClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRechClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvRechClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRechClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRechClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRechClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRechClient.ColumnHeadersHeight = 40;
            this.dgvRechClient.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.dgvRechClient.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRechClient.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.dgvRechClient.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.dgvRechClient.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvRechClient.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvRechClient.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.dgvRechClient.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvRechClient.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvRechClient.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvRechClient.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.dgvRechClient.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvRechClient.CurrentTheme.Name = null;
            this.dgvRechClient.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.dgvRechClient.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRechClient.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.dgvRechClient.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.dgvRechClient.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRechClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRechClient.EnableHeadersVisualStyles = false;
            this.dgvRechClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.dgvRechClient.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvRechClient.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvRechClient.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvRechClient.Location = new System.Drawing.Point(10, 15);
            this.dgvRechClient.Name = "dgvRechClient";
            this.dgvRechClient.RowHeadersVisible = false;
            this.dgvRechClient.RowTemplate.Height = 40;
            this.dgvRechClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRechClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRechClient.ShowCellErrors = false;
            this.dgvRechClient.ShowEditingIcon = false;
            this.dgvRechClient.Size = new System.Drawing.Size(767, 359);
            this.dgvRechClient.TabIndex = 1;
            this.dgvRechClient.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            this.dgvRechClient.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvRechClient_UserDeletingRow);
            // 
            // scrBarDgv
            // 
            this.scrBarDgv.AllowCursorChanges = true;
            this.scrBarDgv.AllowHomeEndKeysDetection = false;
            this.scrBarDgv.AllowIncrementalClickMoves = true;
            this.scrBarDgv.AllowMouseDownEffects = true;
            this.scrBarDgv.AllowMouseHoverEffects = true;
            this.scrBarDgv.AllowScrollingAnimations = true;
            this.scrBarDgv.AllowScrollKeysDetection = true;
            this.scrBarDgv.AllowScrollOptionsMenu = true;
            this.scrBarDgv.AllowShrinkingOnFocusLost = false;
            this.scrBarDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.scrBarDgv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrBarDgv.BackgroundImage")));
            this.scrBarDgv.BindingContainer = this.dgvRechClient;
            this.scrBarDgv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.scrBarDgv.BorderRadius = 14;
            this.scrBarDgv.BorderThickness = 1;
            this.scrBarDgv.DurationBeforeShrink = 2000;
            this.scrBarDgv.Enabled = false;
            this.scrBarDgv.LargeChange = 10;
            this.scrBarDgv.Location = new System.Drawing.Point(836, 163);
            this.scrBarDgv.Margin = new System.Windows.Forms.Padding(7);
            this.scrBarDgv.Maximum = 150;
            this.scrBarDgv.Minimum = 0;
            this.scrBarDgv.MinimumThumbLength = 18;
            this.scrBarDgv.Name = "scrBarDgv";
            this.scrBarDgv.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.scrBarDgv.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scrBarDgv.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.scrBarDgv.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.scrBarDgv.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.scrBarDgv.ShrinkSizeLimit = 3;
            this.scrBarDgv.Size = new System.Drawing.Size(13, 367);
            this.scrBarDgv.SmallChange = 1;
            this.scrBarDgv.TabIndex = 24;
            this.scrBarDgv.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.scrBarDgv.ThumbLength = 24;
            this.scrBarDgv.ThumbMargin = 1;
            this.scrBarDgv.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional;
            this.scrBarDgv.Value = 0;
            this.scrBarDgv.Visible = false;
            // 
            // bunifuFormDockRechClient
            // 
            this.bunifuFormDockRechClient.AllowFormDragging = true;
            this.bunifuFormDockRechClient.AllowFormDropShadow = true;
            this.bunifuFormDockRechClient.AllowFormResizing = false;
            this.bunifuFormDockRechClient.AllowHidingBottomRegion = true;
            this.bunifuFormDockRechClient.AllowOpacityChangesWhileDragging = true;
            this.bunifuFormDockRechClient.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockRechClient.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDockRechClient.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDockRechClient.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockRechClient.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDockRechClient.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDockRechClient.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockRechClient.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDockRechClient.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDockRechClient.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockRechClient.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDockRechClient.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDockRechClient.ContainerControl = this;
            this.bunifuFormDockRechClient.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDockRechClient.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDockRechClient.DockingOptions.DockAll = true;
            this.bunifuFormDockRechClient.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDockRechClient.DockingOptions.DockBottomRight = true;
            this.bunifuFormDockRechClient.DockingOptions.DockFullScreen = true;
            this.bunifuFormDockRechClient.DockingOptions.DockLeft = true;
            this.bunifuFormDockRechClient.DockingOptions.DockRight = true;
            this.bunifuFormDockRechClient.DockingOptions.DockTopLeft = true;
            this.bunifuFormDockRechClient.DockingOptions.DockTopRight = true;
            this.bunifuFormDockRechClient.FormDraggingOpacity = 0.9D;
            this.bunifuFormDockRechClient.ParentForm = this;
            this.bunifuFormDockRechClient.ShowCursorChanges = true;
            this.bunifuFormDockRechClient.ShowDockingIndicators = true;
            this.bunifuFormDockRechClient.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDockRechClient.TitleBarOptions.BunifuFormDock = this.bunifuFormDockRechClient;
            this.bunifuFormDockRechClient.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDockRechClient.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDockRechClient.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // tbMotCle
            // 
            this.tbMotCle.AcceptsReturn = false;
            this.tbMotCle.AcceptsTab = false;
            this.tbMotCle.AnimationSpeed = 200;
            this.tbMotCle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbMotCle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbMotCle.AutoSizeHeight = true;
            this.tbMotCle.BackColor = System.Drawing.Color.Transparent;
            this.tbMotCle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMotCle.BackgroundImage")));
            this.tbMotCle.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.tbMotCle.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbMotCle.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.tbMotCle.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.tbMotCle.BorderRadius = 15;
            this.tbMotCle.BorderThickness = 2;
            this.tbMotCle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMotCle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMotCle.DefaultFont = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.tbMotCle.DefaultText = "";
            this.tbMotCle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.tbMotCle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tbMotCle.HideSelection = true;
            this.tbMotCle.IconLeft = null;
            this.tbMotCle.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMotCle.IconPadding = 10;
            this.tbMotCle.IconRight = global::IAPM.Properties.Resources.icon_loupe;
            this.tbMotCle.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMotCle.Lines = new string[0];
            this.tbMotCle.Location = new System.Drawing.Point(298, 559);
            this.tbMotCle.MaxLength = 32767;
            this.tbMotCle.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbMotCle.Modified = false;
            this.tbMotCle.Multiline = false;
            this.tbMotCle.Name = "tbMotCle";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbMotCle.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbMotCle.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbMotCle.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbMotCle.OnIdleState = stateProperties4;
            this.tbMotCle.Padding = new System.Windows.Forms.Padding(3);
            this.tbMotCle.PasswordChar = '\0';
            this.tbMotCle.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tbMotCle.PlaceholderText = "Critère de recherche";
            this.tbMotCle.ReadOnly = false;
            this.tbMotCle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMotCle.SelectedText = "";
            this.tbMotCle.SelectionLength = 0;
            this.tbMotCle.SelectionStart = 0;
            this.tbMotCle.ShortcutsEnabled = true;
            this.tbMotCle.Size = new System.Drawing.Size(289, 50);
            this.tbMotCle.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbMotCle.TabIndex = 25;
            this.tbMotCle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMotCle.TextMarginBottom = 0;
            this.tbMotCle.TextMarginLeft = 3;
            this.tbMotCle.TextMarginTop = 1;
            this.tbMotCle.TextPlaceholder = "Critère de recherche";
            this.tbMotCle.UseSystemPasswordChar = false;
            this.tbMotCle.WordWrap = true;
            this.tbMotCle.TextChange += new System.EventHandler(this.tbMotCle_TextChange);
            // 
            // snackBarClient
            // 
            this.snackBarClient.AllowDragging = false;
            this.snackBarClient.AllowMultipleViews = true;
            this.snackBarClient.ClickToClose = true;
            this.snackBarClient.DoubleClickToClose = true;
            this.snackBarClient.DurationAfterIdle = 3000;
            this.snackBarClient.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.ErrorOptions.ActionBorderRadius = 1;
            this.snackBarClient.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarClient.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarClient.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snackBarClient.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarClient.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snackBarClient.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarClient.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarClient.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snackBarClient.ErrorOptions.IconLeftMargin = 12;
            this.snackBarClient.FadeCloseIcon = false;
            this.snackBarClient.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snackBarClient.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.InformationOptions.ActionBorderRadius = 1;
            this.snackBarClient.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarClient.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarClient.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snackBarClient.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarClient.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snackBarClient.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarClient.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarClient.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snackBarClient.InformationOptions.IconLeftMargin = 12;
            this.snackBarClient.Margin = 10;
            this.snackBarClient.MaximumSize = new System.Drawing.Size(0, 0);
            this.snackBarClient.MaximumViews = 7;
            this.snackBarClient.MessageRightMargin = 15;
            this.snackBarClient.MinimumSize = new System.Drawing.Size(0, 0);
            this.snackBarClient.ShowBorders = true;
            this.snackBarClient.ShowCloseIcon = false;
            this.snackBarClient.ShowIcon = true;
            this.snackBarClient.ShowShadows = true;
            this.snackBarClient.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.SuccessOptions.ActionBorderRadius = 1;
            this.snackBarClient.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarClient.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarClient.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snackBarClient.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarClient.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snackBarClient.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarClient.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarClient.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snackBarClient.SuccessOptions.IconLeftMargin = 12;
            this.snackBarClient.ViewsMargin = 7;
            this.snackBarClient.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarClient.WarningOptions.ActionBorderRadius = 1;
            this.snackBarClient.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarClient.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarClient.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snackBarClient.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarClient.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snackBarClient.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarClient.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarClient.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snackBarClient.WarningOptions.IconLeftMargin = 12;
            this.snackBarClient.ZoomCloseIcon = true;
            // 
            // FrmRechClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(899, 634);
            this.Controls.Add(this.tbMotCle);
            this.Controls.Add(this.scrBarDgv);
            this.Controls.Add(this.shwPnlDgv);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pbSeparateur);
            this.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.Icon = global::IAPM.Properties.Resources.icon_recherche;
            this.Name = "FrmRechClient";
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRechClient_FormClosed);
            this.Load += new System.EventHandler(this.FrmRechClient_Load);
            this.Controls.SetChildIndex(this.pbSeparateur, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.shwPnlDgv, 0);
            this.Controls.SetChildIndex(this.scrBarDgv, 0);
            this.Controls.SetChildIndex(this.tbMotCle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparateur)).EndInit();
            this.shwPnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRechClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblTitre;
        private Bunifu.UI.WinForms.BunifuPictureBox pbSeparateur;
        private Bunifu.UI.WinForms.BunifuShadowPanel shwPnlDgv;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvRechClient;
        private Bunifu.UI.WinForms.BunifuVScrollBar scrBarDgv;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDockRechClient;
        private Bunifu.UI.WinForms.BunifuTextBox tbMotCle;
        private Bunifu.UI.WinForms.BunifuSnackbar snackBarClient;
    }
}