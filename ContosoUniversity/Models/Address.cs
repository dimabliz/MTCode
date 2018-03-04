using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models {
    public class Address {

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@contoso.edu$", ErrorMessage = "Email is not a valid Contoso University email")]
        public string Email { get; set; }

    }
}