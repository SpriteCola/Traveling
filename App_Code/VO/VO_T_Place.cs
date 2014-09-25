using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///旅游景点信息表
/// </summary>
public class VO_T_Place
{
	public VO_T_Place()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Place_id { get; set; }

    public VO_T_TourType Ttype_id { get; set; }//资源类型

    public VO_T_PlaceType Type_id { get; set; }//景点类别

    public string Name { get; set; }//景点名称

    public string Location { get; set; }//地理信息

    public string Feature { get; set; }//景点特色

    public string Description { get; set; }//景点介绍

    public decimal Price { get; set; }//门票价格

    public DateTime Time { get; set; }//插入或修改时间

    public string Operator { get; set; }//操作员
}