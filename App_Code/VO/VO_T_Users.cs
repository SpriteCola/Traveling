using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///用户信息表
/// </summary>
public class VO_T_Users
{
	public VO_T_Users()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Id { get; set; }//用户Id

    public string Account { get; set; }//账户名

    public string Pwd { get; set; }//账户密码

    public string Name { get; set; }//用户姓名

    public string Sex { get; set; }//用户性别

    public string User_type { get; set; }//用户类型

    public string Email { get; set; }//用户邮箱

    public string Tel { get; set; }//用户联系电话

    public int Number { get; set; }//总人数

    public string Location { get; set; }//居住地

    public DateTime Departure_time { get; set; }//出发时间

    public DateTime Return_time { get; set; }//返程时间

    public string Destination { get; set; }//目的地

    public string Favorite { get; set; }//偏爱旅游类型

    public decimal Cost { get; set; }//预算

    public int Level { get; set; }//用户等级
}