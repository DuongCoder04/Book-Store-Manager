using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace WindowsFormsApp.Models
{
    /// <summary>
    /// Lớp mô tả sách điện tử
    /// </summary>
    [Serializable]
    public class Book
    {
        private int _id = 1;
        /// <summary>
        /// số định danh duy nhất cho mỗi object
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; } // id chỉ nhận giá trị >= 1
        }
        /// <summary>
        /// tiêu đề sách, không nhận xâu rỗng
        /// </summary>
        private string _title = "A new book";
        public string Title
        {
            get { return _title; }
            set { if (!string.IsNullOrEmpty(value)) _title = value; } // không nhận xâu rỗng
        }

        /// <summary>
        /// tên tác giả hoặc nhóm tác giả, không nhận xâu rỗng
        /// </summary>
        private int _idAuthors = 1;
        public int IdAuthors
        {
            get { return _idAuthors; }
            set { if (value >= 1) _idAuthors = value; }
        }
        [ForeignKey(nameof(IdAuthors))]
        public virtual Authors Authors { get; set; }
        /// <summary>
        /// nhà xuất bản, không nhận xâu rỗng
        /// </summary>
        private int _idPublisher = 1;
        public int IdPublisher
        {
            get { return _idPublisher; }
            set { if (value >= 1) _idPublisher = value; }
        }
        [ForeignKey(nameof(IdPublisher))]
        public virtual Publisher Publisher { get; set; }
        private int _year = 2018;
        /// <summary>
        /// năm xuất bản, không nhỏ hơn 1950
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { if (value >= 1950) _year = value; } // năm không nhỏ hơn 1950
        }
        private int _edition = 1;
        /// <summary>
        /// lần tái bản, không nhỏ hơn 1
        /// </summary>
        public int Edition
        {
            get { return _edition; }
            set { if (value >= 1) _edition = value; } // không nhận giá trị < 1
        }
        /// <summary>
        /// Loại sách 
        /// </summary>
        private int _idCategory = 1;
        public int IdCategory
        {
            get { return _idCategory; }
            set { if (value >= 1) _idCategory = value; }
        }
        [ForeignKey(nameof(IdCategory))]
        public virtual Category Category { get; set; }
        /// <summary>
        /// từ khóa mô tả nội dung / thể loại
        /// </summary>
        public string Tags { get; set; } = "";
        /// <summary>
        /// mô tả tóm tắt nội dung
        /// </summary>
        public string Description { get; set; } = "A new book";
        private int _rating = 1;
        /// <summary>
        /// đánh giá cá nhân, giá trị từ 1 đến 5
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set { if (value >= 1 && value <= 5) _rating = value; } // giá trị từ 1 đến 5
        }
        /// <summary>
        /// đánh dấu là đang đọc
        /// </summary>
        public bool Reading { get; set; }
        /// <summary>
        /// file sách (gồm dường dẫn)
        /// </summary>
        public string FileDirection { get; set; }
        /// <summary>
        /// tên file sách
        /// </summary>
        public string FileName { get; set; }
        public int Price { get; set; }
    }
}
