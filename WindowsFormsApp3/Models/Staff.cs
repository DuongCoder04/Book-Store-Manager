using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{

    [Table("Staff")]
    public class Staff
    {
        public Staff()
        {

        }
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }
        private string _nameStaff = "Unknown name";
        public string NameStaff
        {
            get { return _nameStaff; }
            set { if (!string.IsNullOrEmpty(value)) _nameStaff = value; }
        }
        private string _phone = "Unknown";
        public string Phone
        {
            get { return _phone; }
            set { if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _phone = value; }
        }
        public string Address{get; set;}
        private string _position;
        public string Position
        {
            get { return _position; }
            set { if (!string.IsNullOrEmpty(value)) _position = value; }
        }
    }
}
