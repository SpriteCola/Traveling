using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///娱乐设施信息表
/// </summary>
public class VO_T_Entertainment
{
	public VO_T_Entertainment()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Enter_id { get; set; }

    public VO_T_TourType Ttype_id { get; set; }//资源类型

    public string type { get; set; }//该娱乐场所类别

    public string Name { get; set; }//名称

    public string Location { get; set; }//地理信息

    public string Traffic { get; set; }//交通信息

    public string Description { get; set; }//场所信息介绍

    public string Contact { get; set; }//联系人信息

    public DateTime Time { get; set; }//插入或修改时间

    public string Operator { get; set; }//操作员
}