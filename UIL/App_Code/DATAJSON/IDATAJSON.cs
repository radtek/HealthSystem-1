using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// IDATAJSON 的摘要说明
/// </summary>
public interface IDATAJSON
{

    TableData dataToJson();

    
}

public class TableData
{
    public TableData() { }
    public string data { get; set; }
    public int count { get; set; }
}