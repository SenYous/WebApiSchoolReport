using System;
namespace Models
{
	/// <summary>
	/// 地图表
	/// </summary>
	[Serializable]
	public partial class tbl_city
	{
		public tbl_city()
		{ }
		#region Model
		private int _id;
		private int? _pid;
		private string _district;
		private int? _districttype;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 父及地区关系
		/// </summary>
		public int? pid
		{
			set { _pid = value; }
			get { return _pid; }
		}
		/// <summary>
		/// 地区名称
		/// </summary>
		public string district
		{
			set { _district = value; }
			get { return _district; }
		}
		/// <summary>
		/// 子属级别关系
		/// </summary>
		public int? districtType
		{
			set { _districttype = value; }
			get { return _districttype; }
		}
		#endregion Model

	}
}

