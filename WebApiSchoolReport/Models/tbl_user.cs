using System;
namespace Models
{
	/// <summary>
	/// 用户
	/// </summary>
	[Serializable]
	public partial class tbl_user
	{
		public tbl_user()
		{ }
		#region Model
		private int _id;
		private string _token;
		private string _avatarurl;
		private string _city;
		private string _province;
		private string _country;
		private int? _gender;
		private string _language;
		private string _nickname;
		private int? _usertype;
		private int? _status;
		private DateTime? _addtime;
		private DateTime? _uptime;
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
		/// 
		/// </summary>
		public string token
		{
			set { _token = value; }
			get { return _token; }
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string avatarUrl
		{
			set { _avatarurl = value; }
			get { return _avatarurl; }
		}
		/// <summary>
		/// 城市
		/// </summary>
		public string city
		{
			set { _city = value; }
			get { return _city; }
		}
		/// <summary>
		/// 省份
		/// </summary>
		public string province
		{
			set { _province = value; }
			get { return _province; }
		}
		/// <summary>
		/// 国家
		/// </summary>
		public string country
		{
			set { _country = value; }
			get { return _country; }
		}
		/// <summary>
		/// 用户性别0：未知;1:男性;2:女性
		/// </summary>
		public int? gender
		{
			set { _gender = value; }
			get { return _gender; }
		}
		/// <summary>
		/// 语言
		/// </summary>
		public string language
		{
			set { _language = value; }
			get { return _language; }
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string nickName
		{
			set { _nickname = value; }
			get { return _nickname; }
		}
		/// <summary>
		/// 用户类型 1:学生，2：老师，0：未知
		/// </summary>
		public int? usertype
		{
			set { _usertype = value; }
			get { return _usertype; }
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int? status
		{
			set { _status = value; }
			get { return _status; }
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime? addtime
		{
			set { _addtime = value; }
			get { return _addtime; }
		}
		/// <summary>
		/// 上线时间
		/// </summary>
		public DateTime? uptime
		{
			set { _uptime = value; }
			get { return _uptime; }
		}
		#endregion Model

	}
}

