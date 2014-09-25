using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///具体旅程步骤内容表
/// </summary>
public class VO_T_DetailTrip
{
	public VO_T_DetailTrip()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Dtrip_id { get; set; }//旅程号＋该步骤的序号

    public DateTime time { get; set; }//时间

    public string Location { get; set; }//地点

    public string Staff { get; set; }//人员

    public string Content { get; set; }//行程内容

    public int Resource_id { get; set; }//用到的资源号(资源类别id＋该类别资源表id)

    public decimal Cost { get; set; }//该步骤预算
}