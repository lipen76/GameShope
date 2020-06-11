using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GaameStore.Domain.Entities
{
   public class ShippingDetails
    {
        [Required(ErrorMessage = "Podaj swoją godność")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Podaj ulicę")]
        [Display(Name = "Ulica")]
        public string Line1 { get; set; }

        [Display(Name = "Nr. domu")]
        public string Line2 { get; set; }

        [Display(Name = "Nr. mieszkania")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Podaj miasto")]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required(ErrorMessage = "Podaj kod pocztowy")]
        [Display(Name = "Kod pocztowy")]
        public string PostCode { get; set; }

        public bool GiftWrap { get; set; }

        
       [Display(Name = "Podaj numer karty bankowej")]
       public string CardNumber { get; set; }
        [Display(Name = "Data ważmości karty bankowej")]
        public string CardDate { get; set; }

        [Display(Name = "Kod CCV")]
        public string CardCCV { get; set; }

    }
}

