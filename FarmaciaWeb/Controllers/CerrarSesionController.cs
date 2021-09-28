

using System;
using FarmaciaWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmaciaWeb.Controllers
{
    public class CerrarSesionController : Controller
    {
        
        public ActionResult CerrarSesion(){
            try{
                //AppHttpContext.Current.Session.SetString("Logueado", null);
//                AppHttpContext.Current.Session.Set("Logueado", null);
                AppHttpContext.Current.Session.Remove("Logueado");
                //return Redirect(Url.Content("/Acceso/Index"));
                ValidarUsuario();
                
                return RedirectToAction("IniciarSesion", "Acceso");
            }catch(Exception e){
                throw e;
            }
        }

        private void ValidarUsuario(){
            var Logueado=AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                PersonaBase.Id=0;
                PersonaBase.Contrasena=null;
                PersonaBase.Nombre=null;
                PersonaBase.ApellidoPat=null;
                PersonaBase.ApellidoMat=null;
                PersonaBase.Genero=null;
                PersonaBase.Foto=null;
                PersonaBase.Rol=null;
            }
        }
    }
}
