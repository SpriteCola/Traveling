using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///饭店信息表
/// </summary>
public class VO_T_Restaurant
{
	public VO_T_Restaurant()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Res_id { get; set; }

    public VO_T_TourType Ttype_id { get; set; }//资源类别Id
}