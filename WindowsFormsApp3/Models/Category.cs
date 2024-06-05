using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{
    [Table("Category")]
    public class Category
    {
        public Category() 
        {
            Books = new HashSet<Book>();
        }
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set {if( value >= 1) _id = value; }
        }
        private string _nameCategory = "Unknown Category";
        public string NameCategory
        {
            get { return _nameCategory; }
            set { if (!string.IsNullOrEmpty(value)) _nameCategory = value; }
        }
        public virtual ICollection<Book> Books { get; set; }
    }
}
