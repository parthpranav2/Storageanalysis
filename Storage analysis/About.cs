using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DiskInfo
{
	/// <summary>
	/// Summary description for About.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel linkLabelAbout;
		private System.Windows.Forms.Label labelProduct;
		private System.Windows.Forms.Label lblRestrictions;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public About()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.linkLabelAbout = new System.Windows.Forms.LinkLabel();
			this.labelProduct = new System.Windows.Forms.Label();
			this.lblRestrictions = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// linkLabelAbout
			// 
			this.linkLabelAbout.LinkArea = new System.Windows.Forms.LinkArea(16, 18);
			this.linkLabelAbout.Location = new System.Drawing.Point(18, 205);
			this.linkLabelAbout.Name = "linkLabelAbout";
			this.linkLabelAbout.Size = new System.Drawing.Size(256, 24);
			this.linkLabelAbout.TabIndex = 0;
			this.linkLabelAbout.TabStop = true;
			this.linkLabelAbout.Text = "Copyright 2005  Decebal Mihailescu";
			this.linkLabelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabelAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAbout_LinkClicked);
			// 
			// labelProduct
			// 
			this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelProduct.Location = new System.Drawing.Point(18, 37);
			this.labelProduct.Name = "labelProduct";
			this.labelProduct.Size = new System.Drawing.Size(256, 24);
			this.labelProduct.TabIndex = 1;
			this.labelProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblRestrictions
			// 
			this.lblRestrictions.Location = new System.Drawing.Point(18, 121);
			this.lblRestrictions.Name = "lblRestrictions";
			this.lblRestrictions.Size = new System.Drawing.Size(256, 24);
			this.lblRestrictions.TabIndex = 2;
			this.lblRestrictions.Text = "This application is free to use as you wish as a binary file.";
			this.lblRestrictions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// About
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.lblRestrictions);
			this.Controls.Add(this.labelProduct);
			this.Controls.Add(this.linkLabelAbout);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.Text = "About";
			this.Load += new System.EventHandler(this.About_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void linkLabelAbout_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.linkLabelAbout.Links[linkLabelAbout.Links.IndexOf(e.Link)].Visited = true;
			string target = e.Link.LinkData as string;
			System.Diagnostics.Process.Start(target);
		}

		private void About_Load(object sender, System.EventArgs e)
		{
			this.linkLabelAbout.Links[0].LinkData = @"www.codeproject.com/script/Articles/list_articles.asp?userid=634640";
			labelProduct.Text = this.Owner.Text;
		
		}
	}
}
