using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool SendPressure(string sxml);

        [OperationContract]
        bool SendBloodOxygen(string sxml);

        [OperationContract]
        bool SendTemperature(string sxml);

        [OperationContract]
        string ValidateId(string id, string password);

        [OperationContract]
        string SearchResident(string name);
        // TODO: 在此添加您的服务操作
    }


    
  
}
