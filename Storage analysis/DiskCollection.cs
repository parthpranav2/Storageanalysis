using System;
using System.Collections;
using System.Management;

namespace DiskInfo
{
	/// <summary>
	/// 
	/// </summary>
	public class DiskCollection : CollectionBase, IEnumerable, IEnumerator
	{
		/// <summary>
		/// Summary description for LogicalDriveInfo.
		/// </summary>
		/// 
		private System.Collections.ArrayList disks;
		public class LogicalDriveInfo
		{
			public char Name;
			public long Volumeserialnumber;
			public long Size;
			public bool Shared;
			public string Description;
			
			internal LogicalDriveInfo(ManagementObject mo, bool shared)
			{
				try
				{

					string txt = mo["Name"].ToString();
					if(txt.Length > 0)
						Name = txt[0];

					txt = mo["Volumeserialnumber"].ToString();
					if(txt.Length > 0)
						Volumeserialnumber = long.Parse(txt,System.Globalization.NumberStyles.HexNumber);

					txt = mo["Size"].ToString();
					if(txt.Length > 0)
						Size = long.Parse(txt);

					Description = mo["Description"].ToString();
				}
				catch
				{
				}
				finally
				{
					Shared = shared;
				}			
			}
		}
		public DiskCollection()
		{
		}
		public LogicalDriveInfo this[int i]
		{
			get
			{
				if(i >= disks.Count || i < 0)
					return null;
				else
					return (LogicalDriveInfo)disks[i];
			}
		}
		public LogicalDriveInfo this[char drive]
		{
			get
			{
				if(char.IsLetter(drive))
					foreach(LogicalDriveInfo drinfo in disks)
						if(char.ToLower(drinfo.Name) == char.ToLower(drive))
							return drinfo;
				return null;
			}
		}
		public bool Load()
		{
			if(disks == null)
				disks = new ArrayList(10);
			disks.Clear();
			Reset();
			try
			{

				using(ManagementObjectSearcher DiskSearch = 
						  new ManagementObjectSearcher(new SelectQuery("Select * from Win32_LogicalDisk")))
				{

					using(ManagementObjectCollection moDiskCollection = DiskSearch.Get())
					{

						foreach(ManagementObject mo in  moDiskCollection)
						{
							LogicalDriveInfo dskinfo = new LogicalDriveInfo(mo ,false);
							if(this[dskinfo.Name] == null)
								disks.Add(dskinfo);//new mapping
							mo.Dispose();
						}
					}
				}

				using(ManagementObjectSearcher ShareDiskSearch = 
						  new ManagementObjectSearcher(new SelectQuery("Select * from Win32_MappedLogicalDisk")))
				{
					using(ManagementObjectCollection moSharedDiskCollection = ShareDiskSearch.Get())
					{
						foreach(ManagementObject mo in  moSharedDiskCollection)
						{
							LogicalDriveInfo dskinfo = new LogicalDriveInfo(mo ,true);
							if(this[dskinfo.Name] == null)
							{
								disks.Add(dskinfo);
							}
							else
								this[dskinfo.Name].Shared = true;
							mo.Dispose();
						}
					}
				}
			}
			catch
			{
				return false;
			}
			return true;
		}
		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return this as IEnumerator;
		}

		#endregion

		#region IEnumerator Members

		private int enumindex = -1;
		public void Reset()
		{
			enumindex = -1;
		}

		public object Current
		{
			get
			{
				if(disks.Count > enumindex && enumindex >= 0)
					return disks[enumindex];
				else
					throw new System.InvalidOperationException();
			}
		}

		public bool MoveNext()
		{
			if(++enumindex >= disks.Count)
				return false;
			else
				return true;
		}

		#endregion
	}
}
