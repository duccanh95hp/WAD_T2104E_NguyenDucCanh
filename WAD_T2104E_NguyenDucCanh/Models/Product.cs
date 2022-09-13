using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenDucCanh.Models
{
    public class Product
    {
     
        public int ProductId { get; set; }
        [StringLength(32, MinimumLength = 3)]
        [Required(ErrorMessage = "Bạn phải nhập tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập giá")]
        [DataType(DataType.PhoneNumber)]
        public string Price { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập số lượng")]
        [Range(1, double.MaxValue, ErrorMessage = "Price must be a positive number and greater than 0")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập ngày")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Bạn phải chọn danh mục")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }

    
}