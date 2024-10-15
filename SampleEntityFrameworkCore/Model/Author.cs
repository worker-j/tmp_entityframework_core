using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameworkCore.Model
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }


    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }                     // enum 처리 가능. 
        public virtual ICollection<Book> Books { get; set; }
    }
}
