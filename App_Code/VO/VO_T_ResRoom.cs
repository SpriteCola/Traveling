using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///饭店房间信息表
/// </summary>
public class VO_T_ResRoom
{
    public VO_T_ResRoom()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public int Id { get; set; }//

    public string Room_type { get; set; }//房间类型

    public int Number { get; set; }//该类型房间数目

    public int Capacity { get; set; }//该类型房间可容纳人数

    public string Feature { get; set; }//房间特点

    public decimal Price { get; set; }//价格
}