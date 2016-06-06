using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
/// <summary>
/// ResidentBasicManagementDATAJSON 的摘要说明
/// </summary>
public class ResidentBasicManagementDATAJSON:IDATAJSON
{
    public ResidentBasicManagementDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public TableData dataToJson()
    {
        Resident[] rd = ResidentBLL.GetAllList().ToArray();
        TableData td = new TableData();
        td.data = JsonConvert.SerializeObject(rd);
        td.count = rd.Length;
        return td;
    }
}