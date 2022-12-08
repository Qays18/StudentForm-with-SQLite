using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSql
{
    public class StudentClass
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Student { get; set; }
        public string Department { get; set; }
    }
}
