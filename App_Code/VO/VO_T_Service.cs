using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///服务项目表
/// </summary>
public class VO_T_Service
{
	public VO_T_Service()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Service_id { get; set; }

    public VO_T_TourType Ttype_id { get; set; }//资源类别

    public string Sname { get; set; }//服务名称

    public string Name { get; set; }//服务人员姓名

    public string Location { get; set; }//地理信息

    public string Traffic { get; set; }//交通信息

    public string Feature { get; set; }//服务人员特长

    public string Contact { get; set; }//联系人信息

    public DateTime Time { get; set; }//插入或修改时间

    public string Operator { get; set; }//操作员
}