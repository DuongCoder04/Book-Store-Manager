using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{
    [Table("Bill")]
    public class Bill
    {
        public Bill()
        {
            
        }
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }
        private DateTime _checkout = DateTime.Now;
        public DateTime CheckOut
        {
            get { return _checkout; }
            set { if (value <= DateTime.Now) _checkout = value; }
        }
        public bool Status { get; set; }
    }
}
