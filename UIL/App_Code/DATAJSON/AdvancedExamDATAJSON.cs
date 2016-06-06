using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
using Newtonsoft.Json;
/// <summary>
/// AdvancedExamDATAJSON 的摘要说明
/// </summary>
public class AdvancedExamDATAJSON:IDATAJSON
{
   
    public TableData dataToJson()
    {
        TableData td = new TableData();
        List<AdvancedExamination> ad = AdvancedExaminationBLL.GetAllList();
        td.data = JsonConvert.SerializeObject(ad);
        td.count = ad.Count;
        return td;       
    }
}