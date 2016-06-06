<%@ WebHandler Language="C#" Class="GetDoctors" %>

using System;
using System.Web;
using Zhbit.HealthSystem.BLL;
public class GetDoctors : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        TableData td = new DoctorDATAJSON().dataToJson();

        string temp = "{\"total\":\""+ td.count.ToString()+"\",\"rows\":"+td.data+"}";
        context.Response.Write(temp);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}