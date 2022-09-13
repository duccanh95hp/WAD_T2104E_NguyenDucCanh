using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenDucCanh.Models
{
    public class Category
    {
      
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "Bạn phải nhập tên")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}