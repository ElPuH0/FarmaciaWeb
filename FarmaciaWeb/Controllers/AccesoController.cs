using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FarmaciaWeb.Models;
using FarmaciaWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using FarmaciaWeb.Filters;

namespace FarmaciaWeb.Controllers
{
    public class AccesoController : Controller
    {
        private readonly ILogger<AccesoController> _logger;
        private readonly ApplicationDbContext _context;
        private int count;
        private int dni_capturado;

        public AccesoController(ILogger<AccesoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult IniciarSesion()
        {
            //if(AppHttpContext.Current.Session.GetInt32("Count")!=null){
            //    count=(int)AppHttpContext.Current.Session.GetInt32("Count");
            //    Console.WriteLine("!=null!!!!");
            //}else{
            //    Console.WriteLine("=null!!!!");
            //}
//Modo 1 de enío
            //HttpContext.Session.SetString("bool_logueado", "true");
//Modo 2 de enío
//            count++;
//            AppHttpContext.Current.Session.SetInt32("Count", count);
            var Logueado=/*(Persona)*/AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                return View();
            }else{
                return RedirectToAction("Index", "Home");
            }
        }

//3.0        [ServiceFilter(typeof(VerifySession))]
        public ActionResult IniciarSesionQuery(int dni, string contrasena){
            try{
                //if();
                //using(ApplicationDbContext db=new ApplicationDbContext())
                {
                    //Método 1
                    var lst1=from d in _context.Personas
                            where d.Id==dni && d.Contrasena==contrasena
                            select d;
                    //Método 2
                    var lst2=_context.Personas.ToList().Find(p=>p.Id==dni && p.Contrasena==contrasena);
                    
                    if(lst1.Count()>0){
                        //ViewBag.se["User"]=lst.First();
//                        ViewBag.se["Persona"]=lst.First();
                        Persona persona1=lst1.First();
                        ViewBag.se5="a e a x";
                        //Session["Persona"]=persona1;
                        AppHttpContext.Current.Session.SetString("Logueado", "Sí");
                        TempData["se6"]=AppHttpContext.Current.Session.GetString("bool_logueado1");
                        dni_capturado=persona1.Id;
                        metodo();
                        Console.WriteLine("Cliente1: "+persona1.Nombre+" "+persona1.ApellidoPat+" "+persona1.ApellidoMat);
                        return Content("1");
                    }else if(lst2!=null){
                        //ViewBag.se["User"]=lst.First();
//                        ViewBag.se["Persona"]=lst.First();
                        Persona persona2=lst2;
                        ViewBag.se5="a e a x";
                        //Session["Persona"]=persona2;
                        AppHttpContext.Current.Session.SetString("Logueado", "Sí");
                        TempData["se6"]=AppHttpContext.Current.Session.GetString("bool_logueado");
                        dni_capturado=persona2.Id;
                        metodo();
                        Console.WriteLine("Cliente2: "+persona2.Nombre+" "+persona2.ApellidoPat+" "+persona2.ApellidoMat);
                        return Content("1");
                    }else{
                        Console.WriteLine("todo2: "+_context.Personas);
                        return Content("Usuario incorrecto :(");
                    }
                }
            }catch(Exception e){
                return Content("Ocurrió un error: "+e.Message);
                throw;
            }
        }

        public IActionResult CrearCuenta(){
            var Logueado=/*(Persona)*/AppHttpContext.Current.Session.GetString("Logueado");
            if(Logueado==null){
                return View();
            }else{
                return RedirectToAction("Index", "Home");
            }
        }
        
        //public ActionResult CerrarSesion(){
        //    try{
        //        AppHttpContext.Current.Session.SetString("Logueado", null);
        //        AppHttpContext.Current.Session.Remove("Logueado");
        //        return Redirect(Url.Content("/Acceso/Index"));
        //    }catch(Exception e){
        //        throw e;
        //    }
        //}

        private void metodo(){
            Persona modeloPersona=_context.Personas.Where(p=>p.Id==dni_capturado).First(p=>p.Id==dni_capturado);
            PersonaBase.Id=modeloPersona.Id;
            PersonaBase.Contrasena=modeloPersona.Contrasena;
            PersonaBase.Nombre=modeloPersona.Nombre;
            PersonaBase.ApellidoPat=modeloPersona.ApellidoPat;
            PersonaBase.ApellidoMat=modeloPersona.ApellidoMat;
            PersonaBase.Genero=modeloPersona.Genero;
            PersonaBase.Foto=modeloPersona.Foto;
            PersonaBase.Rol=modeloPersona.Rol;
            Console.WriteLine("el dni es: "+dni_capturado+" | Nombre: "+PersonaBase.Nombre);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
