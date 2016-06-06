<%@ WebHandler Language="C#" Class="UpdateManager" %>

using System;
using System.Web;
using Zhbit.HealthSystem.BLL;
using Zhbit.HealthSystem.DAL;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.SFL;
public class UpdateManager : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        Manager mg = new Manager();
    if (context.Request.Form["id"] != null)
    {  mg.Id = int.Parse(context.Request.Form["id"]); }
    if (context.Request.Form["username"] != null)
    {  mg.Name = context.Request.Form["username"];    }
    if(context.Request.Form["role"]!=null)
    { mg.Role = context.Request.Form["role"]; }
    if(context.Request.Form["loginname"]!=null)
    { mg.LoginName = context.Request.Form["loginname"]; }
    if(context.Request.Form["newpassword"]!=null)
    { mg.Password = context.Request.Form["newpassword"]; }
    int re = 0;
    if(mg.Id!=null)
    {
      re= ManagerBLL.Update(mg);
    }
        context.Response.ContentType = "text/plain";
        context.Response.Write(re.ToString());
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}