using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITU.RefereeAssistant.Web.Models
{
    public class user
    {
        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "error")]
        public int Age { get; set; }

        [Display(Name = "Имя")]
        [DataType(DataType.Password)]
        [MinLength(3, ErrorMessage = "Таких имен не бывает")]
        public string Name { get; set; }

        [Display(Name = "Дата рождения")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDay { get; set; }

        [Display(Name = "Наличие авто")]        
        public bool HasAuto { get; set; } //переопределение типа в EditorTemplates (Boolean.cshtml)

    }
}