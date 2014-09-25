using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///旅程表
/// </summary>
public class VO_T_Trip
{
	public VO_T_Trip()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Trip_id { get; set; }//旅程编号

    public string Name { get; set; }//客户姓名或单位

    public int Number { get; set; }//总人数

    public string Feature { get; set; }//行程特色

    public int Content_id { get; set; }//旅程内容表

    public DateTime Departure_id { get; set; }//出发时间

    public DateTime Return_id { get; set; }//返回时间
}