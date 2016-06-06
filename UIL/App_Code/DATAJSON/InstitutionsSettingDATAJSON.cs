using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
/// <summary>
/// InstitutionsSetting 的摘要说明
/// </summary>
public class InstitutionsSettingDATAJSON:IDATAJSON
{
    public InstitutionsSettingDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public TableData dataToJson()
    {
        Institutions[] it = InstitutionsBLL.GetAllList().ToArray();
        TableData td = new TableData();
        td.data = JsonConvert.SerializeObject(it);
        td.count = it.Length;
        return td;
    }
}