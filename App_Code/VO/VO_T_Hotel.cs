using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///宾馆信息表
/// </summary>
public class VO_T_Hotel
{
	public VO_T_Hotel()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Id { get; set; }//

    public VO_T_TourType Ttype_id { get; set; }//资源类别

    public string Name { get; set; }//宾馆名称

    public int Number { get; set; }//房间总数

    public string Location { get; set; }//地理信息

    public string Traffic { get; set; }//交通信息

    public string Manager { get; set; }//负责人

    public int Level { get; set; }//星级

    public int Capacity { get; set; }//总容量

    public VO_T_HotelRoom Roominfo { get; set; }//房间信息

    public string Contact { get; set; }//联系人信息

    public DateTime Time { get; set; }//插入或修改时间

    public string Operator { get; set; }//操作员
}