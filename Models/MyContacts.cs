using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class MyContacts
    {
        [AutoIncrement, PrimaryKey]
        public int SERIAL { get; set; }
        public string UNAME { get; set; }
        public string PH2 { get; set; }
        public string PH1 { get; set; }
        public string EMAIL { get; set; }
    }
}
