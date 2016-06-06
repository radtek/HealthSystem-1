using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zhbit.HealthSystem.Model;
using Newtonsoft.Json;
using Zhbit.HealthSystem.BLL;
/// <summary>
/// DoctorManagementDATAJSON 的摘要说明
/// </summary>
public class DoctorDATAJSON : IDATAJSON
{
    public TableData dataToJson()
    {
        int num = 0;
        List<Doctorx> dox = new List<Doctorx>();
        TableData td = new TableData();   
        DoctorBLL.GetAllList().ForEach(a => { dox.Add(new Doctorx() { Id = a.Id, DoctorId = a.DoctorId, Name = a.Name, ExamNo = a.ExamNo, Pwd = a.Pwd, Institution = a.Institution.ToString(), Remarks = a.Remarks });++num; });
       td.data=JsonConvert.SerializeObject(dox);
        td.count = num;
        return td;
        
    }
   private class Doctorx:Doctor
    {
       
        /// <summary>[属性]所在机构</summary>
        public new string Institution
        {
            get;
            set;
        }
      
    }
}