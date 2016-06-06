<%@ WebHandler Language="C#" Class="GetBloodOxygenData" %>

using System;
using System.Web;

public class GetBloodOxygenData : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string temp = string.Empty;
        if( context.Request.QueryString["dataUser"]!=null)
        {
            string name = context.Request.QueryString["dataUser"];
           temp= new BloodOxygenDATAJSON().dataToJson(name);
        }
        context.Response.Write(temp);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}