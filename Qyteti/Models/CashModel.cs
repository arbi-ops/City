using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Qyteti.Models
{
    public class CashModel
    {
        [Required]
        [Range(100, int.MaxValue, ErrorMessage = "Shkruaj nje vlere 3-shifrore")]
        public int Amount { get; set; }

        public Dictionary<int, int> Breakdown { get; set; } = new Dictionary<int, int>();
    }
}