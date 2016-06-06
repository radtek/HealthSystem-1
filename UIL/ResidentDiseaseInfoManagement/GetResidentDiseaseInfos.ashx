<%@ WebHandler Language="C#" Class="GetResidentDiseaseInfos" %>

using System;
using System.Web;

public class GetResidentDiseaseInfos : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
      context.Response.ContentType = "text/plain";
        TableData td = new ResidentBasicManagementDATAJSON().dataToJson();

        string temp = "{\"total\":\""+ td.count.ToString()+"\",\"rows\":"+td.data+"}";
        context.Response.Write(temp);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}