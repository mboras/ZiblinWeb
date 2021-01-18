using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ZiblinWebb.Models
{
    public partial class PromoMaterijali
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Morate unijeti naziv!")]
        public string Naziv { get; set; }
    }
}
