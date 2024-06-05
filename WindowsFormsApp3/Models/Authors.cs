using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{
    [Table("Authors")]
    public class Authors
    {
        public Authors()
        {
            Books = new HashSet<Book>();
        }
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }
        private string _nameAuthors = "Unknown Authors";
        public string NameAuthors
        {
            get { return _nameAuthors; }
            set { if (!string.IsNullOrEmpty(value)) _nameAuthors = value; }
        }
        public virtual ICollection<Book> Books { get; set; }
    }
}
