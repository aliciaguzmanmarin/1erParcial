using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guzman.Models
{
    public class Clown
    {
        public enum TypeTricks
        { Juegos,
          Jarana,
          Jugo,
        }

        [Key]
        public int ClownID { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 2 )]
        [Display(Description = "Nombre Completo")]
        public string NickName { get; set; }

        [Required]
        public TypeTricks Tricks { get; set; }


        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Ingrese una direccion de correo valida")]
        public string Correo { get; set; }
        

        [Display(Description = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Cumpleaños { get; set; }


    }
}