using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
using Newtonsoft.Json;
/// <summary>
/// ResidentDiseaseInfoManagementDATAJSON 的摘要说明
/// </summary>
public class ResidentDiseaseInfoManagementDATAJSON:IDATAJSON
{
    public ResidentDiseaseInfoManagementDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public TableData dataToJson()
    {
        TableData td = new TableData();
        List<ResidentDiseaseInfo> rlist = ResidentDiseaseInfoBLL.GetAllList();
        td.count = rlist.Count;
        td.data = JsonConvert.SerializeObject(rlist);
        return td;
    }
}