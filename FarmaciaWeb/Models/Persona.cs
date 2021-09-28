using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaWeb.Models
{
    [Table("persona")]
    public class Persona
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Usuario")]
        [Column("dni")]
        [Key]
        public int Id{get; set;}

        [Display(Name="Contraseña")]
        [Column("contrasena")]
        [Required(ErrorMessage="Por favor, ingrese su contraseña.")]
        [DataType(DataType.Password)]
        public string Contrasena{get; set;}

        [Display(Name="Nombre")]
        [Column("nombre")]
        [Required(ErrorMessage="Por favor, ingrese su nombre.")]
        public string Nombre{get; set;}

        [Display(Name="Apellido Paterno")]
        [Column("apellidopat")]
        [Required(ErrorMessage="Por favor, ingrese su apellido paterno.")]
        public string ApellidoPat{get; set;}

        [Display(Name="Apellido Materno")]
        [Column("apellidomat")]
        [Required(ErrorMessage="Por favor, ingrese su apellido materno.")]
        public string ApellidoMat{get; set;}

        [Display(Name="Género")]
        [Column("genero")]
        [Required(ErrorMessage="Por favor, ingrese su género.")]
        public string Genero{get; set;}

        [Display(Name="Foto")]
        [Column("foto")]
        [Required(ErrorMessage="Por favor, ingrese su foto.")]
        public string Foto{get; set;}

        [Display(Name="Rol")]
        [Column("rol")]
        //[Required(ErrorMessage="Por favor, ingrese su rol.")]
        public string Rol{get; set;}
    }
}