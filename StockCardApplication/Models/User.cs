using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StockCardApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string UserName { get; set; }
        [Required, StringLength(20)]
        public string Password { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
        [Required, StringLength(20)]
        public string Surname { get; set; }
    }
}