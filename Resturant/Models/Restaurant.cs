using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Resturant.Models
{
    public class Restaurant
    {
     /*        public Restaurant() { }
        public Restaurant(int dollarSigns)
        {
            DollarSigns = dollarSigns;

        }*/


        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Style { get; set; }

        [Required]
        [Range(0, 5)]
        public float Rating { get; set; }

        [Required]
        [Range(1, 5)]
        public int DollarSigns { get; set; }
        public string Symbol 
        { 
            get 
            {
            switch (DollarSigns)
            {
                case 1:
                    Symbol = "$";
                        break;
                case 2:
                    Symbol = "$$";
                        break;
                case 3:
                    Symbol = "$$$";
                        break;
                case 4:
                    Symbol = "$$$$";
                        break;
                case 5:
                   Symbol = "$$$$$";
                        break;
            }
                return null;
            }
            set { }
        }
    }
}