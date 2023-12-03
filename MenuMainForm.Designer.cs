namespace Clipper
{
	partial class MenuMainForm
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMainForm));
			this.miStatus = new System.Windows.Forms.StatusStrip();
			this.miNotify = new System.Windows.Forms.NotifyIcon(this.components);
			this.miNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miNotifyMenuSeparator01 = new System.Windows.Forms.ToolStripSeparator();
			this.miNotifyMenuClose = new System.Windows.Forms.ToolStripMenuItem();
			this.tmTimer = new System.Windows.Forms.Timer(this.components);
			this.pcMain = new System.Windows.Forms.TabControl();
			this.tsList = new System.Windows.Forms.TabPage();
			this.lbList = new System.Windows.Forms.ListBox();
			this.tsConfig = new System.Windows.Forms.TabPage();
			this.pnConfig = new System.Windows.Forms.Panel();
			this.pnMax = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.miAction = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miMenu = new System.Windows.Forms.MenuStrip();
			this.miCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miNotifyMenu.SuspendLayout();
			this.pcMain.SuspendLayout();
			this.tsList.SuspendLayout();
			this.tsConfig.SuspendLayout();
			this.pnConfig.SuspendLayout();
			this.pnMax.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.miMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// miStatus
			// 
			this.miStatus.Location = new System.Drawing.Point(0, 239);
			this.miStatus.Name = "miStatus";
			this.miStatus.Size = new System.Drawing.Size(224, 22);
			this.miStatus.TabIndex = 0;
			this.miStatus.Text = "miStatus";
			// 
			// miNotify
			// 
			this.miNotify.ContextMenuStrip = this.miNotifyMenu;
			this.miNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("miNotify.Icon")));
			this.miNotify.Text = "miNotify";
			this.miNotify.Visible = true;
			this.miNotify.DoubleClick += new System.EventHandler(this.miNotify_DoubleClick);
			// 
			// miNotifyMenu
			// 
			this.miNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNotifyMenuSeparator01,
            this.miNotifyMenuClose});
			this.miNotifyMenu.Name = "miNotifyMenu";
			this.miNotifyMenu.Size = new System.Drawing.Size(118, 32);
			// 
			// miNotifyMenuSeparator01
			// 
			this.miNotifyMenuSeparator01.Name = "miNotifyMenuSeparator01";
			this.miNotifyMenuSeparator01.Size = new System.Drawing.Size(114, 6);
			// 
			// miNotifyMenuClose
			// 
			this.miNotifyMenuClose.Name = "miNotifyMenuClose";
			this.miNotifyMenuClose.Size = new System.Drawing.Size(117, 22);
			this.miNotifyMenuClose.Text = "miClose";
			this.miNotifyMenuClose.Click += new System.EventHandler(this.miNotifyMenuClose_Click);
			// 
			// tmTimer
			// 
			this.tmTimer.Enabled = true;
			this.tmTimer.Interval = 300;
			this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
			// 
			// pcMain
			// 
			this.pcMain.Controls.Add(this.tsList);
			this.pcMain.Controls.Add(this.tsConfig);
			this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcMain.Location = new System.Drawing.Point(0, 24);
			this.pcMain.Name = "pcMain";
			this.pcMain.SelectedIndex = 0;
			this.pcMain.Size = new System.Drawing.Size(224, 215);
			this.pcMain.TabIndex = 1;
			// 
			// tsList
			// 
			this.tsList.Controls.Add(this.lbList);
			this.tsList.Location = new System.Drawing.Point(4, 22);
			this.tsList.Name = "tsList";
			this.tsList.Padding = new System.Windows.Forms.Padding(3);
			this.tsList.Size = new System.Drawing.Size(216, 189);
			this.tsList.TabIndex = 0;
			this.tsList.Text = "tsList";
			this.tsList.UseVisualStyleBackColor = true;
			// 
			// lbList
			// 
			this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbList.FormattingEnabled = true;
			this.lbList.Location = new System.Drawing.Point(3, 3);
			this.lbList.Name = "lbList";
			this.lbList.ScrollAlwaysVisible = true;
			this.lbList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbList.Size = new System.Drawing.Size(210, 183);
			this.lbList.TabIndex = 0;
			// 
			// tsConfig
			// 
			this.tsConfig.Controls.Add(this.pnConfig);
			this.tsConfig.Location = new System.Drawing.Point(4, 22);
			this.tsConfig.Name = "tsConfig";
			this.tsConfig.Padding = new System.Windows.Forms.Padding(3);
			this.tsConfig.Size = new System.Drawing.Size(216, 189);
			this.tsConfig.TabIndex = 1;
			this.tsConfig.Text = "tsConfig";
			this.tsConfig.UseVisualStyleBackColor = true;
			// 
			// pnConfig
			// 
			this.pnConfig.AutoScroll = true;
			this.pnConfig.Controls.Add(this.pnMax);
			this.pnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnConfig.Location = new System.Drawing.Point(3, 3);
			this.pnConfig.Name = "pnConfig";
			this.pnConfig.Size = new System.Drawing.Size(210, 183);
			this.pnConfig.TabIndex = 0;
			// 
			// pnMax
			// 
			this.pnMax.Controls.Add(this.numericUpDown1);
			this.pnMax.Controls.Add(this.label1);
			this.pnMax.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnMax.Location = new System.Drawing.Point(0, 0);
			this.pnMax.Name = "pnMax";
			this.pnMax.Size = new System.Drawing.Size(210, 52);
			this.pnMax.TabIndex = 0;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown1.Location = new System.Drawing.Point(11, 24);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(194, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "lbMax";
			// 
			// miAction
			// 
			this.miAction.Name = "miAction";
			this.miAction.Size = new System.Drawing.Size(61, 4);
			// 
			// miMenu
			// 
			this.miMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAboutToolStripMenuItem,
            this.miCloseToolStripMenuItem});
			this.miMenu.Location = new System.Drawing.Point(0, 0);
			this.miMenu.Name = "miMenu";
			this.miMenu.Size = new System.Drawing.Size(224, 24);
			this.miMenu.TabIndex = 3;
			this.miMenu.Text = "menuStrip1";
			// 
			// miCloseToolStripMenuItem
			// 
			this.miCloseToolStripMenuItem.Name = "miCloseToolStripMenuItem";
			this.miCloseToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.miCloseToolStripMenuItem.Text = "miClose";
			this.miCloseToolStripMenuItem.Click += new System.EventHandler(this.miCloseToolStripMenuItem_Click);
			// 
			// miAboutToolStripMenuItem
			// 
			this.miAboutToolStripMenuItem.Name = "miAboutToolStripMenuItem";
			this.miAboutToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.miAboutToolStripMenuItem.Text = "miAbout";
			this.miAboutToolStripMenuItem.Click += new System.EventHandler(this.miAboutToolStripMenuItem_Click);
			// 
			// MenuMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 261);
			this.Controls.Add(this.pcMain);
			this.Controls.Add(this.miStatus);
			this.Controls.Add(this.miMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.miMenu;
			this.Name = "MenuMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clipper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuMainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuMainForm_FormClosed);
			this.Load += new System.EventHandler(this.MenuMainForm_Load);
			this.miNotifyMenu.ResumeLayout(false);
			this.pcMain.ResumeLayout(false);
			this.tsList.ResumeLayout(false);
			this.tsConfig.ResumeLayout(false);
			this.pnConfig.ResumeLayout(false);
			this.pnMax.ResumeLayout(false);
			this.pnMax.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.miMenu.ResumeLayout(false);
			this.miMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip miStatus;
		private System.Windows.Forms.NotifyIcon miNotify;
		private System.Windows.Forms.ContextMenuStrip miNotifyMenu;
		private System.Windows.Forms.ToolStripSeparator miNotifyMenuSeparator01;
		private System.Windows.Forms.ToolStripMenuItem miNotifyMenuClose;
		private System.Windows.Forms.Timer tmTimer;
		private System.Windows.Forms.TabControl pcMain;
		private System.Windows.Forms.TabPage tsList;
		private System.Windows.Forms.TabPage tsConfig;
		private System.Windows.Forms.ListBox lbList;
		private System.Windows.Forms.Panel pnConfig;
		private System.Windows.Forms.Panel pnMax;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip miAction;
		private System.Windows.Forms.MenuStrip miMenu;
		private System.Windows.Forms.ToolStripMenuItem miCloseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miAboutToolStripMenuItem;
	}
}

