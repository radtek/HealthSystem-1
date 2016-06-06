<%@ WebHandler Language="C#" Class="GetAdvancedExam" %>

using System;
using System.Web;

public class GetAdvancedExam : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        TableData td = new AdvancedExamDATAJSON().dataToJson();
         string temp = "{\"total\":\""+ td.count.ToString()+"\",\"rows\":"+td.data+"}";
        context.Response.ContentType = "text/plain";

        context.Response.Write(temp);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}