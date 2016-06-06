using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
using Newtonsoft.Json;
/// <summary>
/// FamilyManagementPageDATAJSON 的摘要说明
/// </summary>
public class FamilyManagementPageDATAJSON:IDATAJSON
{
    public FamilyManagementPageDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public TableData dataToJson()
    {
        TableData td = new TableData();
        List<Family> flist = FamilyBLL.GetAllList();
        td.count = flist.Count;
        List<Familyx> fx = new List<Familyx>();
        flist.ForEach((a) => { fx.Add(new Familyx() {  CreateDate=a.CreateDate, FamilyType=a.FamilyType, HousingTypes=a.HousingTypes, Id=a.Id, ManageInstitutions=a.ManageInstitutions.ToString(), Name=a.Name, Old=a.Old, Owner=a.Owner, Remark=a.Remark, ResponsibleDoctor=a.ResponsibleDoctor,Total=a.Total}); });
        td.data=JsonConvert.SerializeObject(fx);
        return td;
    }

    private class Familyx:Family
    {
        public new string ManageInstitutions { get; set; }

    }
}