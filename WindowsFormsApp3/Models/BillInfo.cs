using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    [Table("BillInfo")]
    public class BillInfo
    {
        public BillInfo()
        {
            Bills = new HashSet<Bill>();
        }
        private int _id = 1;
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; }
        }
        private int _idbill = 1;
        public int IdBill
        {
            get { return _idbill; }
            set { if (value >= 1) _idbill = value; }
        }
        [ForeignKey(nameof(IdBill))]
        public virtual Bill Bill { get; set; }
        private int _idbook = 1;
        public int IdBook
        {
            get { return _idbook; }
            set { if (value >= 1) _idbook = value; }
        }
        [ForeignKey(nameof(IdBook))]
        public virtual Book Book { get; set; }
        private int _count = 1;
        public int Count
        {
            get { return _count; }
            set { if (value >= 1) _count = value; }
        }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
