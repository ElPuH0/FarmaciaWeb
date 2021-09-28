using Microsoft.AspNetCore.Mvc.Filters;
using FarmaciaWeb.Models;
using Microsoft.AspNetCore.Http;
using FarmaciaWeb.Controllers;

namespace FarmaciaWeb.Filters
{
    public class VerifySession: ActionFilterAttribute{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var Logueado=/*(Persona)*/AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                if(context.Controller is AccesoController==false){
                    //context.HttpContext.Response.Redirect("/Acceso/Index");
                    context.HttpContext.Response.Redirect("/Producto/List");
                }
            }else{
                if(context.Controller is AccesoController==true){
                    context.HttpContext.Response.Redirect("/Home/Asd");
                }
            }
            base.OnActionExecuting(context);
        }
    }
}