using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///交通工具表
/// </summary>
public class VO_T_Vehicle
{
	public VO_T_Vehicle()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Vehicle_id { get; set; }

    public VO_T_TourType Ttype_id { get; set; }//资源类别
    
    public string Type { get; set; }//交通工具类别

    public string Owner { get; set; }//所有人

    public string License { get; set; }//牌号

    public string Category { get; set; }//车型或船型

    public string description { get; set; }//座位及价位信息

    public string Contact { get; set; }//联系人信息

    public DateTime Time { get; set; }//插入或修改时间

    public string Operator { get; set; }//操作员
}