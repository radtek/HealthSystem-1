<%@ WebHandler Language="C#" Class="GetFamilys" %>

using System;
using System.Web;

public class GetFamilys : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        TableData td = new FamilyManagementPageDATAJSON().dataToJson();

        string temp = "{\"total\":\""+ td.count.ToString()+"\",\"rows\":"+td.data+"}";
        context.Response.Write(temp);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}