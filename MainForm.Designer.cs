﻿namespace Ketarin
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imlStatus = new System.Windows.Forms.ImageList(this.components);
            this.cmnuJobs = new System.Windows.Forms.ContextMenu();
            this.cmnuUpdate = new System.Windows.Forms.MenuItem();
            this.cmnuCheckForUpdate = new System.Windows.Forms.MenuItem();
            this.cmnuForceDownload = new System.Windows.Forms.MenuItem();
            this.cmnuSepUpdates = new System.Windows.Forms.MenuItem();
            this.cmnuOpenFile = new System.Windows.Forms.MenuItem();
            this.cmnuOpenFolder = new System.Windows.Forms.MenuItem();
            this.cmnuRename = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.cmnuEdit = new System.Windows.Forms.MenuItem();
            this.cmnuDelete = new System.Windows.Forms.MenuItem();
            this.cmnuCopy = new System.Windows.Forms.MenuItem();
            this.cmnuPaste = new System.Windows.Forms.MenuItem();
            this.mnuSelectAll = new System.Windows.Forms.MenuItem();
            this.mnuInvert = new System.Windows.Forms.MenuItem();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuNew = new System.Windows.Forms.MenuItem();
            this.mnuImport = new System.Windows.Forms.MenuItem();
            this.mnuExportSelected = new System.Windows.Forms.MenuItem();
            this.mnuExportAll = new System.Windows.Forms.MenuItem();
            this.mnusep2 = new System.Windows.Forms.MenuItem();
            this.mnuSettings = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuLog = new System.Windows.Forms.MenuItem();
            this.mnuShowGroups = new System.Windows.Forms.MenuItem();
            this.mnuShowStatusBar = new System.Windows.Forms.MenuItem();
            this.mnuFind = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuTutorial = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.cmuAdd = new System.Windows.Forms.ContextMenu();
            this.cmnuAdd = new System.Windows.Forms.MenuItem();
            this.cmnuImportFile = new System.Windows.Forms.MenuItem();
            this.cmnuImportOnline = new System.Windows.Forms.MenuItem();
            this.olvJobs = new Ketarin.ApplicationJobsListView();
            this.colName = new CDBurnerXP.Controls.OLVColumn();
            this.colLastUpdate = new CDBurnerXP.Controls.OLVColumn();
            this.colProgress = new CDBurnerXP.Controls.OLVColumn();
            this.colTarget = new CDBurnerXP.Controls.OLVColumn();
            this.colCategory = new CDBurnerXP.Controls.OLVColumn();
            this.colCustomValue = new CDBurnerXP.Controls.OLVColumn();
            this.colCustomValue2 = new CDBurnerXP.Controls.OLVColumn();
            this.m_VistaMenu = new CDBurnerXP.Controls.VistaMenu(this.components);
            this.bAddApplication = new wyDay.Controls.SplitButton();
            this.bRun = new wyDay.Controls.SplitButton();
            this.cmuRun = new System.Windows.Forms.ContextMenu();
            this.cmnuCheckAndDownload = new System.Windows.Forms.MenuItem();
            this.cmnuOnlyCheck = new System.Windows.Forms.MenuItem();
            this.ntiTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnuTrayIconMenu = new System.Windows.Forms.ContextMenu();
            this.cmnuShow = new System.Windows.Forms.MenuItem();
            this.cmnuExit = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tbSelectedApplications = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbTotalApplications = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuAutoScroll = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VistaMenu)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlStatus
            // 
            this.imlStatus.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlStatus.ImageSize = new System.Drawing.Size(16, 16);
            this.imlStatus.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmnuJobs
            // 
            this.cmnuJobs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmnuUpdate,
            this.cmnuCheckForUpdate,
            this.cmnuForceDownload,
            this.cmnuSepUpdates,
            this.cmnuOpenFile,
            this.cmnuOpenFolder,
            this.cmnuRename,
            this.menuItem4,
            this.cmnuEdit,
            this.cmnuDelete,
            this.cmnuCopy,
            this.cmnuPaste,
            this.mnuSelectAll,
            this.mnuInvert});
            this.cmnuJobs.Popup += new System.EventHandler(this.cmnuJobs_Popup);
            // 
            // cmnuUpdate
            // 
            this.m_VistaMenu.SetImage(this.cmnuUpdate, global::Ketarin.Properties.Resources.Restart);
            this.cmnuUpdate.Index = 0;
            this.cmnuUpdate.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
            this.cmnuUpdate.Text = "&Update";
            this.cmnuUpdate.Click += new System.EventHandler(this.cmuUpdate_Click);
            // 
            // cmnuCheckForUpdate
            // 
            this.cmnuCheckForUpdate.Index = 1;
            this.cmnuCheckForUpdate.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftU;
            this.cmnuCheckForUpdate.Text = "C&heck for update";
            this.cmnuCheckForUpdate.Click += new System.EventHandler(this.cmnuCheckForUpdate_Click);
            // 
            // cmnuForceDownload
            // 
            this.cmnuForceDownload.Index = 2;
            this.cmnuForceDownload.Shortcut = System.Windows.Forms.Shortcut.CtrlF5;
            this.cmnuForceDownload.Text = "&Force download";
            this.cmnuForceDownload.Click += new System.EventHandler(this.cmnuForceDownload_Click);
            // 
            // cmnuSepUpdates
            // 
            this.cmnuSepUpdates.Index = 3;
            this.cmnuSepUpdates.Text = "-";
            // 
            // cmnuOpenFile
            // 
            this.cmnuOpenFile.Enabled = false;
            this.cmnuOpenFile.Index = 4;
            this.cmnuOpenFile.Text = "&Open file";
            this.cmnuOpenFile.Click += new System.EventHandler(this.cmnuOpenFile_Click);
            // 
            // cmnuOpenFolder
            // 
            this.cmnuOpenFolder.Index = 5;
            this.cmnuOpenFolder.Text = "Ope&n folder";
            this.cmnuOpenFolder.Click += new System.EventHandler(this.cmnuOpenFolder_Click);
            // 
            // cmnuRename
            // 
            this.cmnuRename.Enabled = false;
            this.cmnuRename.Index = 6;
            this.cmnuRename.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.cmnuRename.Text = "&Rename file";
            this.cmnuRename.Click += new System.EventHandler(this.cmnuRename_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 7;
            this.menuItem4.Text = "-";
            // 
            // cmnuEdit
            // 
            this.cmnuEdit.Enabled = false;
            this.cmnuEdit.Index = 8;
            this.cmnuEdit.Text = "&Edit";
            this.cmnuEdit.Click += new System.EventHandler(this.cmnuEdit_Click);
            // 
            // cmnuDelete
            // 
            this.cmnuDelete.Enabled = false;
            this.cmnuDelete.Index = 9;
            this.cmnuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.cmnuDelete.Text = "&Delete";
            this.cmnuDelete.Click += new System.EventHandler(this.cmnuDelete_Click);
            // 
            // cmnuCopy
            // 
            this.cmnuCopy.Index = 10;
            this.cmnuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.cmnuCopy.Text = "&Copy";
            this.cmnuCopy.Click += new System.EventHandler(this.cmnuCopy_Click);
            // 
            // cmnuPaste
            // 
            this.cmnuPaste.Index = 11;
            this.cmnuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.cmnuPaste.Text = "&Paste";
            this.cmnuPaste.Click += new System.EventHandler(this.cmnuPaste_Click);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Index = 12;
            this.mnuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.mnuSelectAll.Text = "Select &all";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuInvert
            // 
            this.mnuInvert.Index = 13;
            this.mnuInvert.Shortcut = System.Windows.Forms.Shortcut.CtrlI;
            this.mnuInvert.Text = "In&vert selection";
            this.mnuInvert.Click += new System.EventHandler(this.mnuInvert_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuView,
            this.mnuHelp});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNew,
            this.mnuImport,
            this.mnuExportSelected,
            this.mnuExportAll,
            this.mnusep2,
            this.mnuSettings,
            this.menuItem7,
            this.mnuExit});
            this.mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            this.m_VistaMenu.SetImage(this.mnuNew, global::Ketarin.Properties.Resources.AddSmall);
            this.mnuNew.Index = 0;
            this.mnuNew.Text = "&New application...";
            this.mnuNew.Click += new System.EventHandler(this.mnuAddNew_Click);
            // 
            // mnuImport
            // 
            this.mnuImport.Index = 1;
            this.mnuImport.Text = "&Import...";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // mnuExportSelected
            // 
            this.mnuExportSelected.Index = 2;
            this.mnuExportSelected.Text = "E&xport selected...";
            this.mnuExportSelected.Click += new System.EventHandler(this.mnuExportSelected_Click);
            // 
            // mnuExportAll
            // 
            this.mnuExportAll.Index = 3;
            this.mnuExportAll.Text = "Export &all...";
            this.mnuExportAll.Click += new System.EventHandler(this.mnuExportAll_Click);
            // 
            // mnusep2
            // 
            this.mnusep2.Index = 4;
            this.mnusep2.Text = "-";
            // 
            // mnuSettings
            // 
            this.mnuSettings.Index = 5;
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            this.menuItem7.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 7;
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.Index = 1;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuLog,
            this.mnuShowGroups,
            this.mnuShowStatusBar,
            this.mnuAutoScroll,
            this.mnuFind});
            this.mnuView.Text = "&View";
            // 
            // mnuLog
            // 
            this.mnuLog.Index = 0;
            this.mnuLog.Text = "&Show log";
            this.mnuLog.Click += new System.EventHandler(this.mnuLog_Click);
            // 
            // mnuShowGroups
            // 
            this.mnuShowGroups.Checked = true;
            this.mnuShowGroups.Index = 1;
            this.mnuShowGroups.Text = "Show &groups";
            this.mnuShowGroups.Click += new System.EventHandler(this.mnuShowGroups_Click);
            // 
            // mnuShowStatusBar
            // 
            this.mnuShowStatusBar.Index = 2;
            this.mnuShowStatusBar.Text = "Show status &bar";
            this.mnuShowStatusBar.Click += new System.EventHandler(this.mnuShowStatusBar_Click);
            // 
            // mnuFind
            // 
            this.mnuFind.Index = 4;
            this.mnuFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.mnuFind.Text = "&Find";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Index = 2;
            this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuTutorial,
            this.mnuAbout});
            this.mnuHelp.Text = "&Help";
            // 
            // mnuTutorial
            // 
            this.mnuTutorial.Index = 0;
            this.mnuTutorial.Text = "&Tutorial";
            this.mnuTutorial.Click += new System.EventHandler(this.mnuTutorial_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 1;
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // cmuAdd
            // 
            this.cmuAdd.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmnuAdd,
            this.cmnuImportFile,
            this.cmnuImportOnline});
            // 
            // cmnuAdd
            // 
            this.cmnuAdd.Index = 0;
            this.cmnuAdd.Text = "&New...";
            this.cmnuAdd.Click += new System.EventHandler(this.cmnuAdd_Click);
            // 
            // cmnuImportFile
            // 
            this.cmnuImportFile.Index = 1;
            this.cmnuImportFile.Text = "Imp&ort from file...";
            this.cmnuImportFile.Click += new System.EventHandler(this.cmnuImport_Click);
            // 
            // cmnuImportOnline
            // 
            this.cmnuImportOnline.Index = 2;
            this.cmnuImportOnline.Text = "I&mport from online database...";
            this.cmnuImportOnline.Click += new System.EventHandler(this.cmnuImportOnline_Click);
            // 
            // olvJobs
            // 
            this.olvJobs.AllColumns.Add(this.colName);
            this.olvJobs.AllColumns.Add(this.colLastUpdate);
            this.olvJobs.AllColumns.Add(this.colProgress);
            this.olvJobs.AllColumns.Add(this.colTarget);
            this.olvJobs.AllColumns.Add(this.colCategory);
            this.olvJobs.AllColumns.Add(this.colCustomValue);
            this.olvJobs.AllColumns.Add(this.colCustomValue2);
            this.olvJobs.AllowColumnReorder = true;
            this.olvJobs.AlternateRowBackColor = System.Drawing.Color.Empty;
            this.olvJobs.AlwaysGroupByColumn = null;
            this.olvJobs.AlwaysGroupBySortOrder = System.Windows.Forms.SortOrder.None;
            this.olvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.olvJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLastUpdate,
            this.colProgress,
            this.colTarget,
            this.colCategory});
            this.olvJobs.FullRowSelect = true;
            this.olvJobs.HideSelection = false;
            this.olvJobs.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.olvJobs.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.olvJobs.LastSortColumn = null;
            this.olvJobs.LastSortOrder = System.Windows.Forms.SortOrder.None;
            this.olvJobs.Location = new System.Drawing.Point(12, 12);
            this.olvJobs.Name = "olvJobs";
            this.olvJobs.OwnerDraw = true;
            this.olvJobs.Size = new System.Drawing.Size(658, 252);
            this.olvJobs.SmallImageList = this.imlStatus;
            this.olvJobs.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvJobs.TabIndex = 0;
            this.olvJobs.UseCompatibleStateImageBehavior = false;
            this.olvJobs.View = System.Windows.Forms.View.Details;
            this.olvJobs.DoubleClick += new System.EventHandler(this.olvJobs_DoubleClick);
            this.olvJobs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.olvJobs_KeyDown);
            this.olvJobs.SelectedIndexChanged += new System.EventHandler(this.olvJobs_SelectedIndexChanged);
            this.olvJobs.SelectionChanged += new System.EventHandler(this.olvJobs_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AspectName = null;
            this.colName.Text = "Application";
            this.colName.Width = 183;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.AspectName = null;
            this.colLastUpdate.Text = "Last updated";
            this.colLastUpdate.Width = 110;
            // 
            // colProgress
            // 
            this.colProgress.AspectName = null;
            this.colProgress.MaximumWidth = 100;
            this.colProgress.MinimumWidth = 100;
            this.colProgress.Text = "Progress";
            this.colProgress.Width = 100;
            // 
            // colTarget
            // 
            this.colTarget.AspectName = null;
            this.colTarget.FillsFreeSpace = true;
            this.colTarget.Text = "Target";
            // 
            // colCategory
            // 
            this.colCategory.AspectName = "Category";
            this.colCategory.Text = "Category";
            this.colCategory.Width = 80;
            // 
            // colCustomValue
            // 
            this.colCustomValue.AspectName = null;
            this.colCustomValue.IsVisible = false;
            this.colCustomValue.Text = "Custom Value";
            // 
            // colCustomValue2
            // 
            this.colCustomValue2.AspectName = null;
            this.colCustomValue2.IsVisible = false;
            this.colCustomValue2.Text = "Custom Value 2";
            // 
            // m_VistaMenu
            // 
            this.m_VistaMenu.ContainerControl = this;
            // 
            // bAddApplication
            // 
            this.bAddApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAddApplication.AutoSize = true;
            this.bAddApplication.Image = global::Ketarin.Properties.Resources.AddSmall;
            this.bAddApplication.Location = new System.Drawing.Point(12, 270);
            this.bAddApplication.Name = "bAddApplication";
            this.bAddApplication.Size = new System.Drawing.Size(150, 24);
            this.bAddApplication.SplitMenu = this.cmuAdd;
            this.bAddApplication.TabIndex = 3;
            this.bAddApplication.Text = "&Add new application";
            this.bAddApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAddApplication.UseVisualStyleBackColor = true;
            this.bAddApplication.Click += new System.EventHandler(this.sbAddApplication_Click);
            // 
            // bRun
            // 
            this.bRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRun.AutoSize = true;
            this.bRun.Image = global::Ketarin.Properties.Resources.Restart;
            this.bRun.Location = new System.Drawing.Point(168, 270);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(116, 24);
            this.bRun.SplitMenu = this.cmuRun;
            this.bRun.TabIndex = 4;
            this.bRun.Text = "&Update now";
            this.bRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // cmuRun
            // 
            this.cmuRun.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmnuCheckAndDownload,
            this.cmnuOnlyCheck});
            // 
            // cmnuCheckAndDownload
            // 
            this.cmnuCheckAndDownload.Index = 0;
            this.cmnuCheckAndDownload.Text = "&Check for updates and download";
            this.cmnuCheckAndDownload.Click += new System.EventHandler(this.cmnuCheckAndDownload_Click);
            // 
            // cmnuOnlyCheck
            // 
            this.cmnuOnlyCheck.Index = 1;
            this.cmnuOnlyCheck.Text = "&Only check for updates";
            this.cmnuOnlyCheck.Click += new System.EventHandler(this.cmnuOnlyCheck_Click);
            // 
            // ntiTrayIcon
            // 
            this.ntiTrayIcon.ContextMenu = this.cmnuTrayIconMenu;
            this.ntiTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiTrayIcon.Icon")));
            this.ntiTrayIcon.Text = "Ketarin (Idle)";
            this.ntiTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiTrayIcon_MouseDoubleClick);
            // 
            // cmnuTrayIconMenu
            // 
            this.cmnuTrayIconMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmnuShow,
            this.cmnuExit});
            // 
            // cmnuShow
            // 
            this.cmnuShow.Index = 0;
            this.cmnuShow.Text = "&Show";
            this.cmnuShow.Click += new System.EventHandler(this.cmnuShow_Click);
            // 
            // cmnuExit
            // 
            this.cmnuExit.Index = 1;
            this.cmnuExit.Text = "E&xit";
            this.cmnuExit.Click += new System.EventHandler(this.cmnuExit_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSelectedApplications,
            this.tbTotalApplications});
            this.statusBar.Location = new System.Drawing.Point(0, 282);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(682, 24);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusBar";
            this.statusBar.Visible = false;
            // 
            // tbSelectedApplications
            // 
            this.tbSelectedApplications.Name = "tbSelectedApplications";
            this.tbSelectedApplications.Size = new System.Drawing.Size(130, 19);
            this.tbSelectedApplications.Text = "Selected applications: 0";
            // 
            // tbTotalApplications
            // 
            this.tbTotalApplications.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tbTotalApplications.Name = "tbTotalApplications";
            this.tbTotalApplications.Size = new System.Drawing.Size(537, 19);
            this.tbTotalApplications.Spring = true;
            this.tbTotalApplications.Text = "Number of applications: 0";
            this.tbTotalApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuAutoScroll
            // 
            this.mnuAutoScroll.Checked = true;
            this.mnuAutoScroll.Index = 3;
            this.mnuAutoScroll.Text = "Auto scroll";
            this.mnuAutoScroll.Click += new System.EventHandler(this.mnuAutoScroll_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 306);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.bAddApplication);
            this.Controls.Add(this.olvJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainForm";
            this.SavePosition = true;
            this.Text = "Ketarin";
            ((System.ComponentModel.ISupportInitialize)(this.olvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VistaMenu)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApplicationJobsListView olvJobs;
        private System.Windows.Forms.ImageList imlStatus;
        private CDBurnerXP.Controls.VistaMenu m_VistaMenu;
        private System.Windows.Forms.ContextMenu cmnuJobs;
        private System.Windows.Forms.MenuItem cmnuUpdate;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem cmnuEdit;
        private System.Windows.Forms.MenuItem cmnuDelete;
        private CDBurnerXP.Controls.OLVColumn colName;
        private CDBurnerXP.Controls.OLVColumn colLastUpdate;
        private CDBurnerXP.Controls.OLVColumn colProgress;
        private CDBurnerXP.Controls.OLVColumn colTarget;
        private System.Windows.Forms.MenuItem cmnuOpenFile;
        private System.Windows.Forms.MenuItem cmnuRename;
        private CDBurnerXP.Controls.OLVColumn colCategory;
        private System.Windows.Forms.MainMenu mnuMain;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuNew;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem mnuExportSelected;
        private System.Windows.Forms.MenuItem mnuImport;
        private wyDay.Controls.SplitButton bAddApplication;
        private System.Windows.Forms.ContextMenu cmuAdd;
        private System.Windows.Forms.MenuItem cmnuAdd;
        private System.Windows.Forms.MenuItem cmnuImportFile;
        private System.Windows.Forms.MenuItem cmnuImportOnline;
        private System.Windows.Forms.MenuItem mnusep2;
        private System.Windows.Forms.MenuItem mnuSettings;
        private CDBurnerXP.Controls.OLVColumn colCustomValue;
        private System.Windows.Forms.MenuItem cmnuCopy;
        private System.Windows.Forms.MenuItem cmnuPaste;
        private System.Windows.Forms.MenuItem mnuSelectAll;
        private System.Windows.Forms.MenuItem cmnuOpenFolder;
        private System.Windows.Forms.MenuItem mnuView;
        private wyDay.Controls.SplitButton bRun;
        private System.Windows.Forms.ContextMenu cmuRun;
        private System.Windows.Forms.MenuItem cmnuCheckAndDownload;
        private System.Windows.Forms.MenuItem cmnuOnlyCheck;
        private System.Windows.Forms.MenuItem mnuTutorial;
        private System.Windows.Forms.NotifyIcon ntiTrayIcon;
        private System.Windows.Forms.ContextMenu cmnuTrayIconMenu;
        private System.Windows.Forms.MenuItem cmnuShow;
        private System.Windows.Forms.MenuItem cmnuExit;
        private System.Windows.Forms.MenuItem mnuExportAll;
        private System.Windows.Forms.MenuItem cmnuCheckForUpdate;
        private System.Windows.Forms.MenuItem mnuLog;
        private System.Windows.Forms.MenuItem mnuShowGroups;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel tbSelectedApplications;
        private System.Windows.Forms.ToolStripStatusLabel tbTotalApplications;
        private System.Windows.Forms.MenuItem mnuShowStatusBar;
        private System.Windows.Forms.MenuItem mnuInvert;
        private CDBurnerXP.Controls.OLVColumn colCustomValue2;
        private System.Windows.Forms.MenuItem cmnuForceDownload;
        private System.Windows.Forms.MenuItem cmnuSepUpdates;
        private System.Windows.Forms.MenuItem mnuFind;
        private System.Windows.Forms.MenuItem mnuAutoScroll;
    }
}

