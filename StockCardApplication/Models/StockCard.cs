using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StockCardApplication.Models
{
    public class StockCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StockNo { get; set; }
        [Required]
        public string StockName { get; set; }
        [Required]
        public int StockCount { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Kdv { get; set; }
        [Required]
        public string StockDetails { get; set; }
        [Required]
        public string WarehouseNo { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }       
    }
}