using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FarmaciaWeb.Models;
using FarmaciaWeb.Data;
using FarmaciaWeb.Utils;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaWeb.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly ApplicationDbContext _context;
        //private List<Producto> ListaProductos;
        //private Paginador<Producto> _Paginador;
        //private readonly int _RegistrosPorPagina = 10;
        private int r_dni;
//        private PersonaBase _personaBase;

        public PersonaController(ILogger<PersonaController> logger, ApplicationDbContext context/*, PersonaBase personaBase*/)
        {
            _logger = logger;
            _context = context;
//            _personaBase = personaBase;
            //var productos=_context.Productos.Include(p=>p.TipoProducto).Include(p=>p.Marca).ToList();
//            ListaProductos = _context.Productos.Include(p=>p.Categoria).AsNoTracking().ToList();
        }

        public IActionResult Index()
        {
            //var listProductos=_context.Productos.OrderBy(s=>s.Id).ToList();
            //return View("List", listProductos);
            return View();
        }

        public IActionResult AdministradorV1(){
            return View();
        }

        public IActionResult ClienteV1(){
            return View();
        }

//        public IActionResult Create()
//        {
//            ViewBag.Categorias=_context.Categorias.ToList();
//            return View();
//        }
//
//        [HttpPost]
//        public IActionResult Create(Producto objProducto){
//            //ViewBag.Categorias=_context.Categorias.ToList();
//            if(ModelState.IsValid){
//                _context.Add(objProducto);
//                _context.SaveChanges();
//                return View(objProducto);
//            }
//                return View();
//        }

        [HttpPost]
        public IActionResult GetPersonas(int dni, string contrasena){
            var persona=_context.Personas.Where(p=>p.Id==dni && p.Contrasena==contrasena);
            if(persona.Any()){
                if(persona.Where(p=>p.Id==dni && p.Contrasena==contrasena).Any()){
                    r_dni=dni;
                    metodo();
                    return Json(new{status=true, message="Bienvenido"});
                }else{
                    return Json(new{status=false, message="Contraseña incorrecta"});
                }
            }else{
                return Json(new{status=false, message="Datos incorrectos"});
            }
        }

//        public ActionResult logout(){
//            object p = Microsoft.AspNetCore.Session.Abandon();
//        }

        private void metodo(){
//            Persona modeloPersona=_context.Personas.Where(p=>p.Id==r_dni).First(p=>p.Id==r_dni);
//            //Persona objPersona=new Persona();
//            //objPersona.Id=r_dni;
//            //objPersona.Contrasena="2";
//            //objPersona.Nombre="nom";
//            //objPersona.ApellidoPat="apepat";
//            //objPersona.ApellidoMat="apemat";
//            //objPersona.Genero="genero";
//            //objPersona.Foto="foto";
//            //objPersona.Rol="Administrador";
//    //        PersonaBase objPersona=new PersonaBase();
//            PersonaBase.Id=modeloPersona.Id;
//            PersonaBase.Contrasena=modeloPersona.Contrasena;
//            PersonaBase.Nombre=modeloPersona.Nombre;
//            PersonaBase.ApellidoPat=modeloPersona.ApellidoPat;
//            PersonaBase.ApellidoMat=modeloPersona.ApellidoMat;
//            PersonaBase.Genero=modeloPersona.Genero;
//            PersonaBase.Foto=modeloPersona.Foto;
//            PersonaBase.Rol=modeloPersona.Rol;
            //_personaBase=objPersona;
//            Console.WriteLine("el dni es: "+r_dni+" | Nombre: "+PersonaBase.Nombre);
        }

//        private void cerrar(){
//            PersonaBase.Id=0;
//        }
    }
}
