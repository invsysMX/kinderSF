using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invsys.Software.Web.KinderSF.Models
{
    public class TodoItemViewModel
    {
        [Required(ErrorMessage = "The Task Field is Required.")]
        public string task { get; set; }
        public bool completed { get; set; }
    }
}