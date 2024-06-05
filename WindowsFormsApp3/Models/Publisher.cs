using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{
    [Table("Publisher")]
    public class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }
        private string _namePublisher = "Unknown publisher";
        public string NamePublisher
        {
            get { return _namePublisher; }
            set { if (!string.IsNullOrEmpty(value)) _namePublisher = value; }
        }
        public virtual ICollection<Book> Books { get; set; }
    }
}
