namespace IAPM
{
    partial class FrmListeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListeClient));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bunifuFormDockListeClient = new Bunifu.UI.WinForms.BunifuFormDock();
            this.dgvClient = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblTitre = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbSeparateur = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.shwPnlDgv = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.scrBarDgv = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.btnPdf = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.ktReportPDF = new Kimtoo.Reports.ktReport(this.components);
            this.saveFileDialogPDF = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparateur)).BeginInit();
            this.shwPnlDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuFormDockListeClient
            // 
            this.bunifuFormDockListeClient.AllowFormDragging = true;
            this.bunifuFormDockListeClient.AllowFormDropShadow = true;
            this.bunifuFormDockListeClient.AllowFormResizing = false;
            this.bunifuFormDockListeClient.AllowHidingBottomRegion = true;
            this.bunifuFormDockListeClient.AllowOpacityChangesWhileDragging = true;
            this.bunifuFormDockListeClient.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockListeClient.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDockListeClient.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDockListeClient.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockListeClient.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDockListeClient.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDockListeClient.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockListeClient.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDockListeClient.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDockListeClient.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDockListeClient.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDockListeClient.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDockListeClient.ContainerControl = this;
            this.bunifuFormDockListeClient.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDockListeClient.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDockListeClient.DockingOptions.DockAll = true;
            this.bunifuFormDockListeClient.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDockListeClient.DockingOptions.DockBottomRight = true;
            this.bunifuFormDockListeClient.DockingOptions.DockFullScreen = true;
            this.bunifuFormDockListeClient.DockingOptions.DockLeft = true;
            this.bunifuFormDockListeClient.DockingOptions.DockRight = true;
            this.bunifuFormDockListeClient.DockingOptions.DockTopLeft = true;
            this.bunifuFormDockListeClient.DockingOptions.DockTopRight = true;
            this.bunifuFormDockListeClient.FormDraggingOpacity = 0.9D;
            this.bunifuFormDockListeClient.ParentForm = this;
            this.bunifuFormDockListeClient.ShowCursorChanges = true;
            this.bunifuFormDockListeClient.ShowDockingIndicators = true;
            this.bunifuFormDockListeClient.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDockListeClient.TitleBarOptions.BunifuFormDock = this.bunifuFormDockListeClient;
            this.bunifuFormDockListeClient.TitleBarOptions.DoubleClickToExpandWindow = false;
            this.bunifuFormDockListeClient.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDockListeClient.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowCustomTheming = true;
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.dgvClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.ColumnHeadersHeight = 40;
            this.dgvClient.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(101)))));
            this.dgvClient.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvClient.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.dgvClient.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.dgvClient.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvClient.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClient.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.dgvClient.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClient.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvClient.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvClient.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.dgvClient.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvClient.CurrentTheme.Name = null;
            this.dgvClient.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.dgvClient.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvClient.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.dgvClient.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.dgvClient.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClient.EnableHeadersVisualStyles = false;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.dgvClient.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClient.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvClient.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dgvClient.Location = new System.Drawing.Point(10, 15);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowTemplate.Height = 40;
            this.dgvClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.ShowCellErrors = false;
            this.dgvClient.ShowEditingIcon = false;
            this.dgvClient.Size = new System.Drawing.Size(767, 359);
            this.dgvClient.TabIndex = 1;
            this.dgvClient.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            // 
            // lblTitre
            // 
            this.lblTitre.AllowParentOverrides = false;
            this.lblTitre.AutoEllipsis = false;
            this.lblTitre.CursorType = null;
            this.lblTitre.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.lblTitre.Location = new System.Drawing.Point(609, 54);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitre.Size = new System.Drawing.Size(180, 40);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Liste des clients";
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
            this.pbSeparateur.Location = new System.Drawing.Point(49, 69);
            this.pbSeparateur.Name = "pbSeparateur";
            this.pbSeparateur.Size = new System.Drawing.Size(771, 81);
            this.pbSeparateur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeparateur.TabIndex = 12;
            this.pbSeparateur.TabStop = false;
            this.pbSeparateur.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // shwPnlDgv
            // 
            this.shwPnlDgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.shwPnlDgv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.shwPnlDgv.BorderRadius = 3;
            this.shwPnlDgv.BorderThickness = 5;
            this.shwPnlDgv.Controls.Add(this.dgvClient);
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
            this.shwPnlDgv.TabIndex = 13;
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
            this.scrBarDgv.BindingContainer = this.dgvClient;
            this.scrBarDgv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.scrBarDgv.BorderRadius = 14;
            this.scrBarDgv.BorderThickness = 1;
            this.scrBarDgv.DurationBeforeShrink = 2000;
            this.scrBarDgv.LargeChange = 10;
            this.scrBarDgv.Location = new System.Drawing.Point(836, 163);
            this.scrBarDgv.Margin = new System.Windows.Forms.Padding(4);
            this.scrBarDgv.Maximum = 100;
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
            this.scrBarDgv.TabIndex = 14;
            this.scrBarDgv.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.scrBarDgv.ThumbLength = 36;
            this.scrBarDgv.ThumbMargin = 1;
            this.scrBarDgv.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional;
            this.scrBarDgv.Value = 0;
            // 
            // btnPdf
            // 
            this.btnPdf.AllowAnimations = true;
            this.btnPdf.AllowMouseEffects = true;
            this.btnPdf.AllowToggling = false;
            this.btnPdf.AnimationSpeed = 200;
            this.btnPdf.AutoGenerateColors = false;
            this.btnPdf.AutoRoundBorders = false;
            this.btnPdf.AutoSizeLeftIcon = true;
            this.btnPdf.AutoSizeRightIcon = true;
            this.btnPdf.BackColor = System.Drawing.Color.Transparent;
            this.btnPdf.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPdf.ButtonText = "Générer un PDF";
            this.btnPdf.ButtonTextMarginLeft = 0;
            this.btnPdf.ColorContrastOnClick = 45;
            this.btnPdf.ColorContrastOnHover = 45;
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPdf.CustomizableEdges = borderEdges1;
            this.btnPdf.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPdf.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPdf.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPdf.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPdf.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnPdf.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPdf.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPdf.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPdf.IconMarginLeft = 11;
            this.btnPdf.IconPadding = 10;
            this.btnPdf.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPdf.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPdf.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPdf.IconSize = 25;
            this.btnPdf.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnPdf.IdleBorderRadius = 15;
            this.btnPdf.IdleBorderThickness = 1;
            this.btnPdf.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnPdf.IdleIconLeftImage = null;
            this.btnPdf.IdleIconRightImage = null;
            this.btnPdf.IndicateFocus = false;
            this.btnPdf.Location = new System.Drawing.Point(364, 549);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPdf.OnDisabledState.BorderRadius = 15;
            this.btnPdf.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPdf.OnDisabledState.BorderThickness = 1;
            this.btnPdf.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPdf.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPdf.OnDisabledState.IconLeftImage = null;
            this.btnPdf.OnDisabledState.IconRightImage = null;
            this.btnPdf.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.btnPdf.onHoverState.BorderRadius = 15;
            this.btnPdf.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPdf.onHoverState.BorderThickness = 1;
            this.btnPdf.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(190)))), ((int)(((byte)(140)))));
            this.btnPdf.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPdf.onHoverState.IconLeftImage = null;
            this.btnPdf.onHoverState.IconRightImage = null;
            this.btnPdf.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnPdf.OnIdleState.BorderRadius = 15;
            this.btnPdf.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPdf.OnIdleState.BorderThickness = 1;
            this.btnPdf.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnPdf.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPdf.OnIdleState.IconLeftImage = null;
            this.btnPdf.OnIdleState.IconRightImage = null;
            this.btnPdf.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.btnPdf.OnPressedState.BorderRadius = 15;
            this.btnPdf.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPdf.OnPressedState.BorderThickness = 1;
            this.btnPdf.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            this.btnPdf.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPdf.OnPressedState.IconLeftImage = null;
            this.btnPdf.OnPressedState.IconRightImage = null;
            this.btnPdf.Size = new System.Drawing.Size(156, 32);
            this.btnPdf.TabIndex = 20;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPdf.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPdf.TextMarginLeft = 0;
            this.btnPdf.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPdf.UseDefaultRadiusAndThickness = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // ktReportPDF
            // 
            this.ktReportPDF.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ktReportPDF.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.ktReportPDF.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.ktReportPDF.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.ktReportPDF.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.ktReportPDF.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ktReportPDF.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.ktReportPDF.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // FrmListeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(899, 600);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.scrBarDgv);
            this.Controls.Add(this.shwPnlDgv);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pbSeparateur);
            this.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.Icon = global::IAPM.Properties.Resources.icon_list;
            this.Name = "FrmListeClient";
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeClient_FormClosed);
            this.Load += new System.EventHandler(this.FrmListeClient_Load);
            this.Controls.SetChildIndex(this.pbSeparateur, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.shwPnlDgv, 0);
            this.Controls.SetChildIndex(this.scrBarDgv, 0);
            this.Controls.SetChildIndex(this.btnPdf, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeparateur)).EndInit();
            this.shwPnlDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDockListeClient;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvClient;
        private Bunifu.UI.WinForms.BunifuLabel lblTitre;
        private Bunifu.UI.WinForms.BunifuPictureBox pbSeparateur;
        private Bunifu.UI.WinForms.BunifuShadowPanel shwPnlDgv;
        private Bunifu.UI.WinForms.BunifuVScrollBar scrBarDgv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnPdf;
        private Kimtoo.Reports.ktReport ktReportPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPDF;
    }
}