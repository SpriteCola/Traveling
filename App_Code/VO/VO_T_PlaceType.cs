using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///旅游景点类别表
/// </summary>
public class VO_T_PlaceType
{
	public VO_T_PlaceType()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Id { get; set; }

    public string Name { get; set; }//景点类别：人文景观、自然风光..
}