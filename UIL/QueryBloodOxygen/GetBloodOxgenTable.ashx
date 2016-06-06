<%@ WebHandler Language="C#" Class="GetBloodOxgenTable" %>

using System;
using System.Web;

public class GetBloodOxgenTable : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        TableData td = new BloodOxygenDATAJSON().dataToJson();
         string temp = "{\"total\":\""+ td.count.ToString()+"\",\"rows\":"+td.data+"}";
        context.Response.Write(temp);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}