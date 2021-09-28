using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaciaWeb.Models
{
    [Table("producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id_producto")]
        [Key]
        public int Id{get; set;}

        [Display(Name="Descripción")]
        [Column("descripcion_producto")]
        [Required(ErrorMessage="Por favor, ingrese un producto.")]
        public string Descripcion{get; set;}

        [Display(Name="Precio")]
        [Column("precio")]
        [Required(ErrorMessage="Por favor, ingrese un precio.")]
        public decimal Precio{get; set;}

        [Display(Name="Foto")]
        [Column("foto")]
        // [Required(ErrorMessage="Por favor, ingrese una foto.")]
        public string Foto{get; set;}
        
        public Categoria Categoria{get; set;}
        [Display(Name="Categoría")]
        [Column("id_categoria")]
        public int CategoriaId{get; set;}
        //public List<Categoria> Categorias{get; set;}
    }
}