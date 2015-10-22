using MyResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalizationLocalization.Models
{
    public class Demo
    {
        [Display(Name = "Name", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "NameRequiredError", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Display(Name = "Age", ResourceType = typeof(Resources))]
        [Required(ErrorMessageResourceName = "AgeRequiredError", ErrorMessageResourceType = typeof(Resources))]
        public int Age { get; set; }
    }
}