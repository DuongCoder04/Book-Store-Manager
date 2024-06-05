using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp.Models
{
    [Table("User")]
    class User
    {
        public User()
        {
          
        }
        [Key]
        public int ID
        {
            get;
            set;
        }
       
        private string _nameUser = "Unknown name";

        public string UserName
        {
            get { return _nameUser; }
            set { if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _nameUser = value; }
        }
        
        private string _password = "Unknown";
        public string Password
        {
            get { return _password; }
            set { if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value)) _password = value; }
        }
        private string _permision = "Unknown";
        public string Permision
        {
            get { return _permision; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _permision = value;
            }
        }
    }
}
