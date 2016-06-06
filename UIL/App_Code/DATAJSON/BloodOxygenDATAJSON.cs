using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
using Newtonsoft.Json;
/// <summary>
/// BloodOxygenDATAJSON 的摘要说明
/// </summary>
public class BloodOxygenDATAJSON:IDATAJSON
{
    public BloodOxygenDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public TableData dataToJson()
    {
        var blist = BloodOxygenBLL.GetAllList();
        TableData td = new TableData();
        td.count = blist.Count;
      td.data=JsonConvert.SerializeObject(blist);
        return td;
    }

    public string dataToJson(string username)
    {
      List<BloodOxygen> blist=BloodOxygenBLL.GetDatasByName(username);
        DATA data1 = new DATA();
        DATA data2 = new DATA();
        DATAT datat = new DATAT();
        datat.yang = data1;
        datat.xue = data2;

        blist.ForEach((a) => 
        {
            data1.srange.Add((int)a.T3001005_srange);
            data1.lrange.Add((int)a.T3001005_lrange);
            data1.bloodoxygenvalue.Add((int)a.T3001005_value);
            data2.srange.Add((int)a.T3001009_srange);
            data2.lrange.Add((int)a.T3001009_lrange);
            data2.bloodoxygenvalue.Add((int)a.T3001009_value);
        });

        return JsonConvert.SerializeObject(datat);
    }


    private class DATA
    {
       private List<int> x_srange = new List<int>();
        private List<int> x_bloodoxygenvalue = new List<int>();
        private List<int> x_lrange = new List<int>();
        public List<int> srange { get { return x_srange; } set { x_srange = value; } }
        public List<int> bloodoxygenvalue { get { return x_bloodoxygenvalue; } set { x_bloodoxygenvalue = value; } }
        public List<int> lrange { get { return x_lrange; } set { x_lrange = value; } }

    }

    private class DATAT
    {
        public DATA yang { get; set; }
        public DATA xue { get; set; }
    }
}