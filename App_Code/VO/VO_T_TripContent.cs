using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///旅程内容表
/// </summary>
public class VO_T_TripContent
{
	public VO_T_TripContent()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Tcontent_id { get; set; }//

    public int Step_id { get; set; }//旅程步骤序号

    public int Dtrip_id { get; set; }//每一步具体内容信息

    public decimal Totalcost { get; set; }//总预算
}