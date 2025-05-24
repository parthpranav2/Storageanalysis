using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DiskInfo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ViewDisks : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView DiskList;
		private System.Windows.Forms.ColumnHeader DriveLetter;
		private System.Windows.Forms.ColumnHeader SerialNumber;
		private System.Windows.Forms.ColumnHeader Size;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnRefresh;

		private DiskCollection DiskColl = null;
		private System.Windows.Forms.ColumnHeader Description;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.ColumnHeader Mapped;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewDisks()
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
				if (components != null) 
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
			this.DiskList = new System.Windows.Forms.ListView();
			this.DriveLetter = new System.Windows.Forms.ColumnHeader();
			this.SerialNumber = new System.Windows.Forms.ColumnHeader();
			this.Size = new System.Windows.Forms.ColumnHeader();
			this.Mapped = new System.Windows.Forms.ColumnHeader();
			this.Description = new System.Windows.Forms.ColumnHeader();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DiskList
			// 
			this.DiskList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.DriveLetter,
																					   this.SerialNumber,
																					   this.Size,
																					   this.Mapped,
																					   this.Description});
			this.DiskList.Location = new System.Drawing.Point(16, 16);
			this.DiskList.Name = "DiskList";
			this.DiskList.Size = new System.Drawing.Size(584, 224);
			this.DiskList.TabIndex = 0;
			this.DiskList.View = System.Windows.Forms.View.Details;
			// 
			// DriveLetter
			// 
			this.DriveLetter.Text = "Drive Letter";
			this.DriveLetter.Width = 71;
			// 
			// SerialNumber
			// 
			this.SerialNumber.Text = "Serial Number";
			this.SerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.SerialNumber.Width = 103;
			// 
			// Size
			// 
			this.Size.Text = "Size";
			this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Size.Width = 115;
			// 
			// Mapped
			// 
			this.Mapped.Text = "Mapped Disks";
			this.Mapped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Mapped.Width = 84;
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 206;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExit.Location = new System.Drawing.Point(224, 248);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(128, 40);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "&Exit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(48, 248);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(128, 40);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(424, 248);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(128, 40);
			this.btnAbout.TabIndex = 1;
			this.btnAbout.Text = "&About";
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// ViewDisks
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 294);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.DiskList);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnAbout);
			this.MaximizeBox = false;
			this.Name = "ViewDisks";
			this.Text = "Logical Drives Information";
			this.Load += new System.EventHandler(this.ViewDisks_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ViewDisks());
		}

		private void ViewDisks_Load(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;


			try
			{
				if(DiskColl == null)
					DiskColl = new DiskCollection();
				if(!DiskColl.Load())
				{
					MessageBox.Show(this,"Unable to retrieve disk info!");
					return;
				}
				DiskList.Items.Clear();
				int i = 0;
				foreach(DiskCollection.LogicalDriveInfo diskinfo in DiskColl)
				{
						DiskList.Items.Add(diskinfo.Name.ToString(),i);
						DiskList.Items[i].SubItems.Add(diskinfo.Volumeserialnumber.ToString("x"));
						DiskList.Items[i].SubItems.Add(diskinfo.Size.ToString("d"));
						DiskList.Items[i].SubItems.Add(diskinfo.Shared.ToString());
						DiskList.Items[i].SubItems.Add(diskinfo.Description);
						i++;
				}
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			ViewDisks_Load(null,null);
		}

		private void btnAbout_Click(object sender, System.EventArgs e)
		{
			About aboutfrm = new About();
			aboutfrm.ShowDialog(this);
			aboutfrm.Dispose();

		}

	}
}
