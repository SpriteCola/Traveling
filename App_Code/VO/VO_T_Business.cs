using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///商务活动场所信息表
/// </summary>
public class VO_T_Business
{
	public VO_T_Business()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Business_id { get; set; }

    public VO_T_TourType Ttype_id { get; set; }//资源类别

    public string Name { get; set; }//场馆名称

    public string Location { get; set; }//地理信息

    public string Traffic { get; set; }//交通信息

    public int Capacity { get; set; }//总容量

    public string Contact { get; set; }//联系人信息

    public DateTime Time { get; set; }//插入或修改时间

    public string Operator { get; set; }//操作员
}