using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameworkCore.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int PublishedYear { get; set; }

        public int AuthorId {  get; set; } // 외래키
        public virtual Author Author { get; set; }
    }
}
