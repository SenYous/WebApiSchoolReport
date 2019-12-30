using System;
namespace Models
{
	/// <summary>
	/// 用户信息
	/// </summary>
	[Serializable]
	public partial class tbl_userInfo
	{
		public tbl_userInfo()
		{ }
		#region Model
		private int _id;
		private string _username;
		private string _schoolname;
		private int? _schoolid;
		private string _classname;
		private string _subject;
		private string _phone;
		private int? _isheadmaster;
		private DateTime? _addtime;
		private DateTime? _updatetime;
		/// <summary>
		/// 
		/// </summary>
		[DHelper.Attributes.SqlField(Ignore: false, Key: true, identity: true)]
		public int id
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string username
		{
			set { _username = value; }
			get { return _username; }
		}
		/// <summary>
		/// 学校名称
		/// </summary>
		public string schoolName
		{
			set { _schoolname = value; }
			get { return _schoolname; }
		}
		/// <summary>
		/// 学校Id
		/// </summary>
		public int? schoolId
		{
			set { _schoolid = value; }
			get { return _schoolid; }
		}
		/// <summary>
		/// 班级名称
		/// </summary>
		public string className
		{
			set { _classname = value; }
			get { return _classname; }
		}
		/// <summary>
		/// 学科
		/// </summary>
		public string subject
		{
			set { _subject = value; }
			get { return _subject; }
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string phone
		{
			set { _phone = value; }
			get { return _phone; }
		}
		/// <summary>
		/// 是否是班主任
		/// </summary>
		public int? isHeadmaster
		{
			set { _isheadmaster = value; }
			get { return _isheadmaster; }
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? addtime
		{
			set { _addtime = value; }
			get { return _addtime; }
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? updatetime
		{
			set { _updatetime = value; }
			get { return _updatetime; }
		}
		#endregion Model

	}
}

