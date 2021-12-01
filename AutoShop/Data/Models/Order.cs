﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name ="Введіть ім'я")]
        [StringLength(15)]
        [Required(ErrorMessage ="Довжина імені не менше 3 символів")]
        public string name { get; set; }

        [Display(Name = "Прізвище")]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина прізвища не менше 3 символів")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(20)]
        [Required(ErrorMessage = "Довжина адреси не менше 5 символів")]
        public string adress { get; set; }

        [Display(Name = "Номер телефону")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжина номера не менше 10 знаків")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(15)]
        [Required(ErrorMessage = "Довжина email не менше 15 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
