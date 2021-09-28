using System;
using Microsoft.AspNetCore.Http;

namespace FarmaciaWeb.Models{
    public static class PersonaBase{
        public static int Id{get; set;}
        public static string Contrasena{get; set;}
        public static string Nombre{get; set;}
        public static string ApellidoPat{get; set;}
        public static string ApellidoMat{get; set;}
        public static string Genero{get; set;}
        public static string Foto{get; set;}
        public static string Rol{get; set;}
//        public static PersonaBase Validar_PersonaBase(){
//            try{
    //    private static PersonaBase(){}
    //            var Logueado=AppHttpContext.Current.Session.GetString("Logueado");
    //            if(Logueado==null){
    //                PersonaBase.Id=0;
    //                PersonaBase.Contrasena=null;
    //                PersonaBase.Nombre=null;
    //                PersonaBase.ApellidoPat=null;
    //                PersonaBase.ApellidoMat=null;
    //                PersonaBase.Genero=null;
    //                PersonaBase.Foto=null;
    //                PersonaBase.Rol=null;
    //            }
//            }catch(Exception e){
//                throw e;
//            }
//            return PersonaBase;
//        }
    }
}
