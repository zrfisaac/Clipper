namespace Clipper
{
	partial class MenuAboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAboutForm));
			this.pcMain = new System.Windows.Forms.TabControl();
			this.tsAbout = new System.Windows.Forms.TabPage();
			this.tsAcknowledgment = new System.Windows.Forms.TabPage();
			this.rtbAcknowledgment = new System.Windows.Forms.RichTextBox();
			this.rtbAbout = new System.Windows.Forms.RichTextBox();
			this.pcMain.SuspendLayout();
			this.tsAbout.SuspendLayout();
			this.tsAcknowledgment.SuspendLayout();
			this.SuspendLayout();
			// 
			// pcMain
			// 
			this.pcMain.Controls.Add(this.tsAbout);
			this.pcMain.Controls.Add(this.tsAcknowledgment);
			this.pcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcMain.Location = new System.Drawing.Point(0, 0);
			this.pcMain.Name = "pcMain";
			this.pcMain.SelectedIndex = 0;
			this.pcMain.Size = new System.Drawing.Size(284, 261);
			this.pcMain.TabIndex = 0;
			// 
			// tsAbout
			// 
			this.tsAbout.Controls.Add(this.rtbAbout);
			this.tsAbout.Location = new System.Drawing.Point(4, 22);
			this.tsAbout.Name = "tsAbout";
			this.tsAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tsAbout.Size = new System.Drawing.Size(276, 235);
			this.tsAbout.TabIndex = 0;
			this.tsAbout.Text = "tsAbout";
			this.tsAbout.UseVisualStyleBackColor = true;
			// 
			// tsAcknowledgment
			// 
			this.tsAcknowledgment.Controls.Add(this.rtbAcknowledgment);
			this.tsAcknowledgment.Location = new System.Drawing.Point(4, 22);
			this.tsAcknowledgment.Name = "tsAcknowledgment";
			this.tsAcknowledgment.Padding = new System.Windows.Forms.Padding(3);
			this.tsAcknowledgment.Size = new System.Drawing.Size(276, 235);
			this.tsAcknowledgment.TabIndex = 1;
			this.tsAcknowledgment.Text = "tsAcknowledgment";
			this.tsAcknowledgment.UseVisualStyleBackColor = true;
			// 
			// rtbAcknowledgment
			// 
			this.rtbAcknowledgment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbAcknowledgment.Location = new System.Drawing.Point(3, 3);
			this.rtbAcknowledgment.Name = "rtbAcknowledgment";
			this.rtbAcknowledgment.ReadOnly = true;
			this.rtbAcknowledgment.Size = new System.Drawing.Size(270, 229);
			this.rtbAcknowledgment.TabIndex = 0;
			this.rtbAcknowledgment.Text = "Icon Usage\n\nThe Clipper logo is designed by [doublejdesign](https://twitter.com/d" +
    "oublejdesign). For more information, visit [https://twitter.com/doublejdesign](h" +
    "ttps://twitter.com/doublejdesign).";
			// 
			// rtbAbout
			// 
			this.rtbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbAbout.Location = new System.Drawing.Point(3, 3);
			this.rtbAbout.Name = "rtbAbout";
			this.rtbAbout.ReadOnly = true;
			this.rtbAbout.Size = new System.Drawing.Size(270, 229);
			this.rtbAbout.TabIndex = 1;
			this.rtbAbout.Text = resources.GetString("rtbAbout.Text");
			// 
			// MenuAboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.pcMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MenuAboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MenuAboutForm";
			this.pcMain.ResumeLayout(false);
			this.tsAbout.ResumeLayout(false);
			this.tsAcknowledgment.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl pcMain;
		private System.Windows.Forms.TabPage tsAbout;
		private System.Windows.Forms.TabPage tsAcknowledgment;
		private System.Windows.Forms.RichTextBox rtbAbout;
		private System.Windows.Forms.RichTextBox rtbAcknowledgment;
	}
}