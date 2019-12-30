using System;
namespace Models
{
	/// <summary>
	/// app信息
	/// </summary>
	[Serializable]
	public partial class tbl_appInfo
	{
		public tbl_appInfo()
		{ }
		#region Model
		private int _id;
		private string _name;
		private string _appid;
		private string _appsecret;
		private string _grant_type;
		private int? _status;
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
		public string name
		{
			set { _name = value; }
			get { return _name; }
		}
		/// <summary>
		/// appId
		/// </summary>
		public string appid
		{
			set { _appid = value; }
			get { return _appid; }
		}
		/// <summary>
		/// appSecret
		/// </summary>
		public string appSecret
		{
			set { _appsecret = value; }
			get { return _appsecret; }
		}
		/// <summary>
		/// 授权类型
		/// </summary>
		public string grant_type
		{
			set { _grant_type = value; }
			get { return _grant_type; }
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

