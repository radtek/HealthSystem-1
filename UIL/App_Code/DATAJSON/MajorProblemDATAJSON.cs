using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
/// <summary>
/// MajorProblemDATAJSON 的摘要说明
/// </summary>
public class MajorProblemDATAJSON:IDATAJSON
{
    public MajorProblemDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public TableData dataToJson()
    {
        MajorProblems[] mp = MajorProblemsBLL.GetAllList().ToArray();
        TableData td = new TableData();
        td.data = JsonConvert.SerializeObject(mp);
        td.count = mp.Length;
        return td;
    }
}