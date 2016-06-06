using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.Model;
/// <summary>
/// BasicExamDATAJSON 的摘要说明
/// </summary>
public class BasicExamDATAJSON:IDATAJSON
{
    public BasicExamDATAJSON()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public TableData dataToJson()
    {
        BasicExamination[] be = BasicExaminationBLL.GetAllList().ToArray();
        TableData td = new TableData();
        td.data = JsonConvert.SerializeObject(be);
        td.count = be.Length;
        return td;
    }

    public string dataToJson(string username)
    {
        BasicExamination[] be = BasicExaminationBLL.GetDataByTheName(username).ToArray();
        Data da = new Data();
        for (int i = 0; i < be.Length; i++)
        {
            da.heart.Add(Convert.ToDouble((be[i].BPM)));
            da.blood.Add(Convert.ToDouble(be[i].BP));
            da.respiration.Add(Convert.ToDouble(be[i].RR));
            da.temperature.Add(Convert.ToDouble(be[i].Temperature));
            da.height.Add(Convert.ToDouble(be[i].Height));
            da.weight.Add(Convert.ToDouble(be[i].Weight));
            if (i == (be.Length - 1))
            {
                da.bmi = Convert.ToDouble(be[i].BMI);
            }
        }
        string s = JsonConvert.SerializeObject(da);
        return s;
    }

    public class Data
    {
        public Data()
        {
            heart = new List<double>();
            blood = new List<double>();
            respiration = new List<double>();
            temperature = new List<double>();
            height = new List<double>();
            weight = new List<double>();
        }
        public List<double> heart { get; set; }
        public List<double> blood { get; set; }
        public List<double> respiration { get; set; }
        public List<double> temperature { get; set; }
        public List<double> height { get; set; }
        public List<double> weight { get; set; }
        public double bmi { get; set; }
    }
}