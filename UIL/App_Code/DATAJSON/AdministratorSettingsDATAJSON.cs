using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
/// <summary>
/// AdministratorSettingsDATAJSON 的摘要说明
/// </summary>
public class AdministratorSettingsDATAJSON:IDATAJSON
{
    public AdministratorSettingsDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public TableData dataToJson()
    {   
        Manager[] m = ManagerBLL.GetAllList().ToArray();
        TableData td = new TableData();
        td.data = JsonConvert.SerializeObject(m);
        td.count = m.Length;
        return td;
    }

}