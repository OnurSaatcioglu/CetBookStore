using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {

        public int Id { get; set; }

        [DisplayName("Ad")]
        [Required(ErrorMessage = "Lütfen kitabın adını giriniz")]
        public string Name { get; set; }

        [DisplayName("Yazar")]
        public string Author { get; set; }

        [DisplayName("Sayfa Sayısı")]
        public int? PageCount { get; set; }

        [DisplayName("Yayımlanma Tarihi")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [DisplayName("Oluşturulma Tarihi")]
        public DateTime DateCreated { get; set; }

        [DisplayName("Fiyat")]
        public decimal Price { get; set; }


    }
}
